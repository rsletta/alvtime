# swagger_client.LedgerSuggestionApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ledgersuggestions_get**](LedgerSuggestionApi.md#ledgersuggestions_get) | **GET** /ledgersuggestions | 
[**ledgersuggestions_id_get**](LedgerSuggestionApi.md#ledgersuggestions_id_get) | **GET** /ledgersuggestions/{id} | 

# **ledgersuggestions_get**
> list[LedgerSuggestion] ledgersuggestions_get()



Query LedgerSuggestion

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.LedgerSuggestionApi()

try:
    api_response = api_instance.ledgersuggestions_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling LedgerSuggestionApi->ledgersuggestions_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[LedgerSuggestion]**](LedgerSuggestion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ledgersuggestions_id_get**
> LedgerSuggestion ledgersuggestions_id_get(id)



Get LedgerSuggestion

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.LedgerSuggestionApi()
id = 56 # int | 

try:
    api_response = api_instance.ledgersuggestions_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling LedgerSuggestionApi->ledgersuggestions_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**LedgerSuggestion**](LedgerSuggestion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

