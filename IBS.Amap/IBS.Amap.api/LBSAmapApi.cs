using LBS.Amap.api.Common;
using LBS.Amap.api.RequestModel;
using LBS.Amap.api.ResponseModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace LBS.Amap.api
{
    public class LBSAmapApi
    {
        public Result_DrivingEntity ApiDriving(DrivingEntity drivingData)
        {
            try
            {
                string resultStr = ObjectToString.EntityToString(drivingData);
                MyConfig config = new MyConfig();
                config = ConfigHelper<MyConfig>.Init(config);
                if (config.Url == null || config.Url == "")
                {
                    config.Url = "http://restapi.amap.com/v3/direction/driving";
                }
                string strResult = HttpHelper.HttpPost(config.Url, resultStr);
                if (drivingData.output.ToUpper() == "JSON")
                {
                    return JsonConvert.DeserializeObject<Result_DrivingEntity>(strResult);
                }
                else if (drivingData.output.ToUpper() == "XML")
                {
                    return XMLHelper<Result_DrivingEntity>.DeserializeToObject(strResult.Replace("response", "Result_DrivingEntity").Replace("paths", "pathlist").Replace("steps", "steplist").Replace("type=\"list\"", ""));
                }
                return new Result_DrivingEntity();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 逆地理编码
        /// </summary>
        /// <param name="lon">经度</param>
        /// <param name="lat">纬度</param>
        /// <returns></returns>
        public static AmapRegeoCodeDto Address(string key, double lon, double lat)
        {
            string url = $"http://restapi.amap.com/v3/geocode/regeo?key={key}&location={lon},{lat}&extensions=base&batch=false";
            try
            {
                string strResponse = HttpHelper.HttpGet(url, string.Empty);
                AmapRegeoCodeDto dto = JsonConvert.DeserializeObject<AmapRegeoCodeDto>(strResponse);
                if (null != dto && "1" == dto.Status && null != dto.RegeoCode)
                {
                    return dto;
                }
            }
            catch (Exception)
            {
            }

            return null;
        }

        public static AmapDto LbsLocation(string key, Lbs lbs)
        {
            if (null == lbs || null == lbs.Cells || 0 == lbs.Cells.Count) return null;

            string url = @"http://apilocate.amap.com/position";

            string arg = $"key={key}&accesstype=0&cdma=0&output=json";

            int rssi = lbs.Cells[0].RSSI.HasValue ? (int)lbs.Cells[0].RSSI : 49;
            arg += $"&bts={lbs.MCC},{lbs.MNC},{lbs.Cells[0].LAC},{lbs.Cells[0].CI},{rssi}";
            if (lbs.Cells.Count > 1)
            {
                string nearbts = string.Empty;
                for (int i = 1; i < lbs.Cells.Count; i++)
                {
                    Cell cell = lbs.Cells[i];
                    rssi = cell.RSSI.HasValue ? (int)cell.RSSI : 49;
                    nearbts += $"{lbs.MCC},{lbs.MNC},{cell.LAC},{cell.CI},{rssi}|";
                }

                arg += $"&nearbts={nearbts.TrimEnd(new char[] { '|' })}";
            }

            var strResponse = HttpHelper.HttpGet(url, arg);
            AmapDto dto = JsonConvert.DeserializeObject<AmapDto>(strResponse);
            if (null != dto && "1" == dto.Status && null != dto.Result && dto.Result.Type > 0)
            {
                return dto;
            }

            return null;
        }

        public static AmapDto WiFiLocation(string key, List<WiFi> wifi, Lbs lbs)
        {
            string url = @"http://apilocate.amap.com/position";

            string arg = $"key={key}&accesstype=1&output=json";

            if (null != wifi && wifi.Count > 0)
            {
                string macs = string.Empty;
                foreach (var w in wifi)
                {
                    macs += $"{MacAddress(w.Mac)},{w.Rssi},|";
                }

                arg += $"&macs={macs.TrimEnd(new char[] { '|' })}";
            }

            var strResponse = HttpHelper.HttpGet(url, arg);
            AmapDto dto = JsonConvert.DeserializeObject<AmapDto>(strResponse);
            if (null != dto && "1" == dto.Status && null != dto.Result && dto.Result.Type > 0)
            {
                return dto;
            }

            return LbsLocation(key, lbs);
        }

        private static string MacAddress(string mac)
        {
            if (null == mac || string.IsNullOrEmpty(mac)) return string.Empty;
            var arrMac1 = mac.Split(new char[] { ':' });
            if (6 == arrMac1.Length && 17 == mac.Length) return mac;

            var arrMac2 = mac.Split(new char[] { '-' });
            if (6 == arrMac2.Length && 17 == mac.Length) return mac.Replace("-", ":");

            if (12 == mac.Length)
            {
                return $"{mac.Substring(0, 2)}:{mac.Substring(2, 2)}:{mac.Substring(4, 2)}:{mac.Substring(6, 2)}:{mac.Substring(8, 2)}:{mac.Substring(10, 2)}";
            }

            return string.Empty;
        }
    }
}
