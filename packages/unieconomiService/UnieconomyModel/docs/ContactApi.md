# swagger_client.ContactApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**contacts_get**](ContactApi.md#contacts_get) | **GET** /contacts | 
[**contacts_id_delete**](ContactApi.md#contacts_id_delete) | **DELETE** /contacts/{id} | 
[**contacts_id_get**](ContactApi.md#contacts_id_get) | **GET** /contacts/{id} | 
[**contacts_id_put**](ContactApi.md#contacts_id_put) | **PUT** /contacts/{id} | 
[**contacts_post**](ContactApi.md#contacts_post) | **POST** /contacts | 

# **contacts_get**
> list[Contact] contacts_get()



Query Contact

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContactApi()

try:
    api_response = api_instance.contacts_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContactApi->contacts_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Contact]**](Contact.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contacts_id_delete**
> Contact contacts_id_delete(id)



Delete Contact

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContactApi()
id = 56 # int | 

try:
    api_response = api_instance.contacts_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContactApi->contacts_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Contact**](Contact.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contacts_id_get**
> Contact contacts_id_get(id)



Get Contact

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContactApi()
id = 56 # int | 

try:
    api_response = api_instance.contacts_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContactApi->contacts_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Contact**](Contact.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contacts_id_put**
> Contact contacts_id_put(body, id)



Update Contact

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContactApi()
body = swagger_client.Contact() # Contact | 
id = 56 # int | 

try:
    api_response = api_instance.contacts_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContactApi->contacts_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Contact**](Contact.md)|  | 
 **id** | **int**|  | 

### Return type

[**Contact**](Contact.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contacts_post**
> Contact contacts_post(body)



Create Contact

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContactApi()
body = swagger_client.Contact() # Contact | 

try:
    api_response = api_instance.contacts_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContactApi->contacts_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Contact**](Contact.md)|  | 

### Return type

[**Contact**](Contact.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

