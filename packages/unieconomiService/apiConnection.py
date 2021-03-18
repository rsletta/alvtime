import requests

# Swagger generated packages
from swagger_client import Customer, ApiClient, CustomerApi, BusinessRelationApi, JournalEntryApi
from swagger_client import AccountMandatoryDimensionApi, AccountGroupSetApi,AccountApi, AccountVisibilityGroupApi

# Selfmade packages
from auth import UnieconomyAuth

class ApiConnection:

    def __init__(self, client_id, audience, api_base_url):
        self.base_url = api_base_url

        accessSetup = UnieconomyAuth(client_id, audience, api_base_url)
        self.access_token = accessSetup.get_access_token()

        self.api_get_company_info()
        self.create_api_client()

    # Gets information about the companies you have access to, you ned the company key for the company
    # you want to perform actions against.
    #
    # Needs (All are set in the initialization method):
    #   - Valid access token
    #
    # Output:
    #   - Nothing, sets the company key as a class variable.
    def api_get_company_info(self):
        try:
            headers = {"Authorization": "Bearer "+self.access_token}
            res = requests.get(r"https://test.softrig.com/api/init/companies", headers=headers)

            if res.status_code == 200:
                self.company_key = res.json()[0]["Key"]
            else:
                raise Exception("Problemer med å koble til API, har du riktig access token?")
        except Exception as err:
            print(err)

    def create_api_client(self):
        headers = {"Authorization": "Bearer " + self.access_token, "CompanyKey": self.company_key}
        self.apiClient = ApiClient()
        for headerName in headers.keys():
            self.apiClient.set_default_header(headerName, headers[headerName])

    # Method used to perform GET requests to the API.
    #
    # Input:
    #   - Valid GET API endpoint
    #
    # Output:
    #   - Result of the request formated as JSON, or -1 if the status code is not 200.
    def api_get_request(self, endpoint):
        try:
            headers = {"Authorization": "Bearer "+self.access_token, "CompanyKey":self.company_key}
            res = requests.get(r"https://test.softrig.com/api/"+endpoint, headers=headers)

            if res.status_code == 200:
                return res.json()
            else:
                raise Exception("Problemer med å koble til API, har du riktig access token?")
        except Exception as err:
            print(err)
            print(res.status_code)
            return -1

    # Method used to perform POST requests to the API.
    #
    # Input:
    #   - Valid POST API endpoint
    #   - POST body data in the form of a dictionary
    #
    # Output:
    #   - The resulting response code, or -1 if the response code is not 200.
    def api_post_request(self, endpoint, data):
        try:
            headers = {"Authorization": "Bearer "+self.access_token, "CompanyKey":self.company_key}
            res = requests.post(r"https://test.softrig.com/api/"+endpoint, json=data, headers=headers)

            if res.status_code == 200:
                return res.json()
            else:
                raise Exception("Problemer med å koble til API, har du riktig access token?")
        except Exception as err:
            print(err)
            print(res.status_code)
            return -1

    # Method used to perform DELETE requests to the API.
    #
    # Input:
    #   - Valid DELETE API endpoint
    #   - DELETE body data in the form of a dictionary
    #
    # Output:
    #   - The resulting response code, or -1 if the response code is not 204.
    def api_delete_request(self, endpoint, data):
        try:
            headers = {"Authorization": "Bearer "+self.access_token, "CompanyKey":self.company_key}
            res = requests.delete(r"https://test.softrig.com/api/"+endpoint, json=data, headers=headers)

            if res.status_code == 204:
                return res.status_code
            else:
                raise Exception("Problemer med å koble til API, har du riktig access token?")
        except Exception as err:
            print(err)
            print(res.status_code)
            return -1

    # Method used to perform DELETE requests to the API.
    #
    # Input:
    #   - Valid PUT API endpoint
    #   - PUT body data in the form of a dictionary
    #
    # Output:
    #   - The resulting response code, or -1 if the response code does not indicate success (200 = success).
    def api_put_request(self, endpoint, data):
        try:
            headers = {"Authorization": "Bearer "+self.access_token, "CompanyKey":self.company_key}
            res = requests.put(r"https://test.softrig.com/api/"+endpoint, json=data, headers=headers)

            if res.status_code == 200:
                return res.status_code
            else:
                raise Exception("Problemer med å koble til API, har du riktig access token?")
        except Exception as err:
            print(err)
            print(res.status_code)
            return -1

    # Methods used to call specific API endpoints. Uses the above generic methods
    def create_customer(self, company_name, *id):
        data = {"Info": {"Name": company_name}, "OrgNumber": id[0]}
        customerApi = CustomerApi(self.apiClient)
        res = customerApi.customers_post(data)
        return res

    def get_customers(self,*args):
        customerApi = CustomerApi(self.apiClient)
        if not args:
            return customerApi.customers_get()
        else:
            customer = customerApi.customers_id_get(args[0])  #type: Customer
            cust_br = BusinessRelationApi(self.apiClient).business_relations_id_get(customer.business_relation_id)
            return customer, cust_br

    def delete_customer(self, customer_id):
        customerApi = CustomerApi(self.apiClient)
        result = customerApi.customers_id_delete(customer_id)
        return result

    def get_customer(self, customer_id):
        customerApi = CustomerApi(self.apiClient)
        return customerApi.customers_id_get(customer_id)

    def update_customer(self, customer_id, data):
        customerApi = CustomerApi(self.apiClient)
        return customerApi.customers_id_put(data, customer_id)

    def get_journal_entries(self, *args):
        journalEntryApi = JournalEntryApi(self.apiClient)
        return journalEntryApi.journalentries_get()

    def get_accounts(self):
        accountApi = AccountApi(self.apiClient)
        return accountApi.accounts_get()

    def get_account_group_sets(self):
        accountGroupSetApi = AccountGroupSetApi(self.apiClient)
        return accountGroupSetApi.accountgroupsets_get()

    def get_account_mandatory_dimension(self):
        accountMandatoryDimensionApi = AccountMandatoryDimensionApi(self.apiClient)
        return accountMandatoryDimensionApi.accountmandatorydimension_get()

    def get_account_visibility_groups(self):
        accountVisibilityGroupApi = AccountVisibilityGroupApi(self.apiClient)
        return accountVisibilityGroupApi.accountvisibilitygroups_get()
