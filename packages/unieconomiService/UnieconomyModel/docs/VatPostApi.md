# swagger_client.VatPostApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**vatposts_get**](VatPostApi.md#vatposts_get) | **GET** /vatposts | 
[**vatposts_id_delete**](VatPostApi.md#vatposts_id_delete) | **DELETE** /vatposts/{id} | 
[**vatposts_id_get**](VatPostApi.md#vatposts_id_get) | **GET** /vatposts/{id} | 
[**vatposts_id_put**](VatPostApi.md#vatposts_id_put) | **PUT** /vatposts/{id} | 
[**vatposts_post**](VatPostApi.md#vatposts_post) | **POST** /vatposts | 
[**vatpostsactionget_vatposts_with_percentage_get**](VatPostApi.md#vatpostsactionget_vatposts_with_percentage_get) | **GET** /vatposts?action&#x3D;get-vatposts-with-percentage | 

# **vatposts_get**
> list[VatPost] vatposts_get()



Query VatPost

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatPostApi()

try:
    api_response = api_instance.vatposts_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatPostApi->vatposts_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[VatPost]**](VatPost.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatposts_id_delete**
> VatPost vatposts_id_delete(id)



Delete VatPost

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatPostApi()
id = 56 # int | 

try:
    api_response = api_instance.vatposts_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatPostApi->vatposts_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VatPost**](VatPost.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatposts_id_get**
> VatPost vatposts_id_get(id)



Get VatPost

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatPostApi()
id = 56 # int | 

try:
    api_response = api_instance.vatposts_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatPostApi->vatposts_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VatPost**](VatPost.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatposts_id_put**
> VatPost vatposts_id_put(body, id)



Update VatPost

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatPostApi()
body = swagger_client.VatPost() # VatPost | 
id = 56 # int | 

try:
    api_response = api_instance.vatposts_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatPostApi->vatposts_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VatPost**](VatPost.md)|  | 
 **id** | **int**|  | 

### Return type

[**VatPost**](VatPost.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatposts_post**
> VatPost vatposts_post(body)



Create VatPost

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatPostApi()
body = swagger_client.VatPost() # VatPost | 

try:
    api_response = api_instance.vatposts_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatPostApi->vatposts_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VatPost**](VatPost.md)|  | 

### Return type

[**VatPost**](VatPost.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatpostsactionget_vatposts_with_percentage_get**
> list[VatPost] vatpostsactionget_vatposts_with_percentage_get(_date)



get-vatposts-with-percentage Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatPostApi()
_date = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatpostsactionget_vatposts_with_percentage_get(_date)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatPostApi->vatpostsactionget_vatposts_with_percentage_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_date** | [**Object**](.md)|  | 

### Return type

[**list[VatPost]**](VatPost.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

