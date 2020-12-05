# swagger_client.AccountMandatoryDimensionApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**accountmandatorydimension_get**](AccountMandatoryDimensionApi.md#accountmandatorydimension_get) | **GET** /accountmandatorydimension | 
[**accountmandatorydimension_id_delete**](AccountMandatoryDimensionApi.md#accountmandatorydimension_id_delete) | **DELETE** /accountmandatorydimension/{id} | 
[**accountmandatorydimension_id_get**](AccountMandatoryDimensionApi.md#accountmandatorydimension_id_get) | **GET** /accountmandatorydimension/{id} | 
[**accountmandatorydimension_id_put**](AccountMandatoryDimensionApi.md#accountmandatorydimension_id_put) | **PUT** /accountmandatorydimension/{id} | 
[**accountmandatorydimension_post**](AccountMandatoryDimensionApi.md#accountmandatorydimension_post) | **POST** /accountmandatorydimension | 
[**accountmandatorydimensionactionadd_accounts_mandatory_dimensions_put**](AccountMandatoryDimensionApi.md#accountmandatorydimensionactionadd_accounts_mandatory_dimensions_put) | **PUT** /accountmandatorydimension?action&#x3D;add-accounts-mandatory-dimensions | 
[**accountmandatorydimensionactioncheck_recurringinvoices_get**](AccountMandatoryDimensionApi.md#accountmandatorydimensionactioncheck_recurringinvoices_get) | **GET** /accountmandatorydimension?action&#x3D;check-recurringinvoices | 
[**accountmandatorydimensionactionget_customer_mandatory_dimensions_report_dimensions_id_get**](AccountMandatoryDimensionApi.md#accountmandatorydimensionactionget_customer_mandatory_dimensions_report_dimensions_id_get) | **GET** /accountmandatorydimension?action&#x3D;get-customer-mandatory-dimensions-report-dimensionsID | 
[**accountmandatorydimensionactionget_customer_mandatory_dimensions_report_dimensions_put**](AccountMandatoryDimensionApi.md#accountmandatorydimensionactionget_customer_mandatory_dimensions_report_dimensions_put) | **PUT** /accountmandatorydimension?action&#x3D;get-customer-mandatory-dimensions-report-dimensions | 
[**accountmandatorydimensionactionget_mandatory_dimensions_report_by_dimensions_put**](AccountMandatoryDimensionApi.md#accountmandatorydimensionactionget_mandatory_dimensions_report_by_dimensions_put) | **PUT** /accountmandatorydimension?action&#x3D;get-mandatory-dimensions-report-by-dimensions | 
[**accountmandatorydimensionactionget_mandatory_dimensions_report_get**](AccountMandatoryDimensionApi.md#accountmandatorydimensionactionget_mandatory_dimensions_report_get) | **GET** /accountmandatorydimension?action&#x3D;get-mandatory-dimensions-report | 
[**accountmandatorydimensionactionget_mandatory_dimensions_reports_put**](AccountMandatoryDimensionApi.md#accountmandatorydimensionactionget_mandatory_dimensions_reports_put) | **PUT** /accountmandatorydimension?action&#x3D;get-mandatory-dimensions-reports | 
[**accountmandatorydimensionactionget_supplier_mandatory_dimensions_report_dimensions_id_get**](AccountMandatoryDimensionApi.md#accountmandatorydimensionactionget_supplier_mandatory_dimensions_report_dimensions_id_get) | **GET** /accountmandatorydimension?action&#x3D;get-supplier-mandatory-dimensions-report-dimensionsID | 
[**accountmandatorydimensionactionget_supplier_mandatory_dimensions_report_dimensions_put**](AccountMandatoryDimensionApi.md#accountmandatorydimensionactionget_supplier_mandatory_dimensions_report_dimensions_put) | **PUT** /accountmandatorydimension?action&#x3D;get-supplier-mandatory-dimensions-report-dimensions | 

# **accountmandatorydimension_get**
> list[AccountMandatoryDimension] accountmandatorydimension_get()



Query AccountMandatoryDimension

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountMandatoryDimensionApi()

try:
    api_response = api_instance.accountmandatorydimension_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountMandatoryDimensionApi->accountmandatorydimension_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[AccountMandatoryDimension]**](AccountMandatoryDimension.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountmandatorydimension_id_delete**
> AccountMandatoryDimension accountmandatorydimension_id_delete(id)



Delete AccountMandatoryDimension

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountMandatoryDimensionApi()
id = 56 # int | 

try:
    api_response = api_instance.accountmandatorydimension_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountMandatoryDimensionApi->accountmandatorydimension_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**AccountMandatoryDimension**](AccountMandatoryDimension.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountmandatorydimension_id_get**
> AccountMandatoryDimension accountmandatorydimension_id_get(id)



Get AccountMandatoryDimension

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountMandatoryDimensionApi()
id = 56 # int | 

try:
    api_response = api_instance.accountmandatorydimension_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountMandatoryDimensionApi->accountmandatorydimension_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**AccountMandatoryDimension**](AccountMandatoryDimension.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountmandatorydimension_id_put**
> AccountMandatoryDimension accountmandatorydimension_id_put(body, id)



Update AccountMandatoryDimension

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountMandatoryDimensionApi()
body = swagger_client.AccountMandatoryDimension() # AccountMandatoryDimension | 
id = 56 # int | 

try:
    api_response = api_instance.accountmandatorydimension_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountMandatoryDimensionApi->accountmandatorydimension_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AccountMandatoryDimension**](AccountMandatoryDimension.md)|  | 
 **id** | **int**|  | 

### Return type

[**AccountMandatoryDimension**](AccountMandatoryDimension.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountmandatorydimension_post**
> AccountMandatoryDimension accountmandatorydimension_post(body)



Create AccountMandatoryDimension

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountMandatoryDimensionApi()
body = swagger_client.AccountMandatoryDimension() # AccountMandatoryDimension | 

try:
    api_response = api_instance.accountmandatorydimension_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountMandatoryDimensionApi->accountmandatorydimension_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AccountMandatoryDimension**](AccountMandatoryDimension.md)|  | 

### Return type

[**AccountMandatoryDimension**](AccountMandatoryDimension.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountmandatorydimensionactionadd_accounts_mandatory_dimensions_put**
> str accountmandatorydimensionactionadd_accounts_mandatory_dimensions_put(from_account_no, to_account_no, dimension_no, mandatory_type)



add-accounts-mandatory-dimensions Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountMandatoryDimensionApi()
from_account_no = swagger_client.Object() # Object | 
to_account_no = swagger_client.Object() # Object | 
dimension_no = swagger_client.Object() # Object | 
mandatory_type = swagger_client.Object() # Object | 

try:
    api_response = api_instance.accountmandatorydimensionactionadd_accounts_mandatory_dimensions_put(from_account_no, to_account_no, dimension_no, mandatory_type)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountMandatoryDimensionApi->accountmandatorydimensionactionadd_accounts_mandatory_dimensions_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from_account_no** | [**Object**](.md)|  | 
 **to_account_no** | [**Object**](.md)|  | 
 **dimension_no** | [**Object**](.md)|  | 
 **mandatory_type** | [**Object**](.md)|  | 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountmandatorydimensionactioncheck_recurringinvoices_get**
> str accountmandatorydimensionactioncheck_recurringinvoices_get(account_id)



check-recurringinvoices Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountMandatoryDimensionApi()
account_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.accountmandatorydimensionactioncheck_recurringinvoices_get(account_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountMandatoryDimensionApi->accountmandatorydimensionactioncheck_recurringinvoices_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account_id** | [**Object**](.md)|  | 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountmandatorydimensionactionget_customer_mandatory_dimensions_report_dimensions_id_get**
> MandatoryDimensionAccountReport accountmandatorydimensionactionget_customer_mandatory_dimensions_report_dimensions_id_get(customer_id, dimensions_id)



get-customer-mandatory-dimensions-report-dimensionsID Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountMandatoryDimensionApi()
customer_id = swagger_client.Object() # Object | 
dimensions_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.accountmandatorydimensionactionget_customer_mandatory_dimensions_report_dimensions_id_get(customer_id, dimensions_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountMandatoryDimensionApi->accountmandatorydimensionactionget_customer_mandatory_dimensions_report_dimensions_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customer_id** | [**Object**](.md)|  | 
 **dimensions_id** | [**Object**](.md)|  | 

### Return type

[**MandatoryDimensionAccountReport**](MandatoryDimensionAccountReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountmandatorydimensionactionget_customer_mandatory_dimensions_report_dimensions_put**
> MandatoryDimensionAccountReport accountmandatorydimensionactionget_customer_mandatory_dimensions_report_dimensions_put(customer_id, body=body)



get-customer-mandatory-dimensions-report-dimensions Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountMandatoryDimensionApi()
customer_id = swagger_client.Object() # Object | 
body = swagger_client.Dimensions() # Dimensions |  (optional)

try:
    api_response = api_instance.accountmandatorydimensionactionget_customer_mandatory_dimensions_report_dimensions_put(customer_id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountMandatoryDimensionApi->accountmandatorydimensionactionget_customer_mandatory_dimensions_report_dimensions_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customer_id** | [**Object**](.md)|  | 
 **body** | [**Dimensions**](Dimensions.md)|  | [optional] 

### Return type

[**MandatoryDimensionAccountReport**](MandatoryDimensionAccountReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountmandatorydimensionactionget_mandatory_dimensions_report_by_dimensions_put**
> MandatoryDimensionAccountReport accountmandatorydimensionactionget_mandatory_dimensions_report_by_dimensions_put(account_id, body=body)



get-mandatory-dimensions-report-by-dimensions Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountMandatoryDimensionApi()
account_id = swagger_client.Object() # Object | 
body = swagger_client.Dimensions() # Dimensions |  (optional)

try:
    api_response = api_instance.accountmandatorydimensionactionget_mandatory_dimensions_report_by_dimensions_put(account_id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountMandatoryDimensionApi->accountmandatorydimensionactionget_mandatory_dimensions_report_by_dimensions_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account_id** | [**Object**](.md)|  | 
 **body** | [**Dimensions**](Dimensions.md)|  | [optional] 

### Return type

[**MandatoryDimensionAccountReport**](MandatoryDimensionAccountReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountmandatorydimensionactionget_mandatory_dimensions_report_get**
> MandatoryDimensionAccountReport accountmandatorydimensionactionget_mandatory_dimensions_report_get(account_id, dimensions_id)



get-mandatory-dimensions-report Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountMandatoryDimensionApi()
account_id = swagger_client.Object() # Object | 
dimensions_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.accountmandatorydimensionactionget_mandatory_dimensions_report_get(account_id, dimensions_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountMandatoryDimensionApi->accountmandatorydimensionactionget_mandatory_dimensions_report_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account_id** | [**Object**](.md)|  | 
 **dimensions_id** | [**Object**](.md)|  | 

### Return type

[**MandatoryDimensionAccountReport**](MandatoryDimensionAccountReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountmandatorydimensionactionget_mandatory_dimensions_reports_put**
> list[MandatoryDimensionAccountReport] accountmandatorydimensionactionget_mandatory_dimensions_reports_put(body=body)



get-mandatory-dimensions-reports Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountMandatoryDimensionApi()
body = [swagger_client.AccountDimension()] # list[AccountDimension] |  (optional)

try:
    api_response = api_instance.accountmandatorydimensionactionget_mandatory_dimensions_reports_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountMandatoryDimensionApi->accountmandatorydimensionactionget_mandatory_dimensions_reports_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**list[AccountDimension]**](AccountDimension.md)|  | [optional] 

### Return type

[**list[MandatoryDimensionAccountReport]**](MandatoryDimensionAccountReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountmandatorydimensionactionget_supplier_mandatory_dimensions_report_dimensions_id_get**
> MandatoryDimensionAccountReport accountmandatorydimensionactionget_supplier_mandatory_dimensions_report_dimensions_id_get(supplier_id, dimensions_id)



get-supplier-mandatory-dimensions-report-dimensionsID Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountMandatoryDimensionApi()
supplier_id = swagger_client.Object() # Object | 
dimensions_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.accountmandatorydimensionactionget_supplier_mandatory_dimensions_report_dimensions_id_get(supplier_id, dimensions_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountMandatoryDimensionApi->accountmandatorydimensionactionget_supplier_mandatory_dimensions_report_dimensions_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **supplier_id** | [**Object**](.md)|  | 
 **dimensions_id** | [**Object**](.md)|  | 

### Return type

[**MandatoryDimensionAccountReport**](MandatoryDimensionAccountReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountmandatorydimensionactionget_supplier_mandatory_dimensions_report_dimensions_put**
> MandatoryDimensionAccountReport accountmandatorydimensionactionget_supplier_mandatory_dimensions_report_dimensions_put(supplier_id, body=body)



get-supplier-mandatory-dimensions-report-dimensions Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountMandatoryDimensionApi()
supplier_id = swagger_client.Object() # Object | 
body = swagger_client.Dimensions() # Dimensions |  (optional)

try:
    api_response = api_instance.accountmandatorydimensionactionget_supplier_mandatory_dimensions_report_dimensions_put(supplier_id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountMandatoryDimensionApi->accountmandatorydimensionactionget_supplier_mandatory_dimensions_report_dimensions_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **supplier_id** | [**Object**](.md)|  | 
 **body** | [**Dimensions**](Dimensions.md)|  | [optional] 

### Return type

[**MandatoryDimensionAccountReport**](MandatoryDimensionAccountReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

