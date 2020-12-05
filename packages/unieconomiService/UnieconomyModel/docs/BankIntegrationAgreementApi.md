# swagger_client.BankIntegrationAgreementApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**bank_agreements_get**](BankIntegrationAgreementApi.md#bank_agreements_get) | **GET** /bank-agreements | 
[**bank_agreements_id_delete**](BankIntegrationAgreementApi.md#bank_agreements_id_delete) | **DELETE** /bank-agreements/{id} | 
[**bank_agreements_id_get**](BankIntegrationAgreementApi.md#bank_agreements_id_get) | **GET** /bank-agreements/{id} | 
[**bank_agreements_id_put**](BankIntegrationAgreementApi.md#bank_agreements_id_put) | **PUT** /bank-agreements/{id} | 
[**bank_agreements_idactionset_default_put**](BankIntegrationAgreementApi.md#bank_agreements_idactionset_default_put) | **PUT** /bank-agreements/{id}?action&#x3D;set-default | 
[**bank_agreements_idactionupdate_bank_properties_put**](BankIntegrationAgreementApi.md#bank_agreements_idactionupdate_bank_properties_put) | **PUT** /bank-agreements/{id}?action&#x3D;update-bank-properties | 
[**bank_agreements_idactionupdate_status_put**](BankIntegrationAgreementApi.md#bank_agreements_idactionupdate_status_put) | **PUT** /bank-agreements/{id}?action&#x3D;update-status | 
[**bank_agreementsactionadd_autobank_user_post**](BankIntegrationAgreementApi.md#bank_agreementsactionadd_autobank_user_post) | **POST** /bank-agreements?action&#x3D;add-autobank-user | 
[**bank_agreementsactionauth_code_post**](BankIntegrationAgreementApi.md#bank_agreementsactionauth_code_post) | **POST** /bank-agreements?action&#x3D;auth-code | 
[**bank_agreementsactioncreate_initial_company_and_bank_accounts_agreement_post**](BankIntegrationAgreementApi.md#bank_agreementsactioncreate_initial_company_and_bank_accounts_agreement_post) | **POST** /bank-agreements?action&#x3D;create-initial-company-and-bank-accounts-agreement | 
[**bank_agreementsactioncreate_integration_post**](BankIntegrationAgreementApi.md#bank_agreementsactioncreate_integration_post) | **POST** /bank-agreements?action&#x3D;create-integration | 
[**bank_agreementsactiondelete_all_bankagreements_put**](BankIntegrationAgreementApi.md#bank_agreementsactiondelete_all_bankagreements_put) | **PUT** /bank-agreements?action&#x3D;delete-all-bankagreements | 
[**bank_agreementsactiondelete_bankagreements_put**](BankIntegrationAgreementApi.md#bank_agreementsactiondelete_bankagreements_put) | **PUT** /bank-agreements?action&#x3D;delete-bankagreements | 
[**bank_agreementsactionget_agreement_templates_get**](BankIntegrationAgreementApi.md#bank_agreementsactionget_agreement_templates_get) | **GET** /bank-agreements?action&#x3D;get-agreement-templates | 
[**bank_agreementsactionget_direct_bank_agreement_get**](BankIntegrationAgreementApi.md#bank_agreementsactionget_direct_bank_agreement_get) | **GET** /bank-agreements?action&#x3D;get-direct-bank-agreement | 
[**bank_agreementsactionorder_bank_integration_change_post**](BankIntegrationAgreementApi.md#bank_agreementsactionorder_bank_integration_change_post) | **POST** /bank-agreements?action&#x3D;order-bank-integration-change | 
[**bank_agreementsactionupdate_service_put**](BankIntegrationAgreementApi.md#bank_agreementsactionupdate_service_put) | **PUT** /bank-agreements?action&#x3D;update-service | 
[**bank_agreementsactionupdate_serviceid_put**](BankIntegrationAgreementApi.md#bank_agreementsactionupdate_serviceid_put) | **PUT** /bank-agreements?action&#x3D;update-serviceid | 
[**bank_agreementsactionvalidate_password_post**](BankIntegrationAgreementApi.md#bank_agreementsactionvalidate_password_post) | **POST** /bank-agreements?action&#x3D;validate-password | 

# **bank_agreements_get**
> list[BankIntegrationAgreement] bank_agreements_get()



Query BankIntegrationAgreement

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankIntegrationAgreementApi()

try:
    api_response = api_instance.bank_agreements_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankIntegrationAgreementApi->bank_agreements_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[BankIntegrationAgreement]**](BankIntegrationAgreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bank_agreements_id_delete**
> BankIntegrationAgreement bank_agreements_id_delete(id)



Delete BankIntegrationAgreement

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankIntegrationAgreementApi()
id = 56 # int | 

try:
    api_response = api_instance.bank_agreements_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankIntegrationAgreementApi->bank_agreements_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BankIntegrationAgreement**](BankIntegrationAgreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bank_agreements_id_get**
> BankIntegrationAgreement bank_agreements_id_get(id)



Get BankIntegrationAgreement

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankIntegrationAgreementApi()
id = 56 # int | 

try:
    api_response = api_instance.bank_agreements_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankIntegrationAgreementApi->bank_agreements_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BankIntegrationAgreement**](BankIntegrationAgreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bank_agreements_id_put**
> BankIntegrationAgreement bank_agreements_id_put(body, id)



Update BankIntegrationAgreement

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankIntegrationAgreementApi()
body = swagger_client.BankIntegrationAgreement() # BankIntegrationAgreement | 
id = 56 # int | 

try:
    api_response = api_instance.bank_agreements_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankIntegrationAgreementApi->bank_agreements_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BankIntegrationAgreement**](BankIntegrationAgreement.md)|  | 
 **id** | **int**|  | 

### Return type

[**BankIntegrationAgreement**](BankIntegrationAgreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bank_agreements_idactionset_default_put**
> BankIntegrationAgreement bank_agreements_idactionset_default_put(id, id)



set-default Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankIntegrationAgreementApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.bank_agreements_idactionset_default_put(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankIntegrationAgreementApi->bank_agreements_idactionset_default_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**BankIntegrationAgreement**](BankIntegrationAgreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bank_agreements_idactionupdate_bank_properties_put**
> BankIntegrationAgreement bank_agreements_idactionupdate_bank_properties_put(id2, id, body=body)



update-bank-properties Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankIntegrationAgreementApi()
id2 = 56 # int | 
id = swagger_client.Object() # Object | 
body = swagger_client.ZdataUpdateBankProperties() # ZdataUpdateBankProperties |  (optional)

try:
    api_response = api_instance.bank_agreements_idactionupdate_bank_properties_put(id2, id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankIntegrationAgreementApi->bank_agreements_idactionupdate_bank_properties_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id2** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **body** | [**ZdataUpdateBankProperties**](ZdataUpdateBankProperties.md)|  | [optional] 

### Return type

[**BankIntegrationAgreement**](BankIntegrationAgreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bank_agreements_idactionupdate_status_put**
> BankIntegrationAgreement bank_agreements_idactionupdate_status_put(id2, id, body=body)



update-status Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankIntegrationAgreementApi()
id2 = 56 # int | 
id = swagger_client.Object() # Object | 
body = 'body_example' # str |  (optional)

try:
    api_response = api_instance.bank_agreements_idactionupdate_status_put(id2, id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankIntegrationAgreementApi->bank_agreements_idactionupdate_status_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id2** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **body** | [**str**](str.md)|  | [optional] 

### Return type

[**BankIntegrationAgreement**](BankIntegrationAgreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bank_agreementsactionadd_autobank_user_post**
> User bank_agreementsactionadd_autobank_user_post(password, body=body)



add-autobank-user Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankIntegrationAgreementApi()
password = swagger_client.Object() # Object | 
body = swagger_client.AutobankUserDTO() # AutobankUserDTO |  (optional)

try:
    api_response = api_instance.bank_agreementsactionadd_autobank_user_post(password, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankIntegrationAgreementApi->bank_agreementsactionadd_autobank_user_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **password** | [**Object**](.md)|  | 
 **body** | [**AutobankUserDTO**](AutobankUserDTO.md)|  | [optional] 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bank_agreementsactionauth_code_post**
> object bank_agreementsactionauth_code_post(body=body)



auth-code Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankIntegrationAgreementApi()
body = 'body_example' # str |  (optional)

try:
    api_response = api_instance.bank_agreementsactionauth_code_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankIntegrationAgreementApi->bank_agreementsactionauth_code_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**str**](str.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bank_agreementsactioncreate_initial_company_and_bank_accounts_agreement_post**
> BankIntegrationAgreement bank_agreementsactioncreate_initial_company_and_bank_accounts_agreement_post(body=body)



create-initial-company-and-bank-accounts-agreement Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankIntegrationAgreementApi()
body = swagger_client.CreateBankIntegrationDTO() # CreateBankIntegrationDTO |  (optional)

try:
    api_response = api_instance.bank_agreementsactioncreate_initial_company_and_bank_accounts_agreement_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankIntegrationAgreementApi->bank_agreementsactioncreate_initial_company_and_bank_accounts_agreement_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateBankIntegrationDTO**](CreateBankIntegrationDTO.md)|  | [optional] 

### Return type

[**BankIntegrationAgreement**](BankIntegrationAgreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bank_agreementsactioncreate_integration_post**
> BankIntegrationAgreement bank_agreementsactioncreate_integration_post(body=body)



create-integration Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankIntegrationAgreementApi()
body = swagger_client.CreateBankIntegrationDTO() # CreateBankIntegrationDTO |  (optional)

try:
    api_response = api_instance.bank_agreementsactioncreate_integration_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankIntegrationAgreementApi->bank_agreementsactioncreate_integration_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateBankIntegrationDTO**](CreateBankIntegrationDTO.md)|  | [optional] 

### Return type

[**BankIntegrationAgreement**](BankIntegrationAgreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bank_agreementsactiondelete_all_bankagreements_put**
> list[BankAccount] bank_agreementsactiondelete_all_bankagreements_put(email_address)



delete-all-bankagreements Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankIntegrationAgreementApi()
email_address = swagger_client.Object() # Object | 

try:
    api_response = api_instance.bank_agreementsactiondelete_all_bankagreements_put(email_address)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankIntegrationAgreementApi->bank_agreementsactiondelete_all_bankagreements_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email_address** | [**Object**](.md)|  | 

### Return type

[**list[BankAccount]**](BankAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bank_agreementsactiondelete_bankagreements_put**
> list[BankAccount] bank_agreementsactiondelete_bankagreements_put(bank_account_id, integration_settings, email_address)



delete-bankagreements Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankIntegrationAgreementApi()
bank_account_id = swagger_client.Object() # Object | 
integration_settings = swagger_client.Object() # Object | 
email_address = swagger_client.Object() # Object | 

try:
    api_response = api_instance.bank_agreementsactiondelete_bankagreements_put(bank_account_id, integration_settings, email_address)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankIntegrationAgreementApi->bank_agreementsactiondelete_bankagreements_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bank_account_id** | [**Object**](.md)|  | 
 **integration_settings** | [**Object**](.md)|  | 
 **email_address** | [**Object**](.md)|  | 

### Return type

[**list[BankAccount]**](BankAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bank_agreementsactionget_agreement_templates_get**
> object bank_agreementsactionget_agreement_templates_get(password)



get-agreement-templates Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankIntegrationAgreementApi()
password = swagger_client.Object() # Object | 

try:
    api_response = api_instance.bank_agreementsactionget_agreement_templates_get(password)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankIntegrationAgreementApi->bank_agreementsactionget_agreement_templates_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **password** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bank_agreementsactionget_direct_bank_agreement_get**
> object bank_agreementsactionget_direct_bank_agreement_get(service_provider)



get-direct-bank-agreement Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankIntegrationAgreementApi()
service_provider = swagger_client.Object() # Object | 

try:
    api_response = api_instance.bank_agreementsactionget_direct_bank_agreement_get(service_provider)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankIntegrationAgreementApi->bank_agreementsactionget_direct_bank_agreement_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **service_provider** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bank_agreementsactionorder_bank_integration_change_post**
> object bank_agreementsactionorder_bank_integration_change_post()



order-bank-integration-change Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankIntegrationAgreementApi()

try:
    api_response = api_instance.bank_agreementsactionorder_bank_integration_change_post()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankIntegrationAgreementApi->bank_agreementsactionorder_bank_integration_change_post: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bank_agreementsactionupdate_service_put**
> object bank_agreementsactionupdate_service_put(body=body)



update-service Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankIntegrationAgreementApi()
body = swagger_client.UpdateServiceStatusDTO() # UpdateServiceStatusDTO |  (optional)

try:
    api_response = api_instance.bank_agreementsactionupdate_service_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankIntegrationAgreementApi->bank_agreementsactionupdate_service_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateServiceStatusDTO**](UpdateServiceStatusDTO.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bank_agreementsactionupdate_serviceid_put**
> object bank_agreementsactionupdate_serviceid_put(body=body)



update-serviceid Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankIntegrationAgreementApi()
body = swagger_client.UpdateServiceIDDTO() # UpdateServiceIDDTO |  (optional)

try:
    api_response = api_instance.bank_agreementsactionupdate_serviceid_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankIntegrationAgreementApi->bank_agreementsactionupdate_serviceid_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateServiceIDDTO**](UpdateServiceIDDTO.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bank_agreementsactionvalidate_password_post**
> bool bank_agreementsactionvalidate_password_post(body=body)



validate-password Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankIntegrationAgreementApi()
body = 'body_example' # str |  (optional)

try:
    api_response = api_instance.bank_agreementsactionvalidate_password_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankIntegrationAgreementApi->bank_agreementsactionvalidate_password_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**str**](str.md)|  | [optional] 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

