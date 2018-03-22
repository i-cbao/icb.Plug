using System;
using System.Collections.Generic;
using System.Text;

namespace LBS.Amap.api.ResponseModel
{
    public class Result<T>
    {
        /// <summary>
        /// 返回Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 返回状态
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 返回提示信息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 返回内容
        /// </summary>
        public List<T> Data { get; set; }
    }
}
