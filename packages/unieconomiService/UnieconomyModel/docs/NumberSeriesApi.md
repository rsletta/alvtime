# swagger_client.NumberSeriesApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**number_series_get**](NumberSeriesApi.md#number_series_get) | **GET** /number-series | 
[**number_series_id_delete**](NumberSeriesApi.md#number_series_id_delete) | **DELETE** /number-series/{id} | 
[**number_series_id_get**](NumberSeriesApi.md#number_series_id_get) | **GET** /number-series/{id} | 
[**number_series_id_put**](NumberSeriesApi.md#number_series_id_put) | **PUT** /number-series/{id} | 
[**number_series_post**](NumberSeriesApi.md#number_series_post) | **POST** /number-series | 
[**number_seriesactionget_active_numberseries_get**](NumberSeriesApi.md#number_seriesactionget_active_numberseries_get) | **GET** /number-series?action&#x3D;get-active-numberseries | 
[**number_seriesactionget_available_numbers_in_numberseries_get**](NumberSeriesApi.md#number_seriesactionget_available_numbers_in_numberseries_get) | **GET** /number-series?action&#x3D;get-available-numbers-in-numberseries | 
[**number_seriesactionget_max_used_number_get**](NumberSeriesApi.md#number_seriesactionget_max_used_number_get) | **GET** /number-series?action&#x3D;get-max-used-number | 
[**number_seriesactionget_numberseries_asinvoice_get**](NumberSeriesApi.md#number_seriesactionget_numberseries_asinvoice_get) | **GET** /number-series?action&#x3D;get-numberseries-asinvoice | 
[**number_seriesactionreset_numberseries_next_number_put**](NumberSeriesApi.md#number_seriesactionreset_numberseries_next_number_put) | **PUT** /number-series?action&#x3D;reset-numberseries-next-number | 

# **number_series_get**
> list[NumberSeries] number_series_get()



Query NumberSeries

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesApi()

try:
    api_response = api_instance.number_series_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesApi->number_series_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[NumberSeries]**](NumberSeries.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_series_id_delete**
> NumberSeries number_series_id_delete(id)



Delete NumberSeries

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesApi()
id = 56 # int | 

try:
    api_response = api_instance.number_series_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesApi->number_series_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**NumberSeries**](NumberSeries.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_series_id_get**
> NumberSeries number_series_id_get(id)



Get NumberSeries

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesApi()
id = 56 # int | 

try:
    api_response = api_instance.number_series_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesApi->number_series_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**NumberSeries**](NumberSeries.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_series_id_put**
> NumberSeries number_series_id_put(body, id)



Update NumberSeries

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesApi()
body = swagger_client.NumberSeries() # NumberSeries | 
id = 56 # int | 

try:
    api_response = api_instance.number_series_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesApi->number_series_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NumberSeries**](NumberSeries.md)|  | 
 **id** | **int**|  | 

### Return type

[**NumberSeries**](NumberSeries.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_series_post**
> NumberSeries number_series_post(body)



Create NumberSeries

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesApi()
body = swagger_client.NumberSeries() # NumberSeries | 

try:
    api_response = api_instance.number_series_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesApi->number_series_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NumberSeries**](NumberSeries.md)|  | 

### Return type

[**NumberSeries**](NumberSeries.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_seriesactionget_active_numberseries_get**
> list[NumberSeries] number_seriesactionget_active_numberseries_get(entity_type, year)



get-active-numberseries Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesApi()
entity_type = swagger_client.Object() # Object | 
year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.number_seriesactionget_active_numberseries_get(entity_type, year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesApi->number_seriesactionget_active_numberseries_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entity_type** | [**Object**](.md)|  | 
 **year** | [**Object**](.md)|  | 

### Return type

[**list[NumberSeries]**](NumberSeries.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_seriesactionget_available_numbers_in_numberseries_get**
> str number_seriesactionget_available_numbers_in_numberseries_get(number_series_id)



get-available-numbers-in-numberseries Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesApi()
number_series_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.number_seriesactionget_available_numbers_in_numberseries_get(number_series_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesApi->number_seriesactionget_available_numbers_in_numberseries_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **number_series_id** | [**Object**](.md)|  | 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_seriesactionget_max_used_number_get**
> str number_seriesactionget_max_used_number_get(number_series_id)



get-max-used-number Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesApi()
number_series_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.number_seriesactionget_max_used_number_get(number_series_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesApi->number_seriesactionget_max_used_number_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **number_series_id** | [**Object**](.md)|  | 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_seriesactionget_numberseries_asinvoice_get**
> NumberSeries number_seriesactionget_numberseries_asinvoice_get()



get-numberseries-asinvoice Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesApi()

try:
    api_response = api_instance.number_seriesactionget_numberseries_asinvoice_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesApi->number_seriesactionget_numberseries_asinvoice_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**NumberSeries**](NumberSeries.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_seriesactionreset_numberseries_next_number_put**
> object number_seriesactionreset_numberseries_next_number_put(number_series_id)



reset-numberseries-next-number Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesApi()
number_series_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.number_seriesactionreset_numberseries_next_number_put(number_series_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesApi->number_seriesactionreset_numberseries_next_number_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **number_series_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

