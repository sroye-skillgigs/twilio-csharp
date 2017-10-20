/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.IO;
using System.Text;
using System.Xml.Linq;
using Twilio.TwiML.Messaging;

namespace Twilio.TwiML 
{

    /// <summary>
    /// Response TwiML for Messages
    /// </summary>
    public class MessagingResponse : TwiML 
    {
        /// <summary>
        /// Create a new MessagingResponse
        /// </summary>
        public MessagingResponse() : base("Response")
        {
        }

        /// <summary>
        /// Append a <Message/> element as a child of this element
        /// </summary>
        /// <param name="message"> A Message instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public MessagingResponse Message(Message message)
        {
            this.Append(message);
            return this;
        }

        /// <summary>
        /// Create a new <Message/> element and append it as a child of this element.
        /// </summary>
        /// <param name="body"> Message Body, the body of the TwiML Element. </param>
        /// <param name="to"> Phone Number to send Message to. Also accepts stringified Types.PhoneNumber </param>
        /// <param name="from"> Phone Number to send Message from. Also accepts stringified Types.PhoneNumber </param>
        /// <param name="action"> Action URL </param>
        /// <param name="method"> Action URL Method </param>
        public MessagingResponse Message(string body = null, 
                                         string to = null, 
                                         string from = null, 
                                         Uri action = null, 
                                         Twilio.Http.HttpMethod method = null)
        {
            var newChild = new Message(body, to, from, action, method);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Redirect/> element as a child of this element
        /// </summary>
        /// <param name="redirect"> A Redirect instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public MessagingResponse Redirect(Redirect redirect)
        {
            this.Append(redirect);
            return this;
        }

        /// <summary>
        /// Create a new <Redirect/> element and append it as a child of this element.
        /// </summary>
        /// <param name="url"> Redirect URL, the body of the TwiML Element. </param>
        /// <param name="method"> Redirect URL method </param>
        public MessagingResponse Redirect(Uri url = null, Twilio.Http.HttpMethod method = null)
        {
            var newChild = new Redirect(url, method);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new MessagingResponse Append(TwiML childElem)
        {
            return (MessagingResponse) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new MessagingResponse SetOption(string key, object value)
        {
            return (MessagingResponse) base.SetOption(key, value);
        }
    }

}