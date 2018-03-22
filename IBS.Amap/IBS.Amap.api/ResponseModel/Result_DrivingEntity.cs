using System;
using System.Collections.Generic;
using System.Text;

namespace LBS.Amap.api.ResponseModel
{
    public class Result_DrivingEntity
    {
        /// <summary>
        /// 结果状态值(0：请求失败；1：请求成功)
        /// </summary>
        public int status { get; set; }

        /// <summary>
        /// 返回状态说明
        /// status为0时，info返回错误原因，否则返回“OK”。详情参阅info状态表
        /// </summary>
        public string info { get; set; }

        /// <summary>
        /// 驾车路径规划方案数目
        /// </summary>
        public int count { get; set; }

        /// <summary>
        /// 驾车路径规划信息列表
        /// </summary>
        public Result_RouteEntity route { get; set; }

    }  
}
