using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace LBS.Amap.api.ResponseModel
{
    /// <summary>
    /// 驾车换乘方案
    /// </summary>
    public class Result_PathsEntity
    {
        /// <summary>
        /// 行驶距离(单位：米)
        /// </summary>
        public int distance { get; set; }

        /// <summary>
        /// 预计行驶时间 （单位：秒）
        /// </summary>
        public int duration { get; set; }

        /// <summary>
        /// 导航策略
        /// </summary>
        public string strategy { get; set; }

        /// <summary>
        /// 此导航方案道路收费 （单位：元）
        /// </summary>
        public int tolls { get; set; }

        /// <summary>
        /// 收费路段距离	
        /// </summary>
        public int toll_distance { get; set; }

        /// <summary>
        /// 限行结果
        /// 0 代表限行已规避或未限行，即该路线没有限行路段
        /// 1 代表限行无法规避，即该线路有限行路段
        /// </summary>
        public int restriction { get; set; }

        /// <summary>
        /// 导航路段
        /// </summary>
        [XmlIgnore]
        public List<Result_StepsEntity> steps { get; set; }

        public int traffic_lights { get; set; }

        [JsonIgnore]
        [XmlElement("steplist")]
        public Step steplist { get; set; } 
    }

    public class Step
    {
        [XmlElement("step")]
        public List<Result_StepsEntity> step { get; set; }
    }
}
