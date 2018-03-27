using System;
using System.Collections.Generic;

namespace LBS.Amap.api.RequestModel
{
    public class Lbs
    {
        /// <summary>
        /// 国家代码
        /// </summary>
        public ushort MCC;

        /// <summary>
        /// 运营商编号
        /// </summary>
        public byte MNC;

        /// <summary>
        /// 相邻小区
        /// </summary>
        public List<Cell> Cells;
    }
}
