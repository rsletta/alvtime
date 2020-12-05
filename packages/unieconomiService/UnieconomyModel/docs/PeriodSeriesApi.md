# swagger_client.PeriodSeriesApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**period_series_get**](PeriodSeriesApi.md#period_series_get) | **GET** /period-series | 
[**period_series_id_delete**](PeriodSeriesApi.md#period_series_id_delete) | **DELETE** /period-series/{id} | 
[**period_series_id_get**](PeriodSeriesApi.md#period_series_id_get) | **GET** /period-series/{id} | 
[**period_series_id_put**](PeriodSeriesApi.md#period_series_id_put) | **PUT** /period-series/{id} | 
[**period_series_post**](PeriodSeriesApi.md#period_series_post) | **POST** /period-series | 

# **period_series_get**
> list[PeriodSeries] period_series_get()



Query PeriodSeries

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PeriodSeriesApi()

try:
    api_response = api_instance.period_series_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PeriodSeriesApi->period_series_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[PeriodSeries]**](PeriodSeries.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **period_series_id_delete**
> PeriodSeries period_series_id_delete(id)



Delete PeriodSeries

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PeriodSeriesApi()
id = 56 # int | 

try:
    api_response = api_instance.period_series_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PeriodSeriesApi->period_series_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PeriodSeries**](PeriodSeries.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **period_series_id_get**
> PeriodSeries period_series_id_get(id)



Get PeriodSeries

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PeriodSeriesApi()
id = 56 # int | 

try:
    api_response = api_instance.period_series_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PeriodSeriesApi->period_series_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PeriodSeries**](PeriodSeries.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **period_series_id_put**
> PeriodSeries period_series_id_put(body, id)



Update PeriodSeries

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PeriodSeriesApi()
body = swagger_client.PeriodSeries() # PeriodSeries | 
id = 56 # int | 

try:
    api_response = api_instance.period_series_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PeriodSeriesApi->period_series_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PeriodSeries**](PeriodSeries.md)|  | 
 **id** | **int**|  | 

### Return type

[**PeriodSeries**](PeriodSeries.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **period_series_post**
> PeriodSeries period_series_post(body)



Create PeriodSeries

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PeriodSeriesApi()
body = swagger_client.PeriodSeries() # PeriodSeries | 

try:
    api_response = api_instance.period_series_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PeriodSeriesApi->period_series_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PeriodSeries**](PeriodSeries.md)|  | 

### Return type

[**PeriodSeries**](PeriodSeries.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

