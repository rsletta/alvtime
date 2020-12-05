# swagger_client.CurrencyApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**currencies_get**](CurrencyApi.md#currencies_get) | **GET** /currencies | 
[**currencies_id_delete**](CurrencyApi.md#currencies_id_delete) | **DELETE** /currencies/{id} | 
[**currencies_id_get**](CurrencyApi.md#currencies_id_get) | **GET** /currencies/{id} | 
[**currencies_id_put**](CurrencyApi.md#currencies_id_put) | **PUT** /currencies/{id} | 
[**currencies_post**](CurrencyApi.md#currencies_post) | **POST** /currencies | 
[**currenciesactiondownload_from_norgesbank_get**](CurrencyApi.md#currenciesactiondownload_from_norgesbank_get) | **GET** /currencies?action&#x3D;download-from-norgesbank | 
[**currenciesactionget_all_exchange_rates_get**](CurrencyApi.md#currenciesactionget_all_exchange_rates_get) | **GET** /currencies?action&#x3D;get-all-exchange-rates | 
[**currenciesactionget_currency_exchange_rate_get**](CurrencyApi.md#currenciesactionget_currency_exchange_rate_get) | **GET** /currencies?action&#x3D;get-currency-exchange-rate | 
[**currenciesactionget_latest_currency_downloaded_date_get**](CurrencyApi.md#currenciesactionget_latest_currency_downloaded_date_get) | **GET** /currencies?action&#x3D;get-latest-currency-downloaded-date | 

# **currencies_get**
> list[Currency] currencies_get()



Query Currency

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CurrencyApi()

try:
    api_response = api_instance.currencies_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CurrencyApi->currencies_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Currency]**](Currency.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **currencies_id_delete**
> Currency currencies_id_delete(id)



Delete Currency

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CurrencyApi()
id = 56 # int | 

try:
    api_response = api_instance.currencies_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CurrencyApi->currencies_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Currency**](Currency.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **currencies_id_get**
> Currency currencies_id_get(id)



Get Currency

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CurrencyApi()
id = 56 # int | 

try:
    api_response = api_instance.currencies_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CurrencyApi->currencies_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Currency**](Currency.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **currencies_id_put**
> Currency currencies_id_put(body, id)



Update Currency

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CurrencyApi()
body = swagger_client.Currency() # Currency | 
id = 56 # int | 

try:
    api_response = api_instance.currencies_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CurrencyApi->currencies_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Currency**](Currency.md)|  | 
 **id** | **int**|  | 

### Return type

[**Currency**](Currency.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **currencies_post**
> Currency currencies_post(body)



Create Currency

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CurrencyApi()
body = swagger_client.Currency() # Currency | 

try:
    api_response = api_instance.currencies_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CurrencyApi->currencies_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Currency**](Currency.md)|  | 

### Return type

[**Currency**](Currency.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **currenciesactiondownload_from_norgesbank_get**
> bool currenciesactiondownload_from_norgesbank_get(download_from_date)



download-from-norgesbank Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CurrencyApi()
download_from_date = swagger_client.Object() # Object | 

try:
    api_response = api_instance.currenciesactiondownload_from_norgesbank_get(download_from_date)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CurrencyApi->currenciesactiondownload_from_norgesbank_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **download_from_date** | [**Object**](.md)|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **currenciesactionget_all_exchange_rates_get**
> list[CurrencyRateData] currenciesactionget_all_exchange_rates_get(to_currency_code_id, currency_date)



get-all-exchange-rates Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CurrencyApi()
to_currency_code_id = swagger_client.Object() # Object | 
currency_date = swagger_client.Object() # Object | 

try:
    api_response = api_instance.currenciesactionget_all_exchange_rates_get(to_currency_code_id, currency_date)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CurrencyApi->currenciesactionget_all_exchange_rates_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **to_currency_code_id** | [**Object**](.md)|  | 
 **currency_date** | [**Object**](.md)|  | 

### Return type

[**list[CurrencyRateData]**](CurrencyRateData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **currenciesactionget_currency_exchange_rate_get**
> CurrencyRateData currenciesactionget_currency_exchange_rate_get(from_currency_code_id, to_currency_code_id, currency_date)



get-currency-exchange-rate Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CurrencyApi()
from_currency_code_id = swagger_client.Object() # Object | 
to_currency_code_id = swagger_client.Object() # Object | 
currency_date = swagger_client.Object() # Object | 

try:
    api_response = api_instance.currenciesactionget_currency_exchange_rate_get(from_currency_code_id, to_currency_code_id, currency_date)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CurrencyApi->currenciesactionget_currency_exchange_rate_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from_currency_code_id** | [**Object**](.md)|  | 
 **to_currency_code_id** | [**Object**](.md)|  | 
 **currency_date** | [**Object**](.md)|  | 

### Return type

[**CurrencyRateData**](CurrencyRateData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **currenciesactionget_latest_currency_downloaded_date_get**
> object currenciesactionget_latest_currency_downloaded_date_get(download_source)



get-latest-currency-downloaded-date Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CurrencyApi()
download_source = swagger_client.Object() # Object | 

try:
    api_response = api_instance.currenciesactionget_latest_currency_downloaded_date_get(download_source)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CurrencyApi->currenciesactionget_latest_currency_downloaded_date_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **download_source** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

