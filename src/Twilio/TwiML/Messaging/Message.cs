/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using Twilio.Converters;

namespace Twilio.TwiML.Messaging
{

    /// <summary>
    /// Message TwiML Verb
    /// </summary>
    public class Message : TwiML
    {
        /// <summary>
        /// Message Body
        /// </summary>
        public string BodyAttribute { get; set; }
        /// <summary>
        /// Phone Number to send Message to
        /// </summary>
        public string To { get; set; }
        /// <summary>
        /// Phone Number to send Message from
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// Action URL
        /// </summary>
        public Uri Action { get; set; }
        /// <summary>
        /// Action URL Method
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; set; }
        /// <summary>
        /// Status callback URL. Deprecated in favor of action.
        /// </summary>
        public Uri StatusCallback { get; set; }

        /// <summary>
        /// Create a new Message
        /// </summary>
        /// <param name="body"> Message Body, the body of the TwiML Element. </param>
        /// <param name="to"> Phone Number to send Message to. Also accepts stringified Types.PhoneNumber </param>
        /// <param name="from"> Phone Number to send Message from. Also accepts stringified Types.PhoneNumber </param>
        /// <param name="action"> Action URL </param>
        /// <param name="method"> Action URL Method </param>
        /// <param name="statusCallback"> Status callback URL. Deprecated in favor of action. </param>
        public Message(string body = null,
                       string to = null,
                       string from = null,
                       Uri action = null,
                       Twilio.Http.HttpMethod method = null,
                       Uri statusCallback = null) : base("Message")
        {
            this.BodyAttribute = body;
            this.To = to;
            this.From = from;
            this.Action = action;
            this.Method = method;
            this.StatusCallback = statusCallback;
        }

        /// <summary>
        /// Return the body of the TwiML tag
        /// </summary>
        protected override string GetElementBody()
        {
            return this.BodyAttribute != null ? this.BodyAttribute : string.Empty;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.To != null)
            {
                attributes.Add(new XAttribute("to", this.To));
            }
            if (this.From != null)
            {
                attributes.Add(new XAttribute("from", this.From));
            }
            if (this.Action != null)
            {
                attributes.Add(new XAttribute("action", Serializers.Url(this.Action)));
            }
            if (this.Method != null)
            {
                attributes.Add(new XAttribute("method", this.Method.ToString()));
            }
            if (this.StatusCallback != null)
            {
                attributes.Add(new XAttribute("statusCallback", Serializers.Url(this.StatusCallback)));
            }
            return attributes;
        }

        /// <summary>
        /// Create a new <Body/> element and append it as a child of this element.
        /// </summary>
        /// <param name="message"> Message Body, the body of the TwiML Element. </param>
        public Message Body(string message = null)
        {
            var newChild = new Body(message);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Body/> element as a child of this element
        /// </summary>
        /// <param name="body"> A Body instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Message Body(Body body)
        {
            this.Append(body);
            return this;
        }

        /// <summary>
        /// Create a new <Media/> element and append it as a child of this element.
        /// </summary>
        /// <param name="url"> Media URL, the body of the TwiML Element. </param>
        public Message Media(Uri url = null)
        {
            var newChild = new Media(url);
            this.Append(newChild);
            return this;
        }

        /// <summary>
        /// Append a <Media/> element as a child of this element
        /// </summary>
        /// <param name="media"> A Media instance. </param>
        [System.Obsolete("This method is deprecated, use .Append() instead.")]
        public Message Media(Media media)
        {
            this.Append(media);
            return this;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Message Append(TwiML childElem)
        {
            return (Message) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Message SetOption(string key, object value)
        {
            return (Message) base.SetOption(key, value);
        }
    }

}