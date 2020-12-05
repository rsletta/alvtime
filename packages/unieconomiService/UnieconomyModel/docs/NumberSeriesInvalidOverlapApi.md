# swagger_client.NumberSeriesInvalidOverlapApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**number_series_invalid_overlaps_get**](NumberSeriesInvalidOverlapApi.md#number_series_invalid_overlaps_get) | **GET** /number-series-invalid-overlaps | 
[**number_series_invalid_overlaps_id_delete**](NumberSeriesInvalidOverlapApi.md#number_series_invalid_overlaps_id_delete) | **DELETE** /number-series-invalid-overlaps/{id} | 
[**number_series_invalid_overlaps_id_get**](NumberSeriesInvalidOverlapApi.md#number_series_invalid_overlaps_id_get) | **GET** /number-series-invalid-overlaps/{id} | 
[**number_series_invalid_overlaps_id_put**](NumberSeriesInvalidOverlapApi.md#number_series_invalid_overlaps_id_put) | **PUT** /number-series-invalid-overlaps/{id} | 
[**number_series_invalid_overlaps_post**](NumberSeriesInvalidOverlapApi.md#number_series_invalid_overlaps_post) | **POST** /number-series-invalid-overlaps | 

# **number_series_invalid_overlaps_get**
> list[NumberSeriesInvalidOverlap] number_series_invalid_overlaps_get()



Query NumberSeriesInvalidOverlap

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesInvalidOverlapApi()

try:
    api_response = api_instance.number_series_invalid_overlaps_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesInvalidOverlapApi->number_series_invalid_overlaps_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[NumberSeriesInvalidOverlap]**](NumberSeriesInvalidOverlap.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_series_invalid_overlaps_id_delete**
> NumberSeriesInvalidOverlap number_series_invalid_overlaps_id_delete(id)



Delete NumberSeriesInvalidOverlap

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesInvalidOverlapApi()
id = 56 # int | 

try:
    api_response = api_instance.number_series_invalid_overlaps_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesInvalidOverlapApi->number_series_invalid_overlaps_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**NumberSeriesInvalidOverlap**](NumberSeriesInvalidOverlap.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_series_invalid_overlaps_id_get**
> NumberSeriesInvalidOverlap number_series_invalid_overlaps_id_get(id)



Get NumberSeriesInvalidOverlap

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesInvalidOverlapApi()
id = 56 # int | 

try:
    api_response = api_instance.number_series_invalid_overlaps_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesInvalidOverlapApi->number_series_invalid_overlaps_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**NumberSeriesInvalidOverlap**](NumberSeriesInvalidOverlap.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_series_invalid_overlaps_id_put**
> NumberSeriesInvalidOverlap number_series_invalid_overlaps_id_put(body, id)



Update NumberSeriesInvalidOverlap

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesInvalidOverlapApi()
body = swagger_client.NumberSeriesInvalidOverlap() # NumberSeriesInvalidOverlap | 
id = 56 # int | 

try:
    api_response = api_instance.number_series_invalid_overlaps_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesInvalidOverlapApi->number_series_invalid_overlaps_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NumberSeriesInvalidOverlap**](NumberSeriesInvalidOverlap.md)|  | 
 **id** | **int**|  | 

### Return type

[**NumberSeriesInvalidOverlap**](NumberSeriesInvalidOverlap.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_series_invalid_overlaps_post**
> NumberSeriesInvalidOverlap number_series_invalid_overlaps_post(body)



Create NumberSeriesInvalidOverlap

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesInvalidOverlapApi()
body = swagger_client.NumberSeriesInvalidOverlap() # NumberSeriesInvalidOverlap | 

try:
    api_response = api_instance.number_series_invalid_overlaps_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesInvalidOverlapApi->number_series_invalid_overlaps_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NumberSeriesInvalidOverlap**](NumberSeriesInvalidOverlap.md)|  | 

### Return type

[**NumberSeriesInvalidOverlap**](NumberSeriesInvalidOverlap.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

