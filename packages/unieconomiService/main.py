from flask import Flask, Response, request

# Selfmade packages
from endpointHandler import EndpointHandler

# SKAL FJERNES
class EndpointAction(object):

    def __init__(self, action):
        self.action = action
        self.response = Response(status=200, headers={})

    def __call__(self, *args):
        if(self.action()):
            self.response = self.action()
        else:
            self.response = Response(status=200, headers={})
        return self.response

class AppServer(object):

    app = None
    client_id = None
    audience = None
    base_url = None
    handle = None

    def __init__(self, client_id, audience, api_base_url):
        self.handle = EndpointHandler(client_id, audience, api_base_url)

        self.app = Flask("UniEconomy Integration Api")
        self.add_endpoints()
        self.app.run(debug=True, host='127.0.0.1')

    def add_endpoints(self):
        self.app.add_url_rule(rule='/financial_data', endpoint='financial_data', view_func=self.handle.financial_data, methods=["GET"])
        self.app.add_url_rule(rule='/customers', endpoint='customers', view_func=self.handle.customers, methods=["GET"])
        self.app.add_url_rule(rule='/customer/<id>', endpoint='customer_change', view_func=self.handle.customer, methods=["GET", "PUT", "DELETE"])

if __name__ == '__main__':

    client_id = "3a726a33-0f53-44a7-8415-a44dff248d77"
    audience = r"https://test-login.softrig.com/connect/token"
    api_base_url = r"https://test.softrig.com/api/init/"

    web_api = AppServer(client_id, audience, api_base_url)

    #print(conn.access_token)
    # customers = conn.get_customers_new()
    # new_customer = conn.create_customer_new("Anders ny-testing", 1256363516)
    # print(new_customer.org_number)
    # print(new_customer.avtale_giro)
    # new_customer.avtale_giro = True
    # chg = conn.update_customer_new(new_customer.id, new_customer)
    # NB!: Må sende in kunde-objekt med oppdaterte verdier, ikke bare en dictionary med de verdiene du ønsker å endre
    # updated_customer,br = conn.get_customers_new(new_customer.id)
    # journal_entries = conn.get_journal_entries()
    # accounts = conn.get_accounts()
    # account_group_sets = conn.get_account_group_sets()
    # account_mandatory_dimension = conn.get_account_mandatory_dimension()
    # account_visibility_group = conn.get_account_visibility_groups()
    #
    # print(journal_entries)
    # print(accounts)
    # print(account_group_sets)
    # print(account_mandatory_dimension)
    # print(account_visibility_group)

    #print(updated_customer.org_number)
    #print(br.name)
    #print(updated_customer.avtale_giro)
    # rem = conn.delete_customer_new(new_customer.id)
