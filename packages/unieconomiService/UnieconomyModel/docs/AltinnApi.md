# swagger_client.AltinnApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**altinn_get**](AltinnApi.md#altinn_get) | **GET** /altinn | 
[**altinn_id_delete**](AltinnApi.md#altinn_id_delete) | **DELETE** /altinn/{id} | 
[**altinn_id_get**](AltinnApi.md#altinn_id_get) | **GET** /altinn/{id} | 
[**altinn_id_put**](AltinnApi.md#altinn_id_put) | **PUT** /altinn/{id} | 
[**altinn_idactionemail_barnepass_to_customers_put**](AltinnApi.md#altinn_idactionemail_barnepass_to_customers_put) | **PUT** /altinn/{id}?action&#x3D;email-barnepass-to-customers | 
[**altinn_idactionsendtaxrequest_post**](AltinnApi.md#altinn_idactionsendtaxrequest_post) | **POST** /altinn/{id}?action&#x3D;sendtaxrequest | 
[**altinn_post**](AltinnApi.md#altinn_post) | **POST** /altinn | 
[**altinnactionchecklogin_get**](AltinnApi.md#altinnactionchecklogin_get) | **GET** /altinn?action&#x3D;checklogin | 
[**altinnactionget_a07_response_get**](AltinnApi.md#altinnactionget_a07_response_get) | **GET** /altinn?action&#x3D;get-a07-response | 
[**altinnactionget_barnepass_get**](AltinnApi.md#altinnactionget_barnepass_get) | **GET** /altinn?action&#x3D;get-barnepass | 
[**altinnactionget_pin_message_post**](AltinnApi.md#altinnactionget_pin_message_post) | **POST** /altinn?action&#x3D;get-pin-message | 
[**altinnactiongetpassword_get**](AltinnApi.md#altinnactiongetpassword_get) | **GET** /altinn?action&#x3D;getpassword | 
[**altinnactionis_barnepass_sendt_get**](AltinnApi.md#altinnactionis_barnepass_sendt_get) | **GET** /altinn?action&#x3D;is-barnepass-sendt | 
[**altinnactionsend_a06_request_post**](AltinnApi.md#altinnactionsend_a06_request_post) | **POST** /altinn?action&#x3D;send-a06-request | 
[**altinnactionsend_barnepass_post**](AltinnApi.md#altinnactionsend_barnepass_post) | **POST** /altinn?action&#x3D;send-barnepass | 
[**altinnactionsend_selfemployed_post**](AltinnApi.md#altinnactionsend_selfemployed_post) | **POST** /altinn?action&#x3D;send-selfemployed | 
[**altinnactionsetpassword_put**](AltinnApi.md#altinnactionsetpassword_put) | **PUT** /altinn?action&#x3D;setpassword | 
[**altinnactiontest_user_authentication_get**](AltinnApi.md#altinnactiontest_user_authentication_get) | **GET** /altinn?action&#x3D;test-user-authentication | 

# **altinn_get**
> list[Altinn] altinn_get()



Query Altinn

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnApi()

try:
    api_response = api_instance.altinn_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnApi->altinn_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Altinn]**](Altinn.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinn_id_delete**
> Altinn altinn_id_delete(id)



Delete Altinn

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnApi()
id = 56 # int | 

try:
    api_response = api_instance.altinn_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnApi->altinn_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Altinn**](Altinn.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinn_id_get**
> Altinn altinn_id_get(id)



Get Altinn

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnApi()
id = 56 # int | 

try:
    api_response = api_instance.altinn_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnApi->altinn_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Altinn**](Altinn.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinn_id_put**
> Altinn altinn_id_put(body, id)



Update Altinn

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnApi()
body = swagger_client.Altinn() # Altinn | 
id = 56 # int | 

try:
    api_response = api_instance.altinn_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnApi->altinn_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Altinn**](Altinn.md)|  | 
 **id** | **int**|  | 

### Return type

[**Altinn**](Altinn.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinn_idactionemail_barnepass_to_customers_put**
> object altinn_idactionemail_barnepass_to_customers_put(id2, id, body=body)



email-barnepass-to-customers Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnApi()
id2 = 56 # int | 
id = swagger_client.Object() # Object | 
body = NULL # object |  (optional)

try:
    api_response = api_instance.altinn_idactionemail_barnepass_to_customers_put(id2, id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnApi->altinn_idactionemail_barnepass_to_customers_put: %s\n" % e)
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

# **altinn_idactionsendtaxrequest_post**
> AltinnReceipt altinn_idactionsendtaxrequest_post(id, option, emp_id, request_all_changes, category_id)



sendtaxrequest Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnApi()
id = 56 # int | 
option = swagger_client.Object() # Object | 
emp_id = swagger_client.Object() # Object | 
request_all_changes = swagger_client.Object() # Object | 
category_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.altinn_idactionsendtaxrequest_post(id, option, emp_id, request_all_changes, category_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnApi->altinn_idactionsendtaxrequest_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **option** | [**Object**](.md)|  | 
 **emp_id** | [**Object**](.md)|  | 
 **request_all_changes** | [**Object**](.md)|  | 
 **category_id** | [**Object**](.md)|  | 

### Return type

[**AltinnReceipt**](AltinnReceipt.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinn_post**
> Altinn altinn_post(body)



Create Altinn

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnApi()
body = swagger_client.Altinn() # Altinn | 

try:
    api_response = api_instance.altinn_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnApi->altinn_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Altinn**](Altinn.md)|  | 

### Return type

[**Altinn**](Altinn.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinnactionchecklogin_get**
> bool altinnactionchecklogin_get()



checklogin Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnApi()

try:
    api_response = api_instance.altinnactionchecklogin_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnApi->altinnactionchecklogin_get: %s\n" % e)
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

# **altinnactionget_a07_response_get**
> A07Response altinnactionget_a07_response_get(receipt_id)



get-a07-response Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnApi()
receipt_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.altinnactionget_a07_response_get(receipt_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnApi->altinnactionget_a07_response_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **receipt_id** | [**Object**](.md)|  | 

### Return type

[**A07Response**](A07Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinnactionget_barnepass_get**
> Barnepass altinnactionget_barnepass_get(year)



get-barnepass Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnApi()
year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.altinnactionget_barnepass_get(year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnApi->altinnactionget_barnepass_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | [**Object**](.md)|  | 

### Return type

[**Barnepass**](Barnepass.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinnactionget_pin_message_post**
> AuthenticationChallengeBE altinnactionget_pin_message_post(body=body)



get-pin-message Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnApi()
body = swagger_client.AltinnAuthRequest() # AltinnAuthRequest |  (optional)

try:
    api_response = api_instance.altinnactionget_pin_message_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnApi->altinnactionget_pin_message_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AltinnAuthRequest**](AltinnAuthRequest.md)|  | [optional] 

### Return type

[**AuthenticationChallengeBE**](AuthenticationChallengeBE.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinnactiongetpassword_get**
> str altinnactiongetpassword_get()



getpassword Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnApi()

try:
    api_response = api_instance.altinnactiongetpassword_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnApi->altinnactiongetpassword_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinnactionis_barnepass_sendt_get**
> bool altinnactionis_barnepass_sendt_get(year)



is-barnepass-sendt Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnApi()
year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.altinnactionis_barnepass_sendt_get(year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnApi->altinnactionis_barnepass_sendt_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | [**Object**](.md)|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinnactionsend_a06_request_post**
> AltinnReceipt altinnactionsend_a06_request_post(body=body)



send-a06-request Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnApi()
body = swagger_client.A06Options() # A06Options |  (optional)

try:
    api_response = api_instance.altinnactionsend_a06_request_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnApi->altinnactionsend_a06_request_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**A06Options**](A06Options.md)|  | [optional] 

### Return type

[**AltinnReceipt**](AltinnReceipt.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinnactionsend_barnepass_post**
> AltinnReceipt altinnactionsend_barnepass_post(body=body)



send-barnepass Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnApi()
body = swagger_client.Barnepass() # Barnepass |  (optional)

try:
    api_response = api_instance.altinnactionsend_barnepass_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnApi->altinnactionsend_barnepass_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Barnepass**](Barnepass.md)|  | [optional] 

### Return type

[**AltinnReceipt**](AltinnReceipt.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinnactionsend_selfemployed_post**
> AltinnReceipt altinnactionsend_selfemployed_post(body=body)



send-selfemployed Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnApi()
body = swagger_client.SelfEmployed() # SelfEmployed |  (optional)

try:
    api_response = api_instance.altinnactionsend_selfemployed_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnApi->altinnactionsend_selfemployed_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SelfEmployed**](SelfEmployed.md)|  | [optional] 

### Return type

[**AltinnReceipt**](AltinnReceipt.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinnactionsetpassword_put**
> str altinnactionsetpassword_put(password)



setpassword Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnApi()
password = swagger_client.Object() # Object | 

try:
    api_response = api_instance.altinnactionsetpassword_put(password)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnApi->altinnactionsetpassword_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **password** | [**Object**](.md)|  | 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinnactiontest_user_authentication_get**
> object altinnactiontest_user_authentication_get()



test-user-authentication Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnApi()

try:
    api_response = api_instance.altinnactiontest_user_authentication_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnApi->altinnactiontest_user_authentication_get: %s\n" % e)
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

