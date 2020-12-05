# swagger_client.CustomerApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**customers_get**](CustomerApi.md#customers_get) | **GET** /customers | 
[**customers_id_delete**](CustomerApi.md#customers_id_delete) | **DELETE** /customers/{id} | 
[**customers_id_get**](CustomerApi.md#customers_id_get) | **GET** /customers/{id} | 
[**customers_id_put**](CustomerApi.md#customers_id_put) | **PUT** /customers/{id} | 
[**customers_idactionnext_get**](CustomerApi.md#customers_idactionnext_get) | **GET** /customers/{id}?action&#x3D;next | 
[**customers_idactionprevious_get**](CustomerApi.md#customers_idactionprevious_get) | **GET** /customers/{id}?action&#x3D;previous | 
[**customers_post**](CustomerApi.md#customers_post) | **POST** /customers | 
[**customersactionactivate_put**](CustomerApi.md#customersactionactivate_put) | **PUT** /customers?action&#x3D;activate | 
[**customersactionblock_put**](CustomerApi.md#customersactionblock_put) | **PUT** /customers?action&#x3D;block | 
[**customersactionbulk_save_put**](CustomerApi.md#customersactionbulk_save_put) | **PUT** /customers?action&#x3D;bulk-save | 
[**customersactiondeactivate_put**](CustomerApi.md#customersactiondeactivate_put) | **PUT** /customers?action&#x3D;deactivate | 
[**customersactionvalidate_customer_kid_alias_get**](CustomerApi.md#customersactionvalidate_customer_kid_alias_get) | **GET** /customers?action&#x3D;validate-customer-KID-Alias | 

# **customers_get**
> list[Customer] customers_get()



Query Customer

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerApi()

try:
    api_response = api_instance.customers_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerApi->customers_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Customer]**](Customer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **customers_id_delete**
> Customer customers_id_delete(id)



Delete Customer

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerApi()
id = 56 # int | 

try:
    api_response = api_instance.customers_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerApi->customers_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Customer**](Customer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **customers_id_get**
> Customer customers_id_get(id)



Get Customer

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerApi()
id = 56 # int | 

try:
    api_response = api_instance.customers_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerApi->customers_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Customer**](Customer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **customers_id_put**
> Customer customers_id_put(body, id)



Update Customer

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerApi()
body = swagger_client.Customer() # Customer | 
id = 56 # int | 

try:
    api_response = api_instance.customers_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerApi->customers_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Customer**](Customer.md)|  | 
 **id** | **int**|  | 

### Return type

[**Customer**](Customer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **customers_idactionnext_get**
> Customer customers_idactionnext_get(id)



next Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerApi()
id = 56 # int | 

try:
    api_response = api_instance.customers_idactionnext_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerApi->customers_idactionnext_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Customer**](Customer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **customers_idactionprevious_get**
> Customer customers_idactionprevious_get(id)



previous Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerApi()
id = 56 # int | 

try:
    api_response = api_instance.customers_idactionprevious_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerApi->customers_idactionprevious_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Customer**](Customer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **customers_post**
> Customer customers_post(body)



Create Customer

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerApi()
body = swagger_client.Customer() # Customer | 

try:
    api_response = api_instance.customers_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerApi->customers_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Customer**](Customer.md)|  | 

### Return type

[**Customer**](Customer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **customersactionactivate_put**
> object customersactionactivate_put(id)



activate Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerApi()
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.customersactionactivate_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerApi->customersactionactivate_put: %s\n" % e)
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

# **customersactionblock_put**
> object customersactionblock_put(id)



block Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerApi()
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.customersactionblock_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerApi->customersactionblock_put: %s\n" % e)
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

# **customersactionbulk_save_put**
> object customersactionbulk_save_put(body=body)



bulk-save Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerApi()
body = [swagger_client.Customer()] # list[Customer] |  (optional)

try:
    api_response = api_instance.customersactionbulk_save_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerApi->customersactionbulk_save_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**list[Customer]**](Customer.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **customersactiondeactivate_put**
> object customersactiondeactivate_put(id)



deactivate Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerApi()
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.customersactiondeactivate_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerApi->customersactiondeactivate_put: %s\n" % e)
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

# **customersactionvalidate_customer_kid_alias_get**
> bool customersactionvalidate_customer_kid_alias_get(customer_kid_alias)



validate-customer-KID-Alias Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerApi()
customer_kid_alias = swagger_client.Object() # Object | 

try:
    api_response = api_instance.customersactionvalidate_customer_kid_alias_get(customer_kid_alias)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerApi->customersactionvalidate_customer_kid_alias_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customer_kid_alias** | [**Object**](.md)|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

