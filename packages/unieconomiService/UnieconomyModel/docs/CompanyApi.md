# swagger_client.CompanyApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**companies_get**](CompanyApi.md#companies_get) | **GET** /companies | 
[**companies_id_delete**](CompanyApi.md#companies_id_delete) | **DELETE** /companies/{id} | 
[**companies_id_get**](CompanyApi.md#companies_id_get) | **GET** /companies/{id} | 
[**companies_idactioncheck_email_changed_get**](CompanyApi.md#companies_idactioncheck_email_changed_get) | **GET** /companies/{id}?action&#x3D;check-email-changed | 
[**companies_idactioncheck_email_changed_valid_available_get**](CompanyApi.md#companies_idactioncheck_email_changed_valid_available_get) | **GET** /companies/{id}?action&#x3D;check-email-changed-valid-available | 
[**companies_idactioncheck_email_valid_available_get**](CompanyApi.md#companies_idactioncheck_email_valid_available_get) | **GET** /companies/{id}?action&#x3D;check-email-valid-available | 
[**companies_idactionclientnumber_put**](CompanyApi.md#companies_idactionclientnumber_put) | **PUT** /companies/{id}?action&#x3D;clientnumber | 
[**companies_idactioncreate_orgnr_email_put**](CompanyApi.md#companies_idactioncreate_orgnr_email_put) | **PUT** /companies/{id}?action&#x3D;create-orgnr-email | 
[**companies_idactioncreate_update_email_put**](CompanyApi.md#companies_idactioncreate_update_email_put) | **PUT** /companies/{id}?action&#x3D;create-update-email | 
[**companies_idactiondelete_company_delete**](CompanyApi.md#companies_idactiondelete_company_delete) | **DELETE** /companies/{id}?action&#x3D;delete-company | 
[**companies_idactiondisable_email_put**](CompanyApi.md#companies_idactiondisable_email_put) | **PUT** /companies/{id}?action&#x3D;disable-email | 
[**companies_idactiondisable_orgnr_email_put**](CompanyApi.md#companies_idactiondisable_orgnr_email_put) | **PUT** /companies/{id}?action&#x3D;disable-orgnr-email | 
[**companies_idactionemail_domain_get**](CompanyApi.md#companies_idactionemail_domain_get) | **GET** /companies/{id}?action&#x3D;email-domain | 
[**companies_idactionundelete_company_put**](CompanyApi.md#companies_idactionundelete_company_put) | **PUT** /companies/{id}?action&#x3D;undelete-company | 
[**companiesactioncreate_company_put**](CompanyApi.md#companiesactioncreate_company_put) | **PUT** /companies?action&#x3D;create-company | 
[**companiesactiondelete_company_delete**](CompanyApi.md#companiesactiondelete_company_delete) | **DELETE** /companies?action&#x3D;delete-company | 
[**companiesactionreset_company_put**](CompanyApi.md#companiesactionreset_company_put) | **PUT** /companies?action&#x3D;reset-company | 
[**companiesactionundelete_company_put**](CompanyApi.md#companiesactionundelete_company_put) | **PUT** /companies?action&#x3D;undelete-company | 

# **companies_get**
> list[Company] companies_get()



Query Company

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyApi()

try:
    api_response = api_instance.companies_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyApi->companies_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Company]**](Company.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_id_delete**
> Company companies_id_delete(id)



Delete Company

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyApi()
id = 56 # int | 

try:
    api_response = api_instance.companies_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyApi->companies_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Company**](Company.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_id_get**
> Company companies_id_get(id)



Get Company

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyApi()
id = 56 # int | 

try:
    api_response = api_instance.companies_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyApi->companies_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Company**](Company.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_idactioncheck_email_changed_get**
> bool companies_idactioncheck_email_changed_get(id, email)



check-email-changed Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyApi()
id = 56 # int | 
email = swagger_client.Object() # Object | 

try:
    api_response = api_instance.companies_idactioncheck_email_changed_get(id, email)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyApi->companies_idactioncheck_email_changed_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **email** | [**Object**](.md)|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_idactioncheck_email_changed_valid_available_get**
> bool companies_idactioncheck_email_changed_valid_available_get(id, email)



check-email-changed-valid-available Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyApi()
id = 56 # int | 
email = swagger_client.Object() # Object | 

try:
    api_response = api_instance.companies_idactioncheck_email_changed_valid_available_get(id, email)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyApi->companies_idactioncheck_email_changed_valid_available_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **email** | [**Object**](.md)|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_idactioncheck_email_valid_available_get**
> bool companies_idactioncheck_email_valid_available_get(id, email)



check-email-valid-available Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyApi()
id = 56 # int | 
email = swagger_client.Object() # Object | 

try:
    api_response = api_instance.companies_idactioncheck_email_valid_available_get(id, email)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyApi->companies_idactioncheck_email_valid_available_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **email** | [**Object**](.md)|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_idactionclientnumber_put**
> Company companies_idactionclientnumber_put(id, clientnumber)



clientnumber Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyApi()
id = 56 # int | 
clientnumber = swagger_client.Object() # Object | 

try:
    api_response = api_instance.companies_idactionclientnumber_put(id, clientnumber)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyApi->companies_idactionclientnumber_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **clientnumber** | [**Object**](.md)|  | 

### Return type

[**Company**](Company.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_idactioncreate_orgnr_email_put**
> Company companies_idactioncreate_orgnr_email_put(id)



create-orgnr-email Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyApi()
id = 56 # int | 

try:
    api_response = api_instance.companies_idactioncreate_orgnr_email_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyApi->companies_idactioncreate_orgnr_email_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Company**](Company.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_idactioncreate_update_email_put**
> Company companies_idactioncreate_update_email_put(id, custom_email)



create-update-email Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyApi()
id = 56 # int | 
custom_email = swagger_client.Object() # Object | 

try:
    api_response = api_instance.companies_idactioncreate_update_email_put(id, custom_email)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyApi->companies_idactioncreate_update_email_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **custom_email** | [**Object**](.md)|  | 

### Return type

[**Company**](Company.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_idactiondelete_company_delete**
> object companies_idactiondelete_company_delete(id, id)



delete-company Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.companies_idactiondelete_company_delete(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyApi->companies_idactiondelete_company_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_idactiondisable_email_put**
> Company companies_idactiondisable_email_put(id)



disable-email Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyApi()
id = 56 # int | 

try:
    api_response = api_instance.companies_idactiondisable_email_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyApi->companies_idactiondisable_email_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Company**](Company.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_idactiondisable_orgnr_email_put**
> Company companies_idactiondisable_orgnr_email_put(id)



disable-orgnr-email Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyApi()
id = 56 # int | 

try:
    api_response = api_instance.companies_idactiondisable_orgnr_email_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyApi->companies_idactiondisable_orgnr_email_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Company**](Company.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_idactionemail_domain_get**
> str companies_idactionemail_domain_get(id)



email-domain Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyApi()
id = 56 # int | 

try:
    api_response = api_instance.companies_idactionemail_domain_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyApi->companies_idactionemail_domain_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_idactionundelete_company_put**
> object companies_idactionundelete_company_put(id, id)



undelete-company Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.companies_idactionundelete_company_put(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyApi->companies_idactionundelete_company_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companiesactioncreate_company_put**
> Company companiesactioncreate_company_put(body=body)



create-company Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyApi()
body = swagger_client.CreateCompanyDetails() # CreateCompanyDetails |  (optional)

try:
    api_response = api_instance.companiesactioncreate_company_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyApi->companiesactioncreate_company_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateCompanyDetails**](CreateCompanyDetails.md)|  | [optional] 

### Return type

[**Company**](Company.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companiesactiondelete_company_delete**
> object companiesactiondelete_company_delete(key)



delete-company Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyApi()
key = swagger_client.Object() # Object | 

try:
    api_response = api_instance.companiesactiondelete_company_delete(key)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyApi->companiesactiondelete_company_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companiesactionreset_company_put**
> object companiesactionreset_company_put()



reset-company Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyApi()

try:
    api_response = api_instance.companiesactionreset_company_put()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyApi->companiesactionreset_company_put: %s\n" % e)
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

# **companiesactionundelete_company_put**
> object companiesactionundelete_company_put(key)



undelete-company Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyApi()
key = swagger_client.Object() # Object | 

try:
    api_response = api_instance.companiesactionundelete_company_put(key)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyApi->companiesactionundelete_company_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

