using RestSharp

namespace Bus_Board
{
    public class TransportApiClient
    {
        private RestClient client;

        public TransportApiClient()
        { 
            client = new RestClient("https://transportapi.com/");
        }

        public BusDepartureResponse GetBusDepartureForStop(string stopcode)
        {
            var request = new RestRequest("v3/uk/bus/stop/{stopcode}/live.json?")
            .AddUrlSegment("stopcode", stopcode)
            .AddQueryParameter("app_id", "a7e8ea58")
            .AddQueryParameter("app_key","8851b8a91efa0eef061bd411ebcb0eaf")
            .AddQueryParameter("group","no")
            .AddQueryParameter("nextbuses","yes");

            var response = client.Get<BusDepartureResponse>(request);
            return response.Data;
        }


        }

    
    }
}

