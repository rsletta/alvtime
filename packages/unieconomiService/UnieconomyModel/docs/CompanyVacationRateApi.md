# swagger_client.CompanyVacationRateApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**companyvacationrates_get**](CompanyVacationRateApi.md#companyvacationrates_get) | **GET** /companyvacationrates | 
[**companyvacationrates_id_delete**](CompanyVacationRateApi.md#companyvacationrates_id_delete) | **DELETE** /companyvacationrates/{id} | 
[**companyvacationrates_id_get**](CompanyVacationRateApi.md#companyvacationrates_id_get) | **GET** /companyvacationrates/{id} | 
[**companyvacationrates_id_put**](CompanyVacationRateApi.md#companyvacationrates_id_put) | **PUT** /companyvacationrates/{id} | 
[**companyvacationrates_post**](CompanyVacationRateApi.md#companyvacationrates_post) | **POST** /companyvacationrates | 
[**companyvacationratesactioncurrent_get**](CompanyVacationRateApi.md#companyvacationratesactioncurrent_get) | **GET** /companyvacationrates?action&#x3D;current | 

# **companyvacationrates_get**
> list[CompanyVacationRate] companyvacationrates_get()



Query CompanyVacationRate

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyVacationRateApi()

try:
    api_response = api_instance.companyvacationrates_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyVacationRateApi->companyvacationrates_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CompanyVacationRate]**](CompanyVacationRate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companyvacationrates_id_delete**
> CompanyVacationRate companyvacationrates_id_delete(id)



Delete CompanyVacationRate

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyVacationRateApi()
id = 56 # int | 

try:
    api_response = api_instance.companyvacationrates_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyVacationRateApi->companyvacationrates_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CompanyVacationRate**](CompanyVacationRate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companyvacationrates_id_get**
> CompanyVacationRate companyvacationrates_id_get(id)



Get CompanyVacationRate

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyVacationRateApi()
id = 56 # int | 

try:
    api_response = api_instance.companyvacationrates_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyVacationRateApi->companyvacationrates_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CompanyVacationRate**](CompanyVacationRate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companyvacationrates_id_put**
> CompanyVacationRate companyvacationrates_id_put(body, id)



Update CompanyVacationRate

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyVacationRateApi()
body = swagger_client.CompanyVacationRate() # CompanyVacationRate | 
id = 56 # int | 

try:
    api_response = api_instance.companyvacationrates_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyVacationRateApi->companyvacationrates_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompanyVacationRate**](CompanyVacationRate.md)|  | 
 **id** | **int**|  | 

### Return type

[**CompanyVacationRate**](CompanyVacationRate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companyvacationrates_post**
> CompanyVacationRate companyvacationrates_post(body)



Create CompanyVacationRate

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyVacationRateApi()
body = swagger_client.CompanyVacationRate() # CompanyVacationRate | 

try:
    api_response = api_instance.companyvacationrates_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyVacationRateApi->companyvacationrates_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompanyVacationRate**](CompanyVacationRate.md)|  | 

### Return type

[**CompanyVacationRate**](CompanyVacationRate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companyvacationratesactioncurrent_get**
> CompanyVacationRate companyvacationratesactioncurrent_get(year)



current Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyVacationRateApi()
year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.companyvacationratesactioncurrent_get(year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyVacationRateApi->companyvacationratesactioncurrent_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | [**Object**](.md)|  | 

### Return type

[**CompanyVacationRate**](CompanyVacationRate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

