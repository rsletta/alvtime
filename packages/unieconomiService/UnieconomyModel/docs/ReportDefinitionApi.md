# swagger_client.ReportDefinitionApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**report_definitions_get**](ReportDefinitionApi.md#report_definitions_get) | **GET** /report-definitions | 
[**report_definitions_id_delete**](ReportDefinitionApi.md#report_definitions_id_delete) | **DELETE** /report-definitions/{id} | 
[**report_definitions_id_get**](ReportDefinitionApi.md#report_definitions_id_get) | **GET** /report-definitions/{id} | 
[**report_definitions_id_put**](ReportDefinitionApi.md#report_definitions_id_put) | **PUT** /report-definitions/{id} | 
[**report_definitions_idactionclear_report_cache_delete**](ReportDefinitionApi.md#report_definitions_idactionclear_report_cache_delete) | **DELETE** /report-definitions/{id}?action&#x3D;clear-report-cache | 
[**report_definitions_post**](ReportDefinitionApi.md#report_definitions_post) | **POST** /report-definitions | 
[**report_definitionsactionget_all_reports_get**](ReportDefinitionApi.md#report_definitionsactionget_all_reports_get) | **GET** /report-definitions?action&#x3D;get-all-reports | 
[**report_definitionsactionget_custom_reports_get**](ReportDefinitionApi.md#report_definitionsactionget_custom_reports_get) | **GET** /report-definitions?action&#x3D;get-custom-reports | 
[**report_definitionsactionload_reports_get**](ReportDefinitionApi.md#report_definitionsactionload_reports_get) | **GET** /report-definitions?action&#x3D;load-reports | 

# **report_definitions_get**
> list[ReportDefinition] report_definitions_get()



Query ReportDefinition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReportDefinitionApi()

try:
    api_response = api_instance.report_definitions_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReportDefinitionApi->report_definitions_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ReportDefinition]**](ReportDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **report_definitions_id_delete**
> ReportDefinition report_definitions_id_delete(id)



Delete ReportDefinition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReportDefinitionApi()
id = 56 # int | 

try:
    api_response = api_instance.report_definitions_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReportDefinitionApi->report_definitions_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ReportDefinition**](ReportDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **report_definitions_id_get**
> ReportDefinition report_definitions_id_get(id)



Get ReportDefinition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReportDefinitionApi()
id = 56 # int | 

try:
    api_response = api_instance.report_definitions_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReportDefinitionApi->report_definitions_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ReportDefinition**](ReportDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **report_definitions_id_put**
> ReportDefinition report_definitions_id_put(body, id)



Update ReportDefinition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReportDefinitionApi()
body = swagger_client.ReportDefinition() # ReportDefinition | 
id = 56 # int | 

try:
    api_response = api_instance.report_definitions_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReportDefinitionApi->report_definitions_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportDefinition**](ReportDefinition.md)|  | 
 **id** | **int**|  | 

### Return type

[**ReportDefinition**](ReportDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **report_definitions_idactionclear_report_cache_delete**
> object report_definitions_idactionclear_report_cache_delete(id, id)



clear-report-cache Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReportDefinitionApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.report_definitions_idactionclear_report_cache_delete(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReportDefinitionApi->report_definitions_idactionclear_report_cache_delete: %s\n" % e)
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

# **report_definitions_post**
> ReportDefinition report_definitions_post(body)



Create ReportDefinition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReportDefinitionApi()
body = swagger_client.ReportDefinition() # ReportDefinition | 

try:
    api_response = api_instance.report_definitions_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReportDefinitionApi->report_definitions_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportDefinition**](ReportDefinition.md)|  | 

### Return type

[**ReportDefinition**](ReportDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **report_definitionsactionget_all_reports_get**
> object report_definitionsactionget_all_reports_get()



get-all-reports Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReportDefinitionApi()

try:
    api_response = api_instance.report_definitionsactionget_all_reports_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReportDefinitionApi->report_definitionsactionget_all_reports_get: %s\n" % e)
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

# **report_definitionsactionget_custom_reports_get**
> object report_definitionsactionget_custom_reports_get()



get-custom-reports Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReportDefinitionApi()

try:
    api_response = api_instance.report_definitionsactionget_custom_reports_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReportDefinitionApi->report_definitionsactionget_custom_reports_get: %s\n" % e)
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

# **report_definitionsactionload_reports_get**
> bool report_definitionsactionload_reports_get()



load-reports Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReportDefinitionApi()

try:
    api_response = api_instance.report_definitionsactionload_reports_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReportDefinitionApi->report_definitionsactionload_reports_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

