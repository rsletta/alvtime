# swagger_client.SalaryBalanceApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**salarybalances_get**](SalaryBalanceApi.md#salarybalances_get) | **GET** /salarybalances | 
[**salarybalances_id_delete**](SalaryBalanceApi.md#salarybalances_id_delete) | **DELETE** /salarybalances/{id} | 
[**salarybalances_id_get**](SalaryBalanceApi.md#salarybalances_id_get) | **GET** /salarybalances/{id} | 
[**salarybalances_id_put**](SalaryBalanceApi.md#salarybalances_id_put) | **PUT** /salarybalances/{id} | 
[**salarybalances_idactionbalance_get**](SalaryBalanceApi.md#salarybalances_idactionbalance_get) | **GET** /salarybalances/{id}?action&#x3D;balance | 
[**salarybalances_post**](SalaryBalanceApi.md#salarybalances_post) | **POST** /salarybalances | 
[**salarybalancesactionfill_post**](SalaryBalanceApi.md#salarybalancesactionfill_post) | **POST** /salarybalances?action&#x3D;fill | 
[**salarybalancesactionunionreport_get**](SalaryBalanceApi.md#salarybalancesactionunionreport_get) | **GET** /salarybalances?action&#x3D;unionreport | 
[**salarybalancesactionupdate_from_employments_put**](SalaryBalanceApi.md#salarybalancesactionupdate_from_employments_put) | **PUT** /salarybalances?action&#x3D;update-from-employments | 

# **salarybalances_get**
> list[SalaryBalance] salarybalances_get()



Query SalaryBalance

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryBalanceApi()

try:
    api_response = api_instance.salarybalances_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryBalanceApi->salarybalances_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[SalaryBalance]**](SalaryBalance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarybalances_id_delete**
> SalaryBalance salarybalances_id_delete(id)



Delete SalaryBalance

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryBalanceApi()
id = 56 # int | 

try:
    api_response = api_instance.salarybalances_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryBalanceApi->salarybalances_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**SalaryBalance**](SalaryBalance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarybalances_id_get**
> SalaryBalance salarybalances_id_get(id)



Get SalaryBalance

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryBalanceApi()
id = 56 # int | 

try:
    api_response = api_instance.salarybalances_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryBalanceApi->salarybalances_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**SalaryBalance**](SalaryBalance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarybalances_id_put**
> SalaryBalance salarybalances_id_put(body, id)



Update SalaryBalance

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryBalanceApi()
body = swagger_client.SalaryBalance() # SalaryBalance | 
id = 56 # int | 

try:
    api_response = api_instance.salarybalances_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryBalanceApi->salarybalances_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SalaryBalance**](SalaryBalance.md)|  | 
 **id** | **int**|  | 

### Return type

[**SalaryBalance**](SalaryBalance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarybalances_idactionbalance_get**
> object salarybalances_idactionbalance_get(id)



balance Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryBalanceApi()
id = 56 # int | 

try:
    api_response = api_instance.salarybalances_idactionbalance_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryBalanceApi->salarybalances_idactionbalance_get: %s\n" % e)
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

# **salarybalances_post**
> SalaryBalance salarybalances_post(body)



Create SalaryBalance

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryBalanceApi()
body = swagger_client.SalaryBalance() # SalaryBalance | 

try:
    api_response = api_instance.salarybalances_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryBalanceApi->salarybalances_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SalaryBalance**](SalaryBalance.md)|  | 

### Return type

[**SalaryBalance**](SalaryBalance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarybalancesactionfill_post**
> SalaryBalance salarybalancesactionfill_post(body=body)



fill Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryBalanceApi()
body = swagger_client.SalaryBalance() # SalaryBalance |  (optional)

try:
    api_response = api_instance.salarybalancesactionfill_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryBalanceApi->salarybalancesactionfill_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SalaryBalance**](SalaryBalance.md)|  | [optional] 

### Return type

[**SalaryBalance**](SalaryBalance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarybalancesactionunionreport_get**
> UnionReport salarybalancesactionunionreport_get(from_period, to_period, from_supplier, to_supplier)



unionreport Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryBalanceApi()
from_period = swagger_client.Object() # Object | 
to_period = swagger_client.Object() # Object | 
from_supplier = swagger_client.Object() # Object | 
to_supplier = swagger_client.Object() # Object | 

try:
    api_response = api_instance.salarybalancesactionunionreport_get(from_period, to_period, from_supplier, to_supplier)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryBalanceApi->salarybalancesactionunionreport_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from_period** | [**Object**](.md)|  | 
 **to_period** | [**Object**](.md)|  | 
 **from_supplier** | [**Object**](.md)|  | 
 **to_supplier** | [**Object**](.md)|  | 

### Return type

[**UnionReport**](UnionReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **salarybalancesactionupdate_from_employments_put**
> list[SalaryTransaction] salarybalancesactionupdate_from_employments_put(body=body)



update-from-employments Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryBalanceApi()
body = 56 # int |  (optional)

try:
    api_response = api_instance.salarybalancesactionupdate_from_employments_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryBalanceApi->salarybalancesactionupdate_from_employments_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**int**](int.md)|  | [optional] 

### Return type

[**list[SalaryTransaction]**](SalaryTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

