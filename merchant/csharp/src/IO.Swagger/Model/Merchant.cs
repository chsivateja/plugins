/* 
 * coinMerchant Api Documentation
 *
 * To generate an API key, please visit <a href='https://pay.coinsecure.in/payment-tools/api' target='_new' class='homeapi'>https://pay.coinsecure.in/payment-tools/api</a>.<br>Guidelines for use can be accessed at <a href='https://pay.coinsecure.in/api/guidelines'>https://pay.coinsecure.in/api/guidelines</a>.
 *
 * OpenAPI spec version: 1.0B
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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Merchant
    /// </summary>
    [DataContract]
    public partial class Merchant :  IEquatable<Merchant>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Merchant" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Merchant() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Merchant" /> class.
        /// </summary>
        /// <param name="FirstName">FirstName (required).</param>
        /// <param name="LastName">LastName (required).</param>
        /// <param name="CoinBalance">CoinBalance (required).</param>
        /// <param name="FiatBalance">FiatBalance (required).</param>
        /// <param name="MerchantType">MerchantType (required).</param>
        /// <param name="Organization">Organization (required).</param>
        /// <param name="Status">Status (required).</param>
        /// <param name="Website">Website (required).</param>
        /// <param name="Address">Address (required).</param>
        /// <param name="AdminEmail">AdminEmail (required).</param>
        /// <param name="BusinessType">BusinessType (required).</param>
        /// <param name="Info">Info (required).</param>
        /// <param name="MinCoinSettlement">MinCoinSettlement (required).</param>
        /// <param name="MinFiatSettlement">MinFiatSettlement (required).</param>
        /// <param name="Tel">Tel (required).</param>
        public Merchant(string FirstName = null, string LastName = null, long? CoinBalance = null, long? FiatBalance = null, string MerchantType = null, string Organization = null, string Status = null, string Website = null, string Address = null, string AdminEmail = null, string BusinessType = null, string Info = null, long? MinCoinSettlement = null, long? MinFiatSettlement = null, string Tel = null)
        {
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for Merchant and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "LastName" is required (not null)
            if (LastName == null)
            {
                throw new InvalidDataException("LastName is a required property for Merchant and cannot be null");
            }
            else
            {
                this.LastName = LastName;
            }
            // to ensure "CoinBalance" is required (not null)
            if (CoinBalance == null)
            {
                throw new InvalidDataException("CoinBalance is a required property for Merchant and cannot be null");
            }
            else
            {
                this.CoinBalance = CoinBalance;
            }
            // to ensure "FiatBalance" is required (not null)
            if (FiatBalance == null)
            {
                throw new InvalidDataException("FiatBalance is a required property for Merchant and cannot be null");
            }
            else
            {
                this.FiatBalance = FiatBalance;
            }
            // to ensure "MerchantType" is required (not null)
            if (MerchantType == null)
            {
                throw new InvalidDataException("MerchantType is a required property for Merchant and cannot be null");
            }
            else
            {
                this.MerchantType = MerchantType;
            }
            // to ensure "Organization" is required (not null)
            if (Organization == null)
            {
                throw new InvalidDataException("Organization is a required property for Merchant and cannot be null");
            }
            else
            {
                this.Organization = Organization;
            }
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for Merchant and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "Website" is required (not null)
            if (Website == null)
            {
                throw new InvalidDataException("Website is a required property for Merchant and cannot be null");
            }
            else
            {
                this.Website = Website;
            }
            // to ensure "Address" is required (not null)
            if (Address == null)
            {
                throw new InvalidDataException("Address is a required property for Merchant and cannot be null");
            }
            else
            {
                this.Address = Address;
            }
            // to ensure "AdminEmail" is required (not null)
            if (AdminEmail == null)
            {
                throw new InvalidDataException("AdminEmail is a required property for Merchant and cannot be null");
            }
            else
            {
                this.AdminEmail = AdminEmail;
            }
            // to ensure "BusinessType" is required (not null)
            if (BusinessType == null)
            {
                throw new InvalidDataException("BusinessType is a required property for Merchant and cannot be null");
            }
            else
            {
                this.BusinessType = BusinessType;
            }
            // to ensure "Info" is required (not null)
            if (Info == null)
            {
                throw new InvalidDataException("Info is a required property for Merchant and cannot be null");
            }
            else
            {
                this.Info = Info;
            }
            // to ensure "MinCoinSettlement" is required (not null)
            if (MinCoinSettlement == null)
            {
                throw new InvalidDataException("MinCoinSettlement is a required property for Merchant and cannot be null");
            }
            else
            {
                this.MinCoinSettlement = MinCoinSettlement;
            }
            // to ensure "MinFiatSettlement" is required (not null)
            if (MinFiatSettlement == null)
            {
                throw new InvalidDataException("MinFiatSettlement is a required property for Merchant and cannot be null");
            }
            else
            {
                this.MinFiatSettlement = MinFiatSettlement;
            }
            // to ensure "Tel" is required (not null)
            if (Tel == null)
            {
                throw new InvalidDataException("Tel is a required property for Merchant and cannot be null");
            }
            else
            {
                this.Tel = Tel;
            }
        }
        
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// Gets or Sets CoinBalance
        /// </summary>
        [DataMember(Name="coinBalance", EmitDefaultValue=false)]
        public long? CoinBalance { get; set; }
        /// <summary>
        /// Gets or Sets FiatBalance
        /// </summary>
        [DataMember(Name="fiatBalance", EmitDefaultValue=false)]
        public long? FiatBalance { get; set; }
        /// <summary>
        /// Gets or Sets MerchantType
        /// </summary>
        [DataMember(Name="merchantType", EmitDefaultValue=false)]
        public string MerchantType { get; set; }
        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public string Organization { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name="website", EmitDefaultValue=false)]
        public string Website { get; set; }
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
        /// <summary>
        /// Gets or Sets AdminEmail
        /// </summary>
        [DataMember(Name="adminEmail", EmitDefaultValue=false)]
        public string AdminEmail { get; set; }
        /// <summary>
        /// Gets or Sets BusinessType
        /// </summary>
        [DataMember(Name="businessType", EmitDefaultValue=false)]
        public string BusinessType { get; set; }
        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name="info", EmitDefaultValue=false)]
        public string Info { get; set; }
        /// <summary>
        /// Gets or Sets MinCoinSettlement
        /// </summary>
        [DataMember(Name="minCoinSettlement", EmitDefaultValue=false)]
        public long? MinCoinSettlement { get; set; }
        /// <summary>
        /// Gets or Sets MinFiatSettlement
        /// </summary>
        [DataMember(Name="minFiatSettlement", EmitDefaultValue=false)]
        public long? MinFiatSettlement { get; set; }
        /// <summary>
        /// Gets or Sets Tel
        /// </summary>
        [DataMember(Name="tel", EmitDefaultValue=false)]
        public string Tel { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Merchant {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  CoinBalance: ").Append(CoinBalance).Append("\n");
            sb.Append("  FiatBalance: ").Append(FiatBalance).Append("\n");
            sb.Append("  MerchantType: ").Append(MerchantType).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AdminEmail: ").Append(AdminEmail).Append("\n");
            sb.Append("  BusinessType: ").Append(BusinessType).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  MinCoinSettlement: ").Append(MinCoinSettlement).Append("\n");
            sb.Append("  MinFiatSettlement: ").Append(MinFiatSettlement).Append("\n");
            sb.Append("  Tel: ").Append(Tel).Append("\n");
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
            return this.Equals(obj as Merchant);
        }

        /// <summary>
        /// Returns true if Merchant instances are equal
        /// </summary>
        /// <param name="other">Instance of Merchant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Merchant other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.CoinBalance == other.CoinBalance ||
                    this.CoinBalance != null &&
                    this.CoinBalance.Equals(other.CoinBalance)
                ) && 
                (
                    this.FiatBalance == other.FiatBalance ||
                    this.FiatBalance != null &&
                    this.FiatBalance.Equals(other.FiatBalance)
                ) && 
                (
                    this.MerchantType == other.MerchantType ||
                    this.MerchantType != null &&
                    this.MerchantType.Equals(other.MerchantType)
                ) && 
                (
                    this.Organization == other.Organization ||
                    this.Organization != null &&
                    this.Organization.Equals(other.Organization)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Website == other.Website ||
                    this.Website != null &&
                    this.Website.Equals(other.Website)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.AdminEmail == other.AdminEmail ||
                    this.AdminEmail != null &&
                    this.AdminEmail.Equals(other.AdminEmail)
                ) && 
                (
                    this.BusinessType == other.BusinessType ||
                    this.BusinessType != null &&
                    this.BusinessType.Equals(other.BusinessType)
                ) && 
                (
                    this.Info == other.Info ||
                    this.Info != null &&
                    this.Info.Equals(other.Info)
                ) && 
                (
                    this.MinCoinSettlement == other.MinCoinSettlement ||
                    this.MinCoinSettlement != null &&
                    this.MinCoinSettlement.Equals(other.MinCoinSettlement)
                ) && 
                (
                    this.MinFiatSettlement == other.MinFiatSettlement ||
                    this.MinFiatSettlement != null &&
                    this.MinFiatSettlement.Equals(other.MinFiatSettlement)
                ) && 
                (
                    this.Tel == other.Tel ||
                    this.Tel != null &&
                    this.Tel.Equals(other.Tel)
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
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.CoinBalance != null)
                    hash = hash * 59 + this.CoinBalance.GetHashCode();
                if (this.FiatBalance != null)
                    hash = hash * 59 + this.FiatBalance.GetHashCode();
                if (this.MerchantType != null)
                    hash = hash * 59 + this.MerchantType.GetHashCode();
                if (this.Organization != null)
                    hash = hash * 59 + this.Organization.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Website != null)
                    hash = hash * 59 + this.Website.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.AdminEmail != null)
                    hash = hash * 59 + this.AdminEmail.GetHashCode();
                if (this.BusinessType != null)
                    hash = hash * 59 + this.BusinessType.GetHashCode();
                if (this.Info != null)
                    hash = hash * 59 + this.Info.GetHashCode();
                if (this.MinCoinSettlement != null)
                    hash = hash * 59 + this.MinCoinSettlement.GetHashCode();
                if (this.MinFiatSettlement != null)
                    hash = hash * 59 + this.MinFiatSettlement.GetHashCode();
                if (this.Tel != null)
                    hash = hash * 59 + this.Tel.GetHashCode();
                return hash;
            }
        }
    }

}
