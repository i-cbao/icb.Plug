using LBS.Amap.api;
using LBS.Amap.api.Common;
using LBS.Amap.api.RequestModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            entity.output = "json";
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

        [TestMethod]
        public void Test2()
        {
            var location = LBSAmapApi.Address("319af3b93403bad8cd533d823b26b2a8", 105.08135,
            30.063167);

            var lbs = LBSAmapApi.LbsLocation("8436f3ee0d0c5474dff770300b661c75", new LBS.Amap.api.LBS
            {
                MNC = 0,
                MCC = 460,
                Cells = new System.Collections.Generic.List<Cell> {
                     new Cell{
                CI=61093,
                LAC=33306 }
}
            });

            var wifi = LBSAmapApi.WiFiLocation("8436f3ee0d0c5474dff770300b661c75", new System.Collections.Generic.List<WiFi> {
                new  WiFi{
            Mac= "FCD733C20020",
            Rssi= 53
        },
        new WiFi{
            Mac= "643AB1364812",
            Rssi= 64
        },
        new WiFi{
            Mac= "502B7308A931",
            Rssi= 68
        },
        new WiFi{
            Mac="B0958E790F21",
            Rssi= 70
        },
        new WiFi{
            Mac= "CC90E88EA536",
            Rssi=75
        },
        new WiFi{
            Mac= "D45F25D6D908",
            Rssi= 79
        },
        new WiFi{
            Mac="FC0A81496F31",
            Rssi= 86
        },
        new WiFi{
            Mac="FC0A81E6A023",
            Rssi= 86
        }
}, new LBS.Amap.api.LBS
{
    MNC = 0,
    MCC = 460,
    Cells = new System.Collections.Generic.List<Cell> {
                     new Cell{
                CI= 29110,
                LAC=32771,
                RSSI= 55
            },
            new Cell{
                CI= 11063,
                LAC=33311,
                RSSI= 34
            },
            new Cell{
                CI= 53232,
                LAC= 32768,
                RSSI=28
            }
            }
});

            var key = "";

        }
    }
}
