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
                string resultStr = ObjectToString.EntityToString<DrivingEntity>(drivingData);
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
    }
}
