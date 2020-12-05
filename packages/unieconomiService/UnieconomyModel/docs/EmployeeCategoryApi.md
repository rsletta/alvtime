# swagger_client.EmployeeCategoryApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**employeecategories_get**](EmployeeCategoryApi.md#employeecategories_get) | **GET** /employeecategories | 
[**employeecategories_id_delete**](EmployeeCategoryApi.md#employeecategories_id_delete) | **DELETE** /employeecategories/{id} | 
[**employeecategories_id_get**](EmployeeCategoryApi.md#employeecategories_id_get) | **GET** /employeecategories/{id} | 
[**employeecategories_id_put**](EmployeeCategoryApi.md#employeecategories_id_put) | **PUT** /employeecategories/{id} | 
[**employeecategories_idactionemployeesoncategory_get**](EmployeeCategoryApi.md#employeecategories_idactionemployeesoncategory_get) | **GET** /employeecategories/{id}?action&#x3D;employeesoncategory | 
[**employeecategories_idactionpayrollrunsoncategory_get**](EmployeeCategoryApi.md#employeecategories_idactionpayrollrunsoncategory_get) | **GET** /employeecategories/{id}?action&#x3D;payrollrunsoncategory | 
[**employeecategories_post**](EmployeeCategoryApi.md#employeecategories_post) | **POST** /employeecategories | 
[**employees_empno_category_get**](EmployeeCategoryApi.md#employees_empno_category_get) | **GET** /employees/{empno}/category | 
[**employees_empno_category_id_delete**](EmployeeCategoryApi.md#employees_empno_category_id_delete) | **DELETE** /employees/{empno}/category/{id} | 
[**employees_empno_category_id_get**](EmployeeCategoryApi.md#employees_empno_category_id_get) | **GET** /employees/{empno}/category/{id} | 
[**employees_empno_category_id_put**](EmployeeCategoryApi.md#employees_empno_category_id_put) | **PUT** /employees/{empno}/category/{id} | 
[**employees_empno_category_post**](EmployeeCategoryApi.md#employees_empno_category_post) | **POST** /employees/{empno}/category | 
[**payrollrun_runid_category_get**](EmployeeCategoryApi.md#payrollrun_runid_category_get) | **GET** /payrollrun/{runid}/category | 
[**payrollrun_runid_category_id_delete**](EmployeeCategoryApi.md#payrollrun_runid_category_id_delete) | **DELETE** /payrollrun/{runid}/category/{id} | 
[**payrollrun_runid_category_id_get**](EmployeeCategoryApi.md#payrollrun_runid_category_id_get) | **GET** /payrollrun/{runid}/category/{id} | 
[**payrollrun_runid_category_id_put**](EmployeeCategoryApi.md#payrollrun_runid_category_id_put) | **PUT** /payrollrun/{runid}/category/{id} | 
[**payrollrun_runid_category_post**](EmployeeCategoryApi.md#payrollrun_runid_category_post) | **POST** /payrollrun/{runid}/category | 

# **employeecategories_get**
> list[EmployeeCategory] employeecategories_get()



Query EmployeeCategory

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeCategoryApi()

try:
    api_response = api_instance.employeecategories_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeCategoryApi->employeecategories_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[EmployeeCategory]**](EmployeeCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employeecategories_id_delete**
> EmployeeCategory employeecategories_id_delete(id)



Delete EmployeeCategory

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeCategoryApi()
id = 56 # int | 

try:
    api_response = api_instance.employeecategories_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeCategoryApi->employeecategories_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**EmployeeCategory**](EmployeeCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employeecategories_id_get**
> EmployeeCategory employeecategories_id_get(id)



Get EmployeeCategory

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeCategoryApi()
id = 56 # int | 

try:
    api_response = api_instance.employeecategories_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeCategoryApi->employeecategories_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**EmployeeCategory**](EmployeeCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employeecategories_id_put**
> EmployeeCategory employeecategories_id_put(body, id)



Update EmployeeCategory

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeCategoryApi()
body = swagger_client.EmployeeCategory() # EmployeeCategory | 
id = 56 # int | 

try:
    api_response = api_instance.employeecategories_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeCategoryApi->employeecategories_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmployeeCategory**](EmployeeCategory.md)|  | 
 **id** | **int**|  | 

### Return type

[**EmployeeCategory**](EmployeeCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employeecategories_idactionemployeesoncategory_get**
> object employeecategories_idactionemployeesoncategory_get(id, id)



employeesoncategory Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeCategoryApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.employeecategories_idactionemployeesoncategory_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeCategoryApi->employeecategories_idactionemployeesoncategory_get: %s\n" % e)
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

# **employeecategories_idactionpayrollrunsoncategory_get**
> object employeecategories_idactionpayrollrunsoncategory_get(id, id)



payrollrunsoncategory Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeCategoryApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.employeecategories_idactionpayrollrunsoncategory_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeCategoryApi->employeecategories_idactionpayrollrunsoncategory_get: %s\n" % e)
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

# **employeecategories_post**
> EmployeeCategory employeecategories_post(body)



Create EmployeeCategory

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeCategoryApi()
body = swagger_client.EmployeeCategory() # EmployeeCategory | 

try:
    api_response = api_instance.employeecategories_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeCategoryApi->employeecategories_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmployeeCategory**](EmployeeCategory.md)|  | 

### Return type

[**EmployeeCategory**](EmployeeCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employees_empno_category_get**
> list[EmployeeCategory] employees_empno_category_get()



Query EmployeeCategory

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeCategoryApi()

try:
    api_response = api_instance.employees_empno_category_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeCategoryApi->employees_empno_category_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[EmployeeCategory]**](EmployeeCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employees_empno_category_id_delete**
> EmployeeCategory employees_empno_category_id_delete(id)



Delete EmployeeCategory

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeCategoryApi()
id = 56 # int | 

try:
    api_response = api_instance.employees_empno_category_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeCategoryApi->employees_empno_category_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**EmployeeCategory**](EmployeeCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employees_empno_category_id_get**
> EmployeeCategory employees_empno_category_id_get(id)



Get EmployeeCategory

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeCategoryApi()
id = 56 # int | 

try:
    api_response = api_instance.employees_empno_category_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeCategoryApi->employees_empno_category_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**EmployeeCategory**](EmployeeCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employees_empno_category_id_put**
> EmployeeCategory employees_empno_category_id_put(body, id)



Update EmployeeCategory

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeCategoryApi()
body = swagger_client.EmployeeCategory() # EmployeeCategory | 
id = 56 # int | 

try:
    api_response = api_instance.employees_empno_category_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeCategoryApi->employees_empno_category_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmployeeCategory**](EmployeeCategory.md)|  | 
 **id** | **int**|  | 

### Return type

[**EmployeeCategory**](EmployeeCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employees_empno_category_post**
> EmployeeCategory employees_empno_category_post(body)



Create EmployeeCategory

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeCategoryApi()
body = swagger_client.EmployeeCategory() # EmployeeCategory | 

try:
    api_response = api_instance.employees_empno_category_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeCategoryApi->employees_empno_category_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmployeeCategory**](EmployeeCategory.md)|  | 

### Return type

[**EmployeeCategory**](EmployeeCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_runid_category_get**
> list[EmployeeCategory] payrollrun_runid_category_get()



Query EmployeeCategory

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeCategoryApi()

try:
    api_response = api_instance.payrollrun_runid_category_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeCategoryApi->payrollrun_runid_category_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[EmployeeCategory]**](EmployeeCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_runid_category_id_delete**
> EmployeeCategory payrollrun_runid_category_id_delete(id)



Delete EmployeeCategory

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeCategoryApi()
id = 56 # int | 

try:
    api_response = api_instance.payrollrun_runid_category_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeCategoryApi->payrollrun_runid_category_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**EmployeeCategory**](EmployeeCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_runid_category_id_get**
> EmployeeCategory payrollrun_runid_category_id_get(id)



Get EmployeeCategory

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeCategoryApi()
id = 56 # int | 

try:
    api_response = api_instance.payrollrun_runid_category_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeCategoryApi->payrollrun_runid_category_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**EmployeeCategory**](EmployeeCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_runid_category_id_put**
> EmployeeCategory payrollrun_runid_category_id_put(body, id)



Update EmployeeCategory

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeCategoryApi()
body = swagger_client.EmployeeCategory() # EmployeeCategory | 
id = 56 # int | 

try:
    api_response = api_instance.payrollrun_runid_category_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeCategoryApi->payrollrun_runid_category_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmployeeCategory**](EmployeeCategory.md)|  | 
 **id** | **int**|  | 

### Return type

[**EmployeeCategory**](EmployeeCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_runid_category_post**
> EmployeeCategory payrollrun_runid_category_post(body)



Create EmployeeCategory

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeCategoryApi()
body = swagger_client.EmployeeCategory() # EmployeeCategory | 

try:
    api_response = api_instance.payrollrun_runid_category_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeCategoryApi->payrollrun_runid_category_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmployeeCategory**](EmployeeCategory.md)|  | 

### Return type

[**EmployeeCategory**](EmployeeCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

