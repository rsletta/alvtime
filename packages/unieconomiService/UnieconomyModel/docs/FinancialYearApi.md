# swagger_client.FinancialYearApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**financialyears_get**](FinancialYearApi.md#financialyears_get) | **GET** /financialyears | 
[**financialyears_id_delete**](FinancialYearApi.md#financialyears_id_delete) | **DELETE** /financialyears/{id} | 
[**financialyears_id_get**](FinancialYearApi.md#financialyears_id_get) | **GET** /financialyears/{id} | 
[**financialyears_id_put**](FinancialYearApi.md#financialyears_id_put) | **PUT** /financialyears/{id} | 
[**financialyears_post**](FinancialYearApi.md#financialyears_post) | **POST** /financialyears | 
[**financialyearsactioncreate_financial_year_get**](FinancialYearApi.md#financialyearsactioncreate_financial_year_get) | **GET** /financialyears?action&#x3D;create-financial-year | 
[**financialyearsactionget_or_create_financial_year_get**](FinancialYearApi.md#financialyearsactionget_or_create_financial_year_get) | **GET** /financialyears?action&#x3D;get-or-create-financial-year | 

# **financialyears_get**
> list[FinancialYear] financialyears_get()



Query FinancialYear

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FinancialYearApi()

try:
    api_response = api_instance.financialyears_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FinancialYearApi->financialyears_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[FinancialYear]**](FinancialYear.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **financialyears_id_delete**
> FinancialYear financialyears_id_delete(id)



Delete FinancialYear

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FinancialYearApi()
id = 56 # int | 

try:
    api_response = api_instance.financialyears_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FinancialYearApi->financialyears_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**FinancialYear**](FinancialYear.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **financialyears_id_get**
> FinancialYear financialyears_id_get(id)



Get FinancialYear

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FinancialYearApi()
id = 56 # int | 

try:
    api_response = api_instance.financialyears_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FinancialYearApi->financialyears_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**FinancialYear**](FinancialYear.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **financialyears_id_put**
> FinancialYear financialyears_id_put(body, id)



Update FinancialYear

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FinancialYearApi()
body = swagger_client.FinancialYear() # FinancialYear | 
id = 56 # int | 

try:
    api_response = api_instance.financialyears_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FinancialYearApi->financialyears_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FinancialYear**](FinancialYear.md)|  | 
 **id** | **int**|  | 

### Return type

[**FinancialYear**](FinancialYear.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **financialyears_post**
> FinancialYear financialyears_post(body)



Create FinancialYear

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FinancialYearApi()
body = swagger_client.FinancialYear() # FinancialYear | 

try:
    api_response = api_instance.financialyears_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FinancialYearApi->financialyears_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FinancialYear**](FinancialYear.md)|  | 

### Return type

[**FinancialYear**](FinancialYear.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **financialyearsactioncreate_financial_year_get**
> FinancialYear financialyearsactioncreate_financial_year_get(year)



create-financial-year Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FinancialYearApi()
year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.financialyearsactioncreate_financial_year_get(year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FinancialYearApi->financialyearsactioncreate_financial_year_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | [**Object**](.md)|  | 

### Return type

[**FinancialYear**](FinancialYear.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **financialyearsactionget_or_create_financial_year_get**
> FinancialYear financialyearsactionget_or_create_financial_year_get(year)



get-or-create-financial-year Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FinancialYearApi()
year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.financialyearsactionget_or_create_financial_year_get(year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FinancialYearApi->financialyearsactionget_or_create_financial_year_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | [**Object**](.md)|  | 

### Return type

[**FinancialYear**](FinancialYear.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

