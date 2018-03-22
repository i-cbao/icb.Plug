using System;
using System.Collections.Generic;
using System.Text;

namespace LBS.Amap.api.RequestModel
{
    public class DrivingEntity
    {
        /// <summary>
        /// 用户唯一标识(用户在高德地图官网申请)
        /// 必填项
        /// </summary>
        public string key { get; set; }

        /// <summary>
        /// 出发点(格式为 经度,纬度|经度,纬度|经度,纬度)
        /// 最多允许传入3个坐标对，每对坐标之间距离必须超过2m。
        /// 必填项
        /// </summary>
        public string origin { get; set; }

        /// <summary>
        ///目的地
        ///经度在前，纬度在后，经度和纬度用","分割，经纬度小数点后不得超过6位。 
        ///必填项
        /// </summary>
        public string destination { get; set; }
        /// <summary>
        /// 出发点poiid
        /// 当起点为POI时，建议填充此值。
        /// 非必填
        /// </summary>
        public string originid { get; set; }

        /// <summary>
        /// 目的地poiid
        /// 当终点为POI时，建议填充此值。
        /// 非必填
        /// </summary>
        public string destinationid { get; set; }

        /// <summary>
        /// 起点的poi类别
        /// 当用户知道起点POI的类别时候，建议填充此值
        /// </summary>
        public string origintype { get; set; }

        /// <summary>
        /// 终点的poi类别
        /// 当用户知道终点POI的类别时候，建议填充此值
        /// </summary>
        public int destinationtype { get; set; }

        /// <summary>
        /// base:返回基本信息；all：返回全部信息
        /// </summary>
        public string extensions { get; set; }

        /// <summary>
        /// 驾车选择策略
        /// 下方10~20的策略，会返回多条路径规划结果。
        /// 下方策略 0~9的策略，仅会返回一条路径规划结果。
        /// 0，不考虑当时路况，返回耗时最短的路线，但是此路线不一定距离最短
        /// 1，不走收费路段，且耗时最少的路线
        /// 2，不考虑路况，仅走距离最短的路线，但是可能存在穿越小路/小区的情况
        /// 3，不走快速路，例如京通快速路（因为策略迭代，建议使用13）
        /// 4，躲避拥堵的路线，但是可能会存在绕路的情况，耗时可能较长
        /// 5，多策略（同时使用速度优先、费用优先、距离优先三个策略计算路径）。其中必须说明，就算使用三个策略算路，会根据路况不固定的返回一 ~三条路径规划信息。
        /// 6，不走高速，但是不排除走其余收费路段
        /// 7，不走高速且避免所有收费路段
        /// 8，躲避收费和拥堵，可能存在走高速的情况，并且考虑路况不走拥堵路线，但有可能存在绕路和时间较长
        /// 9，不走高速且躲避收费和拥堵
        ///10，返回结果会躲避拥堵，路程较短，尽量缩短时间，与高德地图的默认策略也就是不进行任何勾选一致
        ///11，返回三个结果包含：时间最短；距离最短；躲避拥堵 （由于有更优秀的算法，建议用10代替）
        ///12，返回的结果考虑路况，尽量躲避拥堵而规划路径，与高德地图的“躲避拥堵”策略一致
        ///13，返回的结果不走高速，与高德地图“不走高速”策略一致
        ///14，返回的结果尽可能规划收费较低甚至免费的路径，与高德地图“避免收费”策略一致
        ///15，返回的结果考虑路况，尽量躲避拥堵而规划路径，并且不走高速，与高德地图的“躲避拥堵&不走高速”策略一致
        ///16，返回的结果尽量不走高速，并且尽量规划收费较低甚至免费的路径结果，与高德地图的“避免收费&不走高速”策略一致
        ///17，返回路径规划结果会尽量的躲避拥堵，并且规划收费较低甚至免费的路径结果，与高德地图的“躲避拥堵&避免收费”策略一致
        ///18，返回的结果尽量躲避拥堵，规划收费较低甚至免费的路径结果，并且尽量不走高速路，与高德地图的“避免拥堵&避免收费&不走高速”策略一致
        ///19，返回的结果会优先选择高速路，与高德地图的“高速优先”策略一致
        ///20，返回的结果会优先考虑高速路，并且会考虑路况躲避拥堵，与高德地图的“躲避拥堵&高速优先”策略一致
        ///非必填
        /// </summary>
        public string strategy { get; set; } 

        /// <summary>
        /// 途经点
        /// 经度和纬度用","分割，经度在前，纬度在后，小数点后不超过6位，坐标点之间用";"分隔
        /// 最大数目：16个坐标点。如果输入多个途径点，则按照用户输入的顺序进行路径规划
        /// 非必填
        /// </summary>
        public string waypoints { get; set; }

        /// <summary>
        /// 避让区域、
        /// 区域避让，支持32个避让区域，每个区域最多可有16个顶点
        /// 经度和纬度用","分割，经度在前，纬度在后，小数点后不超过6位，坐标点之间用";"分隔，区域之间用"|"分隔。如果是四边形则有四个坐标点，如果是五边形则有五个坐标点；
        /// 同时传入避让区域及避让道路，仅支持避让道路；
        /// 避让区域不能超过81平方公里，否则避让区域会失效。
        /// 非必填
        /// </summary>
        public string avoidpolygons { get; set; }

        /// <summary>
        /// 避让道路名（只支持一条避让道路）
        /// 非必填
        /// </summary>
        public string avoidroad { get; set; }

        /// <summary>
        /// 用汉字填入车牌省份缩写，用于判断是否限行（例如：京）
        /// 非必填
        /// </summary>
        public string province { get; set; }

        /// <summary>
        /// 填入除省份及标点之外，车牌的字母和数字（需大写）。用于判断限行相关。（例如:NH1N11）
        /// 非必填
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// 数字签名。数字签名认证用户必填
        /// 非必填
        /// </summary>
        public string sig { get; set; }

        /// <summary>
        /// 返回数据格式类型(可选值：JSON，XML)
        /// 非必填
        /// </summary>
        public string output { get; set; }

        /// <summary>
        /// 回调函数（callback值是用户定义的函数名称，此参数只在output=JSON时有效）
        /// </summary>
        public string callback { get; set; }
    }
}
