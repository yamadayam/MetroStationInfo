using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MetroStationInfo
{
    public class Station
    {
        [JsonProperty("@context")]
        public string Context { get; set; }

        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@type")]
        public string type { get; set; }

        [JsonProperty("owl:sameAs")]
        public string SameAs { get; set; }

        [JsonProperty("dc:date")]
        public DateTime Date { get; set; }

        [JsonProperty("dc:title")]
        public string Title { get; set; }

        [JsonProperty("ug:region")]
        public string Region { get; set; }

        [JsonProperty("odpt:operator")]
        public string Operator { get; set; }

        [JsonProperty("odpt:railway")]
        public string Railway { get; set; }

        [JsonProperty("odpt:connectingRailway")]
        public string[] ConnectingRailway { get; set; }

        [JsonProperty("odpt:Facility")]
        public string Facility { get; set; }

        [JsonProperty("odpt:passengerSurvey")]
        public string[] PassengerSurvey { get; set; }

        [JsonProperty("odpt:stationCode")]
        public string StationCode { get; set; }

        [JsonProperty("odpt:exit")]
        public string[] Exit { get; set; }

    }
    public class Railway
    {
        [JsonProperty("@context")]
        public string Context { get; set; }

        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("owl:sameAs")]
        public string SameAs { get; set; }

        [JsonProperty("dc:title")]
        public string Title { get; set; }

        [JsonProperty("odpt:stationOrder")]
        public StationOrder[] StationOrder { get; set; }

        [JsonProperty("odpt:travelTime")]
        public TravelTime[] TravelTime { get; set; }

        [JsonProperty("odpt:lineCode")]
        public string LineCode { get; set; }

        [JsonProperty("ug:region")]
        public string Region { get; set; }

        [JsonProperty("dc:date")]
        public DateTime Date { get; set; }

        [JsonProperty("odpt:operator")]
        public string Operator { get; set; }
    }

    /// <summary>
    /// 駅順
    /// </summary>
    public class StationOrder
    {
        [JsonProperty("odpt:station")]
        public string Station { get; set; }

        [JsonProperty("odpt:index")]
        public int Index { get; set; }
    }

    /// <summary>
    /// 駅間所用時間
    /// </summary>
    public class TravelTime
    {
        [JsonProperty("odpt:fromStation")]
        public string FromStation { get; set; }

        [JsonProperty("odpt:toStation")]
        public string ToStation { get; set; }

        [JsonProperty("odpt:necessaryTime")]
        public int NecessaryTime { get; set; }
    }

    /// <summary>
    /// 女性専用車両
    /// </summary>
    public class WomenOnlyCar
    {
        [JsonProperty("odpt:fromStation")]
        public string FromStation { get; set; }

        [JsonProperty("odpt:toStation")]
        public string ToStation { get; set; }

        [JsonProperty("odpt:operationDay")]
        public string OperationDay { get; set; }

        [JsonProperty("odpt:availableTimeFrom")]
        public string AvailableTimeFrom { get; set; }

        [JsonProperty("odpt:avalilableTimeUntil")]
        public string AvalilableTimeUntil { get; set; }

        [JsonProperty("odpt:carComposition")]
        public int CarComposition { get; set; }

        [JsonProperty("odpt:carNumber")]
        public int CarNumber { get; set; }
    }
    public class TrainInformation
    {
        [JsonProperty("@context")]
        public string Context { get; set; }

        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("dc:date")]
        public DateTime Date { get; set; }

        [JsonProperty("dct:valid")]
        public DateTime Valid { get; set; }

        [JsonProperty("odpt:operator")]
        public string Operator { get; set; }

        [JsonProperty("odpt:railway")]
        public string Railway { get; set; }

        [JsonProperty("odpt:timeOfOrigin")]
        public DateTime TimeOfOrigin { get; set; }

        [JsonProperty("odpt:trainInformationText")]
        public string TrainInformationText { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }
    }

}
