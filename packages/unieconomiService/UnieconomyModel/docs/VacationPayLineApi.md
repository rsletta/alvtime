# swagger_client.VacationPayLineApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**vacation_pay_lines_get**](VacationPayLineApi.md#vacation_pay_lines_get) | **GET** /VacationPayLines | 
[**vacation_pay_lines_id_delete**](VacationPayLineApi.md#vacation_pay_lines_id_delete) | **DELETE** /VacationPayLines/{id} | 
[**vacation_pay_lines_id_get**](VacationPayLineApi.md#vacation_pay_lines_id_get) | **GET** /VacationPayLines/{id} | 
[**vacation_pay_lines_id_put**](VacationPayLineApi.md#vacation_pay_lines_id_put) | **PUT** /VacationPayLines/{id} | 
[**vacation_pay_lines_post**](VacationPayLineApi.md#vacation_pay_lines_post) | **POST** /VacationPayLines | 
[**vacation_pay_linesactionclose_put**](VacationPayLineApi.md#vacation_pay_linesactionclose_put) | **PUT** /VacationPayLines?action&#x3D;close | 
[**vacation_pay_linesactionlines_get**](VacationPayLineApi.md#vacation_pay_linesactionlines_get) | **GET** /VacationPayLines?action&#x3D;lines | 
[**vacation_pay_linesactionpay_emps_put**](VacationPayLineApi.md#vacation_pay_linesactionpay_emps_put) | **PUT** /VacationPayLines?action&#x3D;pay-emps | 
[**vacation_pay_linesactionpay_fromlines_put**](VacationPayLineApi.md#vacation_pay_linesactionpay_fromlines_put) | **PUT** /VacationPayLines?action&#x3D;pay-fromlines | 
[**vacation_pay_linesactionto_salary_put**](VacationPayLineApi.md#vacation_pay_linesactionto_salary_put) | **PUT** /VacationPayLines?action&#x3D;to-salary | 

# **vacation_pay_lines_get**
> list[VacationPayLine] vacation_pay_lines_get()



Query VacationPayLine

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VacationPayLineApi()

try:
    api_response = api_instance.vacation_pay_lines_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VacationPayLineApi->vacation_pay_lines_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[VacationPayLine]**](VacationPayLine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vacation_pay_lines_id_delete**
> VacationPayLine vacation_pay_lines_id_delete(id)



Delete VacationPayLine

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VacationPayLineApi()
id = 56 # int | 

try:
    api_response = api_instance.vacation_pay_lines_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VacationPayLineApi->vacation_pay_lines_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VacationPayLine**](VacationPayLine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vacation_pay_lines_id_get**
> VacationPayLine vacation_pay_lines_id_get(id)



Get VacationPayLine

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VacationPayLineApi()
id = 56 # int | 

try:
    api_response = api_instance.vacation_pay_lines_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VacationPayLineApi->vacation_pay_lines_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VacationPayLine**](VacationPayLine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vacation_pay_lines_id_put**
> VacationPayLine vacation_pay_lines_id_put(body, id)



Update VacationPayLine

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VacationPayLineApi()
body = swagger_client.VacationPayLine() # VacationPayLine | 
id = 56 # int | 

try:
    api_response = api_instance.vacation_pay_lines_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VacationPayLineApi->vacation_pay_lines_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VacationPayLine**](VacationPayLine.md)|  | 
 **id** | **int**|  | 

### Return type

[**VacationPayLine**](VacationPayLine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vacation_pay_lines_post**
> VacationPayLine vacation_pay_lines_post(body)



Create VacationPayLine

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VacationPayLineApi()
body = swagger_client.VacationPayLine() # VacationPayLine | 

try:
    api_response = api_instance.vacation_pay_lines_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VacationPayLineApi->vacation_pay_lines_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VacationPayLine**](VacationPayLine.md)|  | 

### Return type

[**VacationPayLine**](VacationPayLine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vacation_pay_linesactionclose_put**
> bool vacation_pay_linesactionclose_put(year, payroll_id, has_sixth_week, body=body)



close Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VacationPayLineApi()
year = swagger_client.Object() # Object | 
payroll_id = swagger_client.Object() # Object | 
has_sixth_week = swagger_client.Object() # Object | 
body = NULL # object |  (optional)

try:
    api_response = api_instance.vacation_pay_linesactionclose_put(year, payroll_id, has_sixth_week, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VacationPayLineApi->vacation_pay_linesactionclose_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | [**Object**](.md)|  | 
 **payroll_id** | [**Object**](.md)|  | 
 **has_sixth_week** | [**Object**](.md)|  | 
 **body** | [**object**](object.md)|  | [optional] 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vacation_pay_linesactionlines_get**
> object vacation_pay_linesactionlines_get(payrun_id, year, expand_emps, show_all)



lines Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VacationPayLineApi()
payrun_id = swagger_client.Object() # Object | 
year = swagger_client.Object() # Object | 
expand_emps = swagger_client.Object() # Object | 
show_all = swagger_client.Object() # Object | 

try:
    api_response = api_instance.vacation_pay_linesactionlines_get(payrun_id, year, expand_emps, show_all)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VacationPayLineApi->vacation_pay_linesactionlines_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payrun_id** | [**Object**](.md)|  | 
 **year** | [**Object**](.md)|  | 
 **expand_emps** | [**Object**](.md)|  | 
 **show_all** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vacation_pay_linesactionpay_emps_put**
> bool vacation_pay_linesactionpay_emps_put(payroll_id, year, has_sixth_week, body=body)



pay-emps Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VacationPayLineApi()
payroll_id = swagger_client.Object() # Object | 
year = swagger_client.Object() # Object | 
has_sixth_week = swagger_client.Object() # Object | 
body = NULL # object |  (optional)

try:
    api_response = api_instance.vacation_pay_linesactionpay_emps_put(payroll_id, year, has_sixth_week, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VacationPayLineApi->vacation_pay_linesactionpay_emps_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payroll_id** | [**Object**](.md)|  | 
 **year** | [**Object**](.md)|  | 
 **has_sixth_week** | [**Object**](.md)|  | 
 **body** | [**object**](object.md)|  | [optional] 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vacation_pay_linesactionpay_fromlines_put**
> bool vacation_pay_linesactionpay_fromlines_put(payroll_id, year, has_sixth_week, body=body)



pay-fromlines Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VacationPayLineApi()
payroll_id = swagger_client.Object() # Object | 
year = swagger_client.Object() # Object | 
has_sixth_week = swagger_client.Object() # Object | 
body = NULL # object |  (optional)

try:
    api_response = api_instance.vacation_pay_linesactionpay_fromlines_put(payroll_id, year, has_sixth_week, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VacationPayLineApi->vacation_pay_linesactionpay_fromlines_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payroll_id** | [**Object**](.md)|  | 
 **year** | [**Object**](.md)|  | 
 **has_sixth_week** | [**Object**](.md)|  | 
 **body** | [**object**](object.md)|  | [optional] 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vacation_pay_linesactionto_salary_put**
> bool vacation_pay_linesactionto_salary_put(payroll_id, base_year, body=body)



to-salary Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VacationPayLineApi()
payroll_id = swagger_client.Object() # Object | 
base_year = swagger_client.Object() # Object | 
body = NULL # object |  (optional)

try:
    api_response = api_instance.vacation_pay_linesactionto_salary_put(payroll_id, base_year, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VacationPayLineApi->vacation_pay_linesactionto_salary_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payroll_id** | [**Object**](.md)|  | 
 **base_year** | [**Object**](.md)|  | 
 **body** | [**object**](object.md)|  | [optional] 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

