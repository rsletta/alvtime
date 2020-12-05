# swagger_client.PeriodTemplateApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**period_templates_get**](PeriodTemplateApi.md#period_templates_get) | **GET** /period-templates | 
[**period_templates_id_delete**](PeriodTemplateApi.md#period_templates_id_delete) | **DELETE** /period-templates/{id} | 
[**period_templates_id_get**](PeriodTemplateApi.md#period_templates_id_get) | **GET** /period-templates/{id} | 
[**period_templates_id_put**](PeriodTemplateApi.md#period_templates_id_put) | **PUT** /period-templates/{id} | 
[**period_templates_post**](PeriodTemplateApi.md#period_templates_post) | **POST** /period-templates | 

# **period_templates_get**
> list[PeriodTemplate] period_templates_get()



Query PeriodTemplate

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PeriodTemplateApi()

try:
    api_response = api_instance.period_templates_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PeriodTemplateApi->period_templates_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[PeriodTemplate]**](PeriodTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **period_templates_id_delete**
> PeriodTemplate period_templates_id_delete(id)



Delete PeriodTemplate

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PeriodTemplateApi()
id = 56 # int | 

try:
    api_response = api_instance.period_templates_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PeriodTemplateApi->period_templates_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PeriodTemplate**](PeriodTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **period_templates_id_get**
> PeriodTemplate period_templates_id_get(id)



Get PeriodTemplate

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PeriodTemplateApi()
id = 56 # int | 

try:
    api_response = api_instance.period_templates_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PeriodTemplateApi->period_templates_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PeriodTemplate**](PeriodTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **period_templates_id_put**
> PeriodTemplate period_templates_id_put(body, id)



Update PeriodTemplate

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PeriodTemplateApi()
body = swagger_client.PeriodTemplate() # PeriodTemplate | 
id = 56 # int | 

try:
    api_response = api_instance.period_templates_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PeriodTemplateApi->period_templates_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PeriodTemplate**](PeriodTemplate.md)|  | 
 **id** | **int**|  | 

### Return type

[**PeriodTemplate**](PeriodTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **period_templates_post**
> PeriodTemplate period_templates_post(body)



Create PeriodTemplate

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PeriodTemplateApi()
body = swagger_client.PeriodTemplate() # PeriodTemplate | 

try:
    api_response = api_instance.period_templates_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PeriodTemplateApi->period_templates_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PeriodTemplate**](PeriodTemplate.md)|  | 

### Return type

[**PeriodTemplate**](PeriodTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

