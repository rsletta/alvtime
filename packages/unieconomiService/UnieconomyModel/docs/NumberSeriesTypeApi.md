# swagger_client.NumberSeriesTypeApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**number_series_types_get**](NumberSeriesTypeApi.md#number_series_types_get) | **GET** /number-series-types | 
[**number_series_types_id_delete**](NumberSeriesTypeApi.md#number_series_types_id_delete) | **DELETE** /number-series-types/{id} | 
[**number_series_types_id_get**](NumberSeriesTypeApi.md#number_series_types_id_get) | **GET** /number-series-types/{id} | 
[**number_series_types_id_put**](NumberSeriesTypeApi.md#number_series_types_id_put) | **PUT** /number-series-types/{id} | 
[**number_series_types_post**](NumberSeriesTypeApi.md#number_series_types_post) | **POST** /number-series-types | 

# **number_series_types_get**
> list[NumberSeriesType] number_series_types_get()



Query NumberSeriesType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesTypeApi()

try:
    api_response = api_instance.number_series_types_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesTypeApi->number_series_types_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[NumberSeriesType]**](NumberSeriesType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_series_types_id_delete**
> NumberSeriesType number_series_types_id_delete(id)



Delete NumberSeriesType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.number_series_types_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesTypeApi->number_series_types_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**NumberSeriesType**](NumberSeriesType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_series_types_id_get**
> NumberSeriesType number_series_types_id_get(id)



Get NumberSeriesType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.number_series_types_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesTypeApi->number_series_types_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**NumberSeriesType**](NumberSeriesType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_series_types_id_put**
> NumberSeriesType number_series_types_id_put(body, id)



Update NumberSeriesType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesTypeApi()
body = swagger_client.NumberSeriesType() # NumberSeriesType | 
id = 56 # int | 

try:
    api_response = api_instance.number_series_types_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesTypeApi->number_series_types_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NumberSeriesType**](NumberSeriesType.md)|  | 
 **id** | **int**|  | 

### Return type

[**NumberSeriesType**](NumberSeriesType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_series_types_post**
> NumberSeriesType number_series_types_post(body)



Create NumberSeriesType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesTypeApi()
body = swagger_client.NumberSeriesType() # NumberSeriesType | 

try:
    api_response = api_instance.number_series_types_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesTypeApi->number_series_types_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NumberSeriesType**](NumberSeriesType.md)|  | 

### Return type

[**NumberSeriesType**](NumberSeriesType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

