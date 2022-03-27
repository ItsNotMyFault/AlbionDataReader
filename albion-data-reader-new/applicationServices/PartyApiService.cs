using albion_data_reader_new.handlers;
using albion_data_reader_new.handlers.party.events;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace GankCompanionDataReader.eventHandler.party
{
    public class PartyApiService
    {
        private HttpClient httpClient;
        private readonly string URL = "https://localhost:44331/Party";
        //private readonly string URL = "https://gankcompanion.azurewebsites.net/Party";
        private readonly IPartyRepository partyRepository;
        public PartyApiService(IPartyRepository partyRepository)
        {
            this.partyRepository = partyRepository;
            httpClient = new HttpClient();
        }

        public void PlayerJoinParty(JoinPartyRequest partyJoinEvent)
        {
            partyJoinEvent.PartyId = partyRepository.GetPartyID().ToString();

            string json2 = JsonConvert.SerializeObject(partyJoinEvent);

            StringContent content = new(json2, Encoding.UTF8, "application/json");
            this.httpClient = new HttpClient();
            this.httpClient.DefaultRequestHeaders.Add("contentType", "application/json");
            this.httpClient.DefaultRequestHeaders.Add("Accept", "*/*");
            this.httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
            this.httpClient.DefaultRequestHeaders.Add("Connection", "keep-alive");

            string postUrl = URL + "/JoinedParty";
            HttpResponseMessage response = null;
            try
            {
                response = this.httpClient.PostAsync(postUrl, content).Result;
            }
            catch (Exception e)
            {
                var ff = e;
            }

            string responseString = response.Content.ReadAsStringAsync().Result;
            Object accessTokenResponse = JsonConvert.DeserializeObject<Object>(responseString);
        }

        private string ConvertByteArrayToString(byte[] buffer)
        {
            string result = "";
            try
            {
                result = string.Join(";", buffer);
                string[] str = result.Split(";");

                //to convertback
                int[] myInts = str.Select(int.Parse).ToArray();
            }
            catch (Exception e)
            {
                var ff = 0;
            }


            return result;
        }

        public void CreateParty(CreatePartyRequest partyCreateEvent)
        {

            string json2 = JsonConvert.SerializeObject(partyCreateEvent);

            StringContent content = new(json2, Encoding.UTF8, "application/json");
            this.httpClient = new HttpClient();
            this.httpClient.DefaultRequestHeaders.Add("contentType", "application/json");
            this.httpClient.DefaultRequestHeaders.Add("Accept", "*/*");
            this.httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
            this.httpClient.DefaultRequestHeaders.Add("Connection", "keep-alive");
            HttpResponseMessage response = null;
            string postUrl = URL + "/CreateParty";
            try
            {
                response = this.httpClient.PostAsync(postUrl, content).Result;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error when addind to party => {e.Message}");
            }

            string responseString = response.Content.ReadAsStringAsync().Result;
            string partyId = JsonConvert.DeserializeObject<string>(responseString);
            partyRepository.SetPartyID(partyId);
            var test = 0;
        }

        public void PlayerLeaveParty(LeavePartyRequest partyLeftEvent)
        {
            partyLeftEvent.PartyId = partyRepository.GetPartyID().ToString();
            string json2 = JsonConvert.SerializeObject(partyLeftEvent);

            StringContent content = new(json2, Encoding.UTF8, "application/json");
            this.httpClient = new HttpClient();
            this.httpClient.DefaultRequestHeaders.Add("contentType", "application/json");
            this.httpClient.DefaultRequestHeaders.Add("Accept", "*/*");
            this.httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
            this.httpClient.DefaultRequestHeaders.Add("Connection", "keep-alive");
            HttpResponseMessage response = null;

            string postUrl = URL + "/LeftParty";
            try
            {
                response = this.httpClient.PostAsync(postUrl, content).Result;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error when player leave the party => {e.Message}");
            }
            string responseString = response.Content.ReadAsStringAsync().Result;
            Object accessTokenResponse = JsonConvert.DeserializeObject<Object>(responseString);
        }

        public void CloseParty()
        {
            string partyId = partyRepository.GetPartyID();

            if (String.IsNullOrEmpty(partyId))
            {
                throw new ArgumentException("PartyId not found");
            }

            PartyCloseEvent partyCloseEvent = new PartyCloseEvent()
            {
                PartyId = partyId
            };

            string json2 = JsonConvert.SerializeObject(partyCloseEvent);

            StringContent content = new StringContent(json2, Encoding.UTF8, "application/json");
            this.httpClient = new HttpClient();
            this.httpClient.DefaultRequestHeaders.Add("contentType", "application/json");
            this.httpClient.DefaultRequestHeaders.Add("Accept", "*/*");
            this.httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
            this.httpClient.DefaultRequestHeaders.Add("Connection", "keep-alive");
            HttpResponseMessage response = null;

            string postUrl = URL + "/CloseParty";
            try
            {
                response = this.httpClient.PostAsync(postUrl, content).Result;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error when closing the party => {e.Message}");
            }
            string responseString = response.Content.ReadAsStringAsync().Result;
            Object accessTokenResponse = JsonConvert.DeserializeObject<Object>(responseString);
        }
    }
}
