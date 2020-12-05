# swagger_client.AgreementApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**agreements_get**](AgreementApi.md#agreements_get) | **GET** /agreements | 
[**agreements_id_delete**](AgreementApi.md#agreements_id_delete) | **DELETE** /agreements/{id} | 
[**agreements_id_get**](AgreementApi.md#agreements_id_get) | **GET** /agreements/{id} | 
[**agreements_id_put**](AgreementApi.md#agreements_id_put) | **PUT** /agreements/{id} | 
[**agreements_post**](AgreementApi.md#agreements_post) | **POST** /agreements | 
[**agreementsactioncurrent_get**](AgreementApi.md#agreementsactioncurrent_get) | **GET** /agreements?action&#x3D;current | 

# **agreements_get**
> list[Agreement] agreements_get()



Query Agreement

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AgreementApi()

try:
    api_response = api_instance.agreements_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AgreementApi->agreements_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Agreement]**](Agreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **agreements_id_delete**
> Agreement agreements_id_delete(id)



Delete Agreement

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AgreementApi()
id = 56 # int | 

try:
    api_response = api_instance.agreements_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AgreementApi->agreements_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Agreement**](Agreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **agreements_id_get**
> Agreement agreements_id_get(id)



Get Agreement

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AgreementApi()
id = 56 # int | 

try:
    api_response = api_instance.agreements_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AgreementApi->agreements_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Agreement**](Agreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **agreements_id_put**
> Agreement agreements_id_put(body, id)



Update Agreement

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AgreementApi()
body = swagger_client.Agreement() # Agreement | 
id = 56 # int | 

try:
    api_response = api_instance.agreements_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AgreementApi->agreements_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Agreement**](Agreement.md)|  | 
 **id** | **int**|  | 

### Return type

[**Agreement**](Agreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **agreements_post**
> Agreement agreements_post(body)



Create Agreement

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AgreementApi()
body = swagger_client.Agreement() # Agreement | 

try:
    api_response = api_instance.agreements_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AgreementApi->agreements_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Agreement**](Agreement.md)|  | 

### Return type

[**Agreement**](Agreement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **agreementsactioncurrent_get**
> str agreementsactioncurrent_get(name, appliesto)



current Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AgreementApi()
name = swagger_client.Object() # Object | 
appliesto = swagger_client.Object() # Object | 

try:
    api_response = api_instance.agreementsactioncurrent_get(name, appliesto)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AgreementApi->agreementsactioncurrent_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | [**Object**](.md)|  | 
 **appliesto** | [**Object**](.md)|  | 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

