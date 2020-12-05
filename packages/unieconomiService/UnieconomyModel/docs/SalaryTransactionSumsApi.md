# swagger_client.SalaryTransactionSumsApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**salarysums_get**](SalaryTransactionSumsApi.md#salarysums_get) | **GET** /salarysums | 
[**salarysums_id_get**](SalaryTransactionSumsApi.md#salarysums_id_get) | **GET** /salarysums/{id} | 
[**salarysums_idactionyearly_sums_on_payrollrun_get**](SalaryTransactionSumsApi.md#salarysums_idactionyearly_sums_on_payrollrun_get) | **GET** /salarysums/{id}?action&#x3D;yearly-sums-on-payrollrun | 
[**salarysumsactionget_sums_get**](SalaryTransactionSumsApi.md#salarysumsactionget_sums_get) | **GET** /salarysums?action&#x3D;get-sums | 
[**salarysumsactiongetall_get**](SalaryTransactionSumsApi.md#salarysumsactiongetall_get) | **GET** /salarysums?action&#x3D;getall | 
[**salarysumsactionsum_aga_lines_get**](SalaryTransactionSumsApi.md#salarysumsactionsum_aga_lines_get) | **GET** /salarysums?action&#x3D;sum-aga-lines | 
[**salarysumsactionsums_in_period_get**](SalaryTransactionSumsApi.md#salarysumsactionsums_in_period_get) | **GET** /salarysums?action&#x3D;sums-in-period | 

# **salarysums_get**
> list[SalaryTransactionSums] salarysums_get()



Query SalaryTransactionSums

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryTransactionSumsApi()

try:
    api_response = api_instance.salarysums_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryTransactionSumsApi->salarysums_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[SalaryTransactionSums]**](SalaryTransactionSums.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarysums_id_get**
> SalaryTransactionSums salarysums_id_get(id)



Get SalaryTransactionSums

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryTransactionSumsApi()
id = 56 # int | 

try:
    api_response = api_instance.salarysums_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryTransactionSumsApi->salarysums_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**SalaryTransactionSums**](SalaryTransactionSums.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarysums_idactionyearly_sums_on_payrollrun_get**
> SalaryTransactionSums salarysums_idactionyearly_sums_on_payrollrun_get(id, id, emp_no, emp_id)



yearly-sums-on-payrollrun Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryTransactionSumsApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 
emp_no = swagger_client.Object() # Object | 
emp_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.salarysums_idactionyearly_sums_on_payrollrun_get(id, id, emp_no, emp_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryTransactionSumsApi->salarysums_idactionyearly_sums_on_payrollrun_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **emp_no** | [**Object**](.md)|  | 
 **emp_id** | [**Object**](.md)|  | 

### Return type

[**SalaryTransactionSums**](SalaryTransactionSums.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarysumsactionget_sums_get**
> SalaryTransactionSums salarysumsactionget_sums_get(id)



get-sums Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryTransactionSumsApi()
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.salarysumsactionget_sums_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryTransactionSumsApi->salarysumsactionget_sums_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 

### Return type

[**SalaryTransactionSums**](SalaryTransactionSums.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarysumsactiongetall_get**
> object salarysumsactiongetall_get()



getall Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryTransactionSumsApi()

try:
    api_response = api_instance.salarysumsactiongetall_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryTransactionSumsApi->salarysumsactiongetall_get: %s\n" % e)
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

# **salarysumsactionsum_aga_lines_get**
> TaxAndAgaSums salarysumsactionsum_aga_lines_get(from_period, to_period, year)



sum-aga-lines Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryTransactionSumsApi()
from_period = swagger_client.Object() # Object | 
to_period = swagger_client.Object() # Object | 
year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.salarysumsactionsum_aga_lines_get(from_period, to_period, year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryTransactionSumsApi->salarysumsactionsum_aga_lines_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from_period** | [**Object**](.md)|  | 
 **to_period** | [**Object**](.md)|  | 
 **year** | [**Object**](.md)|  | 

### Return type

[**TaxAndAgaSums**](TaxAndAgaSums.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarysumsactionsums_in_period_get**
> object salarysumsactionsums_in_period_get(from_period, to_period, year)



sums-in-period Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryTransactionSumsApi()
from_period = swagger_client.Object() # Object | 
to_period = swagger_client.Object() # Object | 
year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.salarysumsactionsums_in_period_get(from_period, to_period, year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryTransactionSumsApi->salarysumsactionsums_in_period_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from_period** | [**Object**](.md)|  | 
 **to_period** | [**Object**](.md)|  | 
 **year** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

