# swagger_client.TracelinkApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**invoiceitems_itemid_tracelinks_get**](TracelinkApi.md#invoiceitems_itemid_tracelinks_get) | **GET** /invoiceitems/{itemid}/tracelinks | 
[**invoiceitems_itemid_tracelinks_id_delete**](TracelinkApi.md#invoiceitems_itemid_tracelinks_id_delete) | **DELETE** /invoiceitems/{itemid}/tracelinks/{id} | 
[**invoiceitems_itemid_tracelinks_id_get**](TracelinkApi.md#invoiceitems_itemid_tracelinks_id_get) | **GET** /invoiceitems/{itemid}/tracelinks/{id} | 
[**invoiceitems_itemid_tracelinks_id_put**](TracelinkApi.md#invoiceitems_itemid_tracelinks_id_put) | **PUT** /invoiceitems/{itemid}/tracelinks/{id} | 
[**invoiceitems_itemid_tracelinks_post**](TracelinkApi.md#invoiceitems_itemid_tracelinks_post) | **POST** /invoiceitems/{itemid}/tracelinks | 
[**orderitems_itemid_tracelinks_get**](TracelinkApi.md#orderitems_itemid_tracelinks_get) | **GET** /orderitems/{itemid}/tracelinks | 
[**orderitems_itemid_tracelinks_id_delete**](TracelinkApi.md#orderitems_itemid_tracelinks_id_delete) | **DELETE** /orderitems/{itemid}/tracelinks/{id} | 
[**orderitems_itemid_tracelinks_id_get**](TracelinkApi.md#orderitems_itemid_tracelinks_id_get) | **GET** /orderitems/{itemid}/tracelinks/{id} | 
[**orderitems_itemid_tracelinks_id_put**](TracelinkApi.md#orderitems_itemid_tracelinks_id_put) | **PUT** /orderitems/{itemid}/tracelinks/{id} | 
[**orderitems_itemid_tracelinks_post**](TracelinkApi.md#orderitems_itemid_tracelinks_post) | **POST** /orderitems/{itemid}/tracelinks | 
[**quoteitems_itemid_tracelinks_get**](TracelinkApi.md#quoteitems_itemid_tracelinks_get) | **GET** /quoteitems/{itemid}/tracelinks | 
[**quoteitems_itemid_tracelinks_id_delete**](TracelinkApi.md#quoteitems_itemid_tracelinks_id_delete) | **DELETE** /quoteitems/{itemid}/tracelinks/{id} | 
[**quoteitems_itemid_tracelinks_id_get**](TracelinkApi.md#quoteitems_itemid_tracelinks_id_get) | **GET** /quoteitems/{itemid}/tracelinks/{id} | 
[**quoteitems_itemid_tracelinks_id_put**](TracelinkApi.md#quoteitems_itemid_tracelinks_id_put) | **PUT** /quoteitems/{itemid}/tracelinks/{id} | 
[**quoteitems_itemid_tracelinks_post**](TracelinkApi.md#quoteitems_itemid_tracelinks_post) | **POST** /quoteitems/{itemid}/tracelinks | 

# **invoiceitems_itemid_tracelinks_get**
> list[Tracelink] invoiceitems_itemid_tracelinks_get()



Query Tracelink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TracelinkApi()

try:
    api_response = api_instance.invoiceitems_itemid_tracelinks_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TracelinkApi->invoiceitems_itemid_tracelinks_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Tracelink]**](Tracelink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoiceitems_itemid_tracelinks_id_delete**
> Tracelink invoiceitems_itemid_tracelinks_id_delete(id)



Delete Tracelink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TracelinkApi()
id = 56 # int | 

try:
    api_response = api_instance.invoiceitems_itemid_tracelinks_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TracelinkApi->invoiceitems_itemid_tracelinks_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Tracelink**](Tracelink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoiceitems_itemid_tracelinks_id_get**
> Tracelink invoiceitems_itemid_tracelinks_id_get(id)



Get Tracelink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TracelinkApi()
id = 56 # int | 

try:
    api_response = api_instance.invoiceitems_itemid_tracelinks_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TracelinkApi->invoiceitems_itemid_tracelinks_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Tracelink**](Tracelink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoiceitems_itemid_tracelinks_id_put**
> Tracelink invoiceitems_itemid_tracelinks_id_put(body, id)



Update Tracelink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TracelinkApi()
body = swagger_client.Tracelink() # Tracelink | 
id = 56 # int | 

try:
    api_response = api_instance.invoiceitems_itemid_tracelinks_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TracelinkApi->invoiceitems_itemid_tracelinks_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Tracelink**](Tracelink.md)|  | 
 **id** | **int**|  | 

### Return type

[**Tracelink**](Tracelink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoiceitems_itemid_tracelinks_post**
> Tracelink invoiceitems_itemid_tracelinks_post(body)



Create Tracelink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TracelinkApi()
body = swagger_client.Tracelink() # Tracelink | 

try:
    api_response = api_instance.invoiceitems_itemid_tracelinks_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TracelinkApi->invoiceitems_itemid_tracelinks_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Tracelink**](Tracelink.md)|  | 

### Return type

[**Tracelink**](Tracelink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orderitems_itemid_tracelinks_get**
> list[Tracelink] orderitems_itemid_tracelinks_get()



Query Tracelink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TracelinkApi()

try:
    api_response = api_instance.orderitems_itemid_tracelinks_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TracelinkApi->orderitems_itemid_tracelinks_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Tracelink]**](Tracelink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orderitems_itemid_tracelinks_id_delete**
> Tracelink orderitems_itemid_tracelinks_id_delete(id)



Delete Tracelink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TracelinkApi()
id = 56 # int | 

try:
    api_response = api_instance.orderitems_itemid_tracelinks_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TracelinkApi->orderitems_itemid_tracelinks_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Tracelink**](Tracelink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orderitems_itemid_tracelinks_id_get**
> Tracelink orderitems_itemid_tracelinks_id_get(id)



Get Tracelink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TracelinkApi()
id = 56 # int | 

try:
    api_response = api_instance.orderitems_itemid_tracelinks_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TracelinkApi->orderitems_itemid_tracelinks_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Tracelink**](Tracelink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orderitems_itemid_tracelinks_id_put**
> Tracelink orderitems_itemid_tracelinks_id_put(body, id)



Update Tracelink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TracelinkApi()
body = swagger_client.Tracelink() # Tracelink | 
id = 56 # int | 

try:
    api_response = api_instance.orderitems_itemid_tracelinks_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TracelinkApi->orderitems_itemid_tracelinks_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Tracelink**](Tracelink.md)|  | 
 **id** | **int**|  | 

### Return type

[**Tracelink**](Tracelink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orderitems_itemid_tracelinks_post**
> Tracelink orderitems_itemid_tracelinks_post(body)



Create Tracelink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TracelinkApi()
body = swagger_client.Tracelink() # Tracelink | 

try:
    api_response = api_instance.orderitems_itemid_tracelinks_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TracelinkApi->orderitems_itemid_tracelinks_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Tracelink**](Tracelink.md)|  | 

### Return type

[**Tracelink**](Tracelink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quoteitems_itemid_tracelinks_get**
> list[Tracelink] quoteitems_itemid_tracelinks_get()



Query Tracelink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TracelinkApi()

try:
    api_response = api_instance.quoteitems_itemid_tracelinks_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TracelinkApi->quoteitems_itemid_tracelinks_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Tracelink]**](Tracelink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quoteitems_itemid_tracelinks_id_delete**
> Tracelink quoteitems_itemid_tracelinks_id_delete(id)



Delete Tracelink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TracelinkApi()
id = 56 # int | 

try:
    api_response = api_instance.quoteitems_itemid_tracelinks_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TracelinkApi->quoteitems_itemid_tracelinks_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Tracelink**](Tracelink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quoteitems_itemid_tracelinks_id_get**
> Tracelink quoteitems_itemid_tracelinks_id_get(id)



Get Tracelink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TracelinkApi()
id = 56 # int | 

try:
    api_response = api_instance.quoteitems_itemid_tracelinks_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TracelinkApi->quoteitems_itemid_tracelinks_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Tracelink**](Tracelink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quoteitems_itemid_tracelinks_id_put**
> Tracelink quoteitems_itemid_tracelinks_id_put(body, id)



Update Tracelink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TracelinkApi()
body = swagger_client.Tracelink() # Tracelink | 
id = 56 # int | 

try:
    api_response = api_instance.quoteitems_itemid_tracelinks_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TracelinkApi->quoteitems_itemid_tracelinks_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Tracelink**](Tracelink.md)|  | 
 **id** | **int**|  | 

### Return type

[**Tracelink**](Tracelink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quoteitems_itemid_tracelinks_post**
> Tracelink quoteitems_itemid_tracelinks_post(body)



Create Tracelink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TracelinkApi()
body = swagger_client.Tracelink() # Tracelink | 

try:
    api_response = api_instance.quoteitems_itemid_tracelinks_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TracelinkApi->quoteitems_itemid_tracelinks_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Tracelink**](Tracelink.md)|  | 

### Return type

[**Tracelink**](Tracelink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

