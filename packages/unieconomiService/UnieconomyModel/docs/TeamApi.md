# swagger_client.TeamApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**teams_get**](TeamApi.md#teams_get) | **GET** /teams | 
[**teams_id_delete**](TeamApi.md#teams_id_delete) | **DELETE** /teams/{id} | 
[**teams_id_get**](TeamApi.md#teams_id_get) | **GET** /teams/{id} | 
[**teams_id_put**](TeamApi.md#teams_id_put) | **PUT** /teams/{id} | 
[**teams_idactionmy_teamposition_get**](TeamApi.md#teams_idactionmy_teamposition_get) | **GET** /teams/{id}?action&#x3D;my-teamposition | 
[**teams_idactionwork_report_get**](TeamApi.md#teams_idactionwork_report_get) | **GET** /teams/{id}?action&#x3D;work-report | 
[**teams_post**](TeamApi.md#teams_post) | **POST** /teams | 
[**teamsactionmy_teams_get**](TeamApi.md#teamsactionmy_teams_get) | **GET** /teams?action&#x3D;my-teams | 
[**teamsactionteampositions_get**](TeamApi.md#teamsactionteampositions_get) | **GET** /teams?action&#x3D;teampositions | 

# **teams_get**
> list[Team] teams_get()



Query Team

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TeamApi()

try:
    api_response = api_instance.teams_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TeamApi->teams_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Team]**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **teams_id_delete**
> Team teams_id_delete(id)



Delete Team

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TeamApi()
id = 56 # int | 

try:
    api_response = api_instance.teams_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TeamApi->teams_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Team**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **teams_id_get**
> Team teams_id_get(id)



Get Team

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TeamApi()
id = 56 # int | 

try:
    api_response = api_instance.teams_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TeamApi->teams_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Team**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **teams_id_put**
> Team teams_id_put(body, id)



Update Team

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TeamApi()
body = swagger_client.Team() # Team | 
id = 56 # int | 

try:
    api_response = api_instance.teams_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TeamApi->teams_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Team**](Team.md)|  | 
 **id** | **int**|  | 

### Return type

[**Team**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **teams_idactionmy_teamposition_get**
> TeamPositionDto teams_idactionmy_teamposition_get(id, id)



my-teamposition Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TeamApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.teams_idactionmy_teamposition_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TeamApi->teams_idactionmy_teamposition_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**TeamPositionDto**](TeamPositionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **teams_idactionwork_report_get**
> TeamReport teams_idactionwork_report_get(id, id)



work-report Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TeamApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.teams_idactionwork_report_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TeamApi->teams_idactionwork_report_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**TeamReport**](TeamReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **teams_post**
> Team teams_post(body)



Create Team

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TeamApi()
body = swagger_client.Team() # Team | 

try:
    api_response = api_instance.teams_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TeamApi->teams_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Team**](Team.md)|  | 

### Return type

[**Team**](Team.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **teamsactionmy_teams_get**
> object teamsactionmy_teams_get()



my-teams Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TeamApi()

try:
    api_response = api_instance.teamsactionmy_teams_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TeamApi->teamsactionmy_teams_get: %s\n" % e)
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

# **teamsactionteampositions_get**
> object teamsactionteampositions_get()



teampositions Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TeamApi()

try:
    api_response = api_instance.teamsactionteampositions_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TeamApi->teamsactionteampositions_get: %s\n" % e)
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

