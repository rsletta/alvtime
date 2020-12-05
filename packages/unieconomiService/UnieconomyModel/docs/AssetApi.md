# swagger_client.AssetApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**assets_get**](AssetApi.md#assets_get) | **GET** /assets | 
[**assets_id_delete**](AssetApi.md#assets_id_delete) | **DELETE** /assets/{id} | 
[**assets_id_get**](AssetApi.md#assets_id_get) | **GET** /assets/{id} | 
[**assets_id_put**](AssetApi.md#assets_id_put) | **PUT** /assets/{id} | 
[**assets_idactionsellasset_post**](AssetApi.md#assets_idactionsellasset_post) | **POST** /assets/{id}?action&#x3D;sellasset | 
[**assets_idactionsetassetaslost_post**](AssetApi.md#assets_idactionsetassetaslost_post) | **POST** /assets/{id}?action&#x3D;setassetaslost | 
[**assets_post**](AssetApi.md#assets_post) | **POST** /assets | 
[**assetsactionactivate_put**](AssetApi.md#assetsactionactivate_put) | **PUT** /assets?action&#x3D;activate | 
[**assetsactionany_depreciations_get**](AssetApi.md#assetsactionany_depreciations_get) | **GET** /assets?action&#x3D;any-depreciations | 
[**assetsactioncalculate_depreciation_amount_put**](AssetApi.md#assetsactioncalculate_depreciation_amount_put) | **PUT** /assets?action&#x3D;calculate-depreciation-amount | 
[**assetsactioncalculate_lifetime_put**](AssetApi.md#assetsactioncalculate_lifetime_put) | **PUT** /assets?action&#x3D;calculate-lifetime | 
[**assetsactioncreate_post**](AssetApi.md#assetsactioncreate_post) | **POST** /assets?action&#x3D;create | 
[**assetsactiondepreciate_missing_put**](AssetApi.md#assetsactiondepreciate_missing_put) | **PUT** /assets?action&#x3D;depreciate-missing | 
[**assetsactiondepreciate_month_put**](AssetApi.md#assetsactiondepreciate_month_put) | **PUT** /assets?action&#x3D;depreciate-month | 
[**assetsactiondepreciate_put**](AssetApi.md#assetsactiondepreciate_put) | **PUT** /assets?action&#x3D;depreciate | 
[**assetsactionget_asset_groups_get**](AssetApi.md#assetsactionget_asset_groups_get) | **GET** /assets?action&#x3D;get-asset-groups | 
[**assetsactionget_assets_report_get**](AssetApi.md#assetsactionget_assets_report_get) | **GET** /assets?action&#x3D;get-assets-report | 
[**assetsactionget_use_asset_get**](AssetApi.md#assetsactionget_use_asset_get) | **GET** /assets?action&#x3D;get-use-asset | 
[**assetsactionis_balance_ok_get**](AssetApi.md#assetsactionis_balance_ok_get) | **GET** /assets?action&#x3D;is-balance-ok | 
[**assetsactionsell_asset_put**](AssetApi.md#assetsactionsell_asset_put) | **PUT** /assets?action&#x3D;sell-asset | 
[**assetsactionset_asset_aslost_put**](AssetApi.md#assetsactionset_asset_aslost_put) | **PUT** /assets?action&#x3D;set-asset-aslost | 
[**assetsactionset_use_asset_put**](AssetApi.md#assetsactionset_use_asset_put) | **PUT** /assets?action&#x3D;set-use-asset | 
[**assetsactionwrite_off_asset_put**](AssetApi.md#assetsactionwrite_off_asset_put) | **PUT** /assets?action&#x3D;write-off-asset | 

# **assets_get**
> list[Asset] assets_get()



Query Asset

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()

try:
    api_response = api_instance.assets_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assets_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Asset]**](Asset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **assets_id_delete**
> Asset assets_id_delete(id)



Delete Asset

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()
id = 56 # int | 

try:
    api_response = api_instance.assets_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assets_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Asset**](Asset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **assets_id_get**
> Asset assets_id_get(id)



Get Asset

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()
id = 56 # int | 

try:
    api_response = api_instance.assets_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assets_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Asset**](Asset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **assets_id_put**
> Asset assets_id_put(body, id)



Update Asset

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()
body = swagger_client.Asset() # Asset | 
id = 56 # int | 

try:
    api_response = api_instance.assets_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assets_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Asset**](Asset.md)|  | 
 **id** | **int**|  | 

### Return type

[**Asset**](Asset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **assets_idactionsellasset_post**
> object assets_idactionsellasset_post(id, id)



sellasset Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.assets_idactionsellasset_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assets_idactionsellasset_post: %s\n" % e)
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

# **assets_idactionsetassetaslost_post**
> object assets_idactionsetassetaslost_post(id, id)



setassetaslost Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.assets_idactionsetassetaslost_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assets_idactionsetassetaslost_post: %s\n" % e)
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

# **assets_post**
> Asset assets_post(body)



Create Asset

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()
body = swagger_client.Asset() # Asset | 

try:
    api_response = api_instance.assets_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assets_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Asset**](Asset.md)|  | 

### Return type

[**Asset**](Asset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **assetsactionactivate_put**
> object assetsactionactivate_put(id)



activate Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.assetsactionactivate_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assetsactionactivate_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **assetsactionany_depreciations_get**
> bool assetsactionany_depreciations_get(_date)



any-depreciations Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()
_date = swagger_client.Object() # Object | 

try:
    api_response = api_instance.assetsactionany_depreciations_get(_date)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assetsactionany_depreciations_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_date** | [**Object**](.md)|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **assetsactioncalculate_depreciation_amount_put**
> object assetsactioncalculate_depreciation_amount_put(body=body)



calculate-depreciation-amount Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()
body = swagger_client.Asset() # Asset |  (optional)

try:
    api_response = api_instance.assetsactioncalculate_depreciation_amount_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assetsactioncalculate_depreciation_amount_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Asset**](Asset.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **assetsactioncalculate_lifetime_put**
> int assetsactioncalculate_lifetime_put(body=body)



calculate-lifetime Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()
body = swagger_client.Asset() # Asset |  (optional)

try:
    api_response = api_instance.assetsactioncalculate_lifetime_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assetsactioncalculate_lifetime_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Asset**](Asset.md)|  | [optional] 

### Return type

**int**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **assetsactioncreate_post**
> Asset assetsactioncreate_post(invoice_id, account_id, account_number)



create Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()
invoice_id = swagger_client.Object() # Object | 
account_id = swagger_client.Object() # Object | 
account_number = swagger_client.Object() # Object | 

try:
    api_response = api_instance.assetsactioncreate_post(invoice_id, account_id, account_number)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assetsactioncreate_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoice_id** | [**Object**](.md)|  | 
 **account_id** | [**Object**](.md)|  | 
 **account_number** | [**Object**](.md)|  | 

### Return type

[**Asset**](Asset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **assetsactiondepreciate_missing_put**
> str assetsactiondepreciate_missing_put()



depreciate-missing Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()

try:
    api_response = api_instance.assetsactiondepreciate_missing_put()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assetsactiondepreciate_missing_put: %s\n" % e)
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

# **assetsactiondepreciate_month_put**
> str assetsactiondepreciate_month_put(_date)



depreciate-month Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()
_date = swagger_client.Object() # Object | 

try:
    api_response = api_instance.assetsactiondepreciate_month_put(_date)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assetsactiondepreciate_month_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_date** | [**Object**](.md)|  | 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **assetsactiondepreciate_put**
> object assetsactiondepreciate_put(id, _date, amount)



depreciate Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()
id = swagger_client.Object() # Object | 
_date = swagger_client.Object() # Object | 
amount = swagger_client.Object() # Object | 

try:
    api_response = api_instance.assetsactiondepreciate_put(id, _date, amount)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assetsactiondepreciate_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 
 **_date** | [**Object**](.md)|  | 
 **amount** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **assetsactionget_asset_groups_get**
> list[AssetGroup] assetsactionget_asset_groups_get()



get-asset-groups Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()

try:
    api_response = api_instance.assetsactionget_asset_groups_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assetsactionget_asset_groups_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[AssetGroup]**](AssetGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **assetsactionget_assets_report_get**
> list[AssetReportDTO] assetsactionget_assets_report_get(_date, asset_id)



get-assets-report Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()
_date = swagger_client.Object() # Object | 
asset_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.assetsactionget_assets_report_get(_date, asset_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assetsactionget_assets_report_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_date** | [**Object**](.md)|  | 
 **asset_id** | [**Object**](.md)|  | 

### Return type

[**list[AssetReportDTO]**](AssetReportDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **assetsactionget_use_asset_get**
> object assetsactionget_use_asset_get()



get-use-asset Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()

try:
    api_response = api_instance.assetsactionget_use_asset_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assetsactionget_use_asset_get: %s\n" % e)
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

# **assetsactionis_balance_ok_get**
> bool assetsactionis_balance_ok_get(account_id, amount)



is-balance-ok Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()
account_id = swagger_client.Object() # Object | 
amount = swagger_client.Object() # Object | 

try:
    api_response = api_instance.assetsactionis_balance_ok_get(account_id, amount)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assetsactionis_balance_ok_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account_id** | [**Object**](.md)|  | 
 **amount** | [**Object**](.md)|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **assetsactionsell_asset_put**
> object assetsactionsell_asset_put(asset_id, customer_id, vat_type_id, invoice_date, amount, create_invoice)



sell-asset Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()
asset_id = swagger_client.Object() # Object | 
customer_id = swagger_client.Object() # Object | 
vat_type_id = swagger_client.Object() # Object | 
invoice_date = swagger_client.Object() # Object | 
amount = swagger_client.Object() # Object | 
create_invoice = swagger_client.Object() # Object | 

try:
    api_response = api_instance.assetsactionsell_asset_put(asset_id, customer_id, vat_type_id, invoice_date, amount, create_invoice)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assetsactionsell_asset_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **asset_id** | [**Object**](.md)|  | 
 **customer_id** | [**Object**](.md)|  | 
 **vat_type_id** | [**Object**](.md)|  | 
 **invoice_date** | [**Object**](.md)|  | 
 **amount** | [**Object**](.md)|  | 
 **create_invoice** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **assetsactionset_asset_aslost_put**
> object assetsactionset_asset_aslost_put(id, _date, description)



set-asset-aslost Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()
id = swagger_client.Object() # Object | 
_date = swagger_client.Object() # Object | 
description = swagger_client.Object() # Object | 

try:
    api_response = api_instance.assetsactionset_asset_aslost_put(id, _date, description)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assetsactionset_asset_aslost_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 
 **_date** | [**Object**](.md)|  | 
 **description** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **assetsactionset_use_asset_put**
> object assetsactionset_use_asset_put(use)



set-use-asset Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()
use = swagger_client.Object() # Object | 

try:
    api_response = api_instance.assetsactionset_use_asset_put(use)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assetsactionset_use_asset_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **use** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **assetsactionwrite_off_asset_put**
> object assetsactionwrite_off_asset_put(id, amount, _date, description)



write-off-asset Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AssetApi()
id = swagger_client.Object() # Object | 
amount = swagger_client.Object() # Object | 
_date = swagger_client.Object() # Object | 
description = swagger_client.Object() # Object | 

try:
    api_response = api_instance.assetsactionwrite_off_asset_put(id, amount, _date, description)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AssetApi->assetsactionwrite_off_asset_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 
 **amount** | [**Object**](.md)|  | 
 **_date** | [**Object**](.md)|  | 
 **description** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

