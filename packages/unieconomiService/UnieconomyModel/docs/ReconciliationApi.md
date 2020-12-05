# swagger_client.ReconciliationApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**reconciliationactionfrom_to_get**](ReconciliationApi.md#reconciliationactionfrom_to_get) | **GET** /reconciliation?action&#x3D;from-to | 

# **reconciliationactionfrom_to_get**
> Reconciliation reconciliationactionfrom_to_get(year, from_month, to_month, include_not_payed, only_booked)



from-to Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReconciliationApi()
year = swagger_client.Object() # Object | 
from_month = swagger_client.Object() # Object | 
to_month = swagger_client.Object() # Object | 
include_not_payed = swagger_client.Object() # Object | 
only_booked = swagger_client.Object() # Object | 

try:
    api_response = api_instance.reconciliationactionfrom_to_get(year, from_month, to_month, include_not_payed, only_booked)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReconciliationApi->reconciliationactionfrom_to_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | [**Object**](.md)|  | 
 **from_month** | [**Object**](.md)|  | 
 **to_month** | [**Object**](.md)|  | 
 **include_not_payed** | [**Object**](.md)|  | 
 **only_booked** | [**Object**](.md)|  | 

### Return type

[**Reconciliation**](Reconciliation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

