# swagger_client.FinancialDeadlineApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**deadlines_get**](FinancialDeadlineApi.md#deadlines_get) | **GET** /deadlines | 
[**deadlines_id_delete**](FinancialDeadlineApi.md#deadlines_id_delete) | **DELETE** /deadlines/{id} | 
[**deadlines_id_get**](FinancialDeadlineApi.md#deadlines_id_get) | **GET** /deadlines/{id} | 
[**deadlines_id_put**](FinancialDeadlineApi.md#deadlines_id_put) | **PUT** /deadlines/{id} | 
[**deadlines_post**](FinancialDeadlineApi.md#deadlines_post) | **POST** /deadlines | 
[**deadlinesactionget_all_filtered_get**](FinancialDeadlineApi.md#deadlinesactionget_all_filtered_get) | **GET** /deadlines?action&#x3D;get-all-filtered | 
[**deadlinesactionnumber_of_days_filtered_get**](FinancialDeadlineApi.md#deadlinesactionnumber_of_days_filtered_get) | **GET** /deadlines?action&#x3D;number-of-days-filtered | 

# **deadlines_get**
> list[FinancialDeadline] deadlines_get()



Query FinancialDeadline

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FinancialDeadlineApi()

try:
    api_response = api_instance.deadlines_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FinancialDeadlineApi->deadlines_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[FinancialDeadline]**](FinancialDeadline.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deadlines_id_delete**
> FinancialDeadline deadlines_id_delete(id)



Delete FinancialDeadline

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FinancialDeadlineApi()
id = 56 # int | 

try:
    api_response = api_instance.deadlines_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FinancialDeadlineApi->deadlines_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**FinancialDeadline**](FinancialDeadline.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deadlines_id_get**
> FinancialDeadline deadlines_id_get(id)



Get FinancialDeadline

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FinancialDeadlineApi()
id = 56 # int | 

try:
    api_response = api_instance.deadlines_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FinancialDeadlineApi->deadlines_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**FinancialDeadline**](FinancialDeadline.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deadlines_id_put**
> FinancialDeadline deadlines_id_put(body, id)



Update FinancialDeadline

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FinancialDeadlineApi()
body = swagger_client.FinancialDeadline() # FinancialDeadline | 
id = 56 # int | 

try:
    api_response = api_instance.deadlines_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FinancialDeadlineApi->deadlines_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FinancialDeadline**](FinancialDeadline.md)|  | 
 **id** | **int**|  | 

### Return type

[**FinancialDeadline**](FinancialDeadline.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deadlines_post**
> FinancialDeadline deadlines_post(body)



Create FinancialDeadline

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FinancialDeadlineApi()
body = swagger_client.FinancialDeadline() # FinancialDeadline | 

try:
    api_response = api_instance.deadlines_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FinancialDeadlineApi->deadlines_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FinancialDeadline**](FinancialDeadline.md)|  | 

### Return type

[**FinancialDeadline**](FinancialDeadline.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deadlinesactionget_all_filtered_get**
> object deadlinesactionget_all_filtered_get(query)



get-all-filtered Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FinancialDeadlineApi()
query = swagger_client.Object() # Object | 

try:
    api_response = api_instance.deadlinesactionget_all_filtered_get(query)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FinancialDeadlineApi->deadlinesactionget_all_filtered_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **deadlinesactionnumber_of_days_filtered_get**
> object deadlinesactionnumber_of_days_filtered_get(nr_of_days)



number-of-days-filtered Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FinancialDeadlineApi()
nr_of_days = swagger_client.Object() # Object | 

try:
    api_response = api_instance.deadlinesactionnumber_of_days_filtered_get(nr_of_days)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FinancialDeadlineApi->deadlinesactionnumber_of_days_filtered_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **nr_of_days** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

