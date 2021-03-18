import os
import jwt
import uuid
import requests
from cryptography.hazmat.backends import default_backend
from cryptography.hazmat.primitives.serialization.pkcs12 import load_key_and_certificates
import datetime
from datetime import datetime, timedelta

class UnieconomyAuth:

    def __init__(self, client_id, audience, api_base_url):
        self.client_id = client_id
        self.audience = audience
        self.base_url = api_base_url

        self.create_jwt_token(self.read_certificate(os.getenv("certPath"), str.encode(os.getenv("password"))))

    # Reads the certificate which must be in p12-format, and sets the private key of the certificate.
    # The private key of the sertificate is used to sign the jwt token, which will prove we have the
    # private key of the certificate. This authenticates us to create the access token to connect
    # to the API.
    #
    # Input:
    #   - Path to certificate (string)
    #   - Certificate password (string)
    #
    # Output:
    #   - Nothing, sets the certificate private key as a class variable.
    def read_certificate(self, path, cert_password):
        with open(path, 'rb') as pkcs12_file:
            pkcs12_data = pkcs12_file.read()
        pycaP12 = load_key_and_certificates(pkcs12_data, cert_password,default_backend())

        return pycaP12[0]




    # Creates the jwt token used to request the access token.
    #
    # Needs (All are set in the initialization method):
    #   - The certificate private key
    #   - The client id
    #   - The audience
    #
    # Output:
    #   - Nothing, sets the jwt token as a class variable.
    def create_jwt_token(self, cert_priv_key):
        issue_time = datetime.utcnow()
        exp_time = issue_time + timedelta(minutes=1)

        encoded_jwt = jwt.encode(
            {
                'jti': str(uuid.uuid4()),
                'sub': self.client_id,
                'iat': issue_time,
                'nbf': issue_time,
                'exp': exp_time,
                'iss': self.client_id,
                'aud': self.audience
            },
            cert_priv_key,
            algorithm='RS256'
        )

        self.jwt_token_encoded = encoded_jwt

    # Requests the access token needed to communicate with the API.
    #
    # Needs (All are set in the initialization method):
    #   - The client id
    #   - The jwt token, signed with the private key of the certificate.
    #   - The audience (which is the url to request access token from)
    #
    # Output:
    #   - Nothing, sets the access token as a class variable.
    def get_access_token(self):
        data = {
            'grant_type':'client_credentials',
            'scope':'AppFramework.All',
            'client_id':self.client_id,
            'client_assertion_type':'urn:ietf:params:oauth:client-assertion-type:jwt-bearer',
            'client_assertion':self.jwt_token_encoded
        }

        res = requests.post(
            self.audience,
            data=data
        )

        return res.json()["access_token"]