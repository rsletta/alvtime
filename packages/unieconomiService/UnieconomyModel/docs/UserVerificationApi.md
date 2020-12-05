# swagger_client.UserVerificationApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**user_verifications_get**](UserVerificationApi.md#user_verifications_get) | **GET** /user-verifications | 
[**user_verifications_id_delete**](UserVerificationApi.md#user_verifications_id_delete) | **DELETE** /user-verifications/{id} | 
[**user_verifications_id_get**](UserVerificationApi.md#user_verifications_id_get) | **GET** /user-verifications/{id} | 
[**user_verifications_post**](UserVerificationApi.md#user_verifications_post) | **POST** /user-verifications | 
[**user_verificationsactioncancel_invitation_post**](UserVerificationApi.md#user_verificationsactioncancel_invitation_post) | **POST** /user-verifications?action&#x3D;cancel-invitation | 
[**user_verificationsactioncreate_post**](UserVerificationApi.md#user_verificationsactioncreate_post) | **POST** /user-verifications?action&#x3D;create | 

# **user_verifications_get**
> list[UserVerification] user_verifications_get()



Query UserVerification

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserVerificationApi()

try:
    api_response = api_instance.user_verifications_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserVerificationApi->user_verifications_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[UserVerification]**](UserVerification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_verifications_id_delete**
> UserVerification user_verifications_id_delete(id)



Delete UserVerification

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserVerificationApi()
id = 56 # int | 

try:
    api_response = api_instance.user_verifications_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserVerificationApi->user_verifications_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**UserVerification**](UserVerification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_verifications_id_get**
> UserVerification user_verifications_id_get(id)



Get UserVerification

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserVerificationApi()
id = 56 # int | 

try:
    api_response = api_instance.user_verifications_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserVerificationApi->user_verifications_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**UserVerification**](UserVerification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_verifications_post**
> UserVerification user_verifications_post(body)



Create UserVerification

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserVerificationApi()
body = swagger_client.UserVerification() # UserVerification | 

try:
    api_response = api_instance.user_verifications_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserVerificationApi->user_verifications_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserVerification**](UserVerification.md)|  | 

### Return type

[**UserVerification**](UserVerification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_verificationsactioncancel_invitation_post**
> UserVerification user_verificationsactioncancel_invitation_post(body=body)



cancel-invitation Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserVerificationApi()
body = swagger_client.UserVerification() # UserVerification |  (optional)

try:
    api_response = api_instance.user_verificationsactioncancel_invitation_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserVerificationApi->user_verificationsactioncancel_invitation_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserVerification**](UserVerification.md)|  | [optional] 

### Return type

[**UserVerification**](UserVerification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_verificationsactioncreate_post**
> UserVerification user_verificationsactioncreate_post(body=body)



create Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserVerificationApi()
body = swagger_client.UserVerification() # UserVerification |  (optional)

try:
    api_response = api_instance.user_verificationsactioncreate_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserVerificationApi->user_verificationsactioncreate_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserVerification**](UserVerification.md)|  | [optional] 

### Return type

[**UserVerification**](UserVerification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

