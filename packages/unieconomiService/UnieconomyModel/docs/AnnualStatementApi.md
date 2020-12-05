# swagger_client.AnnualStatementApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**annual_statementactionemail_put**](AnnualStatementApi.md#annual_statementactionemail_put) | **PUT** /annual-statement?action&#x3D;email | 
[**annual_statementactiongenerate_zip_put**](AnnualStatementApi.md#annual_statementactiongenerate_zip_put) | **PUT** /annual-statement?action&#x3D;generate-zip | 
[**annual_statementactioninselection_get**](AnnualStatementApi.md#annual_statementactioninselection_get) | **GET** /annual-statement?action&#x3D;inselection | 

# **annual_statementactionemail_put**
> bool annual_statementactionemail_put(year, body=body)



email Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AnnualStatementApi()
year = swagger_client.Object() # Object | 
body = swagger_client.AnnualStatementReportSetup() # AnnualStatementReportSetup |  (optional)

try:
    api_response = api_instance.annual_statementactionemail_put(year, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AnnualStatementApi->annual_statementactionemail_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | [**Object**](.md)|  | 
 **body** | [**AnnualStatementReportSetup**](AnnualStatementReportSetup.md)|  | [optional] 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **annual_statementactiongenerate_zip_put**
> object annual_statementactiongenerate_zip_put(year)



generate-zip Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AnnualStatementApi()
year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.annual_statementactiongenerate_zip_put(year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AnnualStatementApi->annual_statementactiongenerate_zip_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **annual_statementactioninselection_get**
> object annual_statementactioninselection_get(employees, year)



inselection Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AnnualStatementApi()
employees = swagger_client.Object() # Object | 
year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.annual_statementactioninselection_get(employees, year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AnnualStatementApi->annual_statementactioninselection_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **employees** | [**Object**](.md)|  | 
 **year** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

