# swagger_client.VatDeductionGroupApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**vatdeductiongroups_get**](VatDeductionGroupApi.md#vatdeductiongroups_get) | **GET** /vatdeductiongroups | 
[**vatdeductiongroups_id_delete**](VatDeductionGroupApi.md#vatdeductiongroups_id_delete) | **DELETE** /vatdeductiongroups/{id} | 
[**vatdeductiongroups_id_get**](VatDeductionGroupApi.md#vatdeductiongroups_id_get) | **GET** /vatdeductiongroups/{id} | 
[**vatdeductiongroups_id_put**](VatDeductionGroupApi.md#vatdeductiongroups_id_put) | **PUT** /vatdeductiongroups/{id} | 
[**vatdeductiongroups_post**](VatDeductionGroupApi.md#vatdeductiongroups_post) | **POST** /vatdeductiongroups | 

# **vatdeductiongroups_get**
> list[VatDeductionGroup] vatdeductiongroups_get()



Query VatDeductionGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatDeductionGroupApi()

try:
    api_response = api_instance.vatdeductiongroups_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatDeductionGroupApi->vatdeductiongroups_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[VatDeductionGroup]**](VatDeductionGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatdeductiongroups_id_delete**
> VatDeductionGroup vatdeductiongroups_id_delete(id)



Delete VatDeductionGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatDeductionGroupApi()
id = 56 # int | 

try:
    api_response = api_instance.vatdeductiongroups_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatDeductionGroupApi->vatdeductiongroups_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VatDeductionGroup**](VatDeductionGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatdeductiongroups_id_get**
> VatDeductionGroup vatdeductiongroups_id_get(id)



Get VatDeductionGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatDeductionGroupApi()
id = 56 # int | 

try:
    api_response = api_instance.vatdeductiongroups_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatDeductionGroupApi->vatdeductiongroups_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VatDeductionGroup**](VatDeductionGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatdeductiongroups_id_put**
> VatDeductionGroup vatdeductiongroups_id_put(body, id)



Update VatDeductionGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatDeductionGroupApi()
body = swagger_client.VatDeductionGroup() # VatDeductionGroup | 
id = 56 # int | 

try:
    api_response = api_instance.vatdeductiongroups_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatDeductionGroupApi->vatdeductiongroups_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VatDeductionGroup**](VatDeductionGroup.md)|  | 
 **id** | **int**|  | 

### Return type

[**VatDeductionGroup**](VatDeductionGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatdeductiongroups_post**
> VatDeductionGroup vatdeductiongroups_post(body)



Create VatDeductionGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatDeductionGroupApi()
body = swagger_client.VatDeductionGroup() # VatDeductionGroup | 

try:
    api_response = api_instance.vatdeductiongroups_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatDeductionGroupApi->vatdeductiongroups_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VatDeductionGroup**](VatDeductionGroup.md)|  | 

### Return type

[**VatDeductionGroup**](VatDeductionGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

