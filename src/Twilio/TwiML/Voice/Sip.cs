/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Twilio.Types;

namespace Twilio.TwiML.Voice 
{

    /// <summary>
    /// Sip TwiML Noun
    /// </summary>
    public class Sip : TwiML 
    {
        public sealed class EventEnum : StringEnum 
        {
            private EventEnum(string value) : base(value) {}
            public EventEnum() {}
            public static implicit operator EventEnum(string value)
            {
                return new EventEnum(value);
            }

            public static readonly EventEnum Initiated = new EventEnum("initiated");
            public static readonly EventEnum Ringing = new EventEnum("ringing");
            public static readonly EventEnum Answered = new EventEnum("answered");
            public static readonly EventEnum Completed = new EventEnum("completed");
        }

        /// <summary>
        /// SIP URL
        /// </summary>
        public Uri SipUrl { get; set; }
        /// <summary>
        /// SIP Username
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// SIP Password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Action URL
        /// </summary>
        public Uri Url { get; set; }
        /// <summary>
        /// Action URL method
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; set; }
        /// <summary>
        /// Status callback events
        /// </summary>
        public List<Sip.EventEnum> StatusCallbackEvent { get; set; }
        /// <summary>
        /// Status callback URL
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// Status callback URL method
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }

        /// <summary>
        /// Create a new Sip
        /// </summary>
        /// <param name="sipUrl"> SIP URL, the body of the TwiML Element. </param>
        /// <param name="username"> SIP Username </param>
        /// <param name="password"> SIP Password </param>
        /// <param name="url"> Action URL </param>
        /// <param name="method"> Action URL method </param>
        /// <param name="statusCallbackEvent"> Status callback events </param>
        /// <param name="statusCallback"> Status callback URL </param>
        /// <param name="statusCallbackMethod"> Status callback URL method </param>
        public Sip(Uri sipUrl = null, 
                   string username = null, 
                   string password = null, 
                   Uri url = null, 
                   Twilio.Http.HttpMethod method = null, 
                   List<Sip.EventEnum> statusCallbackEvent = null, 
                   Uri statusCallback = null, 
                   Twilio.Http.HttpMethod statusCallbackMethod = null) : base("Sip")
        {
            this.SipUrl = sipUrl;
            this.Username = username;
            this.Password = password;
            this.Url = url;
            this.Method = method;
            this.StatusCallbackEvent = statusCallbackEvent;
            this.StatusCallback = statusCallback;
            this.StatusCallbackMethod = statusCallbackMethod;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.SipUrl != null ? this.SipUrl.AbsoluteUri.TrimEnd('/') : string.Empty;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.Username != null)
            {
                attributes.Add(new XAttribute("username", this.Username));
            }
            if (this.Password != null)
            {
                attributes.Add(new XAttribute("password", this.Password));
            }
            if (this.Url != null)
            {
                attributes.Add(new XAttribute("url", this.Url.AbsoluteUri.TrimEnd('/')));
            }
            if (this.Method != null)
            {
                attributes.Add(new XAttribute("method", this.Method.ToString()));
            }
            if (this.StatusCallbackEvent != null)
            {
                attributes.Add(new XAttribute("statusCallbackEvent", String.Join(" ", this.StatusCallbackEvent.Select(e => e.ToString()).ToArray())));
            }
            if (this.StatusCallback != null)
            {
                attributes.Add(new XAttribute("statusCallback", this.StatusCallback.AbsoluteUri.TrimEnd('/')));
            }
            if (this.StatusCallbackMethod != null)
            {
                attributes.Add(new XAttribute("statusCallbackMethod", this.StatusCallbackMethod.ToString()));
            }
            return attributes;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Sip Append(TwiML childElem)
        {
            return (Sip) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Sip SetOption(string key, object value)
        {
            return (Sip) base.SetOption(key, value);
        }
    }

}