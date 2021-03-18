import os
import json
from flask import Response, request

# Azure packages
from azure.storage.blob import BlobServiceClient

# Selfmade packages
from apiConnection import ApiConnection

class EndpointHandler:

    def __init__(self, client_id, audience, api_base_url):
        self.client_id = client_id
        self.audience = audience
        self.api_base_url = api_base_url

    def create_200_response(self, body, content_type):
        return Response(status=200, content_type=content_type, response=body)

    def create_404_response(self, body):
        return Response(status=404, content_type="text/html", response=body)
    # Fetches the list of customers.
    #
    # Needs:
    #   - Nothing.
    def customers(self):
        if request.method == "GET":
            conn = ApiConnection(self.client_id, self.audience, self.api_base_url)
            return self.create_200_response(json.dumps(conn.get_customers()[0].to_dict()), "application/json")
        else:
            return self.create_404_response("HTTP Method not allowed")

    def customer(self, id=None):
        conn = ApiConnection(self.client_id, self.audience, self.api_base_url)
        if request.method == "GET":
            resp = conn.get_customer(id)
            return self.create_200_response(json.dumps(resp.to_dict()), "application/json")
        if request.method == "PUT":
            #print(request.form)
            # !!! Lag sjekk for om ID er allerede brukt
            cust_name = request.form['name']
            resp = conn.create_customer(cust_name, id)
            return self.create_200_response(json.dumps(resp.to_dict()), "application/json")
        elif request.method == "DELETE":
            resp = conn.delete_customer(id)
            return self.create_200_response(json.dumps(resp.to_dict()), "application/json")

    # Fetches financial information, and posts it to a storage blob in Azure
    #
    # Needs:
    #   - Nothing.
    #
    # Output:
    #   - A text displaying whether the fetch was successful.
    def financial_data(self):
        conn = ApiConnection(self.client_id, self.audience, self.api_base_url)

        json_result = {}

        journal_entries = conn.get_journal_entries()
        accounts = conn.get_accounts()
        account_group_sets = conn.get_account_group_sets()
        account_mandatory_dimension = conn.get_account_mandatory_dimension()
        account_visibility_groups = conn.get_account_visibility_groups()

        if(journal_entries):
            json_result['journal_entries'] = journal_entries[0].__dict__
        if(accounts):
            json_result['accounts'] = accounts[0].__dict__
        if(account_group_sets):
            json_result['account_group_sets'] = account_group_sets[0].__dict__
        if(account_mandatory_dimension):
            json_result['account_mandatory_dimension'] = account_mandatory_dimension[0].__dict__
        if(account_visibility_groups):
            json_result['account_visibility_groups'] = account_visibility_groups[0].__dict__

        connect_str = os.getenv("AZURE_STORAGE_CONNECTION_STRING")

        blob_service_client = BlobServiceClient.from_connection_string(connect_str)

        # Create a blob client using the local file name as the name for the blob
        blob_container = blob_service_client.get_container_client("test-conainer")
        blob_list = blob_container.list_blobs()
        exists = False
        for blob in blob_list:
            if blob.name == "Test2":
                exists = True

        if(not exists):
            blob_client = blob_service_client.get_blob_client(container="test-conainer", blob="Test2")

            blob_client.upload_blob(json.dumps(json_result))

        return self.create_200_response("Upload successfull", "text/html")