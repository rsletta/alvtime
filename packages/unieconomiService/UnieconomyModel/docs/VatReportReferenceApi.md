# swagger_client.VatReportReferenceApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**vatreportreferences_get**](VatReportReferenceApi.md#vatreportreferences_get) | **GET** /vatreportreferences | 
[**vatreportreferences_id_delete**](VatReportReferenceApi.md#vatreportreferences_id_delete) | **DELETE** /vatreportreferences/{id} | 
[**vatreportreferences_id_get**](VatReportReferenceApi.md#vatreportreferences_id_get) | **GET** /vatreportreferences/{id} | 
[**vatreportreferences_id_put**](VatReportReferenceApi.md#vatreportreferences_id_put) | **PUT** /vatreportreferences/{id} | 
[**vatreportreferences_post**](VatReportReferenceApi.md#vatreportreferences_post) | **POST** /vatreportreferences | 

# **vatreportreferences_get**
> list[VatReportReference] vatreportreferences_get()



Query VatReportReference

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportReferenceApi()

try:
    api_response = api_instance.vatreportreferences_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportReferenceApi->vatreportreferences_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[VatReportReference]**](VatReportReference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreportreferences_id_delete**
> VatReportReference vatreportreferences_id_delete(id)



Delete VatReportReference

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportReferenceApi()
id = 56 # int | 

try:
    api_response = api_instance.vatreportreferences_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportReferenceApi->vatreportreferences_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VatReportReference**](VatReportReference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreportreferences_id_get**
> VatReportReference vatreportreferences_id_get(id)



Get VatReportReference

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportReferenceApi()
id = 56 # int | 

try:
    api_response = api_instance.vatreportreferences_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportReferenceApi->vatreportreferences_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VatReportReference**](VatReportReference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreportreferences_id_put**
> VatReportReference vatreportreferences_id_put(body, id)



Update VatReportReference

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportReferenceApi()
body = swagger_client.VatReportReference() # VatReportReference | 
id = 56 # int | 

try:
    api_response = api_instance.vatreportreferences_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportReferenceApi->vatreportreferences_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VatReportReference**](VatReportReference.md)|  | 
 **id** | **int**|  | 

### Return type

[**VatReportReference**](VatReportReference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreportreferences_post**
> VatReportReference vatreportreferences_post(body)



Create VatReportReference

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportReferenceApi()
body = swagger_client.VatReportReference() # VatReportReference | 

try:
    api_response = api_instance.vatreportreferences_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportReferenceApi->vatreportreferences_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VatReportReference**](VatReportReference.md)|  | 

### Return type

[**VatReportReference**](VatReportReference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

