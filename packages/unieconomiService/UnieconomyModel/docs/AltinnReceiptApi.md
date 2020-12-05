# swagger_client.AltinnReceiptApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**altinnreceipts_get**](AltinnReceiptApi.md#altinnreceipts_get) | **GET** /altinnreceipts | 
[**altinnreceipts_id_get**](AltinnReceiptApi.md#altinnreceipts_id_get) | **GET** /altinnreceipts/{id} | 
[**altinnreceipts_id_put**](AltinnReceiptApi.md#altinnreceipts_id_put) | **PUT** /altinnreceipts/{id} | 
[**altinnreceipts_idactionupdate_put**](AltinnReceiptApi.md#altinnreceipts_idactionupdate_put) | **PUT** /altinnreceipts/{id}?action&#x3D;update | 
[**altinnreceipts_post**](AltinnReceiptApi.md#altinnreceipts_post) | **POST** /altinnreceipts | 

# **altinnreceipts_get**
> list[AltinnReceipt] altinnreceipts_get()



Query AltinnReceipt

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnReceiptApi()

try:
    api_response = api_instance.altinnreceipts_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnReceiptApi->altinnreceipts_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[AltinnReceipt]**](AltinnReceipt.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinnreceipts_id_get**
> AltinnReceipt altinnreceipts_id_get(id)



Get AltinnReceipt

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnReceiptApi()
id = 56 # int | 

try:
    api_response = api_instance.altinnreceipts_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnReceiptApi->altinnreceipts_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**AltinnReceipt**](AltinnReceipt.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinnreceipts_id_put**
> AltinnReceipt altinnreceipts_id_put(body, id)



Update AltinnReceipt

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnReceiptApi()
body = swagger_client.AltinnReceipt() # AltinnReceipt | 
id = 56 # int | 

try:
    api_response = api_instance.altinnreceipts_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnReceiptApi->altinnreceipts_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AltinnReceipt**](AltinnReceipt.md)|  | 
 **id** | **int**|  | 

### Return type

[**AltinnReceipt**](AltinnReceipt.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinnreceipts_idactionupdate_put**
> AltinnReceipt altinnreceipts_idactionupdate_put(id)



update Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnReceiptApi()
id = 56 # int | 

try:
    api_response = api_instance.altinnreceipts_idactionupdate_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnReceiptApi->altinnreceipts_idactionupdate_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**AltinnReceipt**](AltinnReceipt.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinnreceipts_post**
> AltinnReceipt altinnreceipts_post(body)



Create AltinnReceipt

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnReceiptApi()
body = swagger_client.AltinnReceipt() # AltinnReceipt | 

try:
    api_response = api_instance.altinnreceipts_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnReceiptApi->altinnreceipts_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AltinnReceipt**](AltinnReceipt.md)|  | 

### Return type

[**AltinnReceipt**](AltinnReceipt.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

