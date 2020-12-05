# swagger_client.ReportDefinitionDataSourceApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**report_definition_data_sources_get**](ReportDefinitionDataSourceApi.md#report_definition_data_sources_get) | **GET** /report-definition-data-sources | 
[**report_definition_data_sources_id_delete**](ReportDefinitionDataSourceApi.md#report_definition_data_sources_id_delete) | **DELETE** /report-definition-data-sources/{id} | 
[**report_definition_data_sources_id_get**](ReportDefinitionDataSourceApi.md#report_definition_data_sources_id_get) | **GET** /report-definition-data-sources/{id} | 
[**report_definition_data_sources_id_put**](ReportDefinitionDataSourceApi.md#report_definition_data_sources_id_put) | **PUT** /report-definition-data-sources/{id} | 
[**report_definition_data_sources_post**](ReportDefinitionDataSourceApi.md#report_definition_data_sources_post) | **POST** /report-definition-data-sources | 

# **report_definition_data_sources_get**
> list[ReportDefinitionDataSource] report_definition_data_sources_get()



Query ReportDefinitionDataSource

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReportDefinitionDataSourceApi()

try:
    api_response = api_instance.report_definition_data_sources_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReportDefinitionDataSourceApi->report_definition_data_sources_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ReportDefinitionDataSource]**](ReportDefinitionDataSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **report_definition_data_sources_id_delete**
> ReportDefinitionDataSource report_definition_data_sources_id_delete(id)



Delete ReportDefinitionDataSource

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReportDefinitionDataSourceApi()
id = 56 # int | 

try:
    api_response = api_instance.report_definition_data_sources_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReportDefinitionDataSourceApi->report_definition_data_sources_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ReportDefinitionDataSource**](ReportDefinitionDataSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **report_definition_data_sources_id_get**
> ReportDefinitionDataSource report_definition_data_sources_id_get(id)



Get ReportDefinitionDataSource

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReportDefinitionDataSourceApi()
id = 56 # int | 

try:
    api_response = api_instance.report_definition_data_sources_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReportDefinitionDataSourceApi->report_definition_data_sources_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ReportDefinitionDataSource**](ReportDefinitionDataSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **report_definition_data_sources_id_put**
> ReportDefinitionDataSource report_definition_data_sources_id_put(body, id)



Update ReportDefinitionDataSource

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReportDefinitionDataSourceApi()
body = swagger_client.ReportDefinitionDataSource() # ReportDefinitionDataSource | 
id = 56 # int | 

try:
    api_response = api_instance.report_definition_data_sources_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReportDefinitionDataSourceApi->report_definition_data_sources_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportDefinitionDataSource**](ReportDefinitionDataSource.md)|  | 
 **id** | **int**|  | 

### Return type

[**ReportDefinitionDataSource**](ReportDefinitionDataSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **report_definition_data_sources_post**
> ReportDefinitionDataSource report_definition_data_sources_post(body)



Create ReportDefinitionDataSource

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReportDefinitionDataSourceApi()
body = swagger_client.ReportDefinitionDataSource() # ReportDefinitionDataSource | 

try:
    api_response = api_instance.report_definition_data_sources_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReportDefinitionDataSourceApi->report_definition_data_sources_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportDefinitionDataSource**](ReportDefinitionDataSource.md)|  | 

### Return type

[**ReportDefinitionDataSource**](ReportDefinitionDataSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

