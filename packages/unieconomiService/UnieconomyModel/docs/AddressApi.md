# swagger_client.AddressApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**contacts_contactid_addresses_get**](AddressApi.md#contacts_contactid_addresses_get) | **GET** /contacts/{contactid}/addresses | 
[**contacts_contactid_addresses_id_delete**](AddressApi.md#contacts_contactid_addresses_id_delete) | **DELETE** /contacts/{contactid}/addresses/{id} | 
[**contacts_contactid_addresses_id_get**](AddressApi.md#contacts_contactid_addresses_id_get) | **GET** /contacts/{contactid}/addresses/{id} | 
[**contacts_contactid_addresses_id_put**](AddressApi.md#contacts_contactid_addresses_id_put) | **PUT** /contacts/{contactid}/addresses/{id} | 
[**contacts_contactid_addresses_post**](AddressApi.md#contacts_contactid_addresses_post) | **POST** /contacts/{contactid}/addresses | 

# **contacts_contactid_addresses_get**
> list[Address] contacts_contactid_addresses_get()



Query Address

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AddressApi()

try:
    api_response = api_instance.contacts_contactid_addresses_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AddressApi->contacts_contactid_addresses_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Address]**](Address.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contacts_contactid_addresses_id_delete**
> Address contacts_contactid_addresses_id_delete(id)



Delete Address

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AddressApi()
id = 56 # int | 

try:
    api_response = api_instance.contacts_contactid_addresses_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AddressApi->contacts_contactid_addresses_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Address**](Address.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contacts_contactid_addresses_id_get**
> Address contacts_contactid_addresses_id_get(id)



Get Address

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AddressApi()
id = 56 # int | 

try:
    api_response = api_instance.contacts_contactid_addresses_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AddressApi->contacts_contactid_addresses_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Address**](Address.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contacts_contactid_addresses_id_put**
> Address contacts_contactid_addresses_id_put(body, id)



Update Address

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AddressApi()
body = swagger_client.Address() # Address | 
id = 56 # int | 

try:
    api_response = api_instance.contacts_contactid_addresses_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AddressApi->contacts_contactid_addresses_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Address**](Address.md)|  | 
 **id** | **int**|  | 

### Return type

[**Address**](Address.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contacts_contactid_addresses_post**
> Address contacts_contactid_addresses_post(body)



Create Address

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AddressApi()
body = swagger_client.Address() # Address | 

try:
    api_response = api_instance.contacts_contactid_addresses_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AddressApi->contacts_contactid_addresses_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Address**](Address.md)|  | 

### Return type

[**Address**](Address.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

