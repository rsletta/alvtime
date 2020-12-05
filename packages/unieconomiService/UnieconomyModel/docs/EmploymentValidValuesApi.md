# swagger_client.EmploymentValidValuesApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**employmentvalidvalues_get**](EmploymentValidValuesApi.md#employmentvalidvalues_get) | **GET** /employmentvalidvalues | 
[**employmentvalidvalues_id_delete**](EmploymentValidValuesApi.md#employmentvalidvalues_id_delete) | **DELETE** /employmentvalidvalues/{id} | 
[**employmentvalidvalues_id_get**](EmploymentValidValuesApi.md#employmentvalidvalues_id_get) | **GET** /employmentvalidvalues/{id} | 
[**employmentvalidvalues_id_put**](EmploymentValidValuesApi.md#employmentvalidvalues_id_put) | **PUT** /employmentvalidvalues/{id} | 
[**employmentvalidvalues_post**](EmploymentValidValuesApi.md#employmentvalidvalues_post) | **POST** /employmentvalidvalues | 

# **employmentvalidvalues_get**
> list[EmploymentValidValues] employmentvalidvalues_get()



Query EmploymentValidValues

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmploymentValidValuesApi()

try:
    api_response = api_instance.employmentvalidvalues_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmploymentValidValuesApi->employmentvalidvalues_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[EmploymentValidValues]**](EmploymentValidValues.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employmentvalidvalues_id_delete**
> EmploymentValidValues employmentvalidvalues_id_delete(id)



Delete EmploymentValidValues

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmploymentValidValuesApi()
id = 56 # int | 

try:
    api_response = api_instance.employmentvalidvalues_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmploymentValidValuesApi->employmentvalidvalues_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**EmploymentValidValues**](EmploymentValidValues.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employmentvalidvalues_id_get**
> EmploymentValidValues employmentvalidvalues_id_get(id)



Get EmploymentValidValues

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmploymentValidValuesApi()
id = 56 # int | 

try:
    api_response = api_instance.employmentvalidvalues_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmploymentValidValuesApi->employmentvalidvalues_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**EmploymentValidValues**](EmploymentValidValues.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employmentvalidvalues_id_put**
> EmploymentValidValues employmentvalidvalues_id_put(body, id)



Update EmploymentValidValues

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmploymentValidValuesApi()
body = swagger_client.EmploymentValidValues() # EmploymentValidValues | 
id = 56 # int | 

try:
    api_response = api_instance.employmentvalidvalues_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmploymentValidValuesApi->employmentvalidvalues_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmploymentValidValues**](EmploymentValidValues.md)|  | 
 **id** | **int**|  | 

### Return type

[**EmploymentValidValues**](EmploymentValidValues.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employmentvalidvalues_post**
> EmploymentValidValues employmentvalidvalues_post(body)



Create EmploymentValidValues

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmploymentValidValuesApi()
body = swagger_client.EmploymentValidValues() # EmploymentValidValues | 

try:
    api_response = api_instance.employmentvalidvalues_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmploymentValidValuesApi->employmentvalidvalues_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmploymentValidValues**](EmploymentValidValues.md)|  | 

### Return type

[**EmploymentValidValues**](EmploymentValidValues.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

