# swagger_client.TermsApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**terms_get**](TermsApi.md#terms_get) | **GET** /terms | 
[**terms_id_delete**](TermsApi.md#terms_id_delete) | **DELETE** /terms/{id} | 
[**terms_id_get**](TermsApi.md#terms_id_get) | **GET** /terms/{id} | 
[**terms_id_put**](TermsApi.md#terms_id_put) | **PUT** /terms/{id} | 
[**terms_post**](TermsApi.md#terms_post) | **POST** /terms | 
[**termsactionget_delivery_terms_get**](TermsApi.md#termsactionget_delivery_terms_get) | **GET** /terms?action&#x3D;get-delivery-terms | 
[**termsactionget_payment_terms_get**](TermsApi.md#termsactionget_payment_terms_get) | **GET** /terms?action&#x3D;get-payment-terms | 

# **terms_get**
> list[Terms] terms_get()



Query Terms

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TermsApi()

try:
    api_response = api_instance.terms_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TermsApi->terms_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Terms]**](Terms.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **terms_id_delete**
> Terms terms_id_delete(id)



Delete Terms

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TermsApi()
id = 56 # int | 

try:
    api_response = api_instance.terms_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TermsApi->terms_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Terms**](Terms.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **terms_id_get**
> Terms terms_id_get(id)



Get Terms

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TermsApi()
id = 56 # int | 

try:
    api_response = api_instance.terms_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TermsApi->terms_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Terms**](Terms.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **terms_id_put**
> Terms terms_id_put(body, id)



Update Terms

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TermsApi()
body = swagger_client.Terms() # Terms | 
id = 56 # int | 

try:
    api_response = api_instance.terms_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TermsApi->terms_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Terms**](Terms.md)|  | 
 **id** | **int**|  | 

### Return type

[**Terms**](Terms.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **terms_post**
> Terms terms_post(body)



Create Terms

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TermsApi()
body = swagger_client.Terms() # Terms | 

try:
    api_response = api_instance.terms_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TermsApi->terms_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Terms**](Terms.md)|  | 

### Return type

[**Terms**](Terms.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **termsactionget_delivery_terms_get**
> list[Terms] termsactionget_delivery_terms_get()



get-delivery-terms Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TermsApi()

try:
    api_response = api_instance.termsactionget_delivery_terms_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TermsApi->termsactionget_delivery_terms_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Terms]**](Terms.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **termsactionget_payment_terms_get**
> list[Terms] termsactionget_payment_terms_get()



get-payment-terms Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TermsApi()

try:
    api_response = api_instance.termsactionget_payment_terms_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TermsApi->termsactionget_payment_terms_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Terms]**](Terms.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

