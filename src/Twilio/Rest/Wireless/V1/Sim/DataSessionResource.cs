/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
/// 
/// DataSessionResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Wireless.V1.Sim 
{

    public class DataSessionResource : Resource 
    {
        private static Request BuildReadRequest(ReadDataSessionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Wireless,
                "/v1/Sims/" + options.PathSimSid + "/DataSessions",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read DataSession parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DataSession </returns> 
        public static ResourceSet<DataSessionResource> Read(ReadDataSessionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<DataSessionResource>.FromJson("data_sessions", response.Content);
            return new ResourceSet<DataSessionResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read DataSession parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DataSession </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<DataSessionResource>> ReadAsync(ReadDataSessionOptions options, 
                                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<DataSessionResource>.FromJson("data_sessions", response.Content);
            return new ResourceSet<DataSessionResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathSimSid"> The sim_sid </param>
        /// <param name="end"> The end </param>
        /// <param name="start"> The start </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of DataSession </returns> 
        public static ResourceSet<DataSessionResource> Read(string pathSimSid, 
                                                            DateTime? end = null, 
                                                            DateTime? start = null, 
                                                            int? pageSize = null, 
                                                            long? limit = null, 
                                                            ITwilioRestClient client = null)
        {
            var options = new ReadDataSessionOptions(pathSimSid){End = end, Start = start, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathSimSid"> The sim_sid </param>
        /// <param name="end"> The end </param>
        /// <param name="start"> The start </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of DataSession </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<DataSessionResource>> ReadAsync(string pathSimSid, 
                                                                                                    DateTime? end = null, 
                                                                                                    DateTime? start = null, 
                                                                                                    int? pageSize = null, 
                                                                                                    long? limit = null, 
                                                                                                    ITwilioRestClient client = null)
        {
            var options = new ReadDataSessionOptions(pathSimSid){End = end, Start = start, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<DataSessionResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<DataSessionResource>.FromJson("data_sessions", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<DataSessionResource> NextPage(Page<DataSessionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Wireless,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<DataSessionResource>.FromJson("data_sessions", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<DataSessionResource> PreviousPage(Page<DataSessionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Wireless,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<DataSessionResource>.FromJson("data_sessions", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a DataSessionResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> DataSessionResource object represented by the provided JSON </returns> 
        public static DataSessionResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<DataSessionResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The sim_sid
        /// </summary>
        [JsonProperty("sim_sid")]
        public string SimSid { get; private set; }
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The radio_link
        /// </summary>
        [JsonProperty("radio_link")]
        public string RadioLink { get; private set; }
        /// <summary>
        /// The operator_mcc
        /// </summary>
        [JsonProperty("operator_mcc")]
        public int? OperatorMcc { get; private set; }
        /// <summary>
        /// The operator_mnc
        /// </summary>
        [JsonProperty("operator_mnc")]
        public int? OperatorMnc { get; private set; }
        /// <summary>
        /// The operator_country
        /// </summary>
        [JsonProperty("operator_country")]
        public string OperatorCountry { get; private set; }
        /// <summary>
        /// The operator_name
        /// </summary>
        [JsonProperty("operator_name")]
        public string OperatorName { get; private set; }
        /// <summary>
        /// The cell_id
        /// </summary>
        [JsonProperty("cell_id")]
        public string CellId { get; private set; }
        /// <summary>
        /// The cell_location_estimate
        /// </summary>
        [JsonProperty("cell_location_estimate")]
        public object CellLocationEstimate { get; private set; }
        /// <summary>
        /// The packets_uploaded
        /// </summary>
        [JsonProperty("packets_uploaded")]
        public int? PacketsUploaded { get; private set; }
        /// <summary>
        /// The packets_downloaded
        /// </summary>
        [JsonProperty("packets_downloaded")]
        public int? PacketsDownloaded { get; private set; }
        /// <summary>
        /// The last_updated
        /// </summary>
        [JsonProperty("last_updated")]
        public DateTime? LastUpdated { get; private set; }
        /// <summary>
        /// The start
        /// </summary>
        [JsonProperty("start")]
        public DateTime? Start { get; private set; }
        /// <summary>
        /// The end
        /// </summary>
        [JsonProperty("end")]
        public DateTime? End { get; private set; }

        private DataSessionResource()
        {

        }
    }

}