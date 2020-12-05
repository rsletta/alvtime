# swagger_client.CampaignTemplateApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**campaigntemplate_get**](CampaignTemplateApi.md#campaigntemplate_get) | **GET** /campaigntemplate | 
[**campaigntemplate_id_delete**](CampaignTemplateApi.md#campaigntemplate_id_delete) | **DELETE** /campaigntemplate/{id} | 
[**campaigntemplate_id_get**](CampaignTemplateApi.md#campaigntemplate_id_get) | **GET** /campaigntemplate/{id} | 
[**campaigntemplate_id_put**](CampaignTemplateApi.md#campaigntemplate_id_put) | **PUT** /campaigntemplate/{id} | 
[**campaigntemplate_post**](CampaignTemplateApi.md#campaigntemplate_post) | **POST** /campaigntemplate | 

# **campaigntemplate_get**
> list[CampaignTemplate] campaigntemplate_get()



Query CampaignTemplate

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CampaignTemplateApi()

try:
    api_response = api_instance.campaigntemplate_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CampaignTemplateApi->campaigntemplate_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CampaignTemplate]**](CampaignTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **campaigntemplate_id_delete**
> CampaignTemplate campaigntemplate_id_delete(id)



Delete CampaignTemplate

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CampaignTemplateApi()
id = 56 # int | 

try:
    api_response = api_instance.campaigntemplate_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CampaignTemplateApi->campaigntemplate_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CampaignTemplate**](CampaignTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **campaigntemplate_id_get**
> CampaignTemplate campaigntemplate_id_get(id)



Get CampaignTemplate

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CampaignTemplateApi()
id = 56 # int | 

try:
    api_response = api_instance.campaigntemplate_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CampaignTemplateApi->campaigntemplate_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CampaignTemplate**](CampaignTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **campaigntemplate_id_put**
> CampaignTemplate campaigntemplate_id_put(body, id)



Update CampaignTemplate

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CampaignTemplateApi()
body = swagger_client.CampaignTemplate() # CampaignTemplate | 
id = 56 # int | 

try:
    api_response = api_instance.campaigntemplate_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CampaignTemplateApi->campaigntemplate_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CampaignTemplate**](CampaignTemplate.md)|  | 
 **id** | **int**|  | 

### Return type

[**CampaignTemplate**](CampaignTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **campaigntemplate_post**
> CampaignTemplate campaigntemplate_post(body)



Create CampaignTemplate

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CampaignTemplateApi()
body = swagger_client.CampaignTemplate() # CampaignTemplate | 

try:
    api_response = api_instance.campaigntemplate_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CampaignTemplateApi->campaigntemplate_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CampaignTemplate**](CampaignTemplate.md)|  | 

### Return type

[**CampaignTemplate**](CampaignTemplate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

