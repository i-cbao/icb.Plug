using System;

namespace LBS.Amap.api.RequestModel
{
    public class Cell
    {
        /// <summary>
        /// 基站Id
        /// </summary>
        public uint CI;

        /// <summary>
        /// 网络识别码
        /// </summary>
        public ushort LAC;

        /// <summary>
        ///信号强度
        /// </summary>
        public byte? RSSI;
    }
}
