# swagger_client.RssListApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**rss_id_get**](RssListApi.md#rss_id_get) | **GET** /rss/{id} | 
[**rssactionrss_get**](RssListApi.md#rssactionrss_get) | **GET** /rss?action&#x3D;rss | 

# **rss_id_get**
> RssList rss_id_get(id)



Get RssList

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RssListApi()
id = 56 # int | 

try:
    api_response = api_instance.rss_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RssListApi->rss_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**RssList**](RssList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rssactionrss_get**
> RssList rssactionrss_get()



rss Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RssListApi()

try:
    api_response = api_instance.rssactionrss_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RssListApi->rssactionrss_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**RssList**](RssList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

