using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace MetroStationInfo
{
    class TokyoMetroApi
    {
        public string ConsumerKey { get; private set; }

        public string EndPointUrl { get; private set; }
        public string Json { get; private set; }

        public TokyoMetroApi(string consumerKey)
        {
            ConsumerKey = consumerKey;
            EndPointUrl = "https://api.tokyometroapp.jp/api/v2/datapoints/";
        }

        public IEnumerable<TrainInformation> GetTrainInformation()
        {
            var parm = new Dictionary<string, string>();
            parm["rdf:type"] = "odpt:TrainInformation";
            parm["acl:consumerKey"] = ConsumerKey;

            var url = string.Format("{0}?{1}", EndPointUrl,
                string.Join("&", parm.Select(p => string.Format("{0}={1}", p.Key, p.Value))));

            // JSON-DLを取得する
            var client = new WebClient()
            {
                Encoding = System.Text.Encoding.UTF8
            };
            Json = client.DownloadString(url);

            return JsonConvert.DeserializeObject<TrainInformation[]>(Json);
        }


        public IEnumerable<Railway> GetRailway()
        {
            var parm = new Dictionary<string, string>();
            parm["rdf:type"] = "odpt:Railway";
            parm["acl:consumerKey"] = ConsumerKey;

            var url = string.Format("{0}?{1}", EndPointUrl,
                string.Join("&", parm.Select(p => string.Format("{0}={1}", p.Key, p.Value))));

            // JSON-DLを取得する
            var client = new WebClient()
            {
                Encoding = System.Text.Encoding.UTF8
            };
            Json = client.DownloadString(url);

            return JsonConvert.DeserializeObject<Railway[]>(Json);
        }

        public IEnumerable<Station> GetStations()
        {
            var parm = new Dictionary<string, string>();
            parm["rdf:type"] = "odpt:Station";
            parm["acl:consumerKey"] = ConsumerKey;

            var url = string.Format("{0}?{1}", EndPointUrl,
                string.Join("&", parm.Select(p => string.Format("{0}={1}", p.Key, p.Value))));

            // JSON-DLを取得する
            var client = new WebClient()
            {
                Encoding = System.Text.Encoding.UTF8
            };
            var json = client.DownloadString(url);

            return JsonConvert.DeserializeObject<Station[]>(json);
        }

    }
}
