# swagger_client.EmployeeTaxCardApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**taxcards_get**](EmployeeTaxCardApi.md#taxcards_get) | **GET** /taxcards | 
[**taxcards_id_delete**](EmployeeTaxCardApi.md#taxcards_id_delete) | **DELETE** /taxcards/{id} | 
[**taxcards_id_get**](EmployeeTaxCardApi.md#taxcards_id_get) | **GET** /taxcards/{id} | 
[**taxcards_id_put**](EmployeeTaxCardApi.md#taxcards_id_put) | **PUT** /taxcards/{id} | 
[**taxcards_post**](EmployeeTaxCardApi.md#taxcards_post) | **POST** /taxcards | 

# **taxcards_get**
> list[EmployeeTaxCard] taxcards_get()



Query EmployeeTaxCard

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeTaxCardApi()

try:
    api_response = api_instance.taxcards_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeTaxCardApi->taxcards_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[EmployeeTaxCard]**](EmployeeTaxCard.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **taxcards_id_delete**
> EmployeeTaxCard taxcards_id_delete(id)



Delete EmployeeTaxCard

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeTaxCardApi()
id = 56 # int | 

try:
    api_response = api_instance.taxcards_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeTaxCardApi->taxcards_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**EmployeeTaxCard**](EmployeeTaxCard.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **taxcards_id_get**
> EmployeeTaxCard taxcards_id_get(id)



Get EmployeeTaxCard

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeTaxCardApi()
id = 56 # int | 

try:
    api_response = api_instance.taxcards_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeTaxCardApi->taxcards_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**EmployeeTaxCard**](EmployeeTaxCard.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **taxcards_id_put**
> EmployeeTaxCard taxcards_id_put(body, id)



Update EmployeeTaxCard

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeTaxCardApi()
body = swagger_client.EmployeeTaxCard() # EmployeeTaxCard | 
id = 56 # int | 

try:
    api_response = api_instance.taxcards_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeTaxCardApi->taxcards_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmployeeTaxCard**](EmployeeTaxCard.md)|  | 
 **id** | **int**|  | 

### Return type

[**EmployeeTaxCard**](EmployeeTaxCard.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **taxcards_post**
> EmployeeTaxCard taxcards_post(body)



Create EmployeeTaxCard

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeTaxCardApi()
body = swagger_client.EmployeeTaxCard() # EmployeeTaxCard | 

try:
    api_response = api_instance.taxcards_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeTaxCardApi->taxcards_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmployeeTaxCard**](EmployeeTaxCard.md)|  | 

### Return type

[**EmployeeTaxCard**](EmployeeTaxCard.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

