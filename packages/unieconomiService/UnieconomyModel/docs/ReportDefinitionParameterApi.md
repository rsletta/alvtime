# swagger_client.ReportDefinitionParameterApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**report_definition_parameters_get**](ReportDefinitionParameterApi.md#report_definition_parameters_get) | **GET** /report-definition-parameters | 
[**report_definition_parameters_id_delete**](ReportDefinitionParameterApi.md#report_definition_parameters_id_delete) | **DELETE** /report-definition-parameters/{id} | 
[**report_definition_parameters_id_get**](ReportDefinitionParameterApi.md#report_definition_parameters_id_get) | **GET** /report-definition-parameters/{id} | 
[**report_definition_parameters_id_put**](ReportDefinitionParameterApi.md#report_definition_parameters_id_put) | **PUT** /report-definition-parameters/{id} | 
[**report_definition_parameters_post**](ReportDefinitionParameterApi.md#report_definition_parameters_post) | **POST** /report-definition-parameters | 

# **report_definition_parameters_get**
> list[ReportDefinitionParameter] report_definition_parameters_get()



Query ReportDefinitionParameter

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReportDefinitionParameterApi()

try:
    api_response = api_instance.report_definition_parameters_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReportDefinitionParameterApi->report_definition_parameters_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ReportDefinitionParameter]**](ReportDefinitionParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **report_definition_parameters_id_delete**
> ReportDefinitionParameter report_definition_parameters_id_delete(id)



Delete ReportDefinitionParameter

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReportDefinitionParameterApi()
id = 56 # int | 

try:
    api_response = api_instance.report_definition_parameters_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReportDefinitionParameterApi->report_definition_parameters_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ReportDefinitionParameter**](ReportDefinitionParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **report_definition_parameters_id_get**
> ReportDefinitionParameter report_definition_parameters_id_get(id)



Get ReportDefinitionParameter

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReportDefinitionParameterApi()
id = 56 # int | 

try:
    api_response = api_instance.report_definition_parameters_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReportDefinitionParameterApi->report_definition_parameters_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ReportDefinitionParameter**](ReportDefinitionParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **report_definition_parameters_id_put**
> ReportDefinitionParameter report_definition_parameters_id_put(body, id)



Update ReportDefinitionParameter

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReportDefinitionParameterApi()
body = swagger_client.ReportDefinitionParameter() # ReportDefinitionParameter | 
id = 56 # int | 

try:
    api_response = api_instance.report_definition_parameters_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReportDefinitionParameterApi->report_definition_parameters_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportDefinitionParameter**](ReportDefinitionParameter.md)|  | 
 **id** | **int**|  | 

### Return type

[**ReportDefinitionParameter**](ReportDefinitionParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **report_definition_parameters_post**
> ReportDefinitionParameter report_definition_parameters_post(body)



Create ReportDefinitionParameter

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReportDefinitionParameterApi()
body = swagger_client.ReportDefinitionParameter() # ReportDefinitionParameter | 

try:
    api_response = api_instance.report_definition_parameters_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReportDefinitionParameterApi->report_definition_parameters_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportDefinitionParameter**](ReportDefinitionParameter.md)|  | 

### Return type

[**ReportDefinitionParameter**](ReportDefinitionParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

