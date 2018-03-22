using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;
using IBS.Amap.api;
using IBS.Amap.api.RequestModel;

namespace UITest1
{
    [TestFixture]
    public class Tests
    { 
        [Test]
        public void AppLaunches()
        {
            DrivingEntity entity = new DrivingEntity();
            IBSAmapApi testApi = new IBSAmapApi();

            entity.key = "319af3b93403bad8cd533d823b26b2a8";
            entity.number = "";
            entity.origin = "116.481028,39.989643";
            entity.originid = "";
            entity.origintype = "";
            entity.output = "xml";
            entity.province = "";
            entity.sig = "";
            entity.strategy = "";
            entity.waypoints = "116.357483,39.907234";
            entity.avoidpolygons= "";
            entity.extensions = "base";
            entity.avoidroad = "";
            entity.callback = "";
            entity.destination = "116.465302,40.004717";
            entity.destinationid = "";
            entity.destinationtype = "";

            string result =testApi.ApiDriving(entity);
       }
    }
}

