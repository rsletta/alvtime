# swagger_client.EmailLogApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**emails_get**](EmailLogApi.md#emails_get) | **GET** /emails | 
[**emails_id_delete**](EmailLogApi.md#emails_id_delete) | **DELETE** /emails/{id} | 
[**emails_id_get**](EmailLogApi.md#emails_id_get) | **GET** /emails/{id} | 
[**emails_id_put**](EmailLogApi.md#emails_id_put) | **PUT** /emails/{id} | 
[**emails_post**](EmailLogApi.md#emails_post) | **POST** /emails | 
[**emailsactionsend_post**](EmailLogApi.md#emailsactionsend_post) | **POST** /emails?action&#x3D;send | 

# **emails_get**
> list[EmailLog] emails_get()



Query EmailLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmailLogApi()

try:
    api_response = api_instance.emails_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmailLogApi->emails_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[EmailLog]**](EmailLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **emails_id_delete**
> EmailLog emails_id_delete(id)



Delete EmailLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmailLogApi()
id = 56 # int | 

try:
    api_response = api_instance.emails_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmailLogApi->emails_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**EmailLog**](EmailLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **emails_id_get**
> EmailLog emails_id_get(id)



Get EmailLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmailLogApi()
id = 56 # int | 

try:
    api_response = api_instance.emails_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmailLogApi->emails_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**EmailLog**](EmailLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **emails_id_put**
> EmailLog emails_id_put(body, id)



Update EmailLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmailLogApi()
body = swagger_client.EmailLog() # EmailLog | 
id = 56 # int | 

try:
    api_response = api_instance.emails_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmailLogApi->emails_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmailLog**](EmailLog.md)|  | 
 **id** | **int**|  | 

### Return type

[**EmailLog**](EmailLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **emails_post**
> EmailLog emails_post(body)



Create EmailLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmailLogApi()
body = swagger_client.EmailLog() # EmailLog | 

try:
    api_response = api_instance.emails_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmailLogApi->emails_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmailLog**](EmailLog.md)|  | 

### Return type

[**EmailLog**](EmailLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **emailsactionsend_post**
> bool emailsactionsend_post(body=body)



send Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmailLogApi()
body = swagger_client.SendEmail() # SendEmail |  (optional)

try:
    api_response = api_instance.emailsactionsend_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmailLogApi->emailsactionsend_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SendEmail**](SendEmail.md)|  | [optional] 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

