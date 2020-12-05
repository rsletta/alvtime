# swagger_client.VatReportApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**vatreports_get**](VatReportApi.md#vatreports_get) | **GET** /vatreports | 
[**vatreports_id_delete**](VatReportApi.md#vatreports_id_delete) | **DELETE** /vatreports/{id} | 
[**vatreports_id_get**](VatReportApi.md#vatreports_id_get) | **GET** /vatreports/{id} | 
[**vatreports_id_put**](VatReportApi.md#vatreports_id_put) | **PUT** /vatreports/{id} | 
[**vatreports_idactionadjust_post**](VatReportApi.md#vatreports_idactionadjust_post) | **POST** /vatreports/{id}?action&#x3D;adjust | 
[**vatreports_idactionapprove_manually_post**](VatReportApi.md#vatreports_idactionapprove_manually_post) | **POST** /vatreports/{id}?action&#x3D;approveManually | 
[**vatreports_idactionapprove_post**](VatReportApi.md#vatreports_idactionapprove_post) | **POST** /vatreports/{id}?action&#x3D;approve | 
[**vatreports_idactioncontrol_vatreport_get**](VatReportApi.md#vatreports_idactioncontrol_vatreport_get) | **GET** /vatreports/{id}?action&#x3D;control-vatreport | 
[**vatreports_idactionexecute_post**](VatReportApi.md#vatreports_idactionexecute_post) | **POST** /vatreports/{id}?action&#x3D;execute | 
[**vatreports_idactionget_vat_report_summary_from_previous_periods_get**](VatReportApi.md#vatreports_idactionget_vat_report_summary_from_previous_periods_get) | **GET** /vatreports/{id}?action&#x3D;get-vat-report-summary-from-previous-periods | 
[**vatreports_idactionget_vat_report_summary_get**](VatReportApi.md#vatreports_idactionget_vat_report_summary_get) | **GET** /vatreports/{id}?action&#x3D;get-vat-report-summary | 
[**vatreports_idactionget_vat_report_summary_per_post_get**](VatReportApi.md#vatreports_idactionget_vat_report_summary_per_post_get) | **GET** /vatreports/{id}?action&#x3D;get-vat-report-summary-per-post | 
[**vatreports_idactionget_vat_report_summary_per_post_per_account_details_get**](VatReportApi.md#vatreports_idactionget_vat_report_summary_per_post_per_account_details_get) | **GET** /vatreports/{id}?action&#x3D;get-vat-report-summary-per-post-per-account-details | 
[**vatreports_idactionget_vat_report_summary_per_post_per_account_get**](VatReportApi.md#vatreports_idactionget_vat_report_summary_per_post_per_account_get) | **GET** /vatreports/{id}?action&#x3D;get-vat-report-summary-per-post-per-account | 
[**vatreports_idactionnext_get**](VatReportApi.md#vatreports_idactionnext_get) | **GET** /vatreports/{id}?action&#x3D;next | 
[**vatreports_idactionpay_vat_post**](VatReportApi.md#vatreports_idactionpay_vat_post) | **POST** /vatreports/{id}?action&#x3D;pay-vat | 
[**vatreports_idactionprevious_get**](VatReportApi.md#vatreports_idactionprevious_get) | **GET** /vatreports/{id}?action&#x3D;previous | 
[**vatreports_idactionreexecute_post**](VatReportApi.md#vatreports_idactionreexecute_post) | **POST** /vatreports/{id}?action&#x3D;reexecute | 
[**vatreports_idactionreject_post**](VatReportApi.md#vatreports_idactionreject_post) | **POST** /vatreports/{id}?action&#x3D;reject | 
[**vatreports_idactionset_to_approved_post**](VatReportApi.md#vatreports_idactionset_to_approved_post) | **POST** /vatreports/{id}?action&#x3D;setToApproved | 
[**vatreports_idactionsubmit_post**](VatReportApi.md#vatreports_idactionsubmit_post) | **POST** /vatreports/{id}?action&#x3D;submit | 
[**vatreports_idactionundo_execute_period_post**](VatReportApi.md#vatreports_idactionundo_execute_period_post) | **POST** /vatreports/{id}?action&#x3D;undo-execute-period | 
[**vatreports_idactionundo_execute_post**](VatReportApi.md#vatreports_idactionundo_execute_post) | **POST** /vatreports/{id}?action&#x3D;undo-execute | 
[**vatreports_post**](VatReportApi.md#vatreports_post) | **POST** /vatreports | 
[**vatreportsactioncreate_additional_vatreport_post**](VatReportApi.md#vatreportsactioncreate_additional_vatreport_post) | **POST** /vatreports?action&#x3D;create-additional-vatreport | 
[**vatreportsactioncreate_adjusted_vatreport_post**](VatReportApi.md#vatreportsactioncreate_adjusted_vatreport_post) | **POST** /vatreports?action&#x3D;create-adjusted-vatreport | 
[**vatreportsactioncurrent_get**](VatReportApi.md#vatreportsactioncurrent_get) | **GET** /vatreports?action&#x3D;current | 
[**vatreportsactionget_not_reported_journalentry_data_get**](VatReportApi.md#vatreportsactionget_not_reported_journalentry_data_get) | **GET** /vatreports?action&#x3D;get-not-reported-journalentry-data | 
[**vatreportsactionget_signing_text_altinn_post**](VatReportApi.md#vatreportsactionget_signing_text_altinn_post) | **POST** /vatreports?action&#x3D;get-signing-text-altinn | 
[**vatreportsactionread_and_update_altinn_vatreport_data_post**](VatReportApi.md#vatreportsactionread_and_update_altinn_vatreport_data_post) | **POST** /vatreports?action&#x3D;read-and-update-altinn-vatreport-data | 
[**vatreportsactionsign_vatreport_altinn_post**](VatReportApi.md#vatreportsactionsign_vatreport_altinn_post) | **POST** /vatreports?action&#x3D;sign-vatreport-altinn | 

# **vatreports_get**
> list[VatReport] vatreports_get()



Query VatReport

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()

try:
    api_response = api_instance.vatreports_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[VatReport]**](VatReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreports_id_delete**
> VatReport vatreports_id_delete(id)



Delete VatReport

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 

try:
    api_response = api_instance.vatreports_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VatReport**](VatReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreports_id_get**
> VatReport vatreports_id_get(id)



Get VatReport

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 

try:
    api_response = api_instance.vatreports_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VatReport**](VatReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreports_id_put**
> VatReport vatreports_id_put(body, id)



Update VatReport

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
body = swagger_client.VatReport() # VatReport | 
id = 56 # int | 

try:
    api_response = api_instance.vatreports_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VatReport**](VatReport.md)|  | 
 **id** | **int**|  | 

### Return type

[**VatReport**](VatReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreports_idactionadjust_post**
> object vatreports_idactionadjust_post(id, id)



adjust Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreports_idactionadjust_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_idactionadjust_post: %s\n" % e)
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

# **vatreports_idactionapprove_manually_post**
> object vatreports_idactionapprove_manually_post(id, id)



approveManually Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreports_idactionapprove_manually_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_idactionapprove_manually_post: %s\n" % e)
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

# **vatreports_idactionapprove_post**
> object vatreports_idactionapprove_post(id, id)



approve Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreports_idactionapprove_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_idactionapprove_post: %s\n" % e)
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

# **vatreports_idactioncontrol_vatreport_get**
> list[VatReportMessage] vatreports_idactioncontrol_vatreport_get(id, period_id)



control-vatreport Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 
period_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreports_idactioncontrol_vatreport_get(id, period_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_idactioncontrol_vatreport_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **period_id** | [**Object**](.md)|  | 

### Return type

[**list[VatReportMessage]**](VatReportMessage.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreports_idactionexecute_post**
> VatReport vatreports_idactionexecute_post(id, period_id)



execute Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 
period_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreports_idactionexecute_post(id, period_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_idactionexecute_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **period_id** | [**Object**](.md)|  | 

### Return type

[**VatReport**](VatReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreports_idactionget_vat_report_summary_from_previous_periods_get**
> list[VatReportSummary] vatreports_idactionget_vat_report_summary_from_previous_periods_get(id, period_id)



get-vat-report-summary-from-previous-periods Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 
period_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreports_idactionget_vat_report_summary_from_previous_periods_get(id, period_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_idactionget_vat_report_summary_from_previous_periods_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **period_id** | [**Object**](.md)|  | 

### Return type

[**list[VatReportSummary]**](VatReportSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreports_idactionget_vat_report_summary_get**
> list[VatReportSummary] vatreports_idactionget_vat_report_summary_get(id, period_id)



get-vat-report-summary Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 
period_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreports_idactionget_vat_report_summary_get(id, period_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_idactionget_vat_report_summary_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **period_id** | [**Object**](.md)|  | 

### Return type

[**list[VatReportSummary]**](VatReportSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreports_idactionget_vat_report_summary_per_post_get**
> list[VatReportSummaryPerPost] vatreports_idactionget_vat_report_summary_per_post_get(id, period_id)



get-vat-report-summary-per-post Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 
period_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreports_idactionget_vat_report_summary_per_post_get(id, period_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_idactionget_vat_report_summary_per_post_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **period_id** | [**Object**](.md)|  | 

### Return type

[**list[VatReportSummaryPerPost]**](VatReportSummaryPerPost.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreports_idactionget_vat_report_summary_per_post_per_account_details_get**
> list[VatReportSummaryPerPostPerAccount] vatreports_idactionget_vat_report_summary_per_post_per_account_details_get(id, period_id)



get-vat-report-summary-per-post-per-account-details Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 
period_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreports_idactionget_vat_report_summary_per_post_per_account_details_get(id, period_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_idactionget_vat_report_summary_per_post_per_account_details_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **period_id** | [**Object**](.md)|  | 

### Return type

[**list[VatReportSummaryPerPostPerAccount]**](VatReportSummaryPerPostPerAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreports_idactionget_vat_report_summary_per_post_per_account_get**
> list[VatReportSummaryPerPostPerAccount] vatreports_idactionget_vat_report_summary_per_post_per_account_get(id, period_id)



get-vat-report-summary-per-post-per-account Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 
period_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreports_idactionget_vat_report_summary_per_post_per_account_get(id, period_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_idactionget_vat_report_summary_per_post_per_account_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **period_id** | [**Object**](.md)|  | 

### Return type

[**list[VatReportSummaryPerPostPerAccount]**](VatReportSummaryPerPostPerAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreports_idactionnext_get**
> VatReport vatreports_idactionnext_get(id, periodid)



next Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 
periodid = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreports_idactionnext_get(id, periodid)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_idactionnext_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **periodid** | [**Object**](.md)|  | 

### Return type

[**VatReport**](VatReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreports_idactionpay_vat_post**
> object vatreports_idactionpay_vat_post(id, vat_report_id)



pay-vat Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 
vat_report_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreports_idactionpay_vat_post(id, vat_report_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_idactionpay_vat_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **vat_report_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreports_idactionprevious_get**
> VatReport vatreports_idactionprevious_get(id, periodid)



previous Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 
periodid = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreports_idactionprevious_get(id, periodid)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_idactionprevious_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **periodid** | [**Object**](.md)|  | 

### Return type

[**VatReport**](VatReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreports_idactionreexecute_post**
> object vatreports_idactionreexecute_post(id, id)



reexecute Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreports_idactionreexecute_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_idactionreexecute_post: %s\n" % e)
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

# **vatreports_idactionreject_post**
> object vatreports_idactionreject_post(id, id)



reject Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreports_idactionreject_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_idactionreject_post: %s\n" % e)
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

# **vatreports_idactionset_to_approved_post**
> object vatreports_idactionset_to_approved_post(id, id)



setToApproved Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreports_idactionset_to_approved_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_idactionset_to_approved_post: %s\n" % e)
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

# **vatreports_idactionsubmit_post**
> object vatreports_idactionsubmit_post(id, id)



submit Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreports_idactionsubmit_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_idactionsubmit_post: %s\n" % e)
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

# **vatreports_idactionundo_execute_period_post**
> object vatreports_idactionundo_execute_period_post(id, period_id)



undo-execute-period Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 
period_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreports_idactionundo_execute_period_post(id, period_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_idactionundo_execute_period_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **period_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreports_idactionundo_execute_post**
> object vatreports_idactionundo_execute_post(id, vat_report_id)



undo-execute Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
id = 56 # int | 
vat_report_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreports_idactionundo_execute_post(id, vat_report_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_idactionundo_execute_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **vat_report_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreports_post**
> VatReport vatreports_post(body)



Create VatReport

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
body = swagger_client.VatReport() # VatReport | 

try:
    api_response = api_instance.vatreports_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreports_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VatReport**](VatReport.md)|  | 

### Return type

[**VatReport**](VatReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreportsactioncreate_additional_vatreport_post**
> VatReport vatreportsactioncreate_additional_vatreport_post(period_id)



create-additional-vatreport Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
period_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreportsactioncreate_additional_vatreport_post(period_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreportsactioncreate_additional_vatreport_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **period_id** | [**Object**](.md)|  | 

### Return type

[**VatReport**](VatReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreportsactioncreate_adjusted_vatreport_post**
> VatReport vatreportsactioncreate_adjusted_vatreport_post(period_id)



create-adjusted-vatreport Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
period_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreportsactioncreate_adjusted_vatreport_post(period_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreportsactioncreate_adjusted_vatreport_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **period_id** | [**Object**](.md)|  | 

### Return type

[**VatReport**](VatReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreportsactioncurrent_get**
> VatReport vatreportsactioncurrent_get()



current Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()

try:
    api_response = api_instance.vatreportsactioncurrent_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreportsactioncurrent_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**VatReport**](VatReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreportsactionget_not_reported_journalentry_data_get**
> VatReportNotReportedJournalEntryData vatreportsactionget_not_reported_journalentry_data_get(period_id)



get-not-reported-journalentry-data Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
period_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreportsactionget_not_reported_journalentry_data_get(period_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreportsactionget_not_reported_journalentry_data_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **period_id** | [**Object**](.md)|  | 

### Return type

[**VatReportNotReportedJournalEntryData**](VatReportNotReportedJournalEntryData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreportsactionget_signing_text_altinn_post**
> AltinnSigningTextResponse vatreportsactionget_signing_text_altinn_post(vat_report_id)



get-signing-text-altinn Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
vat_report_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreportsactionget_signing_text_altinn_post(vat_report_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreportsactionget_signing_text_altinn_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vat_report_id** | [**Object**](.md)|  | 

### Return type

[**AltinnSigningTextResponse**](AltinnSigningTextResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreportsactionread_and_update_altinn_vatreport_data_post**
> AltinnGetVatReportDataFromAltinnResult vatreportsactionread_and_update_altinn_vatreport_data_post(vat_report_id)



read-and-update-altinn-vatreport-data Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
vat_report_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreportsactionread_and_update_altinn_vatreport_data_post(vat_report_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreportsactionread_and_update_altinn_vatreport_data_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vat_report_id** | [**Object**](.md)|  | 

### Return type

[**AltinnGetVatReportDataFromAltinnResult**](AltinnGetVatReportDataFromAltinnResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatreportsactionsign_vatreport_altinn_post**
> AltinnSigning vatreportsactionsign_vatreport_altinn_post(vat_report_id)



sign-vatreport-altinn Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatReportApi()
vat_report_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vatreportsactionsign_vatreport_altinn_post(vat_report_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatReportApi->vatreportsactionsign_vatreport_altinn_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vat_report_id** | [**Object**](.md)|  | 

### Return type

[**AltinnSigning**](AltinnSigning.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

