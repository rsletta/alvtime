# swagger_client.WageTypeApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**wagetypes_get**](WageTypeApi.md#wagetypes_get) | **GET** /wagetypes | 
[**wagetypes_id_delete**](WageTypeApi.md#wagetypes_id_delete) | **DELETE** /wagetypes/{id} | 
[**wagetypes_id_get**](WageTypeApi.md#wagetypes_id_get) | **GET** /wagetypes/{id} | 
[**wagetypes_id_put**](WageTypeApi.md#wagetypes_id_put) | **PUT** /wagetypes/{id} | 
[**wagetypes_idactionsync_supplements_put**](WageTypeApi.md#wagetypes_idactionsync_supplements_put) | **PUT** /wagetypes/{id}?action&#x3D;sync-supplements | 
[**wagetypes_idactionused_in_payrollrun_get**](WageTypeApi.md#wagetypes_idactionused_in_payrollrun_get) | **GET** /wagetypes/{id}?action&#x3D;used-in-payrollrun | 
[**wagetypes_post**](WageTypeApi.md#wagetypes_post) | **POST** /wagetypes | 
[**wagetypesactioncreate_and_update_standard_wagetypes_put**](WageTypeApi.md#wagetypesactioncreate_and_update_standard_wagetypes_put) | **PUT** /wagetypes?action&#x3D;create-and-update-standard-wagetypes | 
[**wagetypesactioncreate_wagetypes_for_year_put**](WageTypeApi.md#wagetypesactioncreate_wagetypes_for_year_put) | **PUT** /wagetypes?action&#x3D;create-wagetypes-for-year | 
[**wagetypesactionget_rate_get**](WageTypeApi.md#wagetypesactionget_rate_get) | **GET** /wagetypes?action&#x3D;get-rate | 
[**wagetypesactionsynchronize_put**](WageTypeApi.md#wagetypesactionsynchronize_put) | **PUT** /wagetypes?action&#x3D;synchronize | 
[**wagetypesactionvalidamelding_get**](WageTypeApi.md#wagetypesactionvalidamelding_get) | **GET** /wagetypes?action&#x3D;validamelding | 

# **wagetypes_get**
> list[WageType] wagetypes_get()



Query WageType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WageTypeApi()

try:
    api_response = api_instance.wagetypes_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WageTypeApi->wagetypes_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[WageType]**](WageType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wagetypes_id_delete**
> WageType wagetypes_id_delete(id)



Delete WageType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WageTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.wagetypes_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WageTypeApi->wagetypes_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**WageType**](WageType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wagetypes_id_get**
> WageType wagetypes_id_get(id)



Get WageType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WageTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.wagetypes_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WageTypeApi->wagetypes_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**WageType**](WageType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wagetypes_id_put**
> WageType wagetypes_id_put(body, id)



Update WageType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WageTypeApi()
body = swagger_client.WageType() # WageType | 
id = 56 # int | 

try:
    api_response = api_instance.wagetypes_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WageTypeApi->wagetypes_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WageType**](WageType.md)|  | 
 **id** | **int**|  | 

### Return type

[**WageType**](WageType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wagetypes_idactionsync_supplements_put**
> object wagetypes_idactionsync_supplements_put(id, id)



sync-supplements Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WageTypeApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.wagetypes_idactionsync_supplements_put(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WageTypeApi->wagetypes_idactionsync_supplements_put: %s\n" % e)
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

# **wagetypes_idactionused_in_payrollrun_get**
> bool wagetypes_idactionused_in_payrollrun_get(id)



used-in-payrollrun Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WageTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.wagetypes_idactionused_in_payrollrun_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WageTypeApi->wagetypes_idactionused_in_payrollrun_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wagetypes_post**
> WageType wagetypes_post(body)



Create WageType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WageTypeApi()
body = swagger_client.WageType() # WageType | 

try:
    api_response = api_instance.wagetypes_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WageTypeApi->wagetypes_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WageType**](WageType.md)|  | 

### Return type

[**WageType**](WageType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wagetypesactioncreate_and_update_standard_wagetypes_put**
> object wagetypesactioncreate_and_update_standard_wagetypes_put()



create-and-update-standard-wagetypes Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WageTypeApi()

try:
    api_response = api_instance.wagetypesactioncreate_and_update_standard_wagetypes_put()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WageTypeApi->wagetypesactioncreate_and_update_standard_wagetypes_put: %s\n" % e)
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

# **wagetypesactioncreate_wagetypes_for_year_put**
> object wagetypesactioncreate_wagetypes_for_year_put()



create-wagetypes-for-year Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WageTypeApi()

try:
    api_response = api_instance.wagetypesactioncreate_wagetypes_for_year_put()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WageTypeApi->wagetypesactioncreate_wagetypes_for_year_put: %s\n" % e)
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

# **wagetypesactionget_rate_get**
> object wagetypesactionget_rate_get(wagetype_id, employment_id, employee_id)



get-rate Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WageTypeApi()
wagetype_id = swagger_client.Object() # Object | 
employment_id = swagger_client.Object() # Object | 
employee_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.wagetypesactionget_rate_get(wagetype_id, employment_id, employee_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WageTypeApi->wagetypesactionget_rate_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **wagetype_id** | [**Object**](.md)|  | 
 **employment_id** | [**Object**](.md)|  | 
 **employee_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wagetypesactionsynchronize_put**
> object wagetypesactionsynchronize_put()



synchronize Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WageTypeApi()

try:
    api_response = api_instance.wagetypesactionsynchronize_put()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WageTypeApi->wagetypesactionsynchronize_put: %s\n" % e)
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

# **wagetypesactionvalidamelding_get**
> object wagetypesactionvalidamelding_get(type, fordel, beskrivelse)



validamelding Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WageTypeApi()
type = swagger_client.Object() # Object | 
fordel = swagger_client.Object() # Object | 
beskrivelse = swagger_client.Object() # Object | 

try:
    api_response = api_instance.wagetypesactionvalidamelding_get(type, fordel, beskrivelse)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WageTypeApi->wagetypesactionvalidamelding_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | [**Object**](.md)|  | 
 **fordel** | [**Object**](.md)|  | 
 **beskrivelse** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

