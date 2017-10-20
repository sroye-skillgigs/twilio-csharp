/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.IpMessaging.V2 
{

    /// <summary>
    /// ReadCredentialOptions
    /// </summary>
    public class ReadCredentialOptions : ReadOptions<CredentialResource> 
    {
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// CreateCredentialOptions
    /// </summary>
    public class CreateCredentialOptions : IOptions<CredentialResource> 
    {
        /// <summary>
        /// The type
        /// </summary>
        public CredentialResource.PushServiceEnum Type { get; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The certificate
        /// </summary>
        public string Certificate { get; set; }
        /// <summary>
        /// The private_key
        /// </summary>
        public string PrivateKey { get; set; }
        /// <summary>
        /// The sandbox
        /// </summary>
        public bool? Sandbox { get; set; }
        /// <summary>
        /// The api_key
        /// </summary>
        public string ApiKey { get; set; }
        /// <summary>
        /// The secret
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        /// Construct a new CreateCredentialOptions
        /// </summary>
        /// <param name="type"> The type </param>
        public CreateCredentialOptions(CredentialResource.PushServiceEnum type)
        {
            Type = type;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Type != null)
            {
                p.Add(new KeyValuePair<string, string>("Type", Type.ToString()));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Certificate != null)
            {
                p.Add(new KeyValuePair<string, string>("Certificate", Certificate));
            }

            if (PrivateKey != null)
            {
                p.Add(new KeyValuePair<string, string>("PrivateKey", PrivateKey));
            }

            if (Sandbox != null)
            {
                p.Add(new KeyValuePair<string, string>("Sandbox", Sandbox.Value.ToString().ToLower()));
            }

            if (ApiKey != null)
            {
                p.Add(new KeyValuePair<string, string>("ApiKey", ApiKey));
            }

            if (Secret != null)
            {
                p.Add(new KeyValuePair<string, string>("Secret", Secret));
            }

            return p;
        }
    }

    /// <summary>
    /// FetchCredentialOptions
    /// </summary>
    public class FetchCredentialOptions : IOptions<CredentialResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchCredentialOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public FetchCredentialOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// UpdateCredentialOptions
    /// </summary>
    public class UpdateCredentialOptions : IOptions<CredentialResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The certificate
        /// </summary>
        public string Certificate { get; set; }
        /// <summary>
        /// The private_key
        /// </summary>
        public string PrivateKey { get; set; }
        /// <summary>
        /// The sandbox
        /// </summary>
        public bool? Sandbox { get; set; }
        /// <summary>
        /// The api_key
        /// </summary>
        public string ApiKey { get; set; }
        /// <summary>
        /// The secret
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        /// Construct a new UpdateCredentialOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public UpdateCredentialOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Certificate != null)
            {
                p.Add(new KeyValuePair<string, string>("Certificate", Certificate));
            }

            if (PrivateKey != null)
            {
                p.Add(new KeyValuePair<string, string>("PrivateKey", PrivateKey));
            }

            if (Sandbox != null)
            {
                p.Add(new KeyValuePair<string, string>("Sandbox", Sandbox.Value.ToString().ToLower()));
            }

            if (ApiKey != null)
            {
                p.Add(new KeyValuePair<string, string>("ApiKey", ApiKey));
            }

            if (Secret != null)
            {
                p.Add(new KeyValuePair<string, string>("Secret", Secret));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteCredentialOptions
    /// </summary>
    public class DeleteCredentialOptions : IOptions<CredentialResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteCredentialOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public DeleteCredentialOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}