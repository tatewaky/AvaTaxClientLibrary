/* 
 * AvaTax API
 *
 * REST interface to Avalara's enterprise tax service, AvaTax.
 *
 * OpenAPI spec version: v2
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

namespace Avalara.AvaTax.RestClient.Model
{
    /// <summary>
    /// Represents an ISO 3166 recognized country
    /// </summary>
    [DataContract]
    public partial class IsoCountryModel :  IEquatable<IsoCountryModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsoCountryModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IsoCountryModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IsoCountryModel" /> class.
        /// </summary>
        /// <param name="Code">The two character ISO 3166 country code (required).</param>
        /// <param name="Name">The full name of this country as it is known in US English (required).</param>
        /// <param name="IsEuropeanUnion">True if this country is a member of the European Union.</param>
        public IsoCountryModel(string Code = null, string Name = null, bool? IsEuropeanUnion = null)
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for IsoCountryModel and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for IsoCountryModel and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.IsEuropeanUnion = IsEuropeanUnion;
        }
        
        /// <summary>
        /// The two character ISO 3166 country code
        /// </summary>
        /// <value>The two character ISO 3166 country code</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }
        /// <summary>
        /// The full name of this country as it is known in US English
        /// </summary>
        /// <value>The full name of this country as it is known in US English</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// True if this country is a member of the European Union
        /// </summary>
        /// <value>True if this country is a member of the European Union</value>
        [DataMember(Name="isEuropeanUnion", EmitDefaultValue=false)]
        public bool? IsEuropeanUnion { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IsoCountryModel {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsEuropeanUnion: ").Append(IsEuropeanUnion).Append("\n");
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
            return this.Equals(obj as IsoCountryModel);
        }

        /// <summary>
        /// Returns true if IsoCountryModel instances are equal
        /// </summary>
        /// <param name="other">Instance of IsoCountryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsoCountryModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.IsEuropeanUnion == other.IsEuropeanUnion ||
                    this.IsEuropeanUnion != null &&
                    this.IsEuropeanUnion.Equals(other.IsEuropeanUnion)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.IsEuropeanUnion != null)
                    hash = hash * 59 + this.IsEuropeanUnion.GetHashCode();
                return hash;
            }
        }
    }

}
