# swagger_client.PayrollRunApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**payrollrun_get**](PayrollRunApi.md#payrollrun_get) | **GET** /payrollrun | 
[**payrollrun_id_delete**](PayrollRunApi.md#payrollrun_id_delete) | **DELETE** /payrollrun/{id} | 
[**payrollrun_id_get**](PayrollRunApi.md#payrollrun_id_get) | **GET** /payrollrun/{id} | 
[**payrollrun_id_put**](PayrollRunApi.md#payrollrun_id_put) | **PUT** /payrollrun/{id} | 
[**payrollrun_idactionbook_put**](PayrollRunApi.md#payrollrun_idactionbook_put) | **PUT** /payrollrun/{id}?action&#x3D;book | 
[**payrollrun_idactioncalculate_put**](PayrollRunApi.md#payrollrun_idactioncalculate_put) | **PUT** /payrollrun/{id}?action&#x3D;calculate | 
[**payrollrun_idactioncalculatejob_put**](PayrollRunApi.md#payrollrun_idactioncalculatejob_put) | **PUT** /payrollrun/{id}?action&#x3D;calculatejob | 
[**payrollrun_idactioncalculateonemp_put**](PayrollRunApi.md#payrollrun_idactioncalculateonemp_put) | **PUT** /payrollrun/{id}?action&#x3D;calculateonemp | 
[**payrollrun_idactioncontrol_put**](PayrollRunApi.md#payrollrun_idactioncontrol_put) | **PUT** /payrollrun/{id}?action&#x3D;control | 
[**payrollrun_idactionemail_paychecks_put**](PayrollRunApi.md#payrollrun_idactionemail_paychecks_put) | **PUT** /payrollrun/{id}?action&#x3D;email-paychecks | 
[**payrollrun_idactionemployeesonrun_get**](PayrollRunApi.md#payrollrun_idactionemployeesonrun_get) | **GET** /payrollrun/{id}?action&#x3D;employeesonrun | 
[**payrollrun_idactionlatest_get**](PayrollRunApi.md#payrollrun_idactionlatest_get) | **GET** /payrollrun/{id}?action&#x3D;latest | 
[**payrollrun_idactionlatestperiod_get**](PayrollRunApi.md#payrollrun_idactionlatestperiod_get) | **GET** /payrollrun/{id}?action&#x3D;latestperiod | 
[**payrollrun_idactionnext_get**](PayrollRunApi.md#payrollrun_idactionnext_get) | **GET** /payrollrun/{id}?action&#x3D;next | 
[**payrollrun_idactionpaymentlist_get**](PayrollRunApi.md#payrollrun_idactionpaymentlist_get) | **GET** /payrollrun/{id}?action&#x3D;paymentlist | 
[**payrollrun_idactionpayments_on_runs_get**](PayrollRunApi.md#payrollrun_idactionpayments_on_runs_get) | **GET** /payrollrun/{id}?action&#x3D;payments-on-runs | 
[**payrollrun_idactionpostingsummary_get**](PayrollRunApi.md#payrollrun_idactionpostingsummary_get) | **GET** /payrollrun/{id}?action&#x3D;postingsummary | 
[**payrollrun_idactionpostingsummary_lines_get**](PayrollRunApi.md#payrollrun_idactionpostingsummary_lines_get) | **GET** /payrollrun/{id}?action&#x3D;postingsummary-lines | 
[**payrollrun_idactionpostingsummarydraft_get**](PayrollRunApi.md#payrollrun_idactionpostingsummarydraft_get) | **GET** /payrollrun/{id}?action&#x3D;postingsummarydraft | 
[**payrollrun_idactionprevious_get**](PayrollRunApi.md#payrollrun_idactionprevious_get) | **GET** /payrollrun/{id}?action&#x3D;previous | 
[**payrollrun_idactionrebuild_balances_put**](PayrollRunApi.md#payrollrun_idactionrebuild_balances_put) | **PUT** /payrollrun/{id}?action&#x3D;rebuildBalances | 
[**payrollrun_idactionrebuildpostings_put**](PayrollRunApi.md#payrollrun_idactionrebuildpostings_put) | **PUT** /payrollrun/{id}?action&#x3D;rebuildpostings | 
[**payrollrun_idactionrecalculatetax_put**](PayrollRunApi.md#payrollrun_idactionrecalculatetax_put) | **PUT** /payrollrun/{id}?action&#x3D;recalculatetax | 
[**payrollrun_idactionresetrun_put**](PayrollRunApi.md#payrollrun_idactionresetrun_put) | **PUT** /payrollrun/{id}?action&#x3D;resetrun | 
[**payrollrun_idactionsendpaymentlist_post**](PayrollRunApi.md#payrollrun_idactionsendpaymentlist_post) | **POST** /payrollrun/{id}?action&#x3D;sendpaymentlist | 
[**payrollrun_idactionsetcategories_put**](PayrollRunApi.md#payrollrun_idactionsetcategories_put) | **PUT** /payrollrun/{id}?action&#x3D;setcategories | 
[**payrollrun_idactiontime_to_salary_selection_get**](PayrollRunApi.md#payrollrun_idactiontime_to_salary_selection_get) | **GET** /payrollrun/{id}?action&#x3D;time-to-salary-selection | 
[**payrollrun_idactionvacationpay_closure_put**](PayrollRunApi.md#payrollrun_idactionvacationpay_closure_put) | **PUT** /payrollrun/{id}?action&#x3D;vacationpay-closure | 
[**payrollrun_idactionvacationpay_from_emp_list_put**](PayrollRunApi.md#payrollrun_idactionvacationpay_from_emp_list_put) | **PUT** /payrollrun/{id}?action&#x3D;vacationpay-from-emp-list | 
[**payrollrun_idactionvacationpay_from_vacationpayinfo_list_put**](PayrollRunApi.md#payrollrun_idactionvacationpay_from_vacationpayinfo_list_put) | **PUT** /payrollrun/{id}?action&#x3D;vacationpay-from-vacationpayinfo-list | 
[**payrollrun_idactionvacationpay_list_get**](PayrollRunApi.md#payrollrun_idactionvacationpay_list_get) | **GET** /payrollrun/{id}?action&#x3D;vacationpay-list | 
[**payrollrun_idactionwork_items_to_transes_put**](PayrollRunApi.md#payrollrun_idactionwork_items_to_transes_put) | **PUT** /payrollrun/{id}?action&#x3D;work-items-to-transes | 
[**payrollrun_post**](PayrollRunApi.md#payrollrun_post) | **POST** /payrollrun | 
[**payrollrunaction_payroll_job_post**](PayrollRunApi.md#payrollrunaction_payroll_job_post) | **POST** /payrollrun?action&#x3D;PayrollJob | 
[**payrollrunactioncalculateonemp_put**](PayrollRunApi.md#payrollrunactioncalculateonemp_put) | **PUT** /payrollrun?action&#x3D;calculateonemp | 
[**payrollrunactionotp_export_get**](PayrollRunApi.md#payrollrunactionotp_export_get) | **GET** /payrollrun?action&#x3D;otp-export | 
[**payrollrunactionrebuild_put**](PayrollRunApi.md#payrollrunactionrebuild_put) | **PUT** /payrollrun?action&#x3D;rebuild | 

# **payrollrun_get**
> list[PayrollRun] payrollrun_get()



Query PayrollRun

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()

try:
    api_response = api_instance.payrollrun_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[PayrollRun]**](PayrollRun.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_id_delete**
> PayrollRun payrollrun_id_delete(id)



Delete PayrollRun

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 

try:
    api_response = api_instance.payrollrun_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PayrollRun**](PayrollRun.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_id_get**
> PayrollRun payrollrun_id_get(id)



Get PayrollRun

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 

try:
    api_response = api_instance.payrollrun_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PayrollRun**](PayrollRun.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_id_put**
> PayrollRun payrollrun_id_put(body, id)



Update PayrollRun

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
body = swagger_client.PayrollRun() # PayrollRun | 
id = 56 # int | 

try:
    api_response = api_instance.payrollrun_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PayrollRun**](PayrollRun.md)|  | 
 **id** | **int**|  | 

### Return type

[**PayrollRun**](PayrollRun.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_idactionbook_put**
> list[JournalEntryLine] payrollrun_idactionbook_put(id, accounting_date, numberseries_id, booking_type, refresh)



book Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 
accounting_date = swagger_client.Object() # Object | 
numberseries_id = swagger_client.Object() # Object | 
booking_type = swagger_client.Object() # Object | 
refresh = swagger_client.Object() # Object | 

try:
    api_response = api_instance.payrollrun_idactionbook_put(id, accounting_date, numberseries_id, booking_type, refresh)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionbook_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **accounting_date** | [**Object**](.md)|  | 
 **numberseries_id** | [**Object**](.md)|  | 
 **booking_type** | [**Object**](.md)|  | 
 **refresh** | [**Object**](.md)|  | 

### Return type

[**list[JournalEntryLine]**](JournalEntryLine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_idactioncalculate_put**
> bool payrollrun_idactioncalculate_put(id)



calculate Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 

try:
    api_response = api_instance.payrollrun_idactioncalculate_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactioncalculate_put: %s\n" % e)
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

# **payrollrun_idactioncalculatejob_put**
> object payrollrun_idactioncalculatejob_put(id, id)



calculatejob Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.payrollrun_idactioncalculatejob_put(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactioncalculatejob_put: %s\n" % e)
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

# **payrollrun_idactioncalculateonemp_put**
> bool payrollrun_idactioncalculateonemp_put(id, emp_id)



calculateonemp Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 
emp_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.payrollrun_idactioncalculateonemp_put(id, emp_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactioncalculateonemp_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **emp_id** | [**Object**](.md)|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_idactioncontrol_put**
> bool payrollrun_idactioncontrol_put(id)



control Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 

try:
    api_response = api_instance.payrollrun_idactioncontrol_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactioncontrol_put: %s\n" % e)
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

# **payrollrun_idactionemail_paychecks_put**
> bool payrollrun_idactionemail_paychecks_put(id, grouped, body=body)



email-paychecks Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 
grouped = swagger_client.Object() # Object | 
body = swagger_client.PaycheckReportSetup() # PaycheckReportSetup |  (optional)

try:
    api_response = api_instance.payrollrun_idactionemail_paychecks_put(id, grouped, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionemail_paychecks_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **grouped** | [**Object**](.md)|  | 
 **body** | [**PaycheckReportSetup**](PaycheckReportSetup.md)|  | [optional] 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_idactionemployeesonrun_get**
> object payrollrun_idactionemployeesonrun_get(id, id)



employeesonrun Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.payrollrun_idactionemployeesonrun_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionemployeesonrun_get: %s\n" % e)
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

# **payrollrun_idactionlatest_get**
> PayrollRun payrollrun_idactionlatest_get(id)



latest Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 

try:
    api_response = api_instance.payrollrun_idactionlatest_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionlatest_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PayrollRun**](PayrollRun.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_idactionlatestperiod_get**
> int payrollrun_idactionlatestperiod_get(id, curr_year)



latestperiod Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 
curr_year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.payrollrun_idactionlatestperiod_get(id, curr_year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionlatestperiod_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **curr_year** | [**Object**](.md)|  | 

### Return type

**int**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_idactionnext_get**
> PayrollRun payrollrun_idactionnext_get(id, run_id, expand)



next Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 
run_id = swagger_client.Object() # Object | 
expand = swagger_client.Object() # Object | 

try:
    api_response = api_instance.payrollrun_idactionnext_get(id, run_id, expand)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionnext_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **run_id** | [**Object**](.md)|  | 
 **expand** | [**Object**](.md)|  | 

### Return type

[**PayrollRun**](PayrollRun.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_idactionpaymentlist_get**
> SalaryTransactionPay payrollrun_idactionpaymentlist_get(id)



paymentlist Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 

try:
    api_response = api_instance.payrollrun_idactionpaymentlist_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionpaymentlist_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**SalaryTransactionPay**](SalaryTransactionPay.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_idactionpayments_on_runs_get**
> object payrollrun_idactionpayments_on_runs_get(id, id)



payments-on-runs Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.payrollrun_idactionpayments_on_runs_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionpayments_on_runs_get: %s\n" % e)
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

# **payrollrun_idactionpostingsummary_get**
> PostingSummary payrollrun_idactionpostingsummary_get(id, booking_type, refresh)



postingsummary Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 
booking_type = swagger_client.Object() # Object | 
refresh = swagger_client.Object() # Object | 

try:
    api_response = api_instance.payrollrun_idactionpostingsummary_get(id, booking_type, refresh)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionpostingsummary_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **booking_type** | [**Object**](.md)|  | 
 **refresh** | [**Object**](.md)|  | 

### Return type

[**PostingSummary**](PostingSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_idactionpostingsummary_lines_get**
> list[JournalEntryLine] payrollrun_idactionpostingsummary_lines_get(id, booking_type, refresh)



postingsummary-lines Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 
booking_type = swagger_client.Object() # Object | 
refresh = swagger_client.Object() # Object | 

try:
    api_response = api_instance.payrollrun_idactionpostingsummary_lines_get(id, booking_type, refresh)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionpostingsummary_lines_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **booking_type** | [**Object**](.md)|  | 
 **refresh** | [**Object**](.md)|  | 

### Return type

[**list[JournalEntryLine]**](JournalEntryLine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_idactionpostingsummarydraft_get**
> PostingSummaryDraft payrollrun_idactionpostingsummarydraft_get(id)



postingsummarydraft Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 

try:
    api_response = api_instance.payrollrun_idactionpostingsummarydraft_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionpostingsummarydraft_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PostingSummaryDraft**](PostingSummaryDraft.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_idactionprevious_get**
> PayrollRun payrollrun_idactionprevious_get(id, run_id, expand)



previous Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 
run_id = swagger_client.Object() # Object | 
expand = swagger_client.Object() # Object | 

try:
    api_response = api_instance.payrollrun_idactionprevious_get(id, run_id, expand)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionprevious_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **run_id** | [**Object**](.md)|  | 
 **expand** | [**Object**](.md)|  | 

### Return type

[**PayrollRun**](PayrollRun.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_idactionrebuild_balances_put**
> object payrollrun_idactionrebuild_balances_put(id)



rebuildBalances Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 

try:
    api_response = api_instance.payrollrun_idactionrebuild_balances_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionrebuild_balances_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_idactionrebuildpostings_put**
> PostingSummaryDraft payrollrun_idactionrebuildpostings_put(id, booking_type, force_regeneration)



rebuildpostings Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 
booking_type = swagger_client.Object() # Object | 
force_regeneration = swagger_client.Object() # Object | 

try:
    api_response = api_instance.payrollrun_idactionrebuildpostings_put(id, booking_type, force_regeneration)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionrebuildpostings_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **booking_type** | [**Object**](.md)|  | 
 **force_regeneration** | [**Object**](.md)|  | 

### Return type

[**PostingSummaryDraft**](PostingSummaryDraft.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_idactionrecalculatetax_put**
> bool payrollrun_idactionrecalculatetax_put(id)



recalculatetax Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 

try:
    api_response = api_instance.payrollrun_idactionrecalculatetax_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionrecalculatetax_put: %s\n" % e)
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

# **payrollrun_idactionresetrun_put**
> bool payrollrun_idactionresetrun_put(id)



resetrun Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 

try:
    api_response = api_instance.payrollrun_idactionresetrun_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionresetrun_put: %s\n" % e)
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

# **payrollrun_idactionsendpaymentlist_post**
> bool payrollrun_idactionsendpaymentlist_post(id)



sendpaymentlist Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 

try:
    api_response = api_instance.payrollrun_idactionsendpaymentlist_post(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionsendpaymentlist_post: %s\n" % e)
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

# **payrollrun_idactionsetcategories_put**
> object payrollrun_idactionsetcategories_put(id2, id, body=body)



setcategories Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id2 = 56 # int | 
id = swagger_client.Object() # Object | 
body = NULL # object |  (optional)

try:
    api_response = api_instance.payrollrun_idactionsetcategories_put(id2, id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionsetcategories_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id2** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **body** | [**object**](object.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_idactiontime_to_salary_selection_get**
> list[WorkItemToSalary] payrollrun_idactiontime_to_salary_selection_get(id, id, to_date)



time-to-salary-selection Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 
to_date = swagger_client.Object() # Object | 

try:
    api_response = api_instance.payrollrun_idactiontime_to_salary_selection_get(id, id, to_date)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactiontime_to_salary_selection_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **to_date** | [**Object**](.md)|  | 

### Return type

[**list[WorkItemToSalary]**](WorkItemToSalary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_idactionvacationpay_closure_put**
> bool payrollrun_idactionvacationpay_closure_put(id, year, split_on_sixth, body=body)



vacationpay-closure Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 
year = swagger_client.Object() # Object | 
split_on_sixth = swagger_client.Object() # Object | 
body = NULL # object |  (optional)

try:
    api_response = api_instance.payrollrun_idactionvacationpay_closure_put(id, year, split_on_sixth, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionvacationpay_closure_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **year** | [**Object**](.md)|  | 
 **split_on_sixth** | [**Object**](.md)|  | 
 **body** | [**object**](object.md)|  | [optional] 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_idactionvacationpay_from_emp_list_put**
> bool payrollrun_idactionvacationpay_from_emp_list_put(id, year, split_on_sixth, body=body)



vacationpay-from-emp-list Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 
year = swagger_client.Object() # Object | 
split_on_sixth = swagger_client.Object() # Object | 
body = NULL # object |  (optional)

try:
    api_response = api_instance.payrollrun_idactionvacationpay_from_emp_list_put(id, year, split_on_sixth, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionvacationpay_from_emp_list_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **year** | [**Object**](.md)|  | 
 **split_on_sixth** | [**Object**](.md)|  | 
 **body** | [**object**](object.md)|  | [optional] 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_idactionvacationpay_from_vacationpayinfo_list_put**
> bool payrollrun_idactionvacationpay_from_vacationpayinfo_list_put(id, year, body=body)



vacationpay-from-vacationpayinfo-list Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 
year = swagger_client.Object() # Object | 
body = NULL # object |  (optional)

try:
    api_response = api_instance.payrollrun_idactionvacationpay_from_vacationpayinfo_list_put(id, year, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionvacationpay_from_vacationpayinfo_list_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **year** | [**Object**](.md)|  | 
 **body** | [**object**](object.md)|  | [optional] 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_idactionvacationpay_list_get**
> object payrollrun_idactionvacationpay_list_get(id, year, lastyear, filter, show_all)



vacationpay-list Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id = 56 # int | 
year = swagger_client.Object() # Object | 
lastyear = swagger_client.Object() # Object | 
filter = swagger_client.Object() # Object | 
show_all = swagger_client.Object() # Object | 

try:
    api_response = api_instance.payrollrun_idactionvacationpay_list_get(id, year, lastyear, filter, show_all)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionvacationpay_list_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **year** | [**Object**](.md)|  | 
 **lastyear** | [**Object**](.md)|  | 
 **filter** | [**Object**](.md)|  | 
 **show_all** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_idactionwork_items_to_transes_put**
> list[SalaryTransaction] payrollrun_idactionwork_items_to_transes_put(id2, id, body=body)



work-items-to-transes Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
id2 = 56 # int | 
id = swagger_client.Object() # Object | 
body = 56 # int |  (optional)

try:
    api_response = api_instance.payrollrun_idactionwork_items_to_transes_put(id2, id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_idactionwork_items_to_transes_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id2** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **body** | [**int**](int.md)|  | [optional] 

### Return type

[**list[SalaryTransaction]**](SalaryTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrun_post**
> PayrollRun payrollrun_post(body)



Create PayrollRun

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
body = swagger_client.PayrollRun() # PayrollRun | 

try:
    api_response = api_instance.payrollrun_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrun_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PayrollRun**](PayrollRun.md)|  | 

### Return type

[**PayrollRun**](PayrollRun.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrunaction_payroll_job_post**
> object payrollrunaction_payroll_job_post(body=body)



PayrollJob Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
body = swagger_client.PayrollRun() # PayrollRun |  (optional)

try:
    api_response = api_instance.payrollrunaction_payroll_job_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrunaction_payroll_job_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PayrollRun**](PayrollRun.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrunactioncalculateonemp_put**
> bool payrollrunactioncalculateonemp_put(emp_id)



calculateonemp Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
emp_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.payrollrunactioncalculateonemp_put(emp_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrunactioncalculateonemp_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emp_id** | [**Object**](.md)|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrunactionotp_export_get**
> object payrollrunactionotp_export_get(runs, month, year, as_xml)



otp-export Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()
runs = swagger_client.Object() # Object | 
month = swagger_client.Object() # Object | 
year = swagger_client.Object() # Object | 
as_xml = swagger_client.Object() # Object | 

try:
    api_response = api_instance.payrollrunactionotp_export_get(runs, month, year, as_xml)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrunactionotp_export_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **runs** | [**Object**](.md)|  | 
 **month** | [**Object**](.md)|  | 
 **year** | [**Object**](.md)|  | 
 **as_xml** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payrollrunactionrebuild_put**
> bool payrollrunactionrebuild_put()



rebuild Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PayrollRunApi()

try:
    api_response = api_instance.payrollrunactionrebuild_put()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PayrollRunApi->payrollrunactionrebuild_put: %s\n" % e)
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

