# IO.Swagger.Api.NrlRapporteringApi

All URIs are relative to */nrl*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Features**](NrlRapporteringApi.md#features) | **PUT** /api/ekstern/nrl_rapportering/features | Oppdater objekter med nullstilte verdier.
[**Features1**](NrlRapporteringApi.md#features1) | **POST** /api/ekstern/nrl_rapportering/features | Oppdater eller meld inn nye objekter.
[**Features2**](NrlRapporteringApi.md#features2) | **GET** /api/ekstern/nrl_rapportering/features | Hent hindre som features

<a name="features"></a>
# **Features**
> FeatureCollection Features (FeatureCollection body, Guid? eierId)

Oppdater objekter med nullstilte verdier.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FeaturesExample
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NrlRapporteringApi();
            var body = new FeatureCollection(); // FeatureCollection | 
            var eierId = new Guid?(); // Guid? | 

            try
            {
                // Oppdater objekter med nullstilte verdier.
                FeatureCollection result = apiInstance.Features(body, eierId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NrlRapporteringApi.Features: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FeatureCollection**](FeatureCollection.md)|  | 
 **eierId** | [**Guid?**](Guid?.md)|  | 

### Return type

[**FeatureCollection**](FeatureCollection.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="features1"></a>
# **Features1**
> FeatureCollection Features1 (FeatureCollection body, Guid? eierId)

Oppdater eller meld inn nye objekter.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Features1Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NrlRapporteringApi();
            var body = new FeatureCollection(); // FeatureCollection | 
            var eierId = new Guid?(); // Guid? | 

            try
            {
                // Oppdater eller meld inn nye objekter.
                FeatureCollection result = apiInstance.Features1(body, eierId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NrlRapporteringApi.Features1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FeatureCollection**](FeatureCollection.md)|  | 
 **eierId** | [**Guid?**](Guid?.md)|  | 

### Return type

[**FeatureCollection**](FeatureCollection.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="features2"></a>
# **Features2**
> FeatureCollection Features2 (Guid? eierId, string CRS, string objekttype = null, Guid? id = null, string bbox = null)

Hent hindre som features

Søk kan gjøres med enkeltfelter.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Features2Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new NrlRapporteringApi();
            var eierId = new Guid?(); // Guid? | Hent tilgjengelige hinder tilknyttet oppgitt eierId
            var CRS = CRS_example;  // string | Velg Koordinatsystem.
            var objekttype = objekttype_example;  // string | Velg en kategori av luftfartshindre, default er å returnere alle tilgjengelige typer. (optional) 
            var id = new Guid?(); // Guid? | Hente ett spesifikt hinder med oppgitt komponentident. (optional) 
            var bbox = bbox_example;  // string | Bounding box, eksempelvis: 'EPSG:4326 10.10 59.90, 10.62 60.28' (optional) 

            try
            {
                // Hent hindre som features
                FeatureCollection result = apiInstance.Features2(eierId, CRS, objekttype, id, bbox);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NrlRapporteringApi.Features2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eierId** | [**Guid?**](Guid?.md)| Hent tilgjengelige hinder tilknyttet oppgitt eierId | 
 **CRS** | **string**| Velg Koordinatsystem. | 
 **objekttype** | **string**| Velg en kategori av luftfartshindre, default er å returnere alle tilgjengelige typer. | [optional] 
 **id** | [**Guid?**](Guid?.md)| Hente ett spesifikt hinder med oppgitt komponentident. | [optional] 
 **bbox** | **string**| Bounding box, eksempelvis: &#x27;EPSG:4326 10.10 59.90, 10.62 60.28&#x27; | [optional] 

### Return type

[**FeatureCollection**](FeatureCollection.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
