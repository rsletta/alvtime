# swagger_client.WorkRelationApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**workrelations_get**](WorkRelationApi.md#workrelations_get) | **GET** /workrelations | 
[**workrelations_id_delete**](WorkRelationApi.md#workrelations_id_delete) | **DELETE** /workrelations/{id} | 
[**workrelations_id_get**](WorkRelationApi.md#workrelations_id_get) | **GET** /workrelations/{id} | 
[**workrelations_id_put**](WorkRelationApi.md#workrelations_id_put) | **PUT** /workrelations/{id} | 
[**workrelations_idactioncalc_flex_balance_get**](WorkRelationApi.md#workrelations_idactioncalc_flex_balance_get) | **GET** /workrelations/{id}?action&#x3D;calc-flex-balance | 
[**workrelations_idactiontimesheet_get**](WorkRelationApi.md#workrelations_idactiontimesheet_get) | **GET** /workrelations/{id}?action&#x3D;timesheet | 
[**workrelations_post**](WorkRelationApi.md#workrelations_post) | **POST** /workrelations | 

# **workrelations_get**
> list[WorkRelation] workrelations_get()



Query WorkRelation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkRelationApi()

try:
    api_response = api_instance.workrelations_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkRelationApi->workrelations_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[WorkRelation]**](WorkRelation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workrelations_id_delete**
> WorkRelation workrelations_id_delete(id)



Delete WorkRelation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkRelationApi()
id = 56 # int | 

try:
    api_response = api_instance.workrelations_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkRelationApi->workrelations_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**WorkRelation**](WorkRelation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workrelations_id_get**
> WorkRelation workrelations_id_get(id)



Get WorkRelation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkRelationApi()
id = 56 # int | 

try:
    api_response = api_instance.workrelations_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkRelationApi->workrelations_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**WorkRelation**](WorkRelation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workrelations_id_put**
> WorkRelation workrelations_id_put(body, id)



Update WorkRelation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkRelationApi()
body = swagger_client.WorkRelation() # WorkRelation | 
id = 56 # int | 

try:
    api_response = api_instance.workrelations_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkRelationApi->workrelations_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WorkRelation**](WorkRelation.md)|  | 
 **id** | **int**|  | 

### Return type

[**WorkRelation**](WorkRelation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workrelations_idactioncalc_flex_balance_get**
> WorkBalanceDto workrelations_idactioncalc_flex_balance_get(id, id)



calc-flex-balance Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkRelationApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.workrelations_idactioncalc_flex_balance_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkRelationApi->workrelations_idactioncalc_flex_balance_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**WorkBalanceDto**](WorkBalanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workrelations_idactiontimesheet_get**
> TimeSheet workrelations_idactiontimesheet_get(id, id)



timesheet Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkRelationApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.workrelations_idactiontimesheet_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkRelationApi->workrelations_idactiontimesheet_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**TimeSheet**](TimeSheet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workrelations_post**
> WorkRelation workrelations_post(body)



Create WorkRelation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkRelationApi()
body = swagger_client.WorkRelation() # WorkRelation | 

try:
    api_response = api_instance.workrelations_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkRelationApi->workrelations_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WorkRelation**](WorkRelation.md)|  | 

### Return type

[**WorkRelation**](WorkRelation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

