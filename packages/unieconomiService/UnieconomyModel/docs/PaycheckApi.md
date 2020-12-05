# swagger_client.PaycheckApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**paycheck_get**](PaycheckApi.md#paycheck_get) | **GET** /paycheck | 
[**paycheck_id_delete**](PaycheckApi.md#paycheck_id_delete) | **DELETE** /paycheck/{id} | 
[**paycheck_id_get**](PaycheckApi.md#paycheck_id_get) | **GET** /paycheck/{id} | 
[**paycheck_id_put**](PaycheckApi.md#paycheck_id_put) | **PUT** /paycheck/{id} | 
[**paycheck_post**](PaycheckApi.md#paycheck_post) | **POST** /paycheck | 
[**paycheckactionall_get**](PaycheckApi.md#paycheckactionall_get) | **GET** /paycheck?action&#x3D;all | 
[**paycheckactionfromto_get**](PaycheckApi.md#paycheckactionfromto_get) | **GET** /paycheck?action&#x3D;fromto | 
[**paycheckactioninselection_get**](PaycheckApi.md#paycheckactioninselection_get) | **GET** /paycheck?action&#x3D;inselection | 
[**paycheckactionregeneratezip_put**](PaycheckApi.md#paycheckactionregeneratezip_put) | **PUT** /paycheck?action&#x3D;regeneratezip | 

# **paycheck_get**
> list[Paycheck] paycheck_get()



Query Paycheck

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaycheckApi()

try:
    api_response = api_instance.paycheck_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaycheckApi->paycheck_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Paycheck]**](Paycheck.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paycheck_id_delete**
> Paycheck paycheck_id_delete(id)



Delete Paycheck

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaycheckApi()
id = 56 # int | 

try:
    api_response = api_instance.paycheck_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaycheckApi->paycheck_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Paycheck**](Paycheck.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paycheck_id_get**
> Paycheck paycheck_id_get(id)



Get Paycheck

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaycheckApi()
id = 56 # int | 

try:
    api_response = api_instance.paycheck_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaycheckApi->paycheck_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Paycheck**](Paycheck.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paycheck_id_put**
> Paycheck paycheck_id_put(body, id)



Update Paycheck

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaycheckApi()
body = swagger_client.Paycheck() # Paycheck | 
id = 56 # int | 

try:
    api_response = api_instance.paycheck_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaycheckApi->paycheck_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Paycheck**](Paycheck.md)|  | 
 **id** | **int**|  | 

### Return type

[**Paycheck**](Paycheck.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paycheck_post**
> Paycheck paycheck_post(body)



Create Paycheck

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaycheckApi()
body = swagger_client.Paycheck() # Paycheck | 

try:
    api_response = api_instance.paycheck_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaycheckApi->paycheck_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Paycheck**](Paycheck.md)|  | 

### Return type

[**Paycheck**](Paycheck.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paycheckactionall_get**
> object paycheckactionall_get(payroll_id, grouped)



all Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaycheckApi()
payroll_id = swagger_client.Object() # Object | 
grouped = swagger_client.Object() # Object | 

try:
    api_response = api_instance.paycheckactionall_get(payroll_id, grouped)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaycheckApi->paycheckactionall_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payroll_id** | [**Object**](.md)|  | 
 **grouped** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paycheckactionfromto_get**
> object paycheckactionfromto_get(payroll_id, empno_from, empno_to, grouped)



fromto Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaycheckApi()
payroll_id = swagger_client.Object() # Object | 
empno_from = swagger_client.Object() # Object | 
empno_to = swagger_client.Object() # Object | 
grouped = swagger_client.Object() # Object | 

try:
    api_response = api_instance.paycheckactionfromto_get(payroll_id, empno_from, empno_to, grouped)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaycheckApi->paycheckactionfromto_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payroll_id** | [**Object**](.md)|  | 
 **empno_from** | [**Object**](.md)|  | 
 **empno_to** | [**Object**](.md)|  | 
 **grouped** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paycheckactioninselection_get**
> object paycheckactioninselection_get(payroll_id, employees, grouped)



inselection Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaycheckApi()
payroll_id = swagger_client.Object() # Object | 
employees = swagger_client.Object() # Object | 
grouped = swagger_client.Object() # Object | 

try:
    api_response = api_instance.paycheckactioninselection_get(payroll_id, employees, grouped)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaycheckApi->paycheckactioninselection_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payroll_id** | [**Object**](.md)|  | 
 **employees** | [**Object**](.md)|  | 
 **grouped** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paycheckactionregeneratezip_put**
> object paycheckactionregeneratezip_put(payroll_id)



regeneratezip Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaycheckApi()
payroll_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.paycheckactionregeneratezip_put(payroll_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaycheckApi->paycheckactionregeneratezip_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payroll_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

