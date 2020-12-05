# swagger_client.EmployeeApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**employees_get**](EmployeeApi.md#employees_get) | **GET** /employees | 
[**employees_id_delete**](EmployeeApi.md#employees_id_delete) | **DELETE** /employees/{id} | 
[**employees_id_get**](EmployeeApi.md#employees_id_get) | **GET** /employees/{id} | 
[**employees_id_put**](EmployeeApi.md#employees_id_put) | **PUT** /employees/{id} | 
[**employees_idactionnext_get**](EmployeeApi.md#employees_idactionnext_get) | **GET** /employees/{id}?action&#x3D;next | 
[**employees_idactionprevious_get**](EmployeeApi.md#employees_idactionprevious_get) | **GET** /employees/{id}?action&#x3D;previous | 
[**employees_idactionsetcategories_put**](EmployeeApi.md#employees_idactionsetcategories_put) | **PUT** /employees/{id}?action&#x3D;setcategories | 
[**employees_idactionvacationpay_closure_put**](EmployeeApi.md#employees_idactionvacationpay_closure_put) | **PUT** /employees/{id}?action&#x3D;vacationpay-closure | 
[**employees_idactionvacationpay_create_put**](EmployeeApi.md#employees_idactionvacationpay_create_put) | **PUT** /employees/{id}?action&#x3D;vacationpay-create | 
[**employees_post**](EmployeeApi.md#employees_post) | **POST** /employees | 
[**employeesactionemps_on_transes_get**](EmployeeApi.md#employeesactionemps_on_transes_get) | **GET** /employees?action&#x3D;emps-on-transes | 
[**employeesactionread_tax_cards_get**](EmployeeApi.md#employeesactionread_tax_cards_get) | **GET** /employees?action&#x3D;read-tax-cards | 

# **employees_get**
> list[Employee] employees_get()



Query Employee

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeApi()

try:
    api_response = api_instance.employees_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeApi->employees_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Employee]**](Employee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employees_id_delete**
> Employee employees_id_delete(id)



Delete Employee

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeApi()
id = 56 # int | 

try:
    api_response = api_instance.employees_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeApi->employees_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Employee**](Employee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employees_id_get**
> Employee employees_id_get(id)



Get Employee

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeApi()
id = 56 # int | 

try:
    api_response = api_instance.employees_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeApi->employees_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Employee**](Employee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employees_id_put**
> Employee employees_id_put(body, id)



Update Employee

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeApi()
body = swagger_client.Employee() # Employee | 
id = 56 # int | 

try:
    api_response = api_instance.employees_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeApi->employees_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Employee**](Employee.md)|  | 
 **id** | **int**|  | 

### Return type

[**Employee**](Employee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employees_idactionnext_get**
> Employee employees_idactionnext_get(id)



next Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeApi()
id = 56 # int | 

try:
    api_response = api_instance.employees_idactionnext_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeApi->employees_idactionnext_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Employee**](Employee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employees_idactionprevious_get**
> Employee employees_idactionprevious_get(id)



previous Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeApi()
id = 56 # int | 

try:
    api_response = api_instance.employees_idactionprevious_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeApi->employees_idactionprevious_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Employee**](Employee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employees_idactionsetcategories_put**
> object employees_idactionsetcategories_put(id, categories)



setcategories Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 
categories = swagger_client.Object() # Object | 

try:
    api_response = api_instance.employees_idactionsetcategories_put(id, categories)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeApi->employees_idactionsetcategories_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **categories** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employees_idactionvacationpay_closure_put**
> object employees_idactionvacationpay_closure_put(id, sixth, payroll_run_id)



vacationpay-closure Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeApi()
id = 56 # int | 
sixth = swagger_client.Object() # Object | 
payroll_run_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.employees_idactionvacationpay_closure_put(id, sixth, payroll_run_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeApi->employees_idactionvacationpay_closure_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **sixth** | [**Object**](.md)|  | 
 **payroll_run_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employees_idactionvacationpay_create_put**
> object employees_idactionvacationpay_create_put(id, year, sixth, payroll_run_id)



vacationpay-create Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeApi()
id = 56 # int | 
year = swagger_client.Object() # Object | 
sixth = swagger_client.Object() # Object | 
payroll_run_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.employees_idactionvacationpay_create_put(id, year, sixth, payroll_run_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeApi->employees_idactionvacationpay_create_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **year** | [**Object**](.md)|  | 
 **sixth** | [**Object**](.md)|  | 
 **payroll_run_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employees_post**
> Employee employees_post(body)



Create Employee

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeApi()
body = swagger_client.Employee() # Employee | 

try:
    api_response = api_instance.employees_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeApi->employees_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Employee**](Employee.md)|  | 

### Return type

[**Employee**](Employee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employeesactionemps_on_transes_get**
> list[Employee] employeesactionemps_on_transes_get(status, expand)



emps-on-transes Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeApi()
status = swagger_client.Object() # Object | 
expand = swagger_client.Object() # Object | 

try:
    api_response = api_instance.employeesactionemps_on_transes_get(status, expand)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeApi->employeesactionemps_on_transes_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **status** | [**Object**](.md)|  | 
 **expand** | [**Object**](.md)|  | 

### Return type

[**list[Employee]**](Employee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employeesactionread_tax_cards_get**
> TaxCardReadStatus employeesactionread_tax_cards_get(receipt_id)



read-tax-cards Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeApi()
receipt_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.employeesactionread_tax_cards_get(receipt_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeApi->employeesactionread_tax_cards_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receipt_id** | [**Object**](.md)|  | 

### Return type

[**TaxCardReadStatus**](TaxCardReadStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

