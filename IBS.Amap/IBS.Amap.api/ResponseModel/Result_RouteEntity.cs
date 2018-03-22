using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace LBS.Amap.api.ResponseModel
{
    public class Result_RouteEntity
    {
        /// <summary>
        /// 起点坐标
        /// 规则： lon，lat（经度，纬度）， “,”分割，如117.500244, 40.417801 经纬度小数点不超过6位
        /// </summary>
        public string origin { get; set; }

        /// <summary>
        /// 终点坐标
        /// 规则： lon，lat（经度，纬度）， “,”分割，如117.500244, 40.417801 经纬度小数点不超过6位
        /// </summary>
        public string destination { get; set; }

        /// <summary>
        /// 驾车换乘方案
        /// </summary>
        [XmlIgnore]
        public List<Result_PathsEntity> paths { get; set; }


        /// <summary>
        /// 驾车换乘方案
        /// </summary>
        [JsonIgnore]
        public Path pathlist { get; set; }
    }

    public class Path
    { 
        [XmlElement("path")]
        public List<Result_PathsEntity> path { get; set; }
    }
}
