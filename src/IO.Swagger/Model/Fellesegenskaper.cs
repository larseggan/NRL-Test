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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;
namespace IO.Swagger.Model
{
    /// <summary>
    /// Fellesegenskaper
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "FeatureType")]
    [JsonSubtypes.KnownSubType(typeof(NrlPunkt), "NrlPunkt")]
    [JsonSubtypes.KnownSubType(typeof(NrlLinje), "NrlLinje")]
    [JsonSubtypes.KnownSubType(typeof(NrlLuftspenn), "NrlLuftspenn")]
    [JsonSubtypes.KnownSubType(typeof(NrlMast), "NrlMast")]
    [JsonSubtypes.KnownSubType(typeof(NrlFlate), "NrlFlate")]
        public partial class Fellesegenskaper :  IEquatable<Fellesegenskaper>, IValidatableObject, OneOfFellesegenskaper 
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum Eksisterende for value: eksisterende
            /// </summary>
            [EnumMember(Value = "eksisterende")]
            Eksisterende = 1,
            /// <summary>
            /// Enum Fjernet for value: fjernet
            /// </summary>
            [EnumMember(Value = "fjernet")]
            Fjernet = 2,
            /// <summary>
            /// Enum PlanlagtFjernet for value: planlagtFjernet
            /// </summary>
            [EnumMember(Value = "planlagtFjernet")]
            PlanlagtFjernet = 3,
            /// <summary>
            /// Enum PlanlagtOppfrt for value: planlagtOppført
            /// </summary>
            [EnumMember(Value = "planlagtOppført")]
            PlanlagtOppfrt = 4        }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Defines Luftfartshindermerking
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum LuftfartshindermerkingEnum
        {
            /// <summary>
            /// Enum Fargemerking for value: fargemerking
            /// </summary>
            [EnumMember(Value = "fargemerking")]
            Fargemerking = 1,
            /// <summary>
            /// Enum Markr for value: markør
            /// </summary>
            [EnumMember(Value = "markør")]
            Markr = 2        }
        /// <summary>
        /// Gets or Sets Luftfartshindermerking
        /// </summary>
        [DataMember(Name="luftfartshindermerking", EmitDefaultValue=false)]
        public LuftfartshindermerkingEnum? Luftfartshindermerking { get; set; }
        /// <summary>
        /// Defines Luftfartshinderlyssetting
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum LuftfartshinderlyssettingEnum
        {
            /// <summary>
            /// Enum BelystMedFlomlys for value: belystMedFlomlys
            /// </summary>
            [EnumMember(Value = "belystMedFlomlys")]
            BelystMedFlomlys = 1,
            /// <summary>
            /// Enum BlinkendeHvitt for value: blinkendeHvitt
            /// </summary>
            [EnumMember(Value = "blinkendeHvitt")]
            BlinkendeHvitt = 2,
            /// <summary>
            /// Enum BlinkendeRdt for value: blinkendeRødt
            /// </summary>
            [EnumMember(Value = "blinkendeRødt")]
            BlinkendeRdt = 3,
            /// <summary>
            /// Enum FastHvitt for value: fastHvitt
            /// </summary>
            [EnumMember(Value = "fastHvitt")]
            FastHvitt = 4,
            /// <summary>
            /// Enum FastRdt for value: fastRødt
            /// </summary>
            [EnumMember(Value = "fastRødt")]
            FastRdt = 5,
            /// <summary>
            /// Enum HyintensitetTypeA for value: høyintensitetTypeA
            /// </summary>
            [EnumMember(Value = "høyintensitetTypeA")]
            HyintensitetTypeA = 6,
            /// <summary>
            /// Enum HyintensitetTypeB for value: høyintensitetTypeB
            /// </summary>
            [EnumMember(Value = "høyintensitetTypeB")]
            HyintensitetTypeB = 7,
            /// <summary>
            /// Enum LavintensitetTypeA for value: lavintensitetTypeA
            /// </summary>
            [EnumMember(Value = "lavintensitetTypeA")]
            LavintensitetTypeA = 8,
            /// <summary>
            /// Enum LavintensitetTypeB for value: lavintensitetTypeB
            /// </summary>
            [EnumMember(Value = "lavintensitetTypeB")]
            LavintensitetTypeB = 9,
            /// <summary>
            /// Enum Lyssatt for value: lyssatt
            /// </summary>
            [EnumMember(Value = "lyssatt")]
            Lyssatt = 10,
            /// <summary>
            /// Enum MellomintensitetTypeA for value: mellomintensitetTypeA
            /// </summary>
            [EnumMember(Value = "mellomintensitetTypeA")]
            MellomintensitetTypeA = 11,
            /// <summary>
            /// Enum MellomintensitetTypeB for value: mellomintensitetTypeB
            /// </summary>
            [EnumMember(Value = "mellomintensitetTypeB")]
            MellomintensitetTypeB = 12,
            /// <summary>
            /// Enum MellomintensitetTypeC for value: mellomintensitetTypeC
            /// </summary>
            [EnumMember(Value = "mellomintensitetTypeC")]
            MellomintensitetTypeC = 13        }
        /// <summary>
        /// Gets or Sets Luftfartshinderlyssetting
        /// </summary>
        [DataMember(Name="luftfartshinderlyssetting", EmitDefaultValue=false)]
        public LuftfartshinderlyssettingEnum? Luftfartshinderlyssetting { get; set; }
        /// <summary>
        /// Defines Materiale
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum MaterialeEnum
        {
            /// <summary>
            /// Enum Annet for value: annet
            /// </summary>
            [EnumMember(Value = "annet")]
            Annet = 1,
            /// <summary>
            /// Enum Betong for value: betong
            /// </summary>
            [EnumMember(Value = "betong")]
            Betong = 2,
            /// <summary>
            /// Enum Glass for value: glass
            /// </summary>
            [EnumMember(Value = "glass")]
            Glass = 3,
            /// <summary>
            /// Enum Metall for value: metall
            /// </summary>
            [EnumMember(Value = "metall")]
            Metall = 4,
            /// <summary>
            /// Enum Murstein for value: murstein
            /// </summary>
            [EnumMember(Value = "murstein")]
            Murstein = 5,
            /// <summary>
            /// Enum Stein for value: stein
            /// </summary>
            [EnumMember(Value = "stein")]
            Stein = 6,
            /// <summary>
            /// Enum Trevirke for value: trevirke
            /// </summary>
            [EnumMember(Value = "trevirke")]
            Trevirke = 7        }
        /// <summary>
        /// Gets or Sets Materiale
        /// </summary>
        [DataMember(Name="materiale", EmitDefaultValue=false)]
        public MaterialeEnum? Materiale { get; set; }
        /// <summary>
        /// Defines VerifisertRapporteringsnyaktighet
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum VerifisertRapporteringsnyaktighetEnum
        {
            /// <summary>
            /// Enum _2023010151 for value: 20230101_5-1
            /// </summary>
            [EnumMember(Value = "20230101_5-1")]
            _2023010151 = 1,
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            [EnumMember(Value = "0")]
            _0 = 2        }
        /// <summary>
        /// Gets or Sets VerifisertRapporteringsnyaktighet
        /// </summary>
        [DataMember(Name="verifisertRapporteringsnøyaktighet", EmitDefaultValue=false)]
        public VerifisertRapporteringsnyaktighetEnum? VerifisertRapporteringsnyaktighet { get; set; }
        /// <summary>
        /// Defines Hydereferanse
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum HydereferanseEnum
        {
            /// <summary>
            /// Enum Fot for value: fot
            /// </summary>
            [EnumMember(Value = "fot")]
            Fot = 1,
            /// <summary>
            /// Enum Topp for value: topp
            /// </summary>
            [EnumMember(Value = "topp")]
            Topp = 2        }
        /// <summary>
        /// Gets or Sets Hydereferanse
        /// </summary>
        [DataMember(Name="høydereferanse", EmitDefaultValue=false)]
        public HydereferanseEnum? Hydereferanse { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Fellesegenskaper" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="komponentident">komponentident.</param>
        /// <param name="referanse">referanse.</param>
        /// <param name="navn">navn.</param>
        /// <param name="vertikalAvstand">vertikalAvstand.</param>
        /// <param name="geometristreng">geometristreng.</param>
        /// <param name="luftfartshindermerking">luftfartshindermerking.</param>
        /// <param name="luftfartshinderlyssetting">luftfartshinderlyssetting.</param>
        /// <param name="materiale">materiale.</param>
        /// <param name="datafangstdato">datafangstdato.</param>
        /// <param name="kvalitet">kvalitet.</param>
        /// <param name="informasjon">informasjon.</param>
        /// <param name="verifisertRapporteringsnyaktighet">verifisertRapporteringsnyaktighet.</param>
        /// <param name="hydereferanse">hydereferanse.</param>
        /// <param name="featureType">featureType (required).</param>
        public Fellesegenskaper(StatusEnum? status = default(StatusEnum?), Guid? komponentident = default(Guid?), Komponentreferanse referanse = default(Komponentreferanse), string navn = default(string), double? vertikalAvstand = default(double?), string geometristreng = default(string), LuftfartshindermerkingEnum? luftfartshindermerking = default(LuftfartshindermerkingEnum?), LuftfartshinderlyssettingEnum? luftfartshinderlyssetting = default(LuftfartshinderlyssettingEnum?), MaterialeEnum? materiale = default(MaterialeEnum?), DateTime? datafangstdato = default(DateTime?), Kvalitet kvalitet = default(Kvalitet), string informasjon = default(string), VerifisertRapporteringsnyaktighetEnum? verifisertRapporteringsnyaktighet = default(VerifisertRapporteringsnyaktighetEnum?), HydereferanseEnum? hydereferanse = default(HydereferanseEnum?), string featureType = default(string))
        {
            // to ensure "featureType" is required (not null)
            if (featureType == null)
            {
                throw new InvalidDataException("featureType is a required property for Fellesegenskaper and cannot be null");
            }
            else
            {
                this.FeatureType = featureType;
            }
            this.Status = status;
            this.Komponentident = komponentident;
            this.Referanse = referanse;
            this.Navn = navn;
            this.VertikalAvstand = vertikalAvstand;
            this.Geometristreng = geometristreng;
            this.Luftfartshindermerking = luftfartshindermerking;
            this.Luftfartshinderlyssetting = luftfartshinderlyssetting;
            this.Materiale = materiale;
            this.Datafangstdato = datafangstdato;
            this.Kvalitet = kvalitet;
            this.Informasjon = informasjon;
            this.VerifisertRapporteringsnyaktighet = verifisertRapporteringsnyaktighet;
            this.Hydereferanse = hydereferanse;
        }
        

        /// <summary>
        /// Gets or Sets Komponentident
        /// </summary>
        [DataMember(Name="komponentident", EmitDefaultValue=false)]
        public Guid? Komponentident { get; set; }

        /// <summary>
        /// Gets or Sets Referanse
        /// </summary>
        [DataMember(Name="referanse", EmitDefaultValue=false)]
        public Komponentreferanse Referanse { get; set; }

        /// <summary>
        /// Gets or Sets Navn
        /// </summary>
        [DataMember(Name="navn", EmitDefaultValue=false)]
        public string Navn { get; set; }

        /// <summary>
        /// Gets or Sets VertikalAvstand
        /// </summary>
        [DataMember(Name="vertikalAvstand", EmitDefaultValue=false)]
        public double? VertikalAvstand { get; set; }

        /// <summary>
        /// Gets or Sets Geometristreng
        /// </summary>
        [DataMember(Name="geometristreng", EmitDefaultValue=false)]
        public string Geometristreng { get; set; }




        /// <summary>
        /// Gets or Sets Datafangstdato
        /// </summary>
        [DataMember(Name="datafangstdato", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? Datafangstdato { get; set; }

        /// <summary>
        /// Gets or Sets Kvalitet
        /// </summary>
        [DataMember(Name="kvalitet", EmitDefaultValue=false)]
        public Kvalitet Kvalitet { get; set; }

        /// <summary>
        /// Gets or Sets Informasjon
        /// </summary>
        [DataMember(Name="informasjon", EmitDefaultValue=false)]
        public string Informasjon { get; set; }



        /// <summary>
        /// Gets or Sets FeatureType
        /// </summary>
        [DataMember(Name="featureType", EmitDefaultValue=false)]
        public string FeatureType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Fellesegenskaper {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Komponentident: ").Append(Komponentident).Append("\n");
            sb.Append("  Referanse: ").Append(Referanse).Append("\n");
            sb.Append("  Navn: ").Append(Navn).Append("\n");
            sb.Append("  VertikalAvstand: ").Append(VertikalAvstand).Append("\n");
            sb.Append("  Geometristreng: ").Append(Geometristreng).Append("\n");
            sb.Append("  Luftfartshindermerking: ").Append(Luftfartshindermerking).Append("\n");
            sb.Append("  Luftfartshinderlyssetting: ").Append(Luftfartshinderlyssetting).Append("\n");
            sb.Append("  Materiale: ").Append(Materiale).Append("\n");
            sb.Append("  Datafangstdato: ").Append(Datafangstdato).Append("\n");
            sb.Append("  Kvalitet: ").Append(Kvalitet).Append("\n");
            sb.Append("  Informasjon: ").Append(Informasjon).Append("\n");
            sb.Append("  VerifisertRapporteringsnyaktighet: ").Append(VerifisertRapporteringsnyaktighet).Append("\n");
            sb.Append("  Hydereferanse: ").Append(Hydereferanse).Append("\n");
            sb.Append("  FeatureType: ").Append(FeatureType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as Fellesegenskaper);
        }

        /// <summary>
        /// Returns true if Fellesegenskaper instances are equal
        /// </summary>
        /// <param name="input">Instance of Fellesegenskaper to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Fellesegenskaper input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Komponentident == input.Komponentident ||
                    (this.Komponentident != null &&
                    this.Komponentident.Equals(input.Komponentident))
                ) && 
                (
                    this.Referanse == input.Referanse ||
                    (this.Referanse != null &&
                    this.Referanse.Equals(input.Referanse))
                ) && 
                (
                    this.Navn == input.Navn ||
                    (this.Navn != null &&
                    this.Navn.Equals(input.Navn))
                ) && 
                (
                    this.VertikalAvstand == input.VertikalAvstand ||
                    (this.VertikalAvstand != null &&
                    this.VertikalAvstand.Equals(input.VertikalAvstand))
                ) && 
                (
                    this.Geometristreng == input.Geometristreng ||
                    (this.Geometristreng != null &&
                    this.Geometristreng.Equals(input.Geometristreng))
                ) && 
                (
                    this.Luftfartshindermerking == input.Luftfartshindermerking ||
                    (this.Luftfartshindermerking != null &&
                    this.Luftfartshindermerking.Equals(input.Luftfartshindermerking))
                ) && 
                (
                    this.Luftfartshinderlyssetting == input.Luftfartshinderlyssetting ||
                    (this.Luftfartshinderlyssetting != null &&
                    this.Luftfartshinderlyssetting.Equals(input.Luftfartshinderlyssetting))
                ) && 
                (
                    this.Materiale == input.Materiale ||
                    (this.Materiale != null &&
                    this.Materiale.Equals(input.Materiale))
                ) && 
                (
                    this.Datafangstdato == input.Datafangstdato ||
                    (this.Datafangstdato != null &&
                    this.Datafangstdato.Equals(input.Datafangstdato))
                ) && 
                (
                    this.Kvalitet == input.Kvalitet ||
                    (this.Kvalitet != null &&
                    this.Kvalitet.Equals(input.Kvalitet))
                ) && 
                (
                    this.Informasjon == input.Informasjon ||
                    (this.Informasjon != null &&
                    this.Informasjon.Equals(input.Informasjon))
                ) && 
                (
                    this.VerifisertRapporteringsnyaktighet == input.VerifisertRapporteringsnyaktighet ||
                    (this.VerifisertRapporteringsnyaktighet != null &&
                    this.VerifisertRapporteringsnyaktighet.Equals(input.VerifisertRapporteringsnyaktighet))
                ) && 
                (
                    this.Hydereferanse == input.Hydereferanse ||
                    (this.Hydereferanse != null &&
                    this.Hydereferanse.Equals(input.Hydereferanse))
                ) && 
                (
                    this.FeatureType == input.FeatureType ||
                    (this.FeatureType != null &&
                    this.FeatureType.Equals(input.FeatureType))
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
                int hashCode = 41;
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Komponentident != null)
                    hashCode = hashCode * 59 + this.Komponentident.GetHashCode();
                if (this.Referanse != null)
                    hashCode = hashCode * 59 + this.Referanse.GetHashCode();
                if (this.Navn != null)
                    hashCode = hashCode * 59 + this.Navn.GetHashCode();
                if (this.VertikalAvstand != null)
                    hashCode = hashCode * 59 + this.VertikalAvstand.GetHashCode();
                if (this.Geometristreng != null)
                    hashCode = hashCode * 59 + this.Geometristreng.GetHashCode();
                if (this.Luftfartshindermerking != null)
                    hashCode = hashCode * 59 + this.Luftfartshindermerking.GetHashCode();
                if (this.Luftfartshinderlyssetting != null)
                    hashCode = hashCode * 59 + this.Luftfartshinderlyssetting.GetHashCode();
                if (this.Materiale != null)
                    hashCode = hashCode * 59 + this.Materiale.GetHashCode();
                if (this.Datafangstdato != null)
                    hashCode = hashCode * 59 + this.Datafangstdato.GetHashCode();
                if (this.Kvalitet != null)
                    hashCode = hashCode * 59 + this.Kvalitet.GetHashCode();
                if (this.Informasjon != null)
                    hashCode = hashCode * 59 + this.Informasjon.GetHashCode();
                if (this.VerifisertRapporteringsnyaktighet != null)
                    hashCode = hashCode * 59 + this.VerifisertRapporteringsnyaktighet.GetHashCode();
                if (this.Hydereferanse != null)
                    hashCode = hashCode * 59 + this.Hydereferanse.GetHashCode();
                if (this.FeatureType != null)
                    hashCode = hashCode * 59 + this.FeatureType.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}