# swagger_client.UserApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**users_get**](UserApi.md#users_get) | **GET** /users | 
[**users_id_delete**](UserApi.md#users_id_delete) | **DELETE** /users/{id} | 
[**users_id_get**](UserApi.md#users_id_get) | **GET** /users/{id} | 
[**users_id_put**](UserApi.md#users_id_put) | **PUT** /users/{id} | 
[**users_idactionactivate_post**](UserApi.md#users_idactionactivate_post) | **POST** /users/{id}?action&#x3D;activate | 
[**users_idactioninactivate_post**](UserApi.md#users_idactioninactivate_post) | **POST** /users/{id}?action&#x3D;inactivate | 
[**users_idactionmake_autobank_user_put**](UserApi.md#users_idactionmake_autobank_user_put) | **PUT** /users/{id}?action&#x3D;make-autobank-user | 
[**users_idactionreset_autobank_password_post**](UserApi.md#users_idactionreset_autobank_password_post) | **POST** /users/{id}?action&#x3D;reset-autobank-password | 
[**users_post**](UserApi.md#users_post) | **POST** /users | 
[**usersactionaccept_customer_agreement_post**](UserApi.md#usersactionaccept_customer_agreement_post) | **POST** /users?action&#x3D;accept-CustomerAgreement | 
[**usersactionaccept_user_license_agreement_post**](UserApi.md#usersactionaccept_user_license_agreement_post) | **POST** /users?action&#x3D;accept-UserLicenseAgreement | 
[**usersactionadd_user_post**](UserApi.md#usersactionadd_user_post) | **POST** /users?action&#x3D;add-user | 
[**usersactionadminusers_get**](UserApi.md#usersactionadminusers_get) | **GET** /users?action&#x3D;adminusers | 
[**usersactionchange_autobank_password_put**](UserApi.md#usersactionchange_autobank_password_put) | **PUT** /users?action&#x3D;change-autobank-password | 
[**usersactioncurrent_roles_get**](UserApi.md#usersactioncurrent_roles_get) | **GET** /users?action&#x3D;current-roles | 
[**usersactioncurrent_session_get**](UserApi.md#usersactioncurrent_session_get) | **GET** /users?action&#x3D;current-session | 
[**usersactionself_reset_autobank_password_put**](UserApi.md#usersactionself_reset_autobank_password_put) | **PUT** /users?action&#x3D;self-reset-autobank-password | 
[**usersactionsubjectandemail_get**](UserApi.md#usersactionsubjectandemail_get) | **GET** /users?action&#x3D;subjectandemail | 

# **users_get**
> list[User] users_get()



Query User

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserApi()

try:
    api_response = api_instance.users_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserApi->users_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[User]**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **users_id_delete**
> User users_id_delete(id)



Delete User

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserApi()
id = 56 # int | 

try:
    api_response = api_instance.users_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserApi->users_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **users_id_get**
> User users_id_get(id)



Get User

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserApi()
id = 56 # int | 

try:
    api_response = api_instance.users_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserApi->users_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **users_id_put**
> User users_id_put(body, id)



Update User

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserApi()
body = swagger_client.User() # User | 
id = 56 # int | 

try:
    api_response = api_instance.users_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserApi->users_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**User**](User.md)|  | 
 **id** | **int**|  | 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **users_idactionactivate_post**
> object users_idactionactivate_post(id, id)



activate Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.users_idactionactivate_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserApi->users_idactionactivate_post: %s\n" % e)
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

# **users_idactioninactivate_post**
> object users_idactioninactivate_post(id, id)



inactivate Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.users_idactioninactivate_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserApi->users_idactioninactivate_post: %s\n" % e)
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

# **users_idactionmake_autobank_user_put**
> object users_idactionmake_autobank_user_put(id2, id, body=body)



make-autobank-user Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserApi()
id2 = 56 # int | 
id = swagger_client.Object() # Object | 
body = swagger_client.CreateBankUserDTO() # CreateBankUserDTO |  (optional)

try:
    api_response = api_instance.users_idactionmake_autobank_user_put(id2, id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserApi->users_idactionmake_autobank_user_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id2** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **body** | [**CreateBankUserDTO**](CreateBankUserDTO.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **users_idactionreset_autobank_password_post**
> object users_idactionreset_autobank_password_post(id, id)



reset-autobank-password Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.users_idactionreset_autobank_password_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserApi->users_idactionreset_autobank_password_post: %s\n" % e)
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

# **users_post**
> User users_post(body)



Create User

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserApi()
body = swagger_client.User() # User | 

try:
    api_response = api_instance.users_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserApi->users_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**User**](User.md)|  | 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usersactionaccept_customer_agreement_post**
> object usersactionaccept_customer_agreement_post()



accept-CustomerAgreement Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserApi()

try:
    api_response = api_instance.usersactionaccept_customer_agreement_post()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserApi->usersactionaccept_customer_agreement_post: %s\n" % e)
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

# **usersactionaccept_user_license_agreement_post**
> object usersactionaccept_user_license_agreement_post()



accept-UserLicenseAgreement Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserApi()

try:
    api_response = api_instance.usersactionaccept_user_license_agreement_post()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserApi->usersactionaccept_user_license_agreement_post: %s\n" % e)
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

# **usersactionadd_user_post**
> User usersactionadd_user_post(global_identity, supportuser)



add-user Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserApi()
global_identity = swagger_client.Object() # Object | 
supportuser = swagger_client.Object() # Object | 

try:
    api_response = api_instance.usersactionadd_user_post(global_identity, supportuser)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserApi->usersactionadd_user_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **global_identity** | [**Object**](.md)|  | 
 **supportuser** | [**Object**](.md)|  | 

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usersactionadminusers_get**
> list[User] usersactionadminusers_get()



adminusers Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserApi()

try:
    api_response = api_instance.usersactionadminusers_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserApi->usersactionadminusers_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[User]**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usersactionchange_autobank_password_put**
> object usersactionchange_autobank_password_put(body=body)



change-autobank-password Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserApi()
body = swagger_client.ChangeAutobankPasswordDTO() # ChangeAutobankPasswordDTO |  (optional)

try:
    api_response = api_instance.usersactionchange_autobank_password_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserApi->usersactionchange_autobank_password_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ChangeAutobankPasswordDTO**](ChangeAutobankPasswordDTO.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usersactioncurrent_roles_get**
> object usersactioncurrent_roles_get()



current-roles Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserApi()

try:
    api_response = api_instance.usersactioncurrent_roles_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserApi->usersactioncurrent_roles_get: %s\n" % e)
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

# **usersactioncurrent_session_get**
> UserDto usersactioncurrent_session_get()



current-session Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserApi()

try:
    api_response = api_instance.usersactioncurrent_session_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserApi->usersactioncurrent_session_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UserDto**](UserDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usersactionself_reset_autobank_password_put**
> object usersactionself_reset_autobank_password_put()



self-reset-autobank-password Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserApi()

try:
    api_response = api_instance.usersactionself_reset_autobank_password_put()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserApi->usersactionself_reset_autobank_password_put: %s\n" % e)
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

# **usersactionsubjectandemail_get**
> object usersactionsubjectandemail_get()



subjectandemail Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserApi()

try:
    api_response = api_instance.usersactionsubjectandemail_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserApi->usersactionsubjectandemail_get: %s\n" % e)
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

