# swagger_client.OtpExportWagetypeApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**otpexportwagetypes_get**](OtpExportWagetypeApi.md#otpexportwagetypes_get) | **GET** /otpexportwagetypes | 
[**otpexportwagetypes_id_delete**](OtpExportWagetypeApi.md#otpexportwagetypes_id_delete) | **DELETE** /otpexportwagetypes/{id} | 
[**otpexportwagetypes_id_get**](OtpExportWagetypeApi.md#otpexportwagetypes_id_get) | **GET** /otpexportwagetypes/{id} | 
[**otpexportwagetypes_id_put**](OtpExportWagetypeApi.md#otpexportwagetypes_id_put) | **PUT** /otpexportwagetypes/{id} | 
[**otpexportwagetypes_post**](OtpExportWagetypeApi.md#otpexportwagetypes_post) | **POST** /otpexportwagetypes | 

# **otpexportwagetypes_get**
> list[OtpExportWagetype] otpexportwagetypes_get()



Query OtpExportWagetype

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.OtpExportWagetypeApi()

try:
    api_response = api_instance.otpexportwagetypes_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling OtpExportWagetypeApi->otpexportwagetypes_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[OtpExportWagetype]**](OtpExportWagetype.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **otpexportwagetypes_id_delete**
> OtpExportWagetype otpexportwagetypes_id_delete(id)



Delete OtpExportWagetype

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.OtpExportWagetypeApi()
id = 56 # int | 

try:
    api_response = api_instance.otpexportwagetypes_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling OtpExportWagetypeApi->otpexportwagetypes_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**OtpExportWagetype**](OtpExportWagetype.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **otpexportwagetypes_id_get**
> OtpExportWagetype otpexportwagetypes_id_get(id)



Get OtpExportWagetype

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.OtpExportWagetypeApi()
id = 56 # int | 

try:
    api_response = api_instance.otpexportwagetypes_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling OtpExportWagetypeApi->otpexportwagetypes_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**OtpExportWagetype**](OtpExportWagetype.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **otpexportwagetypes_id_put**
> OtpExportWagetype otpexportwagetypes_id_put(body, id)



Update OtpExportWagetype

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.OtpExportWagetypeApi()
body = swagger_client.OtpExportWagetype() # OtpExportWagetype | 
id = 56 # int | 

try:
    api_response = api_instance.otpexportwagetypes_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling OtpExportWagetypeApi->otpexportwagetypes_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OtpExportWagetype**](OtpExportWagetype.md)|  | 
 **id** | **int**|  | 

### Return type

[**OtpExportWagetype**](OtpExportWagetype.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **otpexportwagetypes_post**
> OtpExportWagetype otpexportwagetypes_post(body)



Create OtpExportWagetype

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.OtpExportWagetypeApi()
body = swagger_client.OtpExportWagetype() # OtpExportWagetype | 

try:
    api_response = api_instance.otpexportwagetypes_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling OtpExportWagetypeApi->otpexportwagetypes_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OtpExportWagetype**](OtpExportWagetype.md)|  | 

### Return type

[**OtpExportWagetype**](OtpExportWagetype.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

