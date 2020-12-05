# swagger_client.FileApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**files_entitytype_entityid_get**](FileApi.md#files_entitytype_entityid_get) | **GET** /files/{entitytype}/{entityid} | 
[**files_entitytype_entityid_id_delete**](FileApi.md#files_entitytype_entityid_id_delete) | **DELETE** /files/{entitytype}/{entityid}/{id} | 
[**files_entitytype_entityid_id_get**](FileApi.md#files_entitytype_entityid_id_get) | **GET** /files/{entitytype}/{entityid}/{id} | 
[**files_entitytype_entityid_idactiondownload_get**](FileApi.md#files_entitytype_entityid_idactiondownload_get) | **GET** /files/{entitytype}/{entityid}/{id}?action&#x3D;download | 
[**files_entitytype_entityid_idactionfinalize_post**](FileApi.md#files_entitytype_entityid_idactionfinalize_post) | **POST** /files/{entitytype}/{entityid}/{id}?action&#x3D;finalize | 
[**files_entitytype_entityid_idactionocranalyse_get**](FileApi.md#files_entitytype_entityid_idactionocranalyse_get) | **GET** /files/{entitytype}/{entityid}/{id}?action&#x3D;ocranalyse | 
[**files_entitytype_entityid_post**](FileApi.md#files_entitytype_entityid_post) | **POST** /files/{entitytype}/{entityid} | 
[**files_entitytype_entityidactiondelete_by_filetag_delete**](FileApi.md#files_entitytype_entityidactiondelete_by_filetag_delete) | **DELETE** /files/{entitytype}/{entityid}?action&#x3D;delete-by-filetag | 
[**files_get**](FileApi.md#files_get) | **GET** /files | 
[**files_id_delete**](FileApi.md#files_id_delete) | **DELETE** /files/{id} | 
[**files_id_get**](FileApi.md#files_id_get) | **GET** /files/{id} | 
[**files_id_put**](FileApi.md#files_id_put) | **PUT** /files/{id} | 
[**files_idactiondownload_get**](FileApi.md#files_idactiondownload_get) | **GET** /files/{id}?action&#x3D;download | 
[**files_idactionfinalize_post**](FileApi.md#files_idactionfinalize_post) | **POST** /files/{id}?action&#x3D;finalize | 
[**files_idactionlink_post**](FileApi.md#files_idactionlink_post) | **POST** /files/{id}?action&#x3D;link | 
[**files_idactionocranalyse_get**](FileApi.md#files_idactionocranalyse_get) | **GET** /files/{id}?action&#x3D;ocranalyse | 
[**files_idactionset_is_attachment_put**](FileApi.md#files_idactionset_is_attachment_put) | **PUT** /files/{id}?action&#x3D;set-is-attachment | 
[**files_idactionunlink_post**](FileApi.md#files_idactionunlink_post) | **POST** /files/{id}?action&#x3D;unlink | 
[**files_post**](FileApi.md#files_post) | **POST** /files | 
[**filesactionsplit_file_multiple_post**](FileApi.md#filesactionsplit_file_multiple_post) | **POST** /files?action&#x3D;split-file-multiple | 
[**filesactionsplit_file_post**](FileApi.md#filesactionsplit_file_post) | **POST** /files?action&#x3D;split-file | 
[**filetags_tagnames_status_get**](FileApi.md#filetags_tagnames_status_get) | **GET** /filetags/{tagnames}/{status} | 
[**filetags_tagnames_statusactionget_supplier_invoice_inbox_count_get**](FileApi.md#filetags_tagnames_statusactionget_supplier_invoice_inbox_count_get) | **GET** /filetags/{tagnames}/{status}?action&#x3D;get-supplierInvoice-inbox-count | 
[**filetags_tagnames_statusactionget_supplier_invoice_inbox_get**](FileApi.md#filetags_tagnames_statusactionget_supplier_invoice_inbox_get) | **GET** /filetags/{tagnames}/{status}?action&#x3D;get-supplierInvoice-inbox | 

# **files_entitytype_entityid_get**
> list[File] files_entitytype_entityid_get()



Query File

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()

try:
    api_response = api_instance.files_entitytype_entityid_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->files_entitytype_entityid_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[File]**](File.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **files_entitytype_entityid_id_delete**
> File files_entitytype_entityid_id_delete(id)



Delete File

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()
id = 56 # int | 

try:
    api_response = api_instance.files_entitytype_entityid_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->files_entitytype_entityid_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**File**](File.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **files_entitytype_entityid_id_get**
> File files_entitytype_entityid_id_get(id)



Get File

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()
id = 56 # int | 

try:
    api_response = api_instance.files_entitytype_entityid_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->files_entitytype_entityid_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**File**](File.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **files_entitytype_entityid_idactiondownload_get**
> str files_entitytype_entityid_idactiondownload_get(id)



download Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()
id = 56 # int | 

try:
    api_response = api_instance.files_entitytype_entityid_idactiondownload_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->files_entitytype_entityid_idactiondownload_get: %s\n" % e)
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

# **files_entitytype_entityid_idactionfinalize_post**
> object files_entitytype_entityid_idactionfinalize_post(id, id)



finalize Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.files_entitytype_entityid_idactionfinalize_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->files_entitytype_entityid_idactionfinalize_post: %s\n" % e)
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

# **files_entitytype_entityid_idactionocranalyse_get**
> object files_entitytype_entityid_idactionocranalyse_get(id)



ocranalyse Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()
id = 56 # int | 

try:
    api_response = api_instance.files_entitytype_entityid_idactionocranalyse_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->files_entitytype_entityid_idactionocranalyse_get: %s\n" % e)
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

# **files_entitytype_entityid_post**
> File files_entitytype_entityid_post(body)



Create File

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()
body = '/path/to/file' # File | 

try:
    api_response = api_instance.files_entitytype_entityid_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->files_entitytype_entityid_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**File**](File.md)|  | 

### Return type

[**File**](File.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **files_entitytype_entityidactiondelete_by_filetag_delete**
> object files_entitytype_entityidactiondelete_by_filetag_delete(file_tag_name)



delete-by-filetag Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()
file_tag_name = swagger_client.Object() # Object | 

try:
    api_response = api_instance.files_entitytype_entityidactiondelete_by_filetag_delete(file_tag_name)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->files_entitytype_entityidactiondelete_by_filetag_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file_tag_name** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **files_get**
> list[File] files_get()



Query File

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()

try:
    api_response = api_instance.files_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->files_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[File]**](File.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **files_id_delete**
> File files_id_delete(id)



Delete File

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()
id = 56 # int | 

try:
    api_response = api_instance.files_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->files_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**File**](File.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **files_id_get**
> File files_id_get(id)



Get File

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()
id = 56 # int | 

try:
    api_response = api_instance.files_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->files_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**File**](File.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **files_id_put**
> File files_id_put(body, id)



Update File

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()
body = '/path/to/file' # File | 
id = 56 # int | 

try:
    api_response = api_instance.files_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->files_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**File**](File.md)|  | 
 **id** | **int**|  | 

### Return type

[**File**](File.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **files_idactiondownload_get**
> str files_idactiondownload_get(id)



download Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()
id = 56 # int | 

try:
    api_response = api_instance.files_idactiondownload_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->files_idactiondownload_get: %s\n" % e)
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

# **files_idactionfinalize_post**
> object files_idactionfinalize_post(id, id)



finalize Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.files_idactionfinalize_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->files_idactionfinalize_post: %s\n" % e)
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

# **files_idactionlink_post**
> File files_idactionlink_post(id, entitytype, entityid)



link Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()
id = 56 # int | 
entitytype = swagger_client.Object() # Object | 
entityid = swagger_client.Object() # Object | 

try:
    api_response = api_instance.files_idactionlink_post(id, entitytype, entityid)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->files_idactionlink_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **entitytype** | [**Object**](.md)|  | 
 **entityid** | [**Object**](.md)|  | 

### Return type

[**File**](File.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **files_idactionocranalyse_get**
> object files_idactionocranalyse_get(id)



ocranalyse Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()
id = 56 # int | 

try:
    api_response = api_instance.files_idactionocranalyse_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->files_idactionocranalyse_get: %s\n" % e)
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

# **files_idactionset_is_attachment_put**
> object files_idactionset_is_attachment_put(id, entitytype, entityid, is_attachment)



set-is-attachment Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()
id = 56 # int | 
entitytype = swagger_client.Object() # Object | 
entityid = swagger_client.Object() # Object | 
is_attachment = swagger_client.Object() # Object | 

try:
    api_response = api_instance.files_idactionset_is_attachment_put(id, entitytype, entityid, is_attachment)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->files_idactionset_is_attachment_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **entitytype** | [**Object**](.md)|  | 
 **entityid** | [**Object**](.md)|  | 
 **is_attachment** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **files_idactionunlink_post**
> object files_idactionunlink_post(id, entitytype, entityid)



unlink Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()
id = 56 # int | 
entitytype = swagger_client.Object() # Object | 
entityid = swagger_client.Object() # Object | 

try:
    api_response = api_instance.files_idactionunlink_post(id, entitytype, entityid)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->files_idactionunlink_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **entitytype** | [**Object**](.md)|  | 
 **entityid** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **files_post**
> File files_post(body)



Create File

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()
body = '/path/to/file' # File | 

try:
    api_response = api_instance.files_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->files_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**File**](File.md)|  | 

### Return type

[**File**](File.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **filesactionsplit_file_multiple_post**
> SplitFileMultipeResult filesactionsplit_file_multiple_post(old_file_id, new_file_ids)



split-file-multiple Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()
old_file_id = swagger_client.Object() # Object | 
new_file_ids = swagger_client.Object() # Object | 

try:
    api_response = api_instance.filesactionsplit_file_multiple_post(old_file_id, new_file_ids)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->filesactionsplit_file_multiple_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **old_file_id** | [**Object**](.md)|  | 
 **new_file_ids** | [**Object**](.md)|  | 

### Return type

[**SplitFileMultipeResult**](SplitFileMultipeResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **filesactionsplit_file_post**
> SplitFileResult filesactionsplit_file_post(old_file_id, new_file_id1, new_file_id2)



split-file Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()
old_file_id = swagger_client.Object() # Object | 
new_file_id1 = swagger_client.Object() # Object | 
new_file_id2 = swagger_client.Object() # Object | 

try:
    api_response = api_instance.filesactionsplit_file_post(old_file_id, new_file_id1, new_file_id2)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->filesactionsplit_file_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **old_file_id** | [**Object**](.md)|  | 
 **new_file_id1** | [**Object**](.md)|  | 
 **new_file_id2** | [**Object**](.md)|  | 

### Return type

[**SplitFileResult**](SplitFileResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **filetags_tagnames_status_get**
> list[File] filetags_tagnames_status_get()



Query File

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()

try:
    api_response = api_instance.filetags_tagnames_status_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->filetags_tagnames_status_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[File]**](File.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **filetags_tagnames_statusactionget_supplier_invoice_inbox_count_get**
> int filetags_tagnames_statusactionget_supplier_invoice_inbox_count_get()



get-supplierInvoice-inbox-count Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()

try:
    api_response = api_instance.filetags_tagnames_statusactionget_supplier_invoice_inbox_count_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->filetags_tagnames_statusactionget_supplier_invoice_inbox_count_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

**int**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **filetags_tagnames_statusactionget_supplier_invoice_inbox_get**
> object filetags_tagnames_statusactionget_supplier_invoice_inbox_get(top, skip)



get-supplierInvoice-inbox Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileApi()
top = swagger_client.Object() # Object | 
skip = swagger_client.Object() # Object | 

try:
    api_response = api_instance.filetags_tagnames_statusactionget_supplier_invoice_inbox_get(top, skip)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileApi->filetags_tagnames_statusactionget_supplier_invoice_inbox_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **top** | [**Object**](.md)|  | 
 **skip** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

