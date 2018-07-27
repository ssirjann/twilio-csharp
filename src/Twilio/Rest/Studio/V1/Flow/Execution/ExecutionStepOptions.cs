/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Studio.V1.Flow.Execution 
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Retrieve a list of all Steps for an Execution.
    /// </summary>
    public class ReadExecutionStepOptions : ReadOptions<ExecutionStepResource> 
    {
        /// <summary>
        /// Flow Sid.
        /// </summary>
        public string PathFlowSid { get; }
        /// <summary>
        /// Execution Sid.
        /// </summary>
        public string PathExecutionSid { get; }

        /// <summary>
        /// Construct a new ReadExecutionStepOptions
        /// </summary>
        /// <param name="pathFlowSid"> Flow Sid. </param>
        /// <param name="pathExecutionSid"> Execution Sid. </param>
        public ReadExecutionStepOptions(string pathFlowSid, string pathExecutionSid)
        {
            PathFlowSid = pathFlowSid;
            PathExecutionSid = pathExecutionSid;
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
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Retrieve a Step.
    /// </summary>
    public class FetchExecutionStepOptions : IOptions<ExecutionStepResource> 
    {
        /// <summary>
        /// Flow Sid.
        /// </summary>
        public string PathFlowSid { get; }
        /// <summary>
        /// Execution Sid.
        /// </summary>
        public string PathExecutionSid { get; }
        /// <summary>
        /// Step Sid.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchExecutionStepOptions
        /// </summary>
        /// <param name="pathFlowSid"> Flow Sid. </param>
        /// <param name="pathExecutionSid"> Execution Sid. </param>
        /// <param name="pathSid"> Step Sid. </param>
        public FetchExecutionStepOptions(string pathFlowSid, string pathExecutionSid, string pathSid)
        {
            PathFlowSid = pathFlowSid;
            PathExecutionSid = pathExecutionSid;
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