# swagger_client.EHFLogApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ehf_get**](EHFLogApi.md#ehf_get) | **GET** /ehf | 
[**ehf_id_delete**](EHFLogApi.md#ehf_id_delete) | **DELETE** /ehf/{id} | 
[**ehf_id_get**](EHFLogApi.md#ehf_id_get) | **GET** /ehf/{id} | 
[**ehf_id_put**](EHFLogApi.md#ehf_id_put) | **PUT** /ehf/{id} | 
[**ehf_post**](EHFLogApi.md#ehf_post) | **POST** /ehf | 
[**ehfactionactivate_post**](EHFLogApi.md#ehfactionactivate_post) | **POST** /ehf?action&#x3D;activate | 
[**ehfactiondeactivate_post**](EHFLogApi.md#ehfactiondeactivate_post) | **POST** /ehf?action&#x3D;deactivate | 
[**ehfactionimport_get**](EHFLogApi.md#ehfactionimport_get) | **GET** /ehf?action&#x3D;import | 
[**ehfactionis_ehf_receiver_get**](EHFLogApi.md#ehfactionis_ehf_receiver_get) | **GET** /ehf?action&#x3D;is-ehf-receiver | 
[**ehfactionparse_get**](EHFLogApi.md#ehfactionparse_get) | **GET** /ehf?action&#x3D;parse | 
[**ehfactionservicemetadata_get**](EHFLogApi.md#ehfactionservicemetadata_get) | **GET** /ehf?action&#x3D;servicemetadata | 

# **ehf_get**
> list[EHFLog] ehf_get()



Query EHFLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EHFLogApi()

try:
    api_response = api_instance.ehf_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EHFLogApi->ehf_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[EHFLog]**](EHFLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ehf_id_delete**
> EHFLog ehf_id_delete(id)



Delete EHFLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EHFLogApi()
id = 56 # int | 

try:
    api_response = api_instance.ehf_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EHFLogApi->ehf_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**EHFLog**](EHFLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ehf_id_get**
> EHFLog ehf_id_get(id)



Get EHFLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EHFLogApi()
id = 56 # int | 

try:
    api_response = api_instance.ehf_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EHFLogApi->ehf_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**EHFLog**](EHFLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ehf_id_put**
> EHFLog ehf_id_put(body, id)



Update EHFLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EHFLogApi()
body = swagger_client.EHFLog() # EHFLog | 
id = 56 # int | 

try:
    api_response = api_instance.ehf_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EHFLogApi->ehf_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EHFLog**](EHFLog.md)|  | 
 **id** | **int**|  | 

### Return type

[**EHFLog**](EHFLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ehf_post**
> EHFLog ehf_post(body)



Create EHFLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EHFLogApi()
body = swagger_client.EHFLog() # EHFLog | 

try:
    api_response = api_instance.ehf_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EHFLogApi->ehf_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EHFLog**](EHFLog.md)|  | 

### Return type

[**EHFLog**](EHFLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ehfactionactivate_post**
> object ehfactionactivate_post(service, direction, body=body)



activate Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EHFLogApi()
service = swagger_client.Object() # Object | 
direction = swagger_client.Object() # Object | 
body = swagger_client.EHFCustomer() # EHFCustomer |  (optional)

try:
    api_response = api_instance.ehfactionactivate_post(service, direction, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EHFLogApi->ehfactionactivate_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **service** | [**Object**](.md)|  | 
 **direction** | [**Object**](.md)|  | 
 **body** | [**EHFCustomer**](EHFCustomer.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ehfactiondeactivate_post**
> bool ehfactiondeactivate_post(service)



deactivate Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EHFLogApi()
service = swagger_client.Object() # Object | 

try:
    api_response = api_instance.ehfactiondeactivate_post(service)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EHFLogApi->ehfactiondeactivate_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **service** | [**Object**](.md)|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ehfactionimport_get**
> object ehfactionimport_get(file_id)



import Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EHFLogApi()
file_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.ehfactionimport_get(file_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EHFLogApi->ehfactionimport_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ehfactionis_ehf_receiver_get**
> bool ehfactionis_ehf_receiver_get(peppoladdress, entitytype)



is-ehf-receiver Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EHFLogApi()
peppoladdress = swagger_client.Object() # Object | 
entitytype = swagger_client.Object() # Object | 

try:
    api_response = api_instance.ehfactionis_ehf_receiver_get(peppoladdress, entitytype)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EHFLogApi->ehfactionis_ehf_receiver_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **peppoladdress** | [**Object**](.md)|  | 
 **entitytype** | [**Object**](.md)|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ehfactionparse_get**
> object ehfactionparse_get(file_id)



parse Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EHFLogApi()
file_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.ehfactionparse_get(file_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EHFLogApi->ehfactionparse_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ehfactionservicemetadata_get**
> ServiceMetadataDto ehfactionservicemetadata_get(peppoladdress, entitytype)



servicemetadata Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EHFLogApi()
peppoladdress = swagger_client.Object() # Object | 
entitytype = swagger_client.Object() # Object | 

try:
    api_response = api_instance.ehfactionservicemetadata_get(peppoladdress, entitytype)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EHFLogApi->ehfactionservicemetadata_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **peppoladdress** | [**Object**](.md)|  | 
 **entitytype** | [**Object**](.md)|  | 

### Return type

[**ServiceMetadataDto**](ServiceMetadataDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

