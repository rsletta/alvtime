# swagger_client.CompanyReportApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**company_report_get**](CompanyReportApi.md#company_report_get) | **GET** /company-report | 
[**company_report_id_delete**](CompanyReportApi.md#company_report_id_delete) | **DELETE** /company-report/{id} | 
[**company_report_id_get**](CompanyReportApi.md#company_report_id_get) | **GET** /company-report/{id} | 
[**company_report_id_put**](CompanyReportApi.md#company_report_id_put) | **PUT** /company-report/{id} | 
[**company_report_post**](CompanyReportApi.md#company_report_post) | **POST** /company-report | 

# **company_report_get**
> list[CompanyReport] company_report_get()



Query CompanyReport

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyReportApi()

try:
    api_response = api_instance.company_report_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyReportApi->company_report_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CompanyReport]**](CompanyReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **company_report_id_delete**
> CompanyReport company_report_id_delete(id)



Delete CompanyReport

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyReportApi()
id = 56 # int | 

try:
    api_response = api_instance.company_report_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyReportApi->company_report_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CompanyReport**](CompanyReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **company_report_id_get**
> CompanyReport company_report_id_get(id)



Get CompanyReport

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyReportApi()
id = 56 # int | 

try:
    api_response = api_instance.company_report_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyReportApi->company_report_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CompanyReport**](CompanyReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **company_report_id_put**
> CompanyReport company_report_id_put(body, id)



Update CompanyReport

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyReportApi()
body = swagger_client.CompanyReport() # CompanyReport | 
id = 56 # int | 

try:
    api_response = api_instance.company_report_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyReportApi->company_report_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompanyReport**](CompanyReport.md)|  | 
 **id** | **int**|  | 

### Return type

[**CompanyReport**](CompanyReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **company_report_post**
> CompanyReport company_report_post(body)



Create CompanyReport

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyReportApi()
body = swagger_client.CompanyReport() # CompanyReport | 

try:
    api_response = api_instance.company_report_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyReportApi->company_report_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompanyReport**](CompanyReport.md)|  | 

### Return type

[**CompanyReport**](CompanyReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

