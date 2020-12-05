# swagger_client.SupplierApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**suppliers_get**](SupplierApi.md#suppliers_get) | **GET** /suppliers | 
[**suppliers_id_delete**](SupplierApi.md#suppliers_id_delete) | **DELETE** /suppliers/{id} | 
[**suppliers_id_get**](SupplierApi.md#suppliers_id_get) | **GET** /suppliers/{id} | 
[**suppliers_id_put**](SupplierApi.md#suppliers_id_put) | **PUT** /suppliers/{id} | 
[**suppliers_idactionnext_get**](SupplierApi.md#suppliers_idactionnext_get) | **GET** /suppliers/{id}?action&#x3D;next | 
[**suppliers_idactionprevious_get**](SupplierApi.md#suppliers_idactionprevious_get) | **GET** /suppliers/{id}?action&#x3D;previous | 
[**suppliers_post**](SupplierApi.md#suppliers_post) | **POST** /suppliers | 
[**suppliersactionactivate_put**](SupplierApi.md#suppliersactionactivate_put) | **PUT** /suppliers?action&#x3D;activate | 
[**suppliersactionblock_put**](SupplierApi.md#suppliersactionblock_put) | **PUT** /suppliers?action&#x3D;block | 
[**suppliersactionbulk_save_put**](SupplierApi.md#suppliersactionbulk_save_put) | **PUT** /suppliers?action&#x3D;bulk-save | 
[**suppliersactiondeactivate_put**](SupplierApi.md#suppliersactiondeactivate_put) | **PUT** /suppliers?action&#x3D;deactivate | 
[**suppliersactiondelete_put**](SupplierApi.md#suppliersactiondelete_put) | **PUT** /suppliers?action&#x3D;delete | 
[**suppliersactionunblock_put**](SupplierApi.md#suppliersactionunblock_put) | **PUT** /suppliers?action&#x3D;unblock | 

# **suppliers_get**
> list[Supplier] suppliers_get()



Query Supplier

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierApi()

try:
    api_response = api_instance.suppliers_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierApi->suppliers_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Supplier]**](Supplier.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **suppliers_id_delete**
> Supplier suppliers_id_delete(id)



Delete Supplier

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierApi()
id = 56 # int | 

try:
    api_response = api_instance.suppliers_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierApi->suppliers_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Supplier**](Supplier.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **suppliers_id_get**
> Supplier suppliers_id_get(id)



Get Supplier

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierApi()
id = 56 # int | 

try:
    api_response = api_instance.suppliers_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierApi->suppliers_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Supplier**](Supplier.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **suppliers_id_put**
> Supplier suppliers_id_put(body, id)



Update Supplier

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierApi()
body = swagger_client.Supplier() # Supplier | 
id = 56 # int | 

try:
    api_response = api_instance.suppliers_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierApi->suppliers_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Supplier**](Supplier.md)|  | 
 **id** | **int**|  | 

### Return type

[**Supplier**](Supplier.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **suppliers_idactionnext_get**
> Supplier suppliers_idactionnext_get(id)



next Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierApi()
id = 56 # int | 

try:
    api_response = api_instance.suppliers_idactionnext_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierApi->suppliers_idactionnext_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Supplier**](Supplier.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **suppliers_idactionprevious_get**
> Supplier suppliers_idactionprevious_get(id)



previous Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierApi()
id = 56 # int | 

try:
    api_response = api_instance.suppliers_idactionprevious_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierApi->suppliers_idactionprevious_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Supplier**](Supplier.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **suppliers_post**
> Supplier suppliers_post(body)



Create Supplier

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierApi()
body = swagger_client.Supplier() # Supplier | 

try:
    api_response = api_instance.suppliers_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierApi->suppliers_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Supplier**](Supplier.md)|  | 

### Return type

[**Supplier**](Supplier.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **suppliersactionactivate_put**
> object suppliersactionactivate_put(id)



activate Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierApi()
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.suppliersactionactivate_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierApi->suppliersactionactivate_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **suppliersactionblock_put**
> object suppliersactionblock_put(id)



block Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierApi()
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.suppliersactionblock_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierApi->suppliersactionblock_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **suppliersactionbulk_save_put**
> object suppliersactionbulk_save_put(body=body)



bulk-save Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierApi()
body = [swagger_client.Supplier()] # list[Supplier] |  (optional)

try:
    api_response = api_instance.suppliersactionbulk_save_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierApi->suppliersactionbulk_save_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**list[Supplier]**](Supplier.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **suppliersactiondeactivate_put**
> object suppliersactiondeactivate_put(id)



deactivate Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierApi()
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.suppliersactiondeactivate_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierApi->suppliersactiondeactivate_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **suppliersactiondelete_put**
> object suppliersactiondelete_put(id)



delete Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierApi()
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.suppliersactiondelete_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierApi->suppliersactiondelete_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **suppliersactionunblock_put**
> object suppliersactionunblock_put(id)



unblock Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierApi()
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.suppliersactionunblock_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierApi->suppliersactionunblock_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

