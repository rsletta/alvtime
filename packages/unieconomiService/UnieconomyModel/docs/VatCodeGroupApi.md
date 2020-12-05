# swagger_client.VatCodeGroupApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**vatcodegroups_get**](VatCodeGroupApi.md#vatcodegroups_get) | **GET** /vatcodegroups | 
[**vatcodegroups_id_delete**](VatCodeGroupApi.md#vatcodegroups_id_delete) | **DELETE** /vatcodegroups/{id} | 
[**vatcodegroups_id_get**](VatCodeGroupApi.md#vatcodegroups_id_get) | **GET** /vatcodegroups/{id} | 
[**vatcodegroups_id_put**](VatCodeGroupApi.md#vatcodegroups_id_put) | **PUT** /vatcodegroups/{id} | 
[**vatcodegroups_post**](VatCodeGroupApi.md#vatcodegroups_post) | **POST** /vatcodegroups | 

# **vatcodegroups_get**
> list[VatCodeGroup] vatcodegroups_get()



Query VatCodeGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatCodeGroupApi()

try:
    api_response = api_instance.vatcodegroups_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatCodeGroupApi->vatcodegroups_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[VatCodeGroup]**](VatCodeGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatcodegroups_id_delete**
> VatCodeGroup vatcodegroups_id_delete(id)



Delete VatCodeGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatCodeGroupApi()
id = 56 # int | 

try:
    api_response = api_instance.vatcodegroups_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatCodeGroupApi->vatcodegroups_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VatCodeGroup**](VatCodeGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatcodegroups_id_get**
> VatCodeGroup vatcodegroups_id_get(id)



Get VatCodeGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatCodeGroupApi()
id = 56 # int | 

try:
    api_response = api_instance.vatcodegroups_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatCodeGroupApi->vatcodegroups_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VatCodeGroup**](VatCodeGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatcodegroups_id_put**
> VatCodeGroup vatcodegroups_id_put(body, id)



Update VatCodeGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatCodeGroupApi()
body = swagger_client.VatCodeGroup() # VatCodeGroup | 
id = 56 # int | 

try:
    api_response = api_instance.vatcodegroups_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatCodeGroupApi->vatcodegroups_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VatCodeGroup**](VatCodeGroup.md)|  | 
 **id** | **int**|  | 

### Return type

[**VatCodeGroup**](VatCodeGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatcodegroups_post**
> VatCodeGroup vatcodegroups_post(body)



Create VatCodeGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatCodeGroupApi()
body = swagger_client.VatCodeGroup() # VatCodeGroup | 

try:
    api_response = api_instance.vatcodegroups_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatCodeGroupApi->vatcodegroups_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VatCodeGroup**](VatCodeGroup.md)|  | 

### Return type

[**VatCodeGroup**](VatCodeGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

