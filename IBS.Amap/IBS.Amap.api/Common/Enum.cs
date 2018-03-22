using System;
using System.Collections.Generic;
using System.Text;

namespace LBS.Amap.api.Common
{
    public static class Enum
    {
        public enum DestinationType
        {
            //返回耗时最短的路线
            shortestRoute = 0,
            //不走收费路段耗时最少的路线
            NoTollRoadsTakeLeast = 1,
            //走距离最短的路线
            TakeTheShortestRoute = 2,
            //不走快速路策略迭代
            DontWalkFastTrack = 3,
            //躲避拥堵的路线
            AvoidCongestion = 4,
            //多策略
            MultiStrategy = 5,
            //不走高速
            DontWalkFast = 6,
            //不走高速且避免所有收费路段
            DontWalkFastORallTollRoads = 7,
            //躲避收费和拥堵
            AvoidFeesAndCongestion = 8,
            //不走高速且躲避收费和拥堵
            DontWalkFastAvoidFeesAndCongestion = 9,
            //躲避拥堵路程较短
            AvoidCongestionShortDistance = 10,
            //时间最短距离最短躲避拥堵
            shortestRouteShortestRouteAvoidCongestion = 11,
            //躲避拥堵
            AvoidCongestions = 12,
            //不走高速快速路
            DontWalkFastTrackStrategy = 13,
            //避免收费
            AvoidFees = 14,
            //躲避拥堵不走高速
            AvoidCongestionDontWalkFast = 15,
            //避免收费不走高速
            AvoidFeesDontWalkFast = 16,
            //躲避拥堵避免收费
            AvoidCongestionsAvoidFees = 17,
            //避免拥堵避免收费不走高速
            AvoidCongestionsAvoidFeesDontWalkFast = 18,
            //高速优先
            HighPriority = 19,
            //躲避拥堵高速优先
            AvoidCongestionHighPriority = 20
        }
    }
}
