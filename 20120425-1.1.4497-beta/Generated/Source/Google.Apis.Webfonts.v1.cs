//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5448
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Webfonts.v1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class Webfont {
        
        private string _family;
        
        private string _kind;
        
        private string _subsets;
        
        private string _variants;
        
        /// <summary>The name of the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("family")]
        public virtual string Family {
            get {
                return this._family;
            }
            set {
                this._family = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this._kind;
            }
            set {
                this._kind = value;
            }
        }
        
        /// <summary>The scripts supported by the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subsets")]
        public virtual string Subsets {
            get {
                return this._subsets;
            }
            set {
                this._subsets = value;
            }
        }
        
        /// <summary>The available variants for the font.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("variants")]
        public virtual string Variants {
            get {
                return this._variants;
            }
            set {
                this._variants = value;
            }
        }
    }
    
    public class WebfontList : Google.Apis.Requests.IDirectResponseSchema {
        
        private System.Collections.Generic.IList<Webfont> _items;
        
        private string _kind;
        
        private Google.Apis.Requests.RequestError _Error;
        
        private string _ETag;
        
        /// <summary>The list of fonts currently served by the Google Fonts API.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Webfont> Items {
            get {
                return this._items;
            }
            set {
                this._items = value;
            }
        }
        
        /// <summary>The object kind.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this._kind;
            }
            set {
                this._kind = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this._Error;
            }
            set {
                this._Error = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this._ETag;
            }
            set {
                this._ETag = value;
            }
        }
    }
}
namespace Google.Apis.Webfonts.v1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public partial class WebfontsService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string DiscoveryDocument = "{\"kind\":\"discovery#restDescription\",\"discoveryVersion\":\"v1\",\"id\":\"webfonts:v1\",\"n" +
            "ame\":\"webfonts\",\"version\":\"v1\",\"revision\":\"20111110\",\"title\":\"Google Web Fonts D" +
            "eveloper API\",\"description\":\"The Google Web Fonts Developer API.\",\"icons\":{\"x16\"" +
            ":\"http://www.google.com/images/icons/feature/font_api-16.png\",\"x32\":\"http://www." +
            "google.com/images/icons/feature/font_api-32.gif\"},\"documentationLink\":\"http://co" +
            "de.google.com/apis/webfonts/docs/developer_api.html\",\"protocol\":\"rest\",\"baseUrl\"" +
            ":\"https://www.googleapis.com/webfonts/v1/\",\"basePath\":\"/webfonts/v1/\",\"rootUrl\":" +
            "\"https://www.googleapis.com/\",\"servicePath\":\"webfonts/v1/\",\"batchPath\":\"batch\",\"" +
            "parameters\":{\"alt\":{\"type\":\"string\",\"description\":\"Data format for the response." +
            "\",\"default\":\"json\",\"enum\":[\"json\"],\"enumDescriptions\":[\"Responses with Content-T" +
            "ype of application/json\"],\"location\":\"query\"},\"fields\":{\"type\":\"string\",\"descrip" +
            "tion\":\"Selector specifying which fields to include in a partial response.\",\"loca" +
            "tion\":\"query\"},\"key\":{\"type\":\"string\",\"description\":\"API key. Your API key ident" +
            "ifies your project and provides you with API access, quota, and reports. Require" +
            "d unless you provide an OAuth 2.0 token.\",\"location\":\"query\"},\"oauth_token\":{\"ty" +
            "pe\":\"string\",\"description\":\"OAuth 2.0 token for the current user.\",\"location\":\"q" +
            "uery\"},\"prettyPrint\":{\"type\":\"boolean\",\"description\":\"Returns response with inde" +
            "ntations and line breaks.\",\"default\":\"true\",\"location\":\"query\"},\"quotaUser\":{\"ty" +
            "pe\":\"string\",\"description\":\"Available to use for quota purposes for server-side " +
            "applications. Can be any arbitrary string assigned to a user, but should not exc" +
            "eed 40 characters. Overrides userIp if both are provided.\",\"location\":\"query\"},\"" +
            "userIp\":{\"type\":\"string\",\"description\":\"IP address of the site where the request" +
            " originates. Use this if you want to enforce per-user limits.\",\"location\":\"query" +
            "\"}},\"schemas\":{\"Webfont\":{\"id\":\"Webfont\",\"type\":\"object\",\"properties\":{\"family\":" +
            "{\"type\":\"any\",\"description\":\"The name of the font.\"},\"kind\":{\"type\":\"string\",\"de" +
            "fault\":\"webfonts#webfont\"},\"subsets\":{\"type\":\"any\",\"description\":\"The scripts su" +
            "pported by the font.\"},\"variants\":{\"type\":\"any\",\"description\":\"The available var" +
            "iants for the font.\"}}},\"WebfontList\":{\"id\":\"WebfontList\",\"type\":\"object\",\"prope" +
            "rties\":{\"items\":{\"type\":\"array\",\"description\":\"The list of fonts currently serve" +
            "d by the Google Fonts API.\",\"items\":{\"$ref\":\"Webfont\"}},\"kind\":{\"type\":\"string\"," +
            "\"description\":\"The object kind.\",\"default\":\"webfonts#webfontList\"}}}},\"resources" +
            "\":{\"webfonts\":{\"methods\":{\"list\":{\"id\":\"webfonts.webfonts.list\",\"path\":\"webfonts" +
            "\",\"httpMethod\":\"GET\",\"description\":\"Retrieves the list of fonts currently served" +
            " by the Google Web Fonts Developer API\",\"parameters\":{\"sort\":{\"type\":\"string\",\"d" +
            "escription\":\"Enables sorting of the list\",\"enum\":[\"alpha\",\"date\",\"popularity\",\"s" +
            "tyle\",\"trending\"],\"enumDescriptions\":[\"Sort alphabetically\",\"Sort by date added\"" +
            ",\"Sort by popularity\",\"Sort by number of styles\",\"Sort by trending\"],\"location\":" +
            "\"query\"}},\"response\":{\"$ref\":\"WebfontList\"}}}}}}";
        
        private const string Version = "v1";
        
        private const string Name = "webfonts";
        
        private const string BaseUri = "https://www.googleapis.com/webfonts/v1/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string _Key;
        
        protected WebfontsService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this._webfonts = new WebfontsResource(this);
        }
        
        public WebfontsService() : 
                this(Google.Apis.Authentication.NullAuthenticator.Instance) {
        }
        
        public WebfontsService(Google.Apis.Authentication.IAuthenticator authenticator) : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.StringDiscoveryDevice(DiscoveryDocument)).GetService(WebfontsService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameters(new System.Uri(WebfontsService.BaseUri))), authenticator) {
        }
        
        /// <summary>Sets the API-Key (or DeveloperKey) which this service uses for all requests</summary>
        public virtual string Key {
            get {
                return this._Key;
            }
            set {
                this._Key = value;
            }
        }
        
        public virtual Google.Apis.Requests.IRequest CreateRequest(string resource, string method) {
            Google.Apis.Requests.IRequest request = this.genericService.CreateRequest(resource, method);
            if ((string.IsNullOrEmpty(Key) == false)) {
                request = request.WithKey(this.Key);
            }
            return request.WithAuthentication(authenticator);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            genericService.Serializer = serializer;
        }
        
        public virtual string SerializeObject(object obj) {
            return genericService.SerializeRequest(obj);
        }
        
        public virtual T DeserializeResponse<T>(Google.Apis.Requests.IResponse response)
         {
            return genericService.DeserializeResponse<T>(response);
        }
    }
    
    public class WebfontsResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "webfonts";
        
        public WebfontsResource(WebfontsService service) {
            this.service = service;
        }
        
        /// <summary>Retrieves the list of fonts currently served by the Google Web Fonts Developer API</summary>
        public virtual ListRequest List() {
            return new ListRequest(service);
        }
        
        /// <summary>Enables sorting of the list</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Sort {
            
            /// <summary>Sort alphabetically</summary>
            [Google.Apis.Util.StringValueAttribute("alpha")]
            Alpha,
            
            /// <summary>Sort by date added</summary>
            [Google.Apis.Util.StringValueAttribute("date")]
            Date,
            
            /// <summary>Sort by popularity</summary>
            [Google.Apis.Util.StringValueAttribute("popularity")]
            Popularity,
            
            /// <summary>Sort by number of styles</summary>
            [Google.Apis.Util.StringValueAttribute("style")]
            Style,
            
            /// <summary>Sort by trending</summary>
            [Google.Apis.Util.StringValueAttribute("trending")]
            Trending,
        }
        
        public class ListRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Webfonts.v1.Data.WebfontList> {
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private string _quotaUser;
            
            private System.Nullable<Sort> _sort;
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service) : 
                    base(service) {
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token")]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint")]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser")]
            public virtual string QuotaUser {
                get {
                    return this._quotaUser;
                }
                set {
                    this._quotaUser = value;
                }
            }
            
            /// <summary>Enables sorting of the list</summary>
            [Google.Apis.Util.RequestParameterAttribute("sort")]
            public virtual System.Nullable<Sort> Sort {
                get {
                    return this._sort;
                }
                set {
                    this._sort = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "webfonts";
                }
            }
            
            protected override string MethodName {
                get {
                    return "list";
                }
            }
        }
    }
    
    public partial class WebfontsService {
        
        private const string Resource = "";
        
        private WebfontsResource _webfonts;
        
        private Google.Apis.Discovery.IRequestProvider service {
            get {
                return this;
            }
        }
        
        public virtual WebfontsResource Webfonts {
            get {
                return this._webfonts;
            }
        }
    }
}
