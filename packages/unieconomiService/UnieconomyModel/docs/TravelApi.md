# swagger_client.TravelApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**travels_get**](TravelApi.md#travels_get) | **GET** /travels | 
[**travels_id_delete**](TravelApi.md#travels_id_delete) | **DELETE** /travels/{id} | 
[**travels_id_get**](TravelApi.md#travels_id_get) | **GET** /travels/{id} | 
[**travels_id_put**](TravelApi.md#travels_id_put) | **PUT** /travels/{id} | 
[**travels_post**](TravelApi.md#travels_post) | **POST** /travels | 
[**travelsactiontoinvoice_put**](TravelApi.md#travelsactiontoinvoice_put) | **PUT** /travels?action&#x3D;toinvoice | 
[**travelsactiontosalary_put**](TravelApi.md#travelsactiontosalary_put) | **PUT** /travels?action&#x3D;tosalary | 
[**travelsactiontraveltext_post**](TravelApi.md#travelsactiontraveltext_post) | **POST** /travels?action&#x3D;traveltext | 
[**travelsactionttpdf_put**](TravelApi.md#travelsactionttpdf_put) | **PUT** /travels?action&#x3D;ttpdf | 

# **travels_get**
> list[Travel] travels_get()



Query Travel

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TravelApi()

try:
    api_response = api_instance.travels_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TravelApi->travels_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Travel]**](Travel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **travels_id_delete**
> Travel travels_id_delete(id)



Delete Travel

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TravelApi()
id = 56 # int | 

try:
    api_response = api_instance.travels_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TravelApi->travels_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Travel**](Travel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **travels_id_get**
> Travel travels_id_get(id)



Get Travel

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TravelApi()
id = 56 # int | 

try:
    api_response = api_instance.travels_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TravelApi->travels_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Travel**](Travel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **travels_id_put**
> Travel travels_id_put(body, id)



Update Travel

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TravelApi()
body = swagger_client.Travel() # Travel | 
id = 56 # int | 

try:
    api_response = api_instance.travels_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TravelApi->travels_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Travel**](Travel.md)|  | 
 **id** | **int**|  | 

### Return type

[**Travel**](Travel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **travels_post**
> Travel travels_post(body)



Create Travel

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TravelApi()
body = swagger_client.Travel() # Travel | 

try:
    api_response = api_instance.travels_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TravelApi->travels_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Travel**](Travel.md)|  | 

### Return type

[**Travel**](Travel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **travelsactiontoinvoice_put**
> list[SupplierInvoice] travelsactiontoinvoice_put(body=body)



toinvoice Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TravelApi()
body = NULL # object |  (optional)

try:
    api_response = api_instance.travelsactiontoinvoice_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TravelApi->travelsactiontoinvoice_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**object**](object.md)|  | [optional] 

### Return type

[**list[SupplierInvoice]**](SupplierInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **travelsactiontosalary_put**
> list[SalaryTransaction] travelsactiontosalary_put(run_id, body=body)



tosalary Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TravelApi()
run_id = swagger_client.Object() # Object | 
body = NULL # object |  (optional)

try:
    api_response = api_instance.travelsactiontosalary_put(run_id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TravelApi->travelsactiontosalary_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **run_id** | [**Object**](.md)|  | 
 **body** | [**object**](object.md)|  | [optional] 

### Return type

[**list[SalaryTransaction]**](SalaryTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **travelsactiontraveltext_post**
> list[Travel] travelsactiontraveltext_post(apikey_id)



traveltext Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TravelApi()
apikey_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.travelsactiontraveltext_post(apikey_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TravelApi->travelsactiontraveltext_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apikey_id** | [**Object**](.md)|  | 

### Return type

[**list[Travel]**](Travel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **travelsactionttpdf_put**
> File travelsactionttpdf_put(id, apikey_id)



ttpdf Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TravelApi()
id = swagger_client.Object() # Object | 
apikey_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.travelsactionttpdf_put(id, apikey_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TravelApi->travelsactionttpdf_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 
 **apikey_id** | [**Object**](.md)|  | 

### Return type

[**File**](File.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

