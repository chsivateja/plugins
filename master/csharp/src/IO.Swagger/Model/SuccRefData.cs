/* 
 * Coinsecure Api Documentation
 *
 * To generate an API key, please visit <a href='https://coinsecure.in/api' target='_new' class='homeapi'>https://coinsecure.in/api</a>.<br>Guidelines for use can be accessed at <a href='https://api.coinsecure.in/v1/guidelines'>https://api.coinsecure.in/v1/guidelines</a>.<br>Programming Language Libraries for use can be accessed at <a href='https://api.coinsecure.in/v1/code-libraries'>https://api.coinsecure.in/v1/code-libraries</a>.
 *
 * OpenAPI spec version: beta
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
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

namespace IO.Swagger.Model
{
    /// <summary>
    /// SuccRefData
    /// </summary>
    [DataContract]
    public partial class SuccRefData :  IEquatable<SuccRefData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SuccRefData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SuccRefData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SuccRefData" /> class.
        /// </summary>
        /// <param name="RefPercent">RefPercent (required).</param>
        /// <param name="Time">Time (required).</param>
        /// <param name="RefID">RefID (required).</param>
        /// <param name="EmailVerified">EmailVerified (required) (default to false).</param>
        /// <param name="KycComplete">KycComplete (required) (default to false).</param>
        /// <param name="BtcEarned">BtcEarned (required).</param>
        /// <param name="FiatEarned">FiatEarned (required).</param>
        public SuccRefData(double? RefPercent = null, long? Time = null, string RefID = null, bool? EmailVerified = null, bool? KycComplete = null, long? BtcEarned = null, long? FiatEarned = null)
        {
            // to ensure "RefPercent" is required (not null)
            if (RefPercent == null)
            {
                throw new InvalidDataException("RefPercent is a required property for SuccRefData and cannot be null");
            }
            else
            {
                this.RefPercent = RefPercent;
            }
            // to ensure "Time" is required (not null)
            if (Time == null)
            {
                throw new InvalidDataException("Time is a required property for SuccRefData and cannot be null");
            }
            else
            {
                this.Time = Time;
            }
            // to ensure "RefID" is required (not null)
            if (RefID == null)
            {
                throw new InvalidDataException("RefID is a required property for SuccRefData and cannot be null");
            }
            else
            {
                this.RefID = RefID;
            }
            // to ensure "EmailVerified" is required (not null)
            if (EmailVerified == null)
            {
                throw new InvalidDataException("EmailVerified is a required property for SuccRefData and cannot be null");
            }
            else
            {
                this.EmailVerified = EmailVerified;
            }
            // to ensure "KycComplete" is required (not null)
            if (KycComplete == null)
            {
                throw new InvalidDataException("KycComplete is a required property for SuccRefData and cannot be null");
            }
            else
            {
                this.KycComplete = KycComplete;
            }
            // to ensure "BtcEarned" is required (not null)
            if (BtcEarned == null)
            {
                throw new InvalidDataException("BtcEarned is a required property for SuccRefData and cannot be null");
            }
            else
            {
                this.BtcEarned = BtcEarned;
            }
            // to ensure "FiatEarned" is required (not null)
            if (FiatEarned == null)
            {
                throw new InvalidDataException("FiatEarned is a required property for SuccRefData and cannot be null");
            }
            else
            {
                this.FiatEarned = FiatEarned;
            }
        }
        
        /// <summary>
        /// Gets or Sets RefPercent
        /// </summary>
        [DataMember(Name="refPercent", EmitDefaultValue=false)]
        public double? RefPercent { get; set; }
        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public long? Time { get; set; }
        /// <summary>
        /// Gets or Sets RefID
        /// </summary>
        [DataMember(Name="refID", EmitDefaultValue=false)]
        public string RefID { get; set; }
        /// <summary>
        /// Gets or Sets EmailVerified
        /// </summary>
        [DataMember(Name="emailVerified", EmitDefaultValue=false)]
        public bool? EmailVerified { get; set; }
        /// <summary>
        /// Gets or Sets KycComplete
        /// </summary>
        [DataMember(Name="kycComplete", EmitDefaultValue=false)]
        public bool? KycComplete { get; set; }
        /// <summary>
        /// Gets or Sets BtcEarned
        /// </summary>
        [DataMember(Name="btcEarned", EmitDefaultValue=false)]
        public long? BtcEarned { get; set; }
        /// <summary>
        /// Gets or Sets FiatEarned
        /// </summary>
        [DataMember(Name="fiatEarned", EmitDefaultValue=false)]
        public long? FiatEarned { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuccRefData {\n");
            sb.Append("  RefPercent: ").Append(RefPercent).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  RefID: ").Append(RefID).Append("\n");
            sb.Append("  EmailVerified: ").Append(EmailVerified).Append("\n");
            sb.Append("  KycComplete: ").Append(KycComplete).Append("\n");
            sb.Append("  BtcEarned: ").Append(BtcEarned).Append("\n");
            sb.Append("  FiatEarned: ").Append(FiatEarned).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as SuccRefData);
        }

        /// <summary>
        /// Returns true if SuccRefData instances are equal
        /// </summary>
        /// <param name="other">Instance of SuccRefData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuccRefData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RefPercent == other.RefPercent ||
                    this.RefPercent != null &&
                    this.RefPercent.Equals(other.RefPercent)
                ) && 
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
                ) && 
                (
                    this.RefID == other.RefID ||
                    this.RefID != null &&
                    this.RefID.Equals(other.RefID)
                ) && 
                (
                    this.EmailVerified == other.EmailVerified ||
                    this.EmailVerified != null &&
                    this.EmailVerified.Equals(other.EmailVerified)
                ) && 
                (
                    this.KycComplete == other.KycComplete ||
                    this.KycComplete != null &&
                    this.KycComplete.Equals(other.KycComplete)
                ) && 
                (
                    this.BtcEarned == other.BtcEarned ||
                    this.BtcEarned != null &&
                    this.BtcEarned.Equals(other.BtcEarned)
                ) && 
                (
                    this.FiatEarned == other.FiatEarned ||
                    this.FiatEarned != null &&
                    this.FiatEarned.Equals(other.FiatEarned)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.RefPercent != null)
                    hash = hash * 59 + this.RefPercent.GetHashCode();
                if (this.Time != null)
                    hash = hash * 59 + this.Time.GetHashCode();
                if (this.RefID != null)
                    hash = hash * 59 + this.RefID.GetHashCode();
                if (this.EmailVerified != null)
                    hash = hash * 59 + this.EmailVerified.GetHashCode();
                if (this.KycComplete != null)
                    hash = hash * 59 + this.KycComplete.GetHashCode();
                if (this.BtcEarned != null)
                    hash = hash * 59 + this.BtcEarned.GetHashCode();
                if (this.FiatEarned != null)
                    hash = hash * 59 + this.FiatEarned.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
