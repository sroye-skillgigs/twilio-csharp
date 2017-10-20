/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Preview.HostedNumbers 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Fetch a specific AuthorizationDocument.
    /// </summary>
    public class FetchAuthorizationDocumentOptions : IOptions<AuthorizationDocumentResource> 
    {
        /// <summary>
        /// AuthorizationDocument sid.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchAuthorizationDocumentOptions
        /// </summary>
        /// <param name="pathSid"> AuthorizationDocument sid. </param>
        public FetchAuthorizationDocumentOptions(string pathSid)
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
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Updates a specific AuthorizationDocument.
    /// </summary>
    public class UpdateAuthorizationDocumentOptions : IOptions<AuthorizationDocumentResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A list of HostedNumberOrder sids.
        /// </summary>
        public List<string> HostedNumberOrderSids { get; set; }
        /// <summary>
        /// Address sid.
        /// </summary>
        public string AddressSid { get; set; }
        /// <summary>
        /// Email.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// A list of emails.
        /// </summary>
        public List<string> CcEmails { get; set; }
        /// <summary>
        /// The Status of this AuthorizationDocument.
        /// </summary>
        public AuthorizationDocumentResource.StatusEnum Status { get; set; }

        /// <summary>
        /// Construct a new UpdateAuthorizationDocumentOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public UpdateAuthorizationDocumentOptions(string pathSid)
        {
            PathSid = pathSid;
            HostedNumberOrderSids = new List<string>();
            CcEmails = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (HostedNumberOrderSids != null)
            {
                p.AddRange(HostedNumberOrderSids.Select(prop => new KeyValuePair<string, string>("HostedNumberOrderSids", prop)));
            }

            if (AddressSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AddressSid", AddressSid.ToString()));
            }

            if (Email != null)
            {
                p.Add(new KeyValuePair<string, string>("Email", Email));
            }

            if (CcEmails != null)
            {
                p.AddRange(CcEmails.Select(prop => new KeyValuePair<string, string>("CcEmails", prop)));
            }

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Retrieve a list of AuthorizationDocuments belonging to the account initiating the request.
    /// </summary>
    public class ReadAuthorizationDocumentOptions : ReadOptions<AuthorizationDocumentResource> 
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
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Create an AuthorizationDocument for authorizing the hosting of phone number capabilities on Twilio's platform.
    /// </summary>
    public class CreateAuthorizationDocumentOptions : IOptions<AuthorizationDocumentResource> 
    {
        /// <summary>
        /// A list of HostedNumberOrder sids.
        /// </summary>
        public List<string> HostedNumberOrderSids { get; }
        /// <summary>
        /// Address sid.
        /// </summary>
        public string AddressSid { get; }
        /// <summary>
        /// Email.
        /// </summary>
        public string Email { get; }
        /// <summary>
        /// A list of emails.
        /// </summary>
        public List<string> CcEmails { get; set; }

        /// <summary>
        /// Construct a new CreateAuthorizationDocumentOptions
        /// </summary>
        /// <param name="hostedNumberOrderSids"> A list of HostedNumberOrder sids. </param>
        /// <param name="addressSid"> Address sid. </param>
        /// <param name="email"> Email. </param>
        public CreateAuthorizationDocumentOptions(List<string> hostedNumberOrderSids, string addressSid, string email)
        {
            HostedNumberOrderSids = hostedNumberOrderSids;
            AddressSid = addressSid;
            Email = email;
            CcEmails = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (HostedNumberOrderSids != null)
            {
                p.AddRange(HostedNumberOrderSids.Select(prop => new KeyValuePair<string, string>("HostedNumberOrderSids", prop)));
            }

            if (AddressSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AddressSid", AddressSid.ToString()));
            }

            if (Email != null)
            {
                p.Add(new KeyValuePair<string, string>("Email", Email));
            }

            if (CcEmails != null)
            {
                p.AddRange(CcEmails.Select(prop => new KeyValuePair<string, string>("CcEmails", prop)));
            }

            return p;
        }
    }

}