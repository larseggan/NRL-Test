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
    /// NrlLinje
    /// </summary>
    [DataContract]
        public partial class NrlLinje : Fellesegenskaper,  IEquatable<NrlLinje>, IValidatableObject, OneOfFellesegenskaper 
    {
        /// <summary>
        /// Defines LinjeType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum LinjeTypeEnum
        {
            /// <summary>
            /// Enum Annet for value: annet
            /// </summary>
            [EnumMember(Value = "annet")]
            Annet = 1,
            /// <summary>
            /// Enum Bru for value: bru
            /// </summary>
            [EnumMember(Value = "bru")]
            Bru = 2,
            /// <summary>
            /// Enum Demning for value: demning
            /// </summary>
            [EnumMember(Value = "demning")]
            Demning = 3,
            /// <summary>
            /// Enum Gjerde for value: gjerde
            /// </summary>
            [EnumMember(Value = "gjerde")]
            Gjerde = 4        }
        /// <summary>
        /// Gets or Sets LinjeType
        /// </summary>
        [DataMember(Name="linjeType", EmitDefaultValue=false)]
        public LinjeTypeEnum? LinjeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NrlLinje" /> class.
        /// </summary>
        /// <param name="anleggsbredde">anleggsbredde.</param>
        /// <param name="linjeType">linjeType.</param>
        public NrlLinje(double? anleggsbredde = default(double?), LinjeTypeEnum? linjeType = default(LinjeTypeEnum?), StatusEnum? status = default(StatusEnum?), Guid? komponentident = default(Guid?), Komponentreferanse referanse = default(Komponentreferanse), string navn = default(string), double? vertikalAvstand = default(double?), string geometristreng = default(string), LuftfartshindermerkingEnum? luftfartshindermerking = default(LuftfartshindermerkingEnum?), LuftfartshinderlyssettingEnum? luftfartshinderlyssetting = default(LuftfartshinderlyssettingEnum?), MaterialeEnum? materiale = default(MaterialeEnum?), DateTime? datafangstdato = default(DateTime?), Kvalitet kvalitet = default(Kvalitet), string informasjon = default(string), VerifisertRapporteringsnyaktighetEnum? verifisertRapporteringsnyaktighet = default(VerifisertRapporteringsnyaktighetEnum?), HydereferanseEnum? hydereferanse = default(HydereferanseEnum?), string featureType = default(string)) : base(status, komponentident, referanse, navn, vertikalAvstand, geometristreng, luftfartshindermerking, luftfartshinderlyssetting, materiale, datafangstdato, kvalitet, informasjon, verifisertRapporteringsnyaktighet, hydereferanse, featureType)
        {
            this.Anleggsbredde = anleggsbredde;
            this.LinjeType = linjeType;
        }
        
        /// <summary>
        /// Gets or Sets Anleggsbredde
        /// </summary>
        [DataMember(Name="anleggsbredde", EmitDefaultValue=false)]
        public double? Anleggsbredde { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NrlLinje {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Anleggsbredde: ").Append(Anleggsbredde).Append("\n");
            sb.Append("  LinjeType: ").Append(LinjeType).Append("\n");
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
            return this.Equals(input as NrlLinje);
        }

        /// <summary>
        /// Returns true if NrlLinje instances are equal
        /// </summary>
        /// <param name="input">Instance of NrlLinje to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NrlLinje input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Anleggsbredde == input.Anleggsbredde ||
                    (this.Anleggsbredde != null &&
                    this.Anleggsbredde.Equals(input.Anleggsbredde))
                ) && base.Equals(input) && 
                (
                    this.LinjeType == input.LinjeType ||
                    (this.LinjeType != null &&
                    this.LinjeType.Equals(input.LinjeType))
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
                if (this.Anleggsbredde != null)
                    hashCode = hashCode * 59 + this.Anleggsbredde.GetHashCode();
                if (this.LinjeType != null)
                    hashCode = hashCode * 59 + this.LinjeType.GetHashCode();
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
