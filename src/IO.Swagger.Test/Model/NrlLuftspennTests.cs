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
    ///  Class for testing NrlLuftspenn
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class NrlLuftspennTests
    {
        // TODO uncomment below to declare an instance variable for NrlLuftspenn
        //private NrlLuftspenn instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of NrlLuftspenn
            //instance = new NrlLuftspenn();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NrlLuftspenn
        /// </summary>
        [Test]
        public void NrlLuftspennInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" NrlLuftspenn
            //Assert.IsInstanceOfType<NrlLuftspenn> (instance, "variable 'instance' is a NrlLuftspenn");
        }


        /// <summary>
        /// Test the property 'LuftspennType'
        /// </summary>
        [Test]
        public void LuftspennTypeTest()
        {
            // TODO unit test for the property 'LuftspennType'
        }
        /// <summary>
        /// Test the property 'Anleggsbredde'
        /// </summary>
        [Test]
        public void AnleggsbreddeTest()
        {
            // TODO unit test for the property 'Anleggsbredde'
        }
        /// <summary>
        /// Test the property 'Friseilingshyde'
        /// </summary>
        [Test]
        public void FriseilingshydeTest()
        {
            // TODO unit test for the property 'Friseilingshyde'
        }
        /// <summary>
        /// Test the property 'NrlMast'
        /// </summary>
        [Test]
        public void NrlMastTest()
        {
            // TODO unit test for the property 'NrlMast'
        }

    }

}
