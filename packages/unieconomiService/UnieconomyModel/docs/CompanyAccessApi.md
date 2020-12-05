# swagger_client.CompanyAccessApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**companies_access_get**](CompanyAccessApi.md#companies_access_get) | **GET** /companies-access | 
[**companies_access_id_delete**](CompanyAccessApi.md#companies_access_id_delete) | **DELETE** /companies-access/{id} | 
[**companies_access_id_get**](CompanyAccessApi.md#companies_access_id_get) | **GET** /companies-access/{id} | 
[**companies_access_id_put**](CompanyAccessApi.md#companies_access_id_put) | **PUT** /companies-access/{id} | 
[**companies_access_post**](CompanyAccessApi.md#companies_access_post) | **POST** /companies-access | 

# **companies_access_get**
> list[CompanyAccess] companies_access_get()



Query CompanyAccess

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyAccessApi()

try:
    api_response = api_instance.companies_access_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyAccessApi->companies_access_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CompanyAccess]**](CompanyAccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_access_id_delete**
> CompanyAccess companies_access_id_delete(id)



Delete CompanyAccess

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyAccessApi()
id = 56 # int | 

try:
    api_response = api_instance.companies_access_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyAccessApi->companies_access_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CompanyAccess**](CompanyAccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_access_id_get**
> CompanyAccess companies_access_id_get(id)



Get CompanyAccess

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyAccessApi()
id = 56 # int | 

try:
    api_response = api_instance.companies_access_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyAccessApi->companies_access_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CompanyAccess**](CompanyAccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_access_id_put**
> CompanyAccess companies_access_id_put(body, id)



Update CompanyAccess

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyAccessApi()
body = swagger_client.CompanyAccess() # CompanyAccess | 
id = 56 # int | 

try:
    api_response = api_instance.companies_access_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyAccessApi->companies_access_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompanyAccess**](CompanyAccess.md)|  | 
 **id** | **int**|  | 

### Return type

[**CompanyAccess**](CompanyAccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_access_post**
> CompanyAccess companies_access_post(body)



Create CompanyAccess

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyAccessApi()
body = swagger_client.CompanyAccess() # CompanyAccess | 

try:
    api_response = api_instance.companies_access_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyAccessApi->companies_access_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompanyAccess**](CompanyAccess.md)|  | 

### Return type

[**CompanyAccess**](CompanyAccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

