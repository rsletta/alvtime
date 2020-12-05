# swagger_client.ContractAssetApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**contractassets_get**](ContractAssetApi.md#contractassets_get) | **GET** /contractassets | 
[**contractassets_id_delete**](ContractAssetApi.md#contractassets_id_delete) | **DELETE** /contractassets/{id} | 
[**contractassets_id_get**](ContractAssetApi.md#contractassets_id_get) | **GET** /contractassets/{id} | 
[**contractassets_id_put**](ContractAssetApi.md#contractassets_id_put) | **PUT** /contractassets/{id} | 
[**contractassets_post**](ContractAssetApi.md#contractassets_post) | **POST** /contractassets | 

# **contractassets_get**
> list[ContractAsset] contractassets_get()



Query ContractAsset

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractAssetApi()

try:
    api_response = api_instance.contractassets_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractAssetApi->contractassets_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ContractAsset]**](ContractAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contractassets_id_delete**
> ContractAsset contractassets_id_delete(id)



Delete ContractAsset

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractAssetApi()
id = 56 # int | 

try:
    api_response = api_instance.contractassets_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractAssetApi->contractassets_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ContractAsset**](ContractAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contractassets_id_get**
> ContractAsset contractassets_id_get(id)



Get ContractAsset

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractAssetApi()
id = 56 # int | 

try:
    api_response = api_instance.contractassets_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractAssetApi->contractassets_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ContractAsset**](ContractAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contractassets_id_put**
> ContractAsset contractassets_id_put(body, id)



Update ContractAsset

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractAssetApi()
body = swagger_client.ContractAsset() # ContractAsset | 
id = 56 # int | 

try:
    api_response = api_instance.contractassets_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractAssetApi->contractassets_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContractAsset**](ContractAsset.md)|  | 
 **id** | **int**|  | 

### Return type

[**ContractAsset**](ContractAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contractassets_post**
> ContractAsset contractassets_post(body)



Create ContractAsset

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractAssetApi()
body = swagger_client.ContractAsset() # ContractAsset | 

try:
    api_response = api_instance.contractassets_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractAssetApi->contractassets_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContractAsset**](ContractAsset.md)|  | 

### Return type

[**ContractAsset**](ContractAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

