# swagger_client.CountryApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**countries_get**](CountryApi.md#countries_get) | **GET** /countries | 
[**countries_id_delete**](CountryApi.md#countries_id_delete) | **DELETE** /countries/{id} | 
[**countries_id_get**](CountryApi.md#countries_id_get) | **GET** /countries/{id} | 
[**countries_id_put**](CountryApi.md#countries_id_put) | **PUT** /countries/{id} | 
[**countries_post**](CountryApi.md#countries_post) | **POST** /countries | 
[**countriesactionget_by_countrycode_get**](CountryApi.md#countriesactionget_by_countrycode_get) | **GET** /countries?action&#x3D;get-by-countrycode | 

# **countries_get**
> list[Country] countries_get()



Query Country

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CountryApi()

try:
    api_response = api_instance.countries_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CountryApi->countries_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Country]**](Country.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **countries_id_delete**
> Country countries_id_delete(id)



Delete Country

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CountryApi()
id = 56 # int | 

try:
    api_response = api_instance.countries_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CountryApi->countries_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Country**](Country.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **countries_id_get**
> Country countries_id_get(id)



Get Country

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CountryApi()
id = 56 # int | 

try:
    api_response = api_instance.countries_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CountryApi->countries_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Country**](Country.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **countries_id_put**
> Country countries_id_put(body, id)



Update Country

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CountryApi()
body = swagger_client.Country() # Country | 
id = 56 # int | 

try:
    api_response = api_instance.countries_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CountryApi->countries_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Country**](Country.md)|  | 
 **id** | **int**|  | 

### Return type

[**Country**](Country.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **countries_post**
> Country countries_post(body)



Create Country

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CountryApi()
body = swagger_client.Country() # Country | 

try:
    api_response = api_instance.countries_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CountryApi->countries_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Country**](Country.md)|  | 

### Return type

[**Country**](Country.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **countriesactionget_by_countrycode_get**
> Country countriesactionget_by_countrycode_get()



get-by-countrycode Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CountryApi()

try:
    api_response = api_instance.countriesactionget_by_countrycode_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CountryApi->countriesactionget_by_countrycode_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Country**](Country.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

