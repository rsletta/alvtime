# swagger_client.CompanySettingsApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**companysettings_get**](CompanySettingsApi.md#companysettings_get) | **GET** /companysettings | 
[**companysettings_id_delete**](CompanySettingsApi.md#companysettings_id_delete) | **DELETE** /companysettings/{id} | 
[**companysettings_id_get**](CompanySettingsApi.md#companysettings_id_get) | **GET** /companysettings/{id} | 
[**companysettings_id_put**](CompanySettingsApi.md#companysettings_id_put) | **PUT** /companysettings/{id} | 
[**companysettings_idactionaccept_ocr_agreement_post**](CompanySettingsApi.md#companysettings_idactionaccept_ocr_agreement_post) | **POST** /companysettings/{id}?action&#x3D;accept-ocr-agreement | 
[**companysettings_idactionactivate_einvoice_put**](CompanySettingsApi.md#companysettings_idactionactivate_einvoice_put) | **PUT** /companysettings/{id}?action&#x3D;activate-einvoice | 
[**companysettings_idactionocr_trial_used_post**](CompanySettingsApi.md#companysettings_idactionocr_trial_used_post) | **POST** /companysettings/{id}?action&#x3D;ocr-trial-used | 
[**companysettings_idactionreject_ocr_agreement_post**](CompanySettingsApi.md#companysettings_idactionreject_ocr_agreement_post) | **POST** /companysettings/{id}?action&#x3D;reject-ocr-agreement | 
[**companysettings_idactionupdate_logo_post**](CompanySettingsApi.md#companysettings_idactionupdate_logo_post) | **POST** /companysettings/{id}?action&#x3D;update-logo | 
[**companysettings_post**](CompanySettingsApi.md#companysettings_post) | **POST** /companysettings | 
[**companysettingsactionchange_period_series_post**](CompanySettingsApi.md#companysettingsactionchange_period_series_post) | **POST** /companysettings?action&#x3D;change-period-series | 
[**companysettingsactionexists_get**](CompanySettingsApi.md#companysettingsactionexists_get) | **GET** /companysettings?action&#x3D;exists | 
[**companysettingsactionfill_in_from_brreg_get**](CompanySettingsApi.md#companysettingsactionfill_in_from_brreg_get) | **GET** /companysettings?action&#x3D;fill-in-from-brreg | 

# **companysettings_get**
> list[CompanySettings] companysettings_get()



Query CompanySettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanySettingsApi()

try:
    api_response = api_instance.companysettings_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanySettingsApi->companysettings_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CompanySettings]**](CompanySettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companysettings_id_delete**
> CompanySettings companysettings_id_delete(id)



Delete CompanySettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanySettingsApi()
id = 56 # int | 

try:
    api_response = api_instance.companysettings_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanySettingsApi->companysettings_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CompanySettings**](CompanySettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companysettings_id_get**
> CompanySettings companysettings_id_get(id)



Get CompanySettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanySettingsApi()
id = 56 # int | 

try:
    api_response = api_instance.companysettings_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanySettingsApi->companysettings_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CompanySettings**](CompanySettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companysettings_id_put**
> CompanySettings companysettings_id_put(body, id)



Update CompanySettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanySettingsApi()
body = swagger_client.CompanySettings() # CompanySettings | 
id = 56 # int | 

try:
    api_response = api_instance.companysettings_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanySettingsApi->companysettings_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompanySettings**](CompanySettings.md)|  | 
 **id** | **int**|  | 

### Return type

[**CompanySettings**](CompanySettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companysettings_idactionaccept_ocr_agreement_post**
> object companysettings_idactionaccept_ocr_agreement_post(id)



accept-ocr-agreement Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanySettingsApi()
id = 56 # int | 

try:
    api_response = api_instance.companysettings_idactionaccept_ocr_agreement_post(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanySettingsApi->companysettings_idactionaccept_ocr_agreement_post: %s\n" % e)
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

# **companysettings_idactionactivate_einvoice_put**
> object companysettings_idactionactivate_einvoice_put(id)



activate-einvoice Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanySettingsApi()
id = 56 # int | 

try:
    api_response = api_instance.companysettings_idactionactivate_einvoice_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanySettingsApi->companysettings_idactionactivate_einvoice_put: %s\n" % e)
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

# **companysettings_idactionocr_trial_used_post**
> object companysettings_idactionocr_trial_used_post(id)



ocr-trial-used Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanySettingsApi()
id = 56 # int | 

try:
    api_response = api_instance.companysettings_idactionocr_trial_used_post(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanySettingsApi->companysettings_idactionocr_trial_used_post: %s\n" % e)
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

# **companysettings_idactionreject_ocr_agreement_post**
> object companysettings_idactionreject_ocr_agreement_post(id)



reject-ocr-agreement Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanySettingsApi()
id = 56 # int | 

try:
    api_response = api_instance.companysettings_idactionreject_ocr_agreement_post(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanySettingsApi->companysettings_idactionreject_ocr_agreement_post: %s\n" % e)
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

# **companysettings_idactionupdate_logo_post**
> object companysettings_idactionupdate_logo_post(id, logo_file_id)



update-logo Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanySettingsApi()
id = 56 # int | 
logo_file_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.companysettings_idactionupdate_logo_post(id, logo_file_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanySettingsApi->companysettings_idactionupdate_logo_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **logo_file_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companysettings_post**
> CompanySettings companysettings_post(body)



Create CompanySettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanySettingsApi()
body = swagger_client.CompanySettings() # CompanySettings | 

try:
    api_response = api_instance.companysettings_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanySettingsApi->companysettings_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompanySettings**](CompanySettings.md)|  | 

### Return type

[**CompanySettings**](CompanySettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companysettingsactionchange_period_series_post**
> object companysettingsactionchange_period_series_post(period_series_id, account_year)



change-period-series Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanySettingsApi()
period_series_id = swagger_client.Object() # Object | 
account_year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.companysettingsactionchange_period_series_post(period_series_id, account_year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanySettingsApi->companysettingsactionchange_period_series_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **period_series_id** | [**Object**](.md)|  | 
 **account_year** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companysettingsactionexists_get**
> object companysettingsactionexists_get()



exists Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanySettingsApi()

try:
    api_response = api_instance.companysettingsactionexists_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanySettingsApi->companysettingsactionexists_get: %s\n" % e)
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

# **companysettingsactionfill_in_from_brreg_get**
> CompanySettings companysettingsactionfill_in_from_brreg_get(org_number)



fill-in-from-brreg Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanySettingsApi()
org_number = swagger_client.Object() # Object | 

try:
    api_response = api_instance.companysettingsactionfill_in_from_brreg_get(org_number)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanySettingsApi->companysettingsactionfill_in_from_brreg_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org_number** | [**Object**](.md)|  | 

### Return type

[**CompanySettings**](CompanySettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

