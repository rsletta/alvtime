# swagger_client.VatReportFormApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**vatreportforms_get**](VatReportFormApi.md#vatreportforms_get) | **GET** /vatreportforms | 
[**vatreportforms_id_delete**](VatReportFormApi.md#vatreportforms_id_delete) | **DELETE** /vatreportforms/{id} | 
[**vatreportforms_id_get**](VatReportFormApi.md#vatreportforms_id_get) | **GET** /vatreportforms/{id} | 
[**vatreportforms_id_put**](VatReportFormApi.md#vatreportforms_id_put) | **PUT** /vatreportforms/{id} | 
[**vatreportforms_post**](VatReportFormApi.md#vatreportforms_post) | **POST** /vatreportforms | 

# **vatreportforms_get**
> list[VatReportForm] vatreportforms_get()



Query VatReportForm

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportFormApi()

try:
    api_response = api_instance.vatreportforms_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportFormApi->vatreportforms_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[VatReportForm]**](VatReportForm.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreportforms_id_delete**
> VatReportForm vatreportforms_id_delete(id)



Delete VatReportForm

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportFormApi()
id = 56 # int | 

try:
    api_response = api_instance.vatreportforms_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportFormApi->vatreportforms_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VatReportForm**](VatReportForm.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreportforms_id_get**
> VatReportForm vatreportforms_id_get(id)



Get VatReportForm

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportFormApi()
id = 56 # int | 

try:
    api_response = api_instance.vatreportforms_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportFormApi->vatreportforms_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VatReportForm**](VatReportForm.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreportforms_id_put**
> VatReportForm vatreportforms_id_put(body, id)



Update VatReportForm

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportFormApi()
body = swagger_client.VatReportForm() # VatReportForm | 
id = 56 # int | 

try:
    api_response = api_instance.vatreportforms_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportFormApi->vatreportforms_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VatReportForm**](VatReportForm.md)|  | 
 **id** | **int**|  | 

### Return type

[**VatReportForm**](VatReportForm.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreportforms_post**
> VatReportForm vatreportforms_post(body)



Create VatReportForm

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportFormApi()
body = swagger_client.VatReportForm() # VatReportForm | 

try:
    api_response = api_instance.vatreportforms_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportFormApi->vatreportforms_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VatReportForm**](VatReportForm.md)|  | 

### Return type

[**VatReportForm**](VatReportForm.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

