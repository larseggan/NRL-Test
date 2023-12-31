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
    ///  Class for testing NrlMast
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class NrlMastTests
    {
        // TODO uncomment below to declare an instance variable for NrlMast
        //private NrlMast instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of NrlMast
            //instance = new NrlMast();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NrlMast
        /// </summary>
        [Test]
        public void NrlMastInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" NrlMast
            //Assert.IsInstanceOfType<NrlMast> (instance, "variable 'instance' is a NrlMast");
        }


        /// <summary>
        /// Test the property 'MastType'
        /// </summary>
        [Test]
        public void MastTypeTest()
        {
            // TODO unit test for the property 'MastType'
        }
        /// <summary>
        /// Test the property 'HorisontalAvstand'
        /// </summary>
        [Test]
        public void HorisontalAvstandTest()
        {
            // TODO unit test for the property 'HorisontalAvstand'
        }
        /// <summary>
        /// Test the property 'NrlLuftspenn'
        /// </summary>
        [Test]
        public void NrlLuftspennTest()
        {
            // TODO unit test for the property 'NrlLuftspenn'
        }

    }

}
