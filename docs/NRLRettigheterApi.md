# IO.Swagger.Api.NRLRettigheterApi

All URIs are relative to */nrl*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HentTilgjengeligeEiere**](NRLRettigheterApi.md#henttilgjengeligeeiere) | **GET** /api/ekstern/rettigheter/eier | Hent eiere som bruker kan representere

<a name="henttilgjengeligeeiere"></a>
# **HentTilgjengeligeEiere**
> List<EierApiDto> HentTilgjengeligeEiere ()

Hent eiere som bruker kan representere

Henter tilgjengelige eiere basert på innlogget bruker.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HentTilgjengeligeEiereExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NRLRettigheterApi();

            try
            {
                // Hent eiere som bruker kan representere
                List&lt;EierApiDto&gt; result = apiInstance.HentTilgjengeligeEiere();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NRLRettigheterApi.HentTilgjengeligeEiere: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<EierApiDto>**](EierApiDto.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
