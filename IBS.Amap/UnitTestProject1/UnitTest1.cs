using LBS.Amap.api;
using LBS.Amap.api.Common;
using LBS.Amap.api.RequestModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DrivingEntity entity = new DrivingEntity();
            LBSAmapApi testApi = new LBSAmapApi();
            //MyConfig config = new MyConfig();
            //config = ConfigHelper<MyConfig>.Init(config);
            entity.key = "319af3b93403bad8cd533d823b26b2a8";
            entity.number = "";
            //entity.origin = "116.481028,39.989643";
            //entity.origin = "104.128906,30.593285";
            entity.origin = "105.583415308412,30.4804903256001";
            entity.originid = "";
            entity.origintype = "";
            entity.output ="json";
            entity.province = "";
            entity.sig = "";
            entity.strategy = "";
            //entity.waypoints = "116.357483,39.907234";
            entity.avoidpolygons = "";
            entity.extensions = "base";
            entity.avoidroad = "";
            entity.callback = "";
            //entity.destination = "116.465302,40.004717";
            //entity.destination = "104.267609,30.710246";
            entity.destination = "105.569449842462,30.4529125787376";
            entity.destinationid = "";
            entity.destinationtype = 20;

            object result = testApi.ApiDriving(entity);
            
        } 

    }
}
