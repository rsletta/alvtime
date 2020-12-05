# swagger_client.DistributionPlanApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**distributions_get**](DistributionPlanApi.md#distributions_get) | **GET** /distributions | 
[**distributions_id_delete**](DistributionPlanApi.md#distributions_id_delete) | **DELETE** /distributions/{id} | 
[**distributions_id_get**](DistributionPlanApi.md#distributions_id_get) | **GET** /distributions/{id} | 
[**distributions_id_put**](DistributionPlanApi.md#distributions_id_put) | **PUT** /distributions/{id} | 
[**distributions_post**](DistributionPlanApi.md#distributions_post) | **POST** /distributions | 
[**distributionsactiondistribute_list_put**](DistributionPlanApi.md#distributionsactiondistribute_list_put) | **PUT** /distributions?action&#x3D;distribute-list | 
[**distributionsactiondistribute_put**](DistributionPlanApi.md#distributionsactiondistribute_put) | **PUT** /distributions?action&#x3D;distribute | 
[**distributionsactiondistribute_with_date_and_type_put**](DistributionPlanApi.md#distributionsactiondistribute_with_date_and_type_put) | **PUT** /distributions?action&#x3D;distribute-with-date-and-type | 
[**distributionsactiondistribute_with_date_put**](DistributionPlanApi.md#distributionsactiondistribute_with_date_put) | **PUT** /distributions?action&#x3D;distribute-with-date | 
[**distributionsactiondistribute_with_type_put**](DistributionPlanApi.md#distributionsactiondistribute_with_type_put) | **PUT** /distributions?action&#x3D;distribute-with-type | 
[**distributionsactionentities_with_distribution_get**](DistributionPlanApi.md#distributionsactionentities_with_distribution_get) | **GET** /distributions?action&#x3D;entities-with-distribution | 
[**distributionsactionget_distributionplanelement_errormap_get**](DistributionPlanApi.md#distributionsactionget_distributionplanelement_errormap_get) | **GET** /distributions?action&#x3D;get-distributionplanelement-errormap | 
[**distributionsactionget_entitytype_distributionplans_get**](DistributionPlanApi.md#distributionsactionget_entitytype_distributionplans_get) | **GET** /distributions?action&#x3D;get-entitytype-distributionplans | 
[**distributionsactionget_entitytype_list_get**](DistributionPlanApi.md#distributionsactionget_entitytype_list_get) | **GET** /distributions?action&#x3D;get-entitytype-list | 
[**distributionsactionget_first_valid_distribution_get**](DistributionPlanApi.md#distributionsactionget_first_valid_distribution_get) | **GET** /distributions?action&#x3D;get-first-valid-distribution | 
[**distributionsactionget_legal_elementtypes_get**](DistributionPlanApi.md#distributionsactionget_legal_elementtypes_get) | **GET** /distributions?action&#x3D;get-legal-elementtypes | 
[**distributionsactionget_valid_distributions_for_customer_get**](DistributionPlanApi.md#distributionsactionget_valid_distributions_for_customer_get) | **GET** /distributions?action&#x3D;get-valid-distributions-for-customer | 
[**distributionsactionget_valid_distributions_get**](DistributionPlanApi.md#distributionsactionget_valid_distributions_get) | **GET** /distributions?action&#x3D;get-valid-distributions | 
[**distributionsactionis_valid_distribution_get**](DistributionPlanApi.md#distributionsactionis_valid_distribution_get) | **GET** /distributions?action&#x3D;is-valid-distribution | 

# **distributions_get**
> list[DistributionPlan] distributions_get()



Query DistributionPlan

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DistributionPlanApi()

try:
    api_response = api_instance.distributions_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DistributionPlanApi->distributions_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[DistributionPlan]**](DistributionPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **distributions_id_delete**
> DistributionPlan distributions_id_delete(id)



Delete DistributionPlan

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DistributionPlanApi()
id = 56 # int | 

try:
    api_response = api_instance.distributions_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DistributionPlanApi->distributions_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**DistributionPlan**](DistributionPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **distributions_id_get**
> DistributionPlan distributions_id_get(id)



Get DistributionPlan

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DistributionPlanApi()
id = 56 # int | 

try:
    api_response = api_instance.distributions_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DistributionPlanApi->distributions_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**DistributionPlan**](DistributionPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **distributions_id_put**
> DistributionPlan distributions_id_put(body, id)



Update DistributionPlan

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DistributionPlanApi()
body = swagger_client.DistributionPlan() # DistributionPlan | 
id = 56 # int | 

try:
    api_response = api_instance.distributions_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DistributionPlanApi->distributions_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DistributionPlan**](DistributionPlan.md)|  | 
 **id** | **int**|  | 

### Return type

[**DistributionPlan**](DistributionPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **distributions_post**
> DistributionPlan distributions_post(body)



Create DistributionPlan

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DistributionPlanApi()
body = swagger_client.DistributionPlan() # DistributionPlan | 

try:
    api_response = api_instance.distributions_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DistributionPlanApi->distributions_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DistributionPlan**](DistributionPlan.md)|  | 

### Return type

[**DistributionPlan**](DistributionPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **distributionsactiondistribute_list_put**
> object distributionsactiondistribute_list_put(ids, entity_type)



distribute-list Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DistributionPlanApi()
ids = swagger_client.Object() # Object | 
entity_type = swagger_client.Object() # Object | 

try:
    api_response = api_instance.distributionsactiondistribute_list_put(ids, entity_type)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DistributionPlanApi->distributionsactiondistribute_list_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**Object**](.md)|  | 
 **entity_type** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **distributionsactiondistribute_put**
> object distributionsactiondistribute_put(id, entity_type)



distribute Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DistributionPlanApi()
id = swagger_client.Object() # Object | 
entity_type = swagger_client.Object() # Object | 

try:
    api_response = api_instance.distributionsactiondistribute_put(id, entity_type)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DistributionPlanApi->distributionsactiondistribute_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 
 **entity_type** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **distributionsactiondistribute_with_date_and_type_put**
> object distributionsactiondistribute_with_date_and_type_put(id, entity_type, distribution_type, distribute_date)



distribute-with-date-and-type Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DistributionPlanApi()
id = swagger_client.Object() # Object | 
entity_type = swagger_client.Object() # Object | 
distribution_type = swagger_client.Object() # Object | 
distribute_date = swagger_client.Object() # Object | 

try:
    api_response = api_instance.distributionsactiondistribute_with_date_and_type_put(id, entity_type, distribution_type, distribute_date)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DistributionPlanApi->distributionsactiondistribute_with_date_and_type_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 
 **entity_type** | [**Object**](.md)|  | 
 **distribution_type** | [**Object**](.md)|  | 
 **distribute_date** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **distributionsactiondistribute_with_date_put**
> object distributionsactiondistribute_with_date_put(id, entity_type, distribute_date)



distribute-with-date Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DistributionPlanApi()
id = swagger_client.Object() # Object | 
entity_type = swagger_client.Object() # Object | 
distribute_date = swagger_client.Object() # Object | 

try:
    api_response = api_instance.distributionsactiondistribute_with_date_put(id, entity_type, distribute_date)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DistributionPlanApi->distributionsactiondistribute_with_date_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 
 **entity_type** | [**Object**](.md)|  | 
 **distribute_date** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **distributionsactiondistribute_with_type_put**
> object distributionsactiondistribute_with_type_put(id, entity_type, distribution_type, body=body)



distribute-with-type Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DistributionPlanApi()
id = swagger_client.Object() # Object | 
entity_type = swagger_client.Object() # Object | 
distribution_type = swagger_client.Object() # Object | 
body = swagger_client.EmailDTO() # EmailDTO |  (optional)

try:
    api_response = api_instance.distributionsactiondistribute_with_type_put(id, entity_type, distribution_type, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DistributionPlanApi->distributionsactiondistribute_with_type_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 
 **entity_type** | [**Object**](.md)|  | 
 **distribution_type** | [**Object**](.md)|  | 
 **body** | [**EmailDTO**](EmailDTO.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **distributionsactionentities_with_distribution_get**
> int distributionsactionentities_with_distribution_get(entity_ids, entity_type)



entities-with-distribution Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DistributionPlanApi()
entity_ids = swagger_client.Object() # Object | 
entity_type = swagger_client.Object() # Object | 

try:
    api_response = api_instance.distributionsactionentities_with_distribution_get(entity_ids, entity_type)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DistributionPlanApi->distributionsactionentities_with_distribution_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entity_ids** | [**Object**](.md)|  | 
 **entity_type** | [**Object**](.md)|  | 

### Return type

**int**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **distributionsactionget_distributionplanelement_errormap_get**
> object distributionsactionget_distributionplanelement_errormap_get()



get-distributionplanelement-errormap Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DistributionPlanApi()

try:
    api_response = api_instance.distributionsactionget_distributionplanelement_errormap_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DistributionPlanApi->distributionsactionget_distributionplanelement_errormap_get: %s\n" % e)
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

# **distributionsactionget_entitytype_distributionplans_get**
> list[DistributionPlan] distributionsactionget_entitytype_distributionplans_get(entity_type)



get-entitytype-distributionplans Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DistributionPlanApi()
entity_type = swagger_client.Object() # Object | 

try:
    api_response = api_instance.distributionsactionget_entitytype_distributionplans_get(entity_type)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DistributionPlanApi->distributionsactionget_entitytype_distributionplans_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entity_type** | [**Object**](.md)|  | 

### Return type

[**list[DistributionPlan]**](DistributionPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **distributionsactionget_entitytype_list_get**
> str distributionsactionget_entitytype_list_get()



get-entitytype-list Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DistributionPlanApi()

try:
    api_response = api_instance.distributionsactionget_entitytype_list_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DistributionPlanApi->distributionsactionget_entitytype_list_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **distributionsactionget_first_valid_distribution_get**
> DistributionPlanElementValidation distributionsactionget_first_valid_distribution_get(plan_id, invoice_id)



get-first-valid-distribution Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DistributionPlanApi()
plan_id = swagger_client.Object() # Object | 
invoice_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.distributionsactionget_first_valid_distribution_get(plan_id, invoice_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DistributionPlanApi->distributionsactionget_first_valid_distribution_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **plan_id** | [**Object**](.md)|  | 
 **invoice_id** | [**Object**](.md)|  | 

### Return type

[**DistributionPlanElementValidation**](DistributionPlanElementValidation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **distributionsactionget_legal_elementtypes_get**
> list[DistributionPlanElementType] distributionsactionget_legal_elementtypes_get(entity_type)



get-legal-elementtypes Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DistributionPlanApi()
entity_type = swagger_client.Object() # Object | 

try:
    api_response = api_instance.distributionsactionget_legal_elementtypes_get(entity_type)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DistributionPlanApi->distributionsactionget_legal_elementtypes_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entity_type** | [**Object**](.md)|  | 

### Return type

[**list[DistributionPlanElementType]**](DistributionPlanElementType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **distributionsactionget_valid_distributions_for_customer_get**
> list[DistributionPlanElementValidation] distributionsactionget_valid_distributions_for_customer_get(customer_id)



get-valid-distributions-for-customer Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DistributionPlanApi()
customer_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.distributionsactionget_valid_distributions_for_customer_get(customer_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DistributionPlanApi->distributionsactionget_valid_distributions_for_customer_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customer_id** | [**Object**](.md)|  | 

### Return type

[**list[DistributionPlanElementValidation]**](DistributionPlanElementValidation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **distributionsactionget_valid_distributions_get**
> list[DistributionPlanElementValidation] distributionsactionget_valid_distributions_get(plan_id, invoice_id)



get-valid-distributions Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DistributionPlanApi()
plan_id = swagger_client.Object() # Object | 
invoice_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.distributionsactionget_valid_distributions_get(plan_id, invoice_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DistributionPlanApi->distributionsactionget_valid_distributions_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **plan_id** | [**Object**](.md)|  | 
 **invoice_id** | [**Object**](.md)|  | 

### Return type

[**list[DistributionPlanElementValidation]**](DistributionPlanElementValidation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **distributionsactionis_valid_distribution_get**
> DistributionPlanElementValidation distributionsactionis_valid_distribution_get(invoice_id, plan_element_type)



is-valid-distribution Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DistributionPlanApi()
invoice_id = swagger_client.Object() # Object | 
plan_element_type = swagger_client.Object() # Object | 

try:
    api_response = api_instance.distributionsactionis_valid_distribution_get(invoice_id, plan_element_type)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DistributionPlanApi->distributionsactionis_valid_distribution_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoice_id** | [**Object**](.md)|  | 
 **plan_element_type** | [**Object**](.md)|  | 

### Return type

[**DistributionPlanElementValidation**](DistributionPlanElementValidation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

