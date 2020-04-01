using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook.AspNetCore.Client.Models
{
    /// <summary>
    /// The options for the Facebook services.
    /// </summary>
    public class FacebookServicesOptions
    {
        /// <summary>
        /// Your application client id.
        /// </summary>
        /// 

        public string ClientId { get; set; }

        /// <summary>
        /// Your application client secret.
        /// </summary>
        /// 

        public string ClientSecret { get; set; }
    }
}
