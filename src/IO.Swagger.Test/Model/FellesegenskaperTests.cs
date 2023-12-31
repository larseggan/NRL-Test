/* 
 * Nasjonalt Register over Luftfartshindre
 *
 * ## Autentisering Finn autoriserings token her: [https://nrl-test.kartverket.no/token/](https://nrl-test.kartverket.no/token/)   Trykk \"Authorize\" og skriv inn `Bearer <token>`  ## Kontakt oss Spørsmål kan sendes til [nrl@kartverket.no](mailto:nrl@kartverket.no) ## Annen dokumentasjon [Introduksjon til NRL](https://www.kartverket.no/geodataarbeid/nrl)   [SOSI-standardisert produktspesifikasjon - NRL rapportering](https://sosi.geonorge.no/produktspesifikasjoner/NRL-rapportering/)   [NRL - webklient](https://nrl-test.kartverket.no) 
 *
 * OpenAPI spec version: 0.6.59
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing Fellesegenskaper
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class FellesegenskaperTests
    {
        // TODO uncomment below to declare an instance variable for Fellesegenskaper
        //private Fellesegenskaper instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Fellesegenskaper
            //instance = new Fellesegenskaper();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Fellesegenskaper
        /// </summary>
        [Test]
        public void FellesegenskaperInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Fellesegenskaper
            //Assert.IsInstanceOfType<Fellesegenskaper> (instance, "variable 'instance' is a Fellesegenskaper");
        }

        /// <summary>
        /// Test deserialize a NrlPunkt from type Fellesegenskaper
        /// </summary>
        [Test]
        public void NrlPunktDeserializeFromFellesegenskaperTest()
        {
            // TODO uncomment below to test deserialize a NrlPunkt from type Fellesegenskaper
            //Assert.IsInstanceOf<Fellesegenskaper>(JsonConvert.DeserializeObject<Fellesegenskaper>(new NrlPunkt().ToJson()));
        }
        /// <summary>
        /// Test deserialize a NrlLinje from type Fellesegenskaper
        /// </summary>
        [Test]
        public void NrlLinjeDeserializeFromFellesegenskaperTest()
        {
            // TODO uncomment below to test deserialize a NrlLinje from type Fellesegenskaper
            //Assert.IsInstanceOf<Fellesegenskaper>(JsonConvert.DeserializeObject<Fellesegenskaper>(new NrlLinje().ToJson()));
        }
        /// <summary>
        /// Test deserialize a NrlLuftspenn from type Fellesegenskaper
        /// </summary>
        [Test]
        public void NrlLuftspennDeserializeFromFellesegenskaperTest()
        {
            // TODO uncomment below to test deserialize a NrlLuftspenn from type Fellesegenskaper
            //Assert.IsInstanceOf<Fellesegenskaper>(JsonConvert.DeserializeObject<Fellesegenskaper>(new NrlLuftspenn().ToJson()));
        }
        /// <summary>
        /// Test deserialize a NrlMast from type Fellesegenskaper
        /// </summary>
        [Test]
        public void NrlMastDeserializeFromFellesegenskaperTest()
        {
            // TODO uncomment below to test deserialize a NrlMast from type Fellesegenskaper
            //Assert.IsInstanceOf<Fellesegenskaper>(JsonConvert.DeserializeObject<Fellesegenskaper>(new NrlMast().ToJson()));
        }
        /// <summary>
        /// Test deserialize a NrlFlate from type Fellesegenskaper
        /// </summary>
        [Test]
        public void NrlFlateDeserializeFromFellesegenskaperTest()
        {
            // TODO uncomment below to test deserialize a NrlFlate from type Fellesegenskaper
            //Assert.IsInstanceOf<Fellesegenskaper>(JsonConvert.DeserializeObject<Fellesegenskaper>(new NrlFlate().ToJson()));
        }

        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'Komponentident'
        /// </summary>
        [Test]
        public void KomponentidentTest()
        {
            // TODO unit test for the property 'Komponentident'
        }
        /// <summary>
        /// Test the property 'Referanse'
        /// </summary>
        [Test]
        public void ReferanseTest()
        {
            // TODO unit test for the property 'Referanse'
        }
        /// <summary>
        /// Test the property 'Navn'
        /// </summary>
        [Test]
        public void NavnTest()
        {
            // TODO unit test for the property 'Navn'
        }
        /// <summary>
        /// Test the property 'VertikalAvstand'
        /// </summary>
        [Test]
        public void VertikalAvstandTest()
        {
            // TODO unit test for the property 'VertikalAvstand'
        }
        /// <summary>
        /// Test the property 'Geometristreng'
        /// </summary>
        [Test]
        public void GeometristrengTest()
        {
            // TODO unit test for the property 'Geometristreng'
        }
        /// <summary>
        /// Test the property 'Luftfartshindermerking'
        /// </summary>
        [Test]
        public void LuftfartshindermerkingTest()
        {
            // TODO unit test for the property 'Luftfartshindermerking'
        }
        /// <summary>
        /// Test the property 'Luftfartshinderlyssetting'
        /// </summary>
        [Test]
        public void LuftfartshinderlyssettingTest()
        {
            // TODO unit test for the property 'Luftfartshinderlyssetting'
        }
        /// <summary>
        /// Test the property 'Materiale'
        /// </summary>
        [Test]
        public void MaterialeTest()
        {
            // TODO unit test for the property 'Materiale'
        }
        /// <summary>
        /// Test the property 'Datafangstdato'
        /// </summary>
        [Test]
        public void DatafangstdatoTest()
        {
            // TODO unit test for the property 'Datafangstdato'
        }
        /// <summary>
        /// Test the property 'Kvalitet'
        /// </summary>
        [Test]
        public void KvalitetTest()
        {
            // TODO unit test for the property 'Kvalitet'
        }
        /// <summary>
        /// Test the property 'Informasjon'
        /// </summary>
        [Test]
        public void InformasjonTest()
        {
            // TODO unit test for the property 'Informasjon'
        }
        /// <summary>
        /// Test the property 'VerifisertRapporteringsnyaktighet'
        /// </summary>
        [Test]
        public void VerifisertRapporteringsnyaktighetTest()
        {
            // TODO unit test for the property 'VerifisertRapporteringsnyaktighet'
        }
        /// <summary>
        /// Test the property 'Hydereferanse'
        /// </summary>
        [Test]
        public void HydereferanseTest()
        {
            // TODO unit test for the property 'Hydereferanse'
        }
        /// <summary>
        /// Test the property 'FeatureType'
        /// </summary>
        [Test]
        public void FeatureTypeTest()
        {
            // TODO unit test for the property 'FeatureType'
        }

    }

}
