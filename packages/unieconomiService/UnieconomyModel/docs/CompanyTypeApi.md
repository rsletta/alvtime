# swagger_client.CompanyTypeApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**companytypes_get**](CompanyTypeApi.md#companytypes_get) | **GET** /companytypes | 
[**companytypes_id_delete**](CompanyTypeApi.md#companytypes_id_delete) | **DELETE** /companytypes/{id} | 
[**companytypes_id_get**](CompanyTypeApi.md#companytypes_id_get) | **GET** /companytypes/{id} | 
[**companytypes_id_put**](CompanyTypeApi.md#companytypes_id_put) | **PUT** /companytypes/{id} | 
[**companytypes_post**](CompanyTypeApi.md#companytypes_post) | **POST** /companytypes | 

# **companytypes_get**
> list[CompanyType] companytypes_get()



Query CompanyType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyTypeApi()

try:
    api_response = api_instance.companytypes_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyTypeApi->companytypes_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CompanyType]**](CompanyType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companytypes_id_delete**
> CompanyType companytypes_id_delete(id)



Delete CompanyType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.companytypes_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyTypeApi->companytypes_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CompanyType**](CompanyType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companytypes_id_get**
> CompanyType companytypes_id_get(id)



Get CompanyType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.companytypes_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyTypeApi->companytypes_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CompanyType**](CompanyType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companytypes_id_put**
> CompanyType companytypes_id_put(body, id)



Update CompanyType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyTypeApi()
body = swagger_client.CompanyType() # CompanyType | 
id = 56 # int | 

try:
    api_response = api_instance.companytypes_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyTypeApi->companytypes_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompanyType**](CompanyType.md)|  | 
 **id** | **int**|  | 

### Return type

[**CompanyType**](CompanyType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companytypes_post**
> CompanyType companytypes_post(body)



Create CompanyType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyTypeApi()
body = swagger_client.CompanyType() # CompanyType | 

try:
    api_response = api_instance.companytypes_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyTypeApi->companytypes_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompanyType**](CompanyType.md)|  | 

### Return type

[**CompanyType**](CompanyType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

