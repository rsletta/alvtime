# swagger_client.SalaryBalanceLineApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**salarybalancelines_get**](SalaryBalanceLineApi.md#salarybalancelines_get) | **GET** /salarybalancelines | 
[**salarybalancelines_id_delete**](SalaryBalanceLineApi.md#salarybalancelines_id_delete) | **DELETE** /salarybalancelines/{id} | 
[**salarybalancelines_id_get**](SalaryBalanceLineApi.md#salarybalancelines_id_get) | **GET** /salarybalancelines/{id} | 
[**salarybalancelines_id_put**](SalaryBalanceLineApi.md#salarybalancelines_id_put) | **PUT** /salarybalancelines/{id} | 
[**salarybalancelines_post**](SalaryBalanceLineApi.md#salarybalancelines_post) | **POST** /salarybalancelines | 

# **salarybalancelines_get**
> list[SalaryBalanceLine] salarybalancelines_get()



Query SalaryBalanceLine

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryBalanceLineApi()

try:
    api_response = api_instance.salarybalancelines_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryBalanceLineApi->salarybalancelines_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[SalaryBalanceLine]**](SalaryBalanceLine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarybalancelines_id_delete**
> SalaryBalanceLine salarybalancelines_id_delete(id)



Delete SalaryBalanceLine

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryBalanceLineApi()
id = 56 # int | 

try:
    api_response = api_instance.salarybalancelines_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryBalanceLineApi->salarybalancelines_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**SalaryBalanceLine**](SalaryBalanceLine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarybalancelines_id_get**
> SalaryBalanceLine salarybalancelines_id_get(id)



Get SalaryBalanceLine

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryBalanceLineApi()
id = 56 # int | 

try:
    api_response = api_instance.salarybalancelines_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryBalanceLineApi->salarybalancelines_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**SalaryBalanceLine**](SalaryBalanceLine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarybalancelines_id_put**
> SalaryBalanceLine salarybalancelines_id_put(body, id)



Update SalaryBalanceLine

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryBalanceLineApi()
body = swagger_client.SalaryBalanceLine() # SalaryBalanceLine | 
id = 56 # int | 

try:
    api_response = api_instance.salarybalancelines_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryBalanceLineApi->salarybalancelines_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SalaryBalanceLine**](SalaryBalanceLine.md)|  | 
 **id** | **int**|  | 

### Return type

[**SalaryBalanceLine**](SalaryBalanceLine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarybalancelines_post**
> SalaryBalanceLine salarybalancelines_post(body)



Create SalaryBalanceLine

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryBalanceLineApi()
body = swagger_client.SalaryBalanceLine() # SalaryBalanceLine | 

try:
    api_response = api_instance.salarybalancelines_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryBalanceLineApi->salarybalancelines_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SalaryBalanceLine**](SalaryBalanceLine.md)|  | 

### Return type

[**SalaryBalanceLine**](SalaryBalanceLine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

