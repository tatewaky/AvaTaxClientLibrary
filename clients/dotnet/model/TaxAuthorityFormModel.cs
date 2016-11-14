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
    /// Represents a form that can be filed with a tax authority.
    /// </summary>
    [DataContract]
    public partial class TaxAuthorityFormModel :  IEquatable<TaxAuthorityFormModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxAuthorityFormModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaxAuthorityFormModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxAuthorityFormModel" /> class.
        /// </summary>
        /// <param name="TaxAuthorityId">The unique ID number of the tax authority. (required).</param>
        /// <param name="FormName">The form name of the form for this tax authority. (required).</param>
        public TaxAuthorityFormModel(int? TaxAuthorityId = null, string FormName = null)
        {
            // to ensure "TaxAuthorityId" is required (not null)
            if (TaxAuthorityId == null)
            {
                throw new InvalidDataException("TaxAuthorityId is a required property for TaxAuthorityFormModel and cannot be null");
            }
            else
            {
                this.TaxAuthorityId = TaxAuthorityId;
            }
            // to ensure "FormName" is required (not null)
            if (FormName == null)
            {
                throw new InvalidDataException("FormName is a required property for TaxAuthorityFormModel and cannot be null");
            }
            else
            {
                this.FormName = FormName;
            }
        }
        
        /// <summary>
        /// The unique ID number of the tax authority.
        /// </summary>
        /// <value>The unique ID number of the tax authority.</value>
        [DataMember(Name="taxAuthorityId", EmitDefaultValue=false)]
        public int? TaxAuthorityId { get; set; }
        /// <summary>
        /// The form name of the form for this tax authority.
        /// </summary>
        /// <value>The form name of the form for this tax authority.</value>
        [DataMember(Name="formName", EmitDefaultValue=false)]
        public string FormName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxAuthorityFormModel {\n");
            sb.Append("  TaxAuthorityId: ").Append(TaxAuthorityId).Append("\n");
            sb.Append("  FormName: ").Append(FormName).Append("\n");
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
            return this.Equals(obj as TaxAuthorityFormModel);
        }

        /// <summary>
        /// Returns true if TaxAuthorityFormModel instances are equal
        /// </summary>
        /// <param name="other">Instance of TaxAuthorityFormModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxAuthorityFormModel other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TaxAuthorityId == other.TaxAuthorityId ||
                    this.TaxAuthorityId != null &&
                    this.TaxAuthorityId.Equals(other.TaxAuthorityId)
                ) && 
                (
                    this.FormName == other.FormName ||
                    this.FormName != null &&
                    this.FormName.Equals(other.FormName)
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
                if (this.TaxAuthorityId != null)
                    hash = hash * 59 + this.TaxAuthorityId.GetHashCode();
                if (this.FormName != null)
                    hash = hash * 59 + this.FormName.GetHashCode();
                return hash;
            }
        }
    }

}