# swagger_client.AmeldingDataApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**amelding_get**](AmeldingDataApi.md#amelding_get) | **GET** /amelding | 
[**amelding_id_delete**](AmeldingDataApi.md#amelding_id_delete) | **DELETE** /amelding/{id} | 
[**amelding_id_get**](AmeldingDataApi.md#amelding_id_get) | **GET** /amelding/{id} | 
[**amelding_idactionfeedback_put**](AmeldingDataApi.md#amelding_idactionfeedback_put) | **PUT** /amelding/{id}?action&#x3D;feedback | 
[**amelding_idactionget_amelding_get**](AmeldingDataApi.md#amelding_idactionget_amelding_get) | **GET** /amelding/{id}?action&#x3D;get-amelding | 
[**amelding_idactionget_feedback_get**](AmeldingDataApi.md#amelding_idactionget_feedback_get) | **GET** /amelding/{id}?action&#x3D;get-feedback | 
[**amelding_idactionpay_aga_tax_post**](AmeldingDataApi.md#amelding_idactionpay_aga_tax_post) | **POST** /amelding/{id}?action&#x3D;pay-aga-tax | 
[**amelding_idactionrebuild_logs_get**](AmeldingDataApi.md#amelding_idactionrebuild_logs_get) | **GET** /amelding/{id}?action&#x3D;rebuild-logs | 
[**amelding_idactionsend_put**](AmeldingDataApi.md#amelding_idactionsend_put) | **PUT** /amelding/{id}?action&#x3D;send | 
[**amelding_post**](AmeldingDataApi.md#amelding_post) | **POST** /amelding | 
[**ameldingactionamelding_feedback_in_period_get**](AmeldingDataApi.md#ameldingactionamelding_feedback_in_period_get) | **GET** /amelding?action&#x3D;amelding-feedback-in-period | 
[**ameldingactionpayrollruns_in_amelding_period_get**](AmeldingDataApi.md#ameldingactionpayrollruns_in_amelding_period_get) | **GET** /amelding?action&#x3D;payrollruns-in-amelding-period | 

# **amelding_get**
> list[AmeldingData] amelding_get()



Query AmeldingData

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AmeldingDataApi()

try:
    api_response = api_instance.amelding_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AmeldingDataApi->amelding_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[AmeldingData]**](AmeldingData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **amelding_id_delete**
> AmeldingData amelding_id_delete(id)



Delete AmeldingData

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AmeldingDataApi()
id = 56 # int | 

try:
    api_response = api_instance.amelding_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AmeldingDataApi->amelding_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**AmeldingData**](AmeldingData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **amelding_id_get**
> AmeldingData amelding_id_get(id)



Get AmeldingData

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AmeldingDataApi()
id = 56 # int | 

try:
    api_response = api_instance.amelding_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AmeldingDataApi->amelding_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**AmeldingData**](AmeldingData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **amelding_idactionfeedback_put**
> AmeldingData amelding_idactionfeedback_put(id)



feedback Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AmeldingDataApi()
id = 56 # int | 

try:
    api_response = api_instance.amelding_idactionfeedback_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AmeldingDataApi->amelding_idactionfeedback_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**AmeldingData**](AmeldingData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **amelding_idactionget_amelding_get**
> str amelding_idactionget_amelding_get(id)



get-amelding Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AmeldingDataApi()
id = 56 # int | 

try:
    api_response = api_instance.amelding_idactionget_amelding_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AmeldingDataApi->amelding_idactionget_amelding_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **amelding_idactionget_feedback_get**
> str amelding_idactionget_feedback_get(id)



get-feedback Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AmeldingDataApi()
id = 56 # int | 

try:
    api_response = api_instance.amelding_idactionget_feedback_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AmeldingDataApi->amelding_idactionget_feedback_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **amelding_idactionpay_aga_tax_post**
> object amelding_idactionpay_aga_tax_post(id, body=body)



pay-aga-tax Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AmeldingDataApi()
id = 56 # int | 
body = swagger_client.PayAgaTaxDTO() # PayAgaTaxDTO |  (optional)

try:
    api_response = api_instance.amelding_idactionpay_aga_tax_post(id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AmeldingDataApi->amelding_idactionpay_aga_tax_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **body** | [**PayAgaTaxDTO**](PayAgaTaxDTO.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **amelding_idactionrebuild_logs_get**
> bool amelding_idactionrebuild_logs_get(id, id)



rebuild-logs Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AmeldingDataApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.amelding_idactionrebuild_logs_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AmeldingDataApi->amelding_idactionrebuild_logs_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **amelding_idactionsend_put**
> AmeldingData amelding_idactionsend_put(id)



send Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AmeldingDataApi()
id = 56 # int | 

try:
    api_response = api_instance.amelding_idactionsend_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AmeldingDataApi->amelding_idactionsend_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**AmeldingData**](AmeldingData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **amelding_post**
> AmeldingData amelding_post(body)



Create AmeldingData

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AmeldingDataApi()
body = swagger_client.AmeldingData() # AmeldingData | 

try:
    api_response = api_instance.amelding_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AmeldingDataApi->amelding_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AmeldingData**](AmeldingData.md)|  | 

### Return type

[**AmeldingData**](AmeldingData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ameldingactionamelding_feedback_in_period_get**
> object ameldingactionamelding_feedback_in_period_get(from_period, to_period, year)



amelding-feedback-in-period Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AmeldingDataApi()
from_period = swagger_client.Object() # Object | 
to_period = swagger_client.Object() # Object | 
year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.ameldingactionamelding_feedback_in_period_get(from_period, to_period, year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AmeldingDataApi->ameldingactionamelding_feedback_in_period_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from_period** | [**Object**](.md)|  | 
 **to_period** | [**Object**](.md)|  | 
 **year** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ameldingactionpayrollruns_in_amelding_period_get**
> object ameldingactionpayrollruns_in_amelding_period_get(period)



payrollruns-in-amelding-period Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AmeldingDataApi()
period = swagger_client.Object() # Object | 

try:
    api_response = api_instance.ameldingactionpayrollruns_in_amelding_period_get(period)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AmeldingDataApi->ameldingactionpayrollruns_in_amelding_period_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **period** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

