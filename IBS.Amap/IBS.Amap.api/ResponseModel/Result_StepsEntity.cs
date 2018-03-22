using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace LBS.Amap.api.ResponseModel
{
    /// <summary>
    /// 导航路段
    /// </summary>
    public class Result_StepsEntity
    {
        /// <summary>
        /// 行驶指示
        /// </summary>
        public string instruction { get; set; }

        /// <summary>
        /// 方向
        /// </summary>
        public string orientation { get; set; }

        /// <summary>
        /// 道路名称
        /// </summary>
        public string road { get; set; }

        /// <summary>
        /// 此路段距离(单位：米)
        /// </summary>
        public int distance { get; set; }

        /// <summary>
        /// 此段收费(单位：元)
        /// </summary>
        public int tolls { get; set; }

        /// <summary>
        /// 收费路段距离(单位：米)
        /// </summary>
        public int toll_distance { get; set; }

        /// <summary>
        /// 主要收费道路
        /// </summary> 
        [JsonIgnore]
        public List<string> toll_road { get; set; }

        /// <summary>
        /// 此路段坐标点串(格式为坐标串，如：116.481247,39.990704;116.481270,39.990726)
        /// </summary>
        public string polyline { get; set; }

        /// <summary>
        /// 导航主要动作
        /// </summary>
        [JsonIgnore]
        public string action { get; set; }

        /// <summary>
        /// 导航辅助动作
        /// </summary>
        ///  
        //private string _assistant_action;

        //public string assistant_action

        //{

        //    get { return _assistant_action; }

        //    set
        //    {
        //        _assistant_action = "";

        //    }

        //}
        [JsonIgnore]
        public string assistant_action { get; set; }

        /// <summary>
        /// 驾车导航详细信息
        /// </summary>
        [XmlIgnore]
        public List<Result_TmcsEntity> tmcs { get; set; }
    }
}
