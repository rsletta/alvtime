# swagger_client.CompanySalaryApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**companysalary_get**](CompanySalaryApi.md#companysalary_get) | **GET** /companysalary | 
[**companysalary_id_delete**](CompanySalaryApi.md#companysalary_id_delete) | **DELETE** /companysalary/{id} | 
[**companysalary_id_get**](CompanySalaryApi.md#companysalary_id_get) | **GET** /companysalary/{id} | 
[**companysalary_id_put**](CompanySalaryApi.md#companysalary_id_put) | **PUT** /companysalary/{id} | 
[**companysalary_post**](CompanySalaryApi.md#companysalary_post) | **POST** /companysalary | 

# **companysalary_get**
> list[CompanySalary] companysalary_get()



Query CompanySalary

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanySalaryApi()

try:
    api_response = api_instance.companysalary_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanySalaryApi->companysalary_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CompanySalary]**](CompanySalary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companysalary_id_delete**
> CompanySalary companysalary_id_delete(id)



Delete CompanySalary

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanySalaryApi()
id = 56 # int | 

try:
    api_response = api_instance.companysalary_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanySalaryApi->companysalary_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CompanySalary**](CompanySalary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companysalary_id_get**
> CompanySalary companysalary_id_get(id)



Get CompanySalary

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanySalaryApi()
id = 56 # int | 

try:
    api_response = api_instance.companysalary_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanySalaryApi->companysalary_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CompanySalary**](CompanySalary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companysalary_id_put**
> CompanySalary companysalary_id_put(body, id)



Update CompanySalary

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanySalaryApi()
body = swagger_client.CompanySalary() # CompanySalary | 
id = 56 # int | 

try:
    api_response = api_instance.companysalary_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanySalaryApi->companysalary_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompanySalary**](CompanySalary.md)|  | 
 **id** | **int**|  | 

### Return type

[**CompanySalary**](CompanySalary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companysalary_post**
> CompanySalary companysalary_post(body)



Create CompanySalary

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanySalaryApi()
body = swagger_client.CompanySalary() # CompanySalary | 

try:
    api_response = api_instance.companysalary_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanySalaryApi->companysalary_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompanySalary**](CompanySalary.md)|  | 

### Return type

[**CompanySalary**](CompanySalary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

