# swagger_client.PeriodApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**periodes_get**](PeriodApi.md#periodes_get) | **GET** /periodes | 
[**periodes_id_delete**](PeriodApi.md#periodes_id_delete) | **DELETE** /periodes/{id} | 
[**periodes_id_get**](PeriodApi.md#periodes_id_get) | **GET** /periodes/{id} | 
[**periodes_id_put**](PeriodApi.md#periodes_id_put) | **PUT** /periodes/{id} | 
[**periodes_post**](PeriodApi.md#periodes_post) | **POST** /periodes | 

# **periodes_get**
> list[Period] periodes_get()



Query Period

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PeriodApi()

try:
    api_response = api_instance.periodes_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PeriodApi->periodes_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Period]**](Period.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **periodes_id_delete**
> Period periodes_id_delete(id)



Delete Period

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PeriodApi()
id = 56 # int | 

try:
    api_response = api_instance.periodes_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PeriodApi->periodes_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Period**](Period.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **periodes_id_get**
> Period periodes_id_get(id)



Get Period

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PeriodApi()
id = 56 # int | 

try:
    api_response = api_instance.periodes_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PeriodApi->periodes_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Period**](Period.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **periodes_id_put**
> Period periodes_id_put(body, id)



Update Period

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PeriodApi()
body = swagger_client.Period() # Period | 
id = 56 # int | 

try:
    api_response = api_instance.periodes_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PeriodApi->periodes_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Period**](Period.md)|  | 
 **id** | **int**|  | 

### Return type

[**Period**](Period.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **periodes_post**
> Period periodes_post(body)



Create Period

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PeriodApi()
body = swagger_client.Period() # Period | 

try:
    api_response = api_instance.periodes_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PeriodApi->periodes_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Period**](Period.md)|  | 

### Return type

[**Period**](Period.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

