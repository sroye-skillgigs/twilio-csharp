/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
/// 
/// CommandResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Preview.Wireless 
{

    public class CommandResource : Resource 
    {
        private static Request BuildFetchRequest(FetchCommandOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/wireless/Commands/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns> 
        public static CommandResource Fetch(FetchCommandOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Command </returns> 
        public static async System.Threading.Tasks.Task<CommandResource> FetchAsync(FetchCommandOptions options, 
                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns> 
        public static CommandResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchCommandOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Command </returns> 
        public static async System.Threading.Tasks.Task<CommandResource> FetchAsync(string pathSid, 
                                                                                    ITwilioRestClient client = null)
        {
            var options = new FetchCommandOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadCommandOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/wireless/Commands",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns> 
        public static ResourceSet<CommandResource> Read(ReadCommandOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<CommandResource>.FromJson("commands", response.Content);
            return new ResourceSet<CommandResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Command </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<CommandResource>> ReadAsync(ReadCommandOptions options, 
                                                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<CommandResource>.FromJson("commands", response.Content);
            return new ResourceSet<CommandResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="device"> The device </param>
        /// <param name="sim"> The sim </param>
        /// <param name="status"> The status </param>
        /// <param name="direction"> The direction </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns> 
        public static ResourceSet<CommandResource> Read(string device = null, 
                                                        string sim = null, 
                                                        string status = null, 
                                                        string direction = null, 
                                                        int? pageSize = null, 
                                                        long? limit = null, 
                                                        ITwilioRestClient client = null)
        {
            var options = new ReadCommandOptions{Device = device, Sim = sim, Status = status, Direction = direction, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="device"> The device </param>
        /// <param name="sim"> The sim </param>
        /// <param name="status"> The status </param>
        /// <param name="direction"> The direction </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Command </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<CommandResource>> ReadAsync(string device = null, 
                                                                                                string sim = null, 
                                                                                                string status = null, 
                                                                                                string direction = null, 
                                                                                                int? pageSize = null, 
                                                                                                long? limit = null, 
                                                                                                ITwilioRestClient client = null)
        {
            var options = new ReadCommandOptions{Device = device, Sim = sim, Status = status, Direction = direction, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<CommandResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<CommandResource>.FromJson("commands", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<CommandResource> NextPage(Page<CommandResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Preview,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<CommandResource>.FromJson("commands", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<CommandResource> PreviousPage(Page<CommandResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Preview,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<CommandResource>.FromJson("commands", response.Content);
        }

        private static Request BuildCreateRequest(CreateCommandOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/wireless/Commands",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns> 
        public static CommandResource Create(CreateCommandOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Command </returns> 
        public static async System.Threading.Tasks.Task<CommandResource> CreateAsync(CreateCommandOptions options, 
                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="command"> The command </param>
        /// <param name="device"> The device </param>
        /// <param name="sim"> The sim </param>
        /// <param name="callbackMethod"> The callback_method </param>
        /// <param name="callbackUrl"> The callback_url </param>
        /// <param name="commandMode"> The command_mode </param>
        /// <param name="includeSid"> The include_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns> 
        public static CommandResource Create(string command, 
                                             string device = null, 
                                             string sim = null, 
                                             string callbackMethod = null, 
                                             Uri callbackUrl = null, 
                                             string commandMode = null, 
                                             string includeSid = null, 
                                             ITwilioRestClient client = null)
        {
            var options = new CreateCommandOptions(command){Device = device, Sim = sim, CallbackMethod = callbackMethod, CallbackUrl = callbackUrl, CommandMode = commandMode, IncludeSid = includeSid};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="command"> The command </param>
        /// <param name="device"> The device </param>
        /// <param name="sim"> The sim </param>
        /// <param name="callbackMethod"> The callback_method </param>
        /// <param name="callbackUrl"> The callback_url </param>
        /// <param name="commandMode"> The command_mode </param>
        /// <param name="includeSid"> The include_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Command </returns> 
        public static async System.Threading.Tasks.Task<CommandResource> CreateAsync(string command, 
                                                                                     string device = null, 
                                                                                     string sim = null, 
                                                                                     string callbackMethod = null, 
                                                                                     Uri callbackUrl = null, 
                                                                                     string commandMode = null, 
                                                                                     string includeSid = null, 
                                                                                     ITwilioRestClient client = null)
        {
            var options = new CreateCommandOptions(command){Device = device, Sim = sim, CallbackMethod = callbackMethod, CallbackUrl = callbackUrl, CommandMode = commandMode, IncludeSid = includeSid};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a CommandResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CommandResource object represented by the provided JSON </returns> 
        public static CommandResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<CommandResource>(json);
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
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The device_sid
        /// </summary>
        [JsonProperty("device_sid")]
        public string DeviceSid { get; private set; }
        /// <summary>
        /// The sim_sid
        /// </summary>
        [JsonProperty("sim_sid")]
        public string SimSid { get; private set; }
        /// <summary>
        /// The command
        /// </summary>
        [JsonProperty("command")]
        public string Command { get; private set; }
        /// <summary>
        /// The command_mode
        /// </summary>
        [JsonProperty("command_mode")]
        public string CommandMode { get; private set; }
        /// <summary>
        /// The status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; private set; }
        /// <summary>
        /// The direction
        /// </summary>
        [JsonProperty("direction")]
        public string Direction { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private CommandResource()
        {

        }
    }

}