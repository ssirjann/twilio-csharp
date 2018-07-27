/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account.Sip.Domain.AuthTypes.AuthTypeCalls 
{

    /// <summary>
    /// Create a new IP Access Control List mapping
    /// </summary>
    public class CreateAuthCallsIpAccessControlListMappingOptions : IOptions<AuthCallsIpAccessControlListMappingResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The domain_sid
        /// </summary>
        public string PathDomainSid { get; }
        /// <summary>
        /// A string that uniquely identifies IP Access Control List
        /// </summary>
        public string IpAccessControlListSid { get; }

        /// <summary>
        /// Construct a new CreateAuthCallsIpAccessControlListMappingOptions
        /// </summary>
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="ipAccessControlListSid"> A string that uniquely identifies IP Access Control List </param>
        public CreateAuthCallsIpAccessControlListMappingOptions(string pathDomainSid, string ipAccessControlListSid)
        {
            PathDomainSid = pathDomainSid;
            IpAccessControlListSid = ipAccessControlListSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (IpAccessControlListSid != null)
            {
                p.Add(new KeyValuePair<string, string>("IpAccessControlListSid", IpAccessControlListSid.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Retrieve a list of IP Access Control List mappings belonging to the domain used in the request
    /// </summary>
    public class ReadAuthCallsIpAccessControlListMappingOptions : ReadOptions<AuthCallsIpAccessControlListMappingResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The domain_sid
        /// </summary>
        public string PathDomainSid { get; }

        /// <summary>
        /// Construct a new ReadAuthCallsIpAccessControlListMappingOptions
        /// </summary>
        /// <param name="pathDomainSid"> The domain_sid </param>
        public ReadAuthCallsIpAccessControlListMappingOptions(string pathDomainSid)
        {
            PathDomainSid = pathDomainSid;
        }

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
    /// Fetch a specific instance of an IP Access Control List mapping
    /// </summary>
    public class FetchAuthCallsIpAccessControlListMappingOptions : IOptions<AuthCallsIpAccessControlListMappingResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The domain_sid
        /// </summary>
        public string PathDomainSid { get; }
        /// <summary>
        /// Fetch by unique IP Access Control List Sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchAuthCallsIpAccessControlListMappingOptions
        /// </summary>
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="pathSid"> Fetch by unique IP Access Control List Sid </param>
        public FetchAuthCallsIpAccessControlListMappingOptions(string pathDomainSid, string pathSid)
        {
            PathDomainSid = pathDomainSid;
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
    /// Delete an IP Access Control List mapping from the requested domain
    /// </summary>
    public class DeleteAuthCallsIpAccessControlListMappingOptions : IOptions<AuthCallsIpAccessControlListMappingResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The domain_sid
        /// </summary>
        public string PathDomainSid { get; }
        /// <summary>
        /// Delete by unique IP Access Control List Sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteAuthCallsIpAccessControlListMappingOptions
        /// </summary>
        /// <param name="pathDomainSid"> The domain_sid </param>
        /// <param name="pathSid"> Delete by unique IP Access Control List Sid </param>
        public DeleteAuthCallsIpAccessControlListMappingOptions(string pathDomainSid, string pathSid)
        {
            PathDomainSid = pathDomainSid;
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