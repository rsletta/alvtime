# swagger_client.SalaryTransactionApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**salarytrans_get**](SalaryTransactionApi.md#salarytrans_get) | **GET** /salarytrans | 
[**salarytrans_id_delete**](SalaryTransactionApi.md#salarytrans_id_delete) | **DELETE** /salarytrans/{id} | 
[**salarytrans_id_get**](SalaryTransactionApi.md#salarytrans_id_get) | **GET** /salarytrans/{id} | 
[**salarytrans_id_put**](SalaryTransactionApi.md#salarytrans_id_put) | **PUT** /salarytrans/{id} | 
[**salarytrans_post**](SalaryTransactionApi.md#salarytrans_post) | **POST** /salarytrans | 
[**salarytransactioncomplete_trans_post**](SalaryTransactionApi.md#salarytransactioncomplete_trans_post) | **POST** /salarytrans?action&#x3D;complete-trans | 
[**salarytransactionupdate_from_employments_put**](SalaryTransactionApi.md#salarytransactionupdate_from_employments_put) | **PUT** /salarytrans?action&#x3D;update-from-employments | 

# **salarytrans_get**
> list[SalaryTransaction] salarytrans_get()



Query SalaryTransaction

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryTransactionApi()

try:
    api_response = api_instance.salarytrans_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryTransactionApi->salarytrans_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[SalaryTransaction]**](SalaryTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarytrans_id_delete**
> SalaryTransaction salarytrans_id_delete(id)



Delete SalaryTransaction

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryTransactionApi()
id = 56 # int | 

try:
    api_response = api_instance.salarytrans_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryTransactionApi->salarytrans_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**SalaryTransaction**](SalaryTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarytrans_id_get**
> SalaryTransaction salarytrans_id_get(id)



Get SalaryTransaction

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryTransactionApi()
id = 56 # int | 

try:
    api_response = api_instance.salarytrans_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryTransactionApi->salarytrans_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**SalaryTransaction**](SalaryTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarytrans_id_put**
> SalaryTransaction salarytrans_id_put(body, id)



Update SalaryTransaction

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryTransactionApi()
body = swagger_client.SalaryTransaction() # SalaryTransaction | 
id = 56 # int | 

try:
    api_response = api_instance.salarytrans_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryTransactionApi->salarytrans_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SalaryTransaction**](SalaryTransaction.md)|  | 
 **id** | **int**|  | 

### Return type

[**SalaryTransaction**](SalaryTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarytrans_post**
> SalaryTransaction salarytrans_post(body)



Create SalaryTransaction

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryTransactionApi()
body = swagger_client.SalaryTransaction() # SalaryTransaction | 

try:
    api_response = api_instance.salarytrans_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryTransactionApi->salarytrans_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SalaryTransaction**](SalaryTransaction.md)|  | 

### Return type

[**SalaryTransaction**](SalaryTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarytransactioncomplete_trans_post**
> list[SalaryTransaction] salarytransactioncomplete_trans_post(body=body)



complete-trans Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryTransactionApi()
body = swagger_client.SalaryTransaction() # SalaryTransaction |  (optional)

try:
    api_response = api_instance.salarytransactioncomplete_trans_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryTransactionApi->salarytransactioncomplete_trans_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SalaryTransaction**](SalaryTransaction.md)|  | [optional] 

### Return type

[**list[SalaryTransaction]**](SalaryTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarytransactionupdate_from_employments_put**
> list[SalaryTransaction] salarytransactionupdate_from_employments_put(body=body)



update-from-employments Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryTransactionApi()
body = 56 # int |  (optional)

try:
    api_response = api_instance.salarytransactionupdate_from_employments_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryTransactionApi->salarytransactionupdate_from_employments_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**int**](int.md)|  | [optional] 

### Return type

[**list[SalaryTransaction]**](SalaryTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

