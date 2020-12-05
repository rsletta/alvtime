# swagger_client.CompanyBankAccountApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**companybankaccounts_get**](CompanyBankAccountApi.md#companybankaccounts_get) | **GET** /companybankaccounts | 
[**companybankaccounts_id_delete**](CompanyBankAccountApi.md#companybankaccounts_id_delete) | **DELETE** /companybankaccounts/{id} | 
[**companybankaccounts_id_get**](CompanyBankAccountApi.md#companybankaccounts_id_get) | **GET** /companybankaccounts/{id} | 
[**companybankaccounts_id_put**](CompanyBankAccountApi.md#companybankaccounts_id_put) | **PUT** /companybankaccounts/{id} | 
[**companybankaccounts_post**](CompanyBankAccountApi.md#companybankaccounts_post) | **POST** /companybankaccounts | 

# **companybankaccounts_get**
> list[CompanyBankAccount] companybankaccounts_get()



Query CompanyBankAccount

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyBankAccountApi()

try:
    api_response = api_instance.companybankaccounts_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyBankAccountApi->companybankaccounts_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CompanyBankAccount]**](CompanyBankAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companybankaccounts_id_delete**
> CompanyBankAccount companybankaccounts_id_delete(id)



Delete CompanyBankAccount

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyBankAccountApi()
id = 56 # int | 

try:
    api_response = api_instance.companybankaccounts_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyBankAccountApi->companybankaccounts_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CompanyBankAccount**](CompanyBankAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companybankaccounts_id_get**
> CompanyBankAccount companybankaccounts_id_get(id)



Get CompanyBankAccount

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyBankAccountApi()
id = 56 # int | 

try:
    api_response = api_instance.companybankaccounts_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyBankAccountApi->companybankaccounts_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CompanyBankAccount**](CompanyBankAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companybankaccounts_id_put**
> CompanyBankAccount companybankaccounts_id_put(body, id)



Update CompanyBankAccount

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyBankAccountApi()
body = swagger_client.CompanyBankAccount() # CompanyBankAccount | 
id = 56 # int | 

try:
    api_response = api_instance.companybankaccounts_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyBankAccountApi->companybankaccounts_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompanyBankAccount**](CompanyBankAccount.md)|  | 
 **id** | **int**|  | 

### Return type

[**CompanyBankAccount**](CompanyBankAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companybankaccounts_post**
> CompanyBankAccount companybankaccounts_post(body)



Create CompanyBankAccount

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyBankAccountApi()
body = swagger_client.CompanyBankAccount() # CompanyBankAccount | 

try:
    api_response = api_instance.companybankaccounts_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyBankAccountApi->companybankaccounts_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompanyBankAccount**](CompanyBankAccount.md)|  | 

### Return type

[**CompanyBankAccount**](CompanyBankAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

