using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace OAuthLib
{
    [DataContract]
    public class OAuthSettings
    {
        /// <summary>
        /// Gets or sets the OAuth signature method. Default to "HMAC-SHA1".
        /// </summary>
        public static string OAuthSignatureMethod = "HMAC-SHA1";

        /// <summary>
        /// Gets or sets the OAuth version. Default to "1.0".
        /// </summary>
        public static string OAuthVersion = "1.0";

        [DataMember]
        public string AppKey { get; set; }
        [DataMember]
        public string AppSecret { get; set; }
        [DataMember]
        public string RequestTokenUrl { get; set; }
        [DataMember]
        public string AccessTokenUrl { get; set; }
        [DataMember]
        public string AuthorizeUrl { get; set; }
        [DataMember]
        public string CallbackUrl { get; set; }
        [DataMember]
        public string QueryAccessTokenUrl { get; set; }
    }
}
