# IO.Swagger - the C# library for the Nasjonalt Register over Luftfartshindre

## Autentisering Finn autoriserings token her: [https://nrl-test.kartverket.no/token/](https://nrl-test.kartverket.no/token/)   Trykk \"Authorize\" og skriv inn `Bearer <token>`  ## Kontakt oss Spørsmål kan sendes til [nrl@kartverket.no](mailto:nrl@kartverket.no) ## Annen dokumentasjon [Introduksjon til NRL](https://www.kartverket.no/geodataarbeid/nrl)   [SOSI-standardisert produktspesifikasjon - NRL rapportering](https://sosi.geonorge.no/produktspesifikasjoner/NRL-rapportering/)   [NRL - webklient](https://nrl-test.kartverket.no) 

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 0.6.59
- SDK version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            // Configure API key authorization: Authorization
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to */nrl*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*KodelisterApi* | [**All**](docs/KodelisterApi.md#all) | **GET** /api/ekstern/koder/ | Hent alle Kodelister.
*KodelisterApi* | [**HentKodeListe**](docs/KodelisterApi.md#hentkodeliste) | **GET** /api/ekstern/koder/{kodelistenavn} | Hent koder for oppgitt kodeliste.
*NRLRettigheterApi* | [**HentTilgjengeligeEiere**](docs/NRLRettigheterApi.md#henttilgjengeligeeiere) | **GET** /api/ekstern/rettigheter/eier | Hent eiere som bruker kan representere
*NrlRapporteringApi* | [**Features**](docs/NrlRapporteringApi.md#features) | **PUT** /api/ekstern/nrl_rapportering/features | Oppdater objekter med nullstilte verdier.
*NrlRapporteringApi* | [**Features1**](docs/NrlRapporteringApi.md#features1) | **POST** /api/ekstern/nrl_rapportering/features | Oppdater eller meld inn nye objekter.
*NrlRapporteringApi* | [**Features2**](docs/NrlRapporteringApi.md#features2) | **GET** /api/ekstern/nrl_rapportering/features | Hent hindre som features

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Crs](docs/Crs.md)
 - [Model.CrsProperties](docs/CrsProperties.md)
 - [Model.EierApiDto](docs/EierApiDto.md)
 - [Model.ErrorDetailDto](docs/ErrorDetailDto.md)
 - [Model.ErrorDto](docs/ErrorDto.md)
 - [Model.Feature](docs/Feature.md)
 - [Model.FeatureCollection](docs/FeatureCollection.md)
 - [Model.Fellesegenskaper](docs/Fellesegenskaper.md)
 - [Model.Geometry](docs/Geometry.md)
 - [Model.KodeDTO](docs/KodeDTO.md)
 - [Model.KoderDTO](docs/KoderDTO.md)
 - [Model.Komponentreferanse](docs/Komponentreferanse.md)
 - [Model.Kvalitet](docs/Kvalitet.md)
 - [Model.LineString](docs/LineString.md)
 - [Model.NrlFlate](docs/NrlFlate.md)
 - [Model.NrlLinje](docs/NrlLinje.md)
 - [Model.NrlLuftspenn](docs/NrlLuftspenn.md)
 - [Model.NrlMast](docs/NrlMast.md)
 - [Model.NrlPunkt](docs/NrlPunkt.md)
 - [Model.OneOfFellesegenskaper](docs/OneOfFellesegenskaper.md)
 - [Model.OneOfGeometry](docs/OneOfGeometry.md)
 - [Model.Point](docs/Point.md)
 - [Model.Polygon](docs/Polygon.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Authorization"></a>
### Authorization

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

