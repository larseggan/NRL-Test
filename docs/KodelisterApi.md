# IO.Swagger.Api.KodelisterApi

All URIs are relative to */nrl*

Method | HTTP request | Description
------------- | ------------- | -------------
[**All**](KodelisterApi.md#all) | **GET** /api/ekstern/koder/ | Hent alle Kodelister.
[**HentKodeListe**](KodelisterApi.md#hentkodeliste) | **GET** /api/ekstern/koder/{kodelistenavn} | Hent koder for oppgitt kodeliste.

<a name="all"></a>
# **All**
> KoderDTO All ()

Hent alle Kodelister.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AllExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new KodelisterApi();

            try
            {
                // Hent alle Kodelister.
                KoderDTO result = apiInstance.All();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KodelisterApi.All: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**KoderDTO**](KoderDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="hentkodeliste"></a>
# **HentKodeListe**
> KodeDTO HentKodeListe (string kodelistenavn)

Hent koder for oppgitt kodeliste.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HentKodeListeExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new KodelisterApi();
            var kodelistenavn = kodelistenavn_example;  // string | 

            try
            {
                // Hent koder for oppgitt kodeliste.
                KodeDTO result = apiInstance.HentKodeListe(kodelistenavn);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling KodelisterApi.HentKodeListe: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kodelistenavn** | **string**|  | 

### Return type

[**KodeDTO**](KodeDTO.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
