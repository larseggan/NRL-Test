/* 
 * Nasjonalt Register over Luftfartshindre
 *
 * ## Autentisering Finn autoriserings token her: [https://nrl-test.kartverket.no/token/](https://nrl-test.kartverket.no/token/)   Trykk \"Authorize\" og skriv inn `Bearer <token>`  ## Kontakt oss Spørsmål kan sendes til [nrl@kartverket.no](mailto:nrl@kartverket.no) ## Annen dokumentasjon [Introduksjon til NRL](https://www.kartverket.no/geodataarbeid/nrl)   [SOSI-standardisert produktspesifikasjon - NRL rapportering](https://sosi.geonorge.no/produktspesifikasjoner/NRL-rapportering/)   [NRL - webklient](https://nrl-test.kartverket.no) 
 *
 * OpenAPI spec version: 0.6.59
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Security;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing NrlRapporteringApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class NrlRapporteringApiTests
    {
        private NrlRapporteringApi instance;
        
        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new NrlRapporteringApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NrlRapporteringApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' NrlRapporteringApi
            Assert.IsInstanceOfType(typeof(NrlRapporteringApi), instance, "instance is a NrlRapporteringApi");
        }

        /// <summary>
        /// Test Features - Oppdater objekter med nullstilte verdier. (PUT)
        /// </summary>
        [Test]
        public void FeaturesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FeatureCollection body = null;
            //Lars
            //string eierIdString = "1df7163c-592e-4593-818b-6f4ca6ae746d"; //null;
            //Guid? eierId = "1df7163c-592e-4593-818b-6f4ca6ae746d"; // null;
            //Guid eierId = new Guid(eierIdString);
            //var response = instance.Features(body, eierId);
            //Assert.IsInstanceOf<FeatureCollection> (response, "response is FeatureCollection");
        }

        /// <summary>
        /// Test Features1 - Oppdater eller meld inn nye objekter (POST)
        /// Sletter også ved å sette status=Fjernet
        /// CRUD: CREATE, READ, UPDATE and DELETE
        /// </summary>
        [Test]
        public void FeaturesPostTest()
        {
            // Lars

            // Les inn en json-fil med test for nytt nrlPunkt. 
            // og serializer til FeatureCollection,
            // Sett body til denne.
            // Husk å sette ny komponentident verdi (Guid)

            Console.WriteLine("=================");
            Console.WriteLine("Nytt objekt");
            Console.WriteLine("=================");
            var path = @"Examples\";
            var featCollection =  ReadFeature(path + "NrlPunkt.json");
            Console.WriteLine("FeaturesPostChangesTest før endring lest fra fil:{0}", featCollection.ToJson());

            // Må sette et 3D koordinatsystem
            var epsg = "5942";//"4937";
            var crs = new Crs("name", new CrsProperties("EPSG:"+epsg));
            featCollection.Crs = crs;

            var komponentIdent = Guid.NewGuid();
            foreach (var feature in featCollection.Features)
            {
                // in this test we only have one feature
                feature.Properties.Komponentident = komponentIdent; //Guid.NewGuid();
                feature.Properties.Navn = "Lars1";
                feature.Properties.Status = Fellesegenskaper.StatusEnum.PlanlagtOppfrt;
                
                List<double?> coords = new List<double?>()  {11.0, 78.0, 0.0};
                var newPoint = new Point(coords, crs, "Point");
               
                feature.Geometry.Crs = crs;
                feature.Geometry = newPoint;
            }
            Console.WriteLine("FeaturesPostTest etter endring før post nytt objekt :{0}", featCollection.ToJson());

            Guid eierId = GetEierId();

            FeatureCollection body = featCollection;
            var response = instance.Features1(body, eierId);
            Assert.IsInstanceOf<FeatureCollection> (response, "response is FeatureCollection");
            Console.WriteLine("FeaturesPostTest etter endring etter post nytt objekt :{0}", response.ToJson());

            Console.WriteLine();
            Console.WriteLine("Henter det nye objektet med komponentIdent:{0}", komponentIdent.ToString("D"));
            GetOneFeatureForEierId(komponentId:komponentIdent.ToString("D"), crs:epsg);

            Console.WriteLine("=================");
            Console.WriteLine("Oppdaterer objekt");
            Console.WriteLine("=================");

            //
            // Oppdater objekt
            //
            featCollection = response;
            foreach (var feature in featCollection.Features)
            {
                // in this test we only have one feature
                feature.Properties.Komponentident = komponentIdent;
                feature.Properties.Navn = "Lars2";
                feature.Properties.Status = Fellesegenskaper.StatusEnum.Eksisterende;
            }
            body = featCollection;
            response = instance.Features1(body, eierId);
            Console.WriteLine("FeaturesPostTest etter endring etter post oppdatert objekt :{0}", response.ToJson());

            Console.WriteLine("=================");
            Console.WriteLine("sletter objekt");
            Console.WriteLine("=================");
            
            //
            // slett objekt
            //
            featCollection = response;
            foreach (var feature in featCollection.Features)
            {
                // in this test we only have one feature
                feature.Properties.Komponentident = komponentIdent;
                feature.Properties.Status = Fellesegenskaper.StatusEnum.Fjernet;
            }
            body = featCollection;
            response = instance.Features1(body, eierId);
            Console.WriteLine("FeaturesPostTest etter endring etter post slett(Fjernet) objekt :{0}", response.ToJson());

        }

        [Test]
        public void FeaturesAssosiasjonPostTest()
        {
            Console.WriteLine("=================");
            Console.WriteLine("Test assosiasjon mellom mast og mastepunkt, flytter en NrlMast");
            Console.WriteLine("Hensikten er å teste om NRL API validerer/sjekker dette");
            Console.WriteLine("=================");


            var featCollection = GetOneFeatureForEierId(komponentId: "0d2d4b36-8037-42fa-8f98-4ffe3e864d9e", crs: "5942"); // NrlMast
            // var featCollection = GetOneFeatureForEierId(komponentId: "0d2d4b36-8037-42fa-8f98-4ffe3e864d9e", crs: "5942"); // NrlLuftspenn

            Console.WriteLine("FeaturesAssosiasjonPostTest før endring:{0}", featCollection.ToJson());
            var deltaX = 0.005;
            

            //var komponentIdent = Guid.NewGuid();
            foreach (var feature in featCollection.Features)
            {
                // in this test we only have one feature
                
                feature.Properties.Navn = "LarsAss1";
                feature.Properties.Informasjon = "TestLars1";
                feature.Properties.Status = Fellesegenskaper.StatusEnum.Eksisterende;

                var point = (Point)feature.Geometry;
                point.Coordinates[0] += deltaX;

                feature.Geometry = point;
            }
            FeatureCollection body = featCollection;
            Guid eierId = GetEierId();
            var response = instance.Features1(body, eierId);
            Console.WriteLine("FeaturesAssosiasjonPostTest etter endring:{0}", response.ToJson());




            // Flytter tilbake punktet
            foreach (var feature in featCollection.Features)
            {
                // in this test we only have one feature

                feature.Properties.Navn = "LarsAss1";
                feature.Properties.Informasjon = "TestLars1";
                feature.Properties.Status = Fellesegenskaper.StatusEnum.Eksisterende;

                var point = (Point)feature.Geometry;
                point.Coordinates[0] -= deltaX;

                feature.Geometry = point;
            }
            body = featCollection;
            response = instance.Features1(body, eierId);

            Console.WriteLine("FeaturesAssosiasjonPostTest etter endring flyttet tilbake:{0}", response.ToJson());
            Console.WriteLine("Flytting av NrlMast viser at dette ikke valideres i assosiasjon");
        }


        /// <summary>
        /// Test Features2  Hent hindre som features
        /// </summary>
        [Test]
        //public void Features2Test()
        public void GetFeaturesForEierIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Lars:
            Guid eierId = GetEierId();
            string CRS = "4326";
            string objekttype = null;
            Guid? id = null;
            string bbox = null;
            var response = instance.Features2(eierId, CRS, objekttype, id, bbox);
            Assert.IsInstanceOf<FeatureCollection>(response, "response is FeatureCollection");

            Console.WriteLine("GetFeaturesForEierIdTest reponse:{0}", response.ToJson());

        }

        [Test]
        public void GetOneFeatureForEierIdTest()
        {

            GetOneFeatureForEierId(komponentId:"0d2d4b36-8037-42fa-8f98-4ffe3e864d9e");

        }

        public FeatureCollection GetOneFeatureForEierId(string komponentId = "0d2d4b36-8037-42fa-8f98-4ffe3e864d9e", string crs = "5972")
        {
            //Lars:
            Guid eierId = GetEierId();
            //string CRS = "5972"; // UTM 32
            string objekttype = null;
            Guid? id = new Guid(komponentId);// null;
            // NrlPunkt "d692c8f5-a38a-4531-a759-43a824ee5b36"


            string bbox = null;
            var response = instance.Features2(eierId, crs, objekttype, id, bbox);
            Assert.IsInstanceOf<FeatureCollection>(response, "response is FeatureCollection");

            // Console.WriteLine("Features2Test reponse:{0}", response.ToString());
            Console.WriteLine("GetOneFeatureForEierId reponse:{0}", response.ToJson());
            return response;
        }

        private static Guid GetEierId(string eierIdString = "1df7163c-592e-4593-818b-6f4ca6ae746d")
        {
            Guid eierId = new Guid(eierIdString);
            return eierId;
        }

        protected static FeatureCollection ReadFeature(string path)
        {
            var text = System.IO.File.ReadAllText(path);
            return JsonConvert.DeserializeObject<FeatureCollection>(text);
        }
    }

}
