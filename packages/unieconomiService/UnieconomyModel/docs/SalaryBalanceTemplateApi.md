# swagger_client.SalaryBalanceTemplateApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**salarybalancetemplates_get**](SalaryBalanceTemplateApi.md#salarybalancetemplates_get) | **GET** /salarybalancetemplates | 
[**salarybalancetemplates_id_delete**](SalaryBalanceTemplateApi.md#salarybalancetemplates_id_delete) | **DELETE** /salarybalancetemplates/{id} | 
[**salarybalancetemplates_id_get**](SalaryBalanceTemplateApi.md#salarybalancetemplates_id_get) | **GET** /salarybalancetemplates/{id} | 
[**salarybalancetemplates_id_put**](SalaryBalanceTemplateApi.md#salarybalancetemplates_id_put) | **PUT** /salarybalancetemplates/{id} | 
[**salarybalancetemplates_post**](SalaryBalanceTemplateApi.md#salarybalancetemplates_post) | **POST** /salarybalancetemplates | 

# **salarybalancetemplates_get**
> list[SalaryBalanceTemplate] salarybalancetemplates_get()



Query SalaryBalanceTemplate

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryBalanceTemplateApi()

try:
    api_response = api_instance.salarybalancetemplates_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryBalanceTemplateApi->salarybalancetemplates_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[SalaryBalanceTemplate]**](SalaryBalanceTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarybalancetemplates_id_delete**
> SalaryBalanceTemplate salarybalancetemplates_id_delete(id)



Delete SalaryBalanceTemplate

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryBalanceTemplateApi()
id = 56 # int | 

try:
    api_response = api_instance.salarybalancetemplates_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryBalanceTemplateApi->salarybalancetemplates_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**SalaryBalanceTemplate**](SalaryBalanceTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarybalancetemplates_id_get**
> SalaryBalanceTemplate salarybalancetemplates_id_get(id)



Get SalaryBalanceTemplate

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryBalanceTemplateApi()
id = 56 # int | 

try:
    api_response = api_instance.salarybalancetemplates_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryBalanceTemplateApi->salarybalancetemplates_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**SalaryBalanceTemplate**](SalaryBalanceTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarybalancetemplates_id_put**
> SalaryBalanceTemplate salarybalancetemplates_id_put(body, id)



Update SalaryBalanceTemplate

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryBalanceTemplateApi()
body = swagger_client.SalaryBalanceTemplate() # SalaryBalanceTemplate | 
id = 56 # int | 

try:
    api_response = api_instance.salarybalancetemplates_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryBalanceTemplateApi->salarybalancetemplates_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SalaryBalanceTemplate**](SalaryBalanceTemplate.md)|  | 
 **id** | **int**|  | 

### Return type

[**SalaryBalanceTemplate**](SalaryBalanceTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarybalancetemplates_post**
> SalaryBalanceTemplate salarybalancetemplates_post(body)



Create SalaryBalanceTemplate

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryBalanceTemplateApi()
body = swagger_client.SalaryBalanceTemplate() # SalaryBalanceTemplate | 

try:
    api_response = api_instance.salarybalancetemplates_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryBalanceTemplateApi->salarybalancetemplates_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SalaryBalanceTemplate**](SalaryBalanceTemplate.md)|  | 

### Return type

[**SalaryBalanceTemplate**](SalaryBalanceTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

