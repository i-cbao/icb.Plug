using System;
using System.Collections.Generic;
using System.Text;

namespace LBS.Amap.api.ResponseModel
{
    /// <summary>
    /// 驾车导航详细信息
    /// </summary>
    public class Result_TmcsEntity
    {
        /// <summary>
        /// 此段路的长度（单位：米）
        /// </summary>
        public int distance { get; set; }

        /// <summary>
        /// 此段路的交通情况（未知、畅通、缓行、拥堵）
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// 此段路的轨迹（规格：x1,y1;x2,y2）
        /// </summary>
        public string polyline { get; set; }
    }
}
