# swagger_client.BankApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**banks_get**](BankApi.md#banks_get) | **GET** /banks | 
[**banks_id_delete**](BankApi.md#banks_id_delete) | **DELETE** /banks/{id} | 
[**banks_id_get**](BankApi.md#banks_id_get) | **GET** /banks/{id} | 
[**banks_id_put**](BankApi.md#banks_id_put) | **PUT** /banks/{id} | 
[**banks_post**](BankApi.md#banks_post) | **POST** /banks | 
[**banksactionget_bank_from_accountnumber_lookup_get**](BankApi.md#banksactionget_bank_from_accountnumber_lookup_get) | **GET** /banks?action&#x3D;get-bank-from-accountnumber-lookup | 
[**banksactionget_iban_from_accountnumber_lookup_get**](BankApi.md#banksactionget_iban_from_accountnumber_lookup_get) | **GET** /banks?action&#x3D;get-iban-from-accountnumber-lookup | 
[**banksactionget_iban_upsert_bank_get**](BankApi.md#banksactionget_iban_upsert_bank_get) | **GET** /banks?action&#x3D;get-iban-upsert-bank | 
[**banksactionverify_iban_get**](BankApi.md#banksactionverify_iban_get) | **GET** /banks?action&#x3D;verify-iban | 
[**banksactionverify_iban_upsert_bank_get**](BankApi.md#banksactionverify_iban_upsert_bank_get) | **GET** /banks?action&#x3D;verify-iban-upsert-bank | 

# **banks_get**
> list[Bank] banks_get()



Query Bank

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankApi()

try:
    api_response = api_instance.banks_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankApi->banks_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Bank]**](Bank.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **banks_id_delete**
> Bank banks_id_delete(id)



Delete Bank

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankApi()
id = 56 # int | 

try:
    api_response = api_instance.banks_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankApi->banks_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Bank**](Bank.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **banks_id_get**
> Bank banks_id_get(id)



Get Bank

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankApi()
id = 56 # int | 

try:
    api_response = api_instance.banks_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankApi->banks_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Bank**](Bank.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **banks_id_put**
> Bank banks_id_put(body, id)



Update Bank

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankApi()
body = swagger_client.Bank() # Bank | 
id = 56 # int | 

try:
    api_response = api_instance.banks_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankApi->banks_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Bank**](Bank.md)|  | 
 **id** | **int**|  | 

### Return type

[**Bank**](Bank.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **banks_post**
> Bank banks_post(body)



Create Bank

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankApi()
body = swagger_client.Bank() # Bank | 

try:
    api_response = api_instance.banks_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankApi->banks_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Bank**](Bank.md)|  | 

### Return type

[**Bank**](Bank.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **banksactionget_bank_from_accountnumber_lookup_get**
> Bank banksactionget_bank_from_accountnumber_lookup_get(bank_account_number)



get-bank-from-accountnumber-lookup Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankApi()
bank_account_number = swagger_client.Object() # Object | 

try:
    api_response = api_instance.banksactionget_bank_from_accountnumber_lookup_get(bank_account_number)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankApi->banksactionget_bank_from_accountnumber_lookup_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bank_account_number** | [**Object**](.md)|  | 

### Return type

[**Bank**](Bank.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **banksactionget_iban_from_accountnumber_lookup_get**
> str banksactionget_iban_from_accountnumber_lookup_get(bank_account_number)



get-iban-from-accountnumber-lookup Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankApi()
bank_account_number = swagger_client.Object() # Object | 

try:
    api_response = api_instance.banksactionget_iban_from_accountnumber_lookup_get(bank_account_number)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankApi->banksactionget_iban_from_accountnumber_lookup_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bank_account_number** | [**Object**](.md)|  | 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **banksactionget_iban_upsert_bank_get**
> BankData banksactionget_iban_upsert_bank_get(bank_account_number)



get-iban-upsert-bank Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankApi()
bank_account_number = swagger_client.Object() # Object | 

try:
    api_response = api_instance.banksactionget_iban_upsert_bank_get(bank_account_number)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankApi->banksactionget_iban_upsert_bank_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bank_account_number** | [**Object**](.md)|  | 

### Return type

[**BankData**](BankData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **banksactionverify_iban_get**
> bool banksactionverify_iban_get(iban)



verify-iban Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankApi()
iban = swagger_client.Object() # Object | 

try:
    api_response = api_instance.banksactionverify_iban_get(iban)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankApi->banksactionverify_iban_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **iban** | [**Object**](.md)|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **banksactionverify_iban_upsert_bank_get**
> BankData banksactionverify_iban_upsert_bank_get(iban)



verify-iban-upsert-bank Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankApi()
iban = swagger_client.Object() # Object | 

try:
    api_response = api_instance.banksactionverify_iban_upsert_bank_get(iban)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankApi->banksactionverify_iban_upsert_bank_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **iban** | [**Object**](.md)|  | 

### Return type

[**BankData**](BankData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

