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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;
namespace IO.Swagger.Model
{
    /// <summary>
    /// NrlFlate
    /// </summary>
    [DataContract]
        public partial class NrlFlate : Fellesegenskaper,  IEquatable<NrlFlate>, IValidatableObject, OneOfFellesegenskaper 
    {
        /// <summary>
        /// Defines FlateType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum FlateTypeEnum
        {
            /// <summary>
            /// Enum Kontaktledning for value: kontaktledning
            /// </summary>
            [EnumMember(Value = "kontaktledning")]
            Kontaktledning = 1,
            /// <summary>
            /// Enum Trafostasjon for value: trafostasjon
            /// </summary>
            [EnumMember(Value = "trafostasjon")]
            Trafostasjon = 2        }
        /// <summary>
        /// Gets or Sets FlateType
        /// </summary>
        [DataMember(Name="flateType", EmitDefaultValue=false)]
        public FlateTypeEnum? FlateType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NrlFlate" /> class.
        /// </summary>
        /// <param name="flateType">flateType.</param>
        public NrlFlate(FlateTypeEnum? flateType = default(FlateTypeEnum?), StatusEnum? status = default(StatusEnum?), Guid? komponentident = default(Guid?), Komponentreferanse referanse = default(Komponentreferanse), string navn = default(string), double? vertikalAvstand = default(double?), string geometristreng = default(string), LuftfartshindermerkingEnum? luftfartshindermerking = default(LuftfartshindermerkingEnum?), LuftfartshinderlyssettingEnum? luftfartshinderlyssetting = default(LuftfartshinderlyssettingEnum?), MaterialeEnum? materiale = default(MaterialeEnum?), DateTime? datafangstdato = default(DateTime?), Kvalitet kvalitet = default(Kvalitet), string informasjon = default(string), VerifisertRapporteringsnyaktighetEnum? verifisertRapporteringsnyaktighet = default(VerifisertRapporteringsnyaktighetEnum?), HydereferanseEnum? hydereferanse = default(HydereferanseEnum?), string featureType = default(string)) : base(status, komponentident, referanse, navn, vertikalAvstand, geometristreng, luftfartshindermerking, luftfartshinderlyssetting, materiale, datafangstdato, kvalitet, informasjon, verifisertRapporteringsnyaktighet, hydereferanse, featureType)
        {
            this.FlateType = flateType;
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NrlFlate {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  FlateType: ").Append(FlateType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NrlFlate);
        }

        /// <summary>
        /// Returns true if NrlFlate instances are equal
        /// </summary>
        /// <param name="input">Instance of NrlFlate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NrlFlate input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.FlateType == input.FlateType ||
                    (this.FlateType != null &&
                    this.FlateType.Equals(input.FlateType))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.FlateType != null)
                    hashCode = hashCode * 59 + this.FlateType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}