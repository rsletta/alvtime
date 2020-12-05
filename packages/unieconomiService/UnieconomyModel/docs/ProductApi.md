# swagger_client.ProductApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**products_get**](ProductApi.md#products_get) | **GET** /products | 
[**products_id_delete**](ProductApi.md#products_id_delete) | **DELETE** /products/{id} | 
[**products_id_get**](ProductApi.md#products_id_get) | **GET** /products/{id} | 
[**products_id_put**](ProductApi.md#products_id_put) | **PUT** /products/{id} | 
[**products_idaction_delete_post**](ProductApi.md#products_idaction_delete_post) | **POST** /products/{id}?action&#x3D;Delete | 
[**products_idaction_discard_post**](ProductApi.md#products_idaction_discard_post) | **POST** /products/{id}?action&#x3D;Discard | 
[**products_idaction_reactivate_post**](ProductApi.md#products_idaction_reactivate_post) | **POST** /products/{id}?action&#x3D;Reactivate | 
[**products_idactionfirst_get**](ProductApi.md#products_idactionfirst_get) | **GET** /products/{id}?action&#x3D;first | 
[**products_idactionis_used_get**](ProductApi.md#products_idactionis_used_get) | **GET** /products/{id}?action&#x3D;is-used | 
[**products_idactionlast_get**](ProductApi.md#products_idactionlast_get) | **GET** /products/{id}?action&#x3D;last | 
[**products_idactionnext_get**](ProductApi.md#products_idactionnext_get) | **GET** /products/{id}?action&#x3D;next | 
[**products_idactionprevious_get**](ProductApi.md#products_idactionprevious_get) | **GET** /products/{id}?action&#x3D;previous | 
[**products_idactiontransitions_get**](ProductApi.md#products_idactiontransitions_get) | **GET** /products/{id}?action&#x3D;transitions | 
[**products_post**](ProductApi.md#products_post) | **POST** /products | 
[**productsactionbulk_save_put**](ProductApi.md#productsactionbulk_save_put) | **PUT** /products?action&#x3D;bulk-save | 
[**productsactioncalculateprice_post**](ProductApi.md#productsactioncalculateprice_post) | **POST** /products?action&#x3D;calculateprice | 
[**productsactionget_barnepass_products_get**](ProductApi.md#productsactionget_barnepass_products_get) | **GET** /products?action&#x3D;get-barnepass-products | 
[**productsactiongetnewpartname_get**](ProductApi.md#productsactiongetnewpartname_get) | **GET** /products?action&#x3D;getnewpartname | 
[**productsactionsave_barnepass_products_put**](ProductApi.md#productsactionsave_barnepass_products_put) | **PUT** /products?action&#x3D;save-barnepass-products | 

# **products_get**
> list[Product] products_get()



Query Product

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductApi()

try:
    api_response = api_instance.products_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductApi->products_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Product]**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **products_id_delete**
> Product products_id_delete(id)



Delete Product

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductApi()
id = 56 # int | 

try:
    api_response = api_instance.products_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductApi->products_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Product**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **products_id_get**
> Product products_id_get(id)



Get Product

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductApi()
id = 56 # int | 

try:
    api_response = api_instance.products_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductApi->products_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Product**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **products_id_put**
> Product products_id_put(body, id)



Update Product

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductApi()
body = swagger_client.Product() # Product | 
id = 56 # int | 

try:
    api_response = api_instance.products_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductApi->products_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Product**](Product.md)|  | 
 **id** | **int**|  | 

### Return type

[**Product**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **products_idaction_delete_post**
> object products_idaction_delete_post(id, id)



Delete Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.products_idaction_delete_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductApi->products_idaction_delete_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **products_idaction_discard_post**
> object products_idaction_discard_post(id, id)



Discard Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.products_idaction_discard_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductApi->products_idaction_discard_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **products_idaction_reactivate_post**
> object products_idaction_reactivate_post(id, id)



Reactivate Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.products_idaction_reactivate_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductApi->products_idaction_reactivate_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **products_idactionfirst_get**
> Product products_idactionfirst_get(id)



first Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductApi()
id = 56 # int | 

try:
    api_response = api_instance.products_idactionfirst_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductApi->products_idactionfirst_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Product**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **products_idactionis_used_get**
> bool products_idactionis_used_get(id)



is-used Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductApi()
id = 56 # int | 

try:
    api_response = api_instance.products_idactionis_used_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductApi->products_idactionis_used_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **products_idactionlast_get**
> Product products_idactionlast_get(id)



last Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductApi()
id = 56 # int | 

try:
    api_response = api_instance.products_idactionlast_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductApi->products_idactionlast_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Product**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **products_idactionnext_get**
> Product products_idactionnext_get(id)



next Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductApi()
id = 56 # int | 

try:
    api_response = api_instance.products_idactionnext_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductApi->products_idactionnext_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Product**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **products_idactionprevious_get**
> Product products_idactionprevious_get(id)



previous Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductApi()
id = 56 # int | 

try:
    api_response = api_instance.products_idactionprevious_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductApi->products_idactionprevious_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Product**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **products_idactiontransitions_get**
> object products_idactiontransitions_get(id)



transitions Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductApi()
id = 56 # int | 

try:
    api_response = api_instance.products_idactiontransitions_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductApi->products_idactiontransitions_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **products_post**
> Product products_post(body)



Create Product

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductApi()
body = swagger_client.Product() # Product | 

try:
    api_response = api_instance.products_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductApi->products_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Product**](Product.md)|  | 

### Return type

[**Product**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **productsactionbulk_save_put**
> object productsactionbulk_save_put(body=body)



bulk-save Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductApi()
body = [swagger_client.Product()] # list[Product] |  (optional)

try:
    api_response = api_instance.productsactionbulk_save_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductApi->productsactionbulk_save_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**list[Product]**](Product.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **productsactioncalculateprice_post**
> Product productsactioncalculateprice_post(body=body)



calculateprice Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductApi()
body = swagger_client.Product() # Product |  (optional)

try:
    api_response = api_instance.productsactioncalculateprice_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductApi->productsactioncalculateprice_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Product**](Product.md)|  | [optional] 

### Return type

[**Product**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **productsactionget_barnepass_products_get**
> list[Product] productsactionget_barnepass_products_get()



get-barnepass-products Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductApi()

try:
    api_response = api_instance.productsactionget_barnepass_products_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductApi->productsactionget_barnepass_products_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Product]**](Product.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **productsactiongetnewpartname_get**
> object productsactiongetnewpartname_get()



getnewpartname Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductApi()

try:
    api_response = api_instance.productsactiongetnewpartname_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductApi->productsactiongetnewpartname_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **productsactionsave_barnepass_products_put**
> object productsactionsave_barnepass_products_put(body=body)



save-barnepass-products Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductApi()
body = 56 # int |  (optional)

try:
    api_response = api_instance.productsactionsave_barnepass_products_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductApi->productsactionsave_barnepass_products_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**int**](int.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

