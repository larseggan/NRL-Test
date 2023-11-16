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
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing KodelisterApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class KodelisterApiTests
    {
        private KodelisterApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new KodelisterApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of KodelisterApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' KodelisterApi
            Assert.IsInstanceOfType(typeof(KodelisterApi), instance, "instance is a KodelisterApi");
        }

        /// <summary>
        /// Test All
        /// </summary>
        [Test]
        public void AllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            var response = instance.All();
            Assert.IsInstanceOf<KoderDTO> (response, "response is KoderDTO");
        }
        /// <summary>
        /// Test HentKodeListe
        /// </summary>
        [Test]
        public void HentKodeListeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            string kodelistenavn = "Luftfartshinderlyssetting";// null;
            var response = instance.HentKodeListe(kodelistenavn);
            Assert.IsInstanceOf<KodeDTO> (response, "response is KodeDTO");
        }
    }

}
