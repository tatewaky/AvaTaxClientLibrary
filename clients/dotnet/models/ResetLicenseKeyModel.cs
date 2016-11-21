using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// Represents a license key reset request.
    /// </summary>
    public class ResetLicenseKeyModel
    {
        /// <summary>
        /// The primary key of the account ID to reset
        /// </summary>
        public Int32 accountId { get; set; }

        /// <summary>
        /// Set this value to true to reset the license key for this account.
        ///             This license key reset function will only work when called using the credentials of the account administrator of this account.
        /// </summary>
        public Boolean confirmResetLicenseKey { get; set; }


    }
}