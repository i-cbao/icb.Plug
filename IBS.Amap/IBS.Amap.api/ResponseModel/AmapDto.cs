using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBS.Amap.api.ResponseModel
{
    #region 智能硬件解析 
    public class AmapDto
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("infocode")]
        public string InfoCode { get; set; }

        [JsonProperty("result")]
        public Result Result { get; set; }
    }

    public class Result
    {
        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

    }
    #endregion

    #region 逆地址解析
    public class AmapRegeoCodeDto
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("infocode")]
        public string InfoCode { get; set; }

        [JsonProperty("regeocode")]
        public RegeoCode RegeoCode { get; set; }
    }

    public class RegeoCode
    {
        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }
    }
    #endregion
}
