# swagger_client.BusinessRelationApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**business_relations_get**](BusinessRelationApi.md#business_relations_get) | **GET** /business-relations | 
[**business_relations_id_delete**](BusinessRelationApi.md#business_relations_id_delete) | **DELETE** /business-relations/{id} | 
[**business_relations_id_get**](BusinessRelationApi.md#business_relations_id_get) | **GET** /business-relations/{id} | 
[**business_relations_id_put**](BusinessRelationApi.md#business_relations_id_put) | **PUT** /business-relations/{id} | 
[**business_relations_post**](BusinessRelationApi.md#business_relations_post) | **POST** /business-relations | 
[**business_relationsactionsearch_data_hotel_get**](BusinessRelationApi.md#business_relationsactionsearch_data_hotel_get) | **GET** /business-relations?action&#x3D;search-data-hotel | 

# **business_relations_get**
> list[BusinessRelation] business_relations_get()



Query BusinessRelation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BusinessRelationApi()

try:
    api_response = api_instance.business_relations_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BusinessRelationApi->business_relations_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[BusinessRelation]**](BusinessRelation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **business_relations_id_delete**
> BusinessRelation business_relations_id_delete(id)



Delete BusinessRelation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BusinessRelationApi()
id = 56 # int | 

try:
    api_response = api_instance.business_relations_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BusinessRelationApi->business_relations_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BusinessRelation**](BusinessRelation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **business_relations_id_get**
> BusinessRelation business_relations_id_get(id)



Get BusinessRelation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BusinessRelationApi()
id = 56 # int | 

try:
    api_response = api_instance.business_relations_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BusinessRelationApi->business_relations_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BusinessRelation**](BusinessRelation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **business_relations_id_put**
> BusinessRelation business_relations_id_put(body, id)



Update BusinessRelation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BusinessRelationApi()
body = swagger_client.BusinessRelation() # BusinessRelation | 
id = 56 # int | 

try:
    api_response = api_instance.business_relations_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BusinessRelationApi->business_relations_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BusinessRelation**](BusinessRelation.md)|  | 
 **id** | **int**|  | 

### Return type

[**BusinessRelation**](BusinessRelation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **business_relations_post**
> BusinessRelation business_relations_post(body)



Create BusinessRelation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BusinessRelationApi()
body = swagger_client.BusinessRelation() # BusinessRelation | 

try:
    api_response = api_instance.business_relations_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BusinessRelationApi->business_relations_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BusinessRelation**](BusinessRelation.md)|  | 

### Return type

[**BusinessRelation**](BusinessRelation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **business_relationsactionsearch_data_hotel_get**
> ContactSearchServiceResponse business_relationsactionsearch_data_hotel_get(search_text)



search-data-hotel Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BusinessRelationApi()
search_text = swagger_client.Object() # Object | 

try:
    api_response = api_instance.business_relationsactionsearch_data_hotel_get(search_text)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BusinessRelationApi->business_relationsactionsearch_data_hotel_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **search_text** | [**Object**](.md)|  | 

### Return type

[**ContactSearchServiceResponse**](ContactSearchServiceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

