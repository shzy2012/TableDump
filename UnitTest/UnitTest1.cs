using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using TableDump;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ITableDumpPlugin tableDump = new TableDumpPlugin();

            string json = @"[
[
'整租·梅陇十村 1室1厅 南\n\n徐汇-华东理工-梅陇十村 / 50㎡ /南 / 1室1厅1卫\n\n新上 随时看房\n\n贝壳优选 4天前维护\n\n3500 元/月'
],
[
'整租·梅陇十村 1室1厅 南\n\n徐汇-华东理工-梅陇十村 / 50㎡ /南 / 1室1厅1卫\n\n新上 随时看房\n\n贝壳优选 4天前维护\n\n3500 元/月'
],
[
'整租·花苑茶花园 1室1厅 南\n\n徐汇-康健-花苑茶花园 / 34㎡ /南 / 1室1厅1卫\n\n随时看房\n\n贝壳优选 8天前维护\n\n3500 元/月'
],
[
'整租·花苑茶花园 1室1厅 南\n\n徐汇-康健-花苑茶花园 / 34㎡ /南 / 1室1厅1卫\n\n随时看房\n\n贝壳优选 8天前维护\n\n3500 元/月'
],
[
'整租·万乐城(商业类) 1室0厅 北\n\n闵行-吴泾-万乐城(商业类) / 22㎡ /北 / 1室0厅1卫\n\n精装 随时看房\n\n贝壳优选 8天前维护\n\n2000 元/月'
],
[
'整租·万乐城(商业类) 1室0厅 北\n\n闵行-吴泾-万乐城(商业类) / 22㎡ /北 / 1室0厅1卫\n\n精装 随时看房\n\n贝壳优选 8天前维护\n\n2000 元/月'
],
[
'整租·虹仙小区 1室1厅 南\n\n长宁-仙霞-虹仙小区 / 37㎡ /南 / 1室1厅1卫\n\n近地铁 精装 随时看房\n\n贝壳优选 今天维护\n\n4500 元/月'
],
[
'整租·虹仙小区 1室1厅 南\n\n长宁-仙霞-虹仙小区 / 37㎡ /南 / 1室1厅1卫\n\n近地铁 精装 随时看房\n\n贝壳优选 今天维护\n\n4500 元/月'
],
[
'整租·瞿溪路115-131号 1室0厅 北\n\n黄浦-蓬莱公园-瞿溪路115-131号 / 30㎡ /北 / 1室0厅1卫\n\n近地铁 随时看房\n\n贝壳优选 1个月前维护\n\n3900 元/月'
],
[
'整租·瞿溪路115-131号 1室0厅 北\n\n黄浦-蓬莱公园-瞿溪路115-131号 / 30㎡ /北 / 1室0厅1卫\n\n近地铁 随时看房\n\n贝壳优选 1个月前维护\n\n3900 元/月'
],
[
'整租·田林十一村 1室0厅 南\n\n徐汇-田林-田林十一村 / 35㎡ /南 / 1室0厅1卫\n\n新上 近地铁 随时看房\n\n贝壳优选 今天维护\n\n4400 元/月'
],
[
'整租·田林十一村 1室0厅 南\n\n徐汇-田林-田林十一村 / 35㎡ /南 / 1室0厅1卫\n\n新上 近地铁 随时看房\n\n贝壳优选 今天维护\n\n4400 元/月'
],
[
'整租·五浦汇B区崧子苑 2室2厅 南\n\n青浦-盈浦-五浦汇B区崧子苑 / 86㎡ /南 / 2室2厅1卫\n\n随时看房\n\n贝壳优选 3天前维护\n\n3200 元/月'
],
[
'整租·五浦汇B区崧子苑 2室2厅 南\n\n青浦-盈浦-五浦汇B区崧子苑 / 86㎡ /南 / 2室2厅1卫\n\n随时看房\n\n贝壳优选 3天前维护\n\n3200 元/月'
],
[
'整租·长虹坊 2室1厅 南\n\n徐汇-康健-长虹坊 / 74㎡ /南 / 2室1厅1卫\n\n随时看房\n\n贝壳优选 2天前维护\n\n5300 元/月'
],
[
'整租·长虹坊 2室1厅 南\n\n徐汇-康健-长虹坊 / 74㎡ /南 / 2室1厅1卫\n\n随时看房\n\n贝壳优选 2天前维护\n\n5300 元/月'
],
[
'整租·独立时代 1室0厅 南\n\n黄浦-蓬莱公园-独立时代 / 36㎡ /南 / 1室0厅1卫\n\n近地铁 精装 随时看房\n\n贝壳优选 9天前维护\n\n5190 元/月'
],
[
'整租·独立时代 1室0厅 南\n\n黄浦-蓬莱公园-独立时代 / 36㎡ /南 / 1室0厅1卫\n\n近地铁 精装 随时看房\n\n贝壳优选 9天前维护\n\n5190 元/月'
],
[
'整租·新泾一村 2室0厅 南\n\n长宁-北新泾-新泾一村 / 53㎡ /南 / 2室0厅1卫\n\n近地铁 随时看房\n\n贝壳优选 5天前维护\n\n5400 元/月'
],
[
'整租·新泾一村 2室0厅 南\n\n长宁-北新泾-新泾一村 / 53㎡ /南 / 2室0厅1卫\n\n近地铁 随时看房\n\n贝壳优选 5天前维护\n\n5400 元/月'
],
[
'整租·南丹小区 1室0厅 南\n\n徐汇-徐家汇-南丹小区 / 28㎡ /南 / 1室0厅1卫\n\n近地铁 精装 随时看房\n\n贝壳优选 今天维护\n\n4680 元/月'
],
[
'整租·南丹小区 1室0厅 南\n\n徐汇-徐家汇-南丹小区 / 28㎡ /南 / 1室0厅1卫\n\n近地铁 精装 随时看房\n\n贝壳优选 今天维护\n\n4680 元/月'
],
[
'整租·城东新村（三区） 2室1厅 南\n\n青浦-夏阳-城东新村（三区） / 64㎡ /南 / 2室1厅1卫\n\n新上 随时看房\n\n贝壳优选 5天前维护\n\n2500 元/月'
],
[
'整租·城东新村（三区） 2室1厅 南\n\n青浦-夏阳-城东新村（三区） / 64㎡ /南 / 2室1厅1卫\n\n新上 随时看房\n\n贝壳优选 5天前维护\n\n2500 元/月'
],
[
'整租·西部花苑（一期、三期） 3室2厅 南\n\n青浦-盈浦-西部花苑（一期、三期） / 119㎡ /南 / 3室2厅2卫\n\n精装 双卫生间 随时看房\n\n贝壳优选 5天前维护\n\n3500 元/月'
],
[
'整租·西部花苑（一期、三期） 3室2厅 南\n\n青浦-盈浦-西部花苑（一期、三期） / 119㎡ /南 / 3室2厅2卫\n\n精装 双卫生间 随时看房\n\n贝壳优选 5天前维护\n\n3500 元/月'
],
[
'整租·斜土路2200弄 1室1厅 南\n\n徐汇-徐家汇-斜土路2200弄 / 33㎡ /南 / 1室1厅1卫\n\n新上 近地铁 精装 随时看房\n\n贝壳优选 4天前维护\n\n5600 元/月'
],
[
'整租·斜土路2200弄 1室1厅 南\n\n徐汇-徐家汇-斜土路2200弄 / 33㎡ /南 / 1室1厅1卫\n\n新上 近地铁 精装 随时看房\n\n贝壳优选 4天前维护\n\n5600 元/月'
],
[
'整租·万寿新村(青浦) 3室2厅 南\n\n青浦-盈浦-万寿新村(青浦) / 89㎡ /南 / 3室2厅1卫\n\n精装 随时看房\n\n贝壳优选 7天前维护\n\n3600 元/月'
],
[
'整租·万寿新村(青浦) 3室2厅 南\n\n青浦-盈浦-万寿新村(青浦) / 89㎡ /南 / 3室2厅1卫\n\n精装 随时看房\n\n贝壳优选 7天前维护\n\n3600 元/月'
],
[
'整租·田林新苑 2室1厅 西\n\n徐汇-田林-田林新苑 / 70㎡ /西 / 2室1厅1卫\n\n新上 近地铁 随时看房\n\n贝壳优选 1天前维护\n\n6700 元/月'
],
[
'整租·田林新苑 2室1厅 西\n\n徐汇-田林-田林新苑 / 70㎡ /西 / 2室1厅1卫\n\n新上 近地铁 随时看房\n\n贝壳优选 1天前维护\n\n6700 元/月'
],
[
'整租·寿益坊 2室1厅 南\n\n徐汇-康健-寿益坊 / 62㎡ /南 / 2室1厅1卫\n\n随时看房\n\n贝壳优选 10天前维护\n\n5400 元/月'
],
[
'整租·寿益坊 2室1厅 南\n\n徐汇-康健-寿益坊 / 62㎡ /南 / 2室1厅1卫\n\n随时看房\n\n贝壳优选 10天前维护\n\n5400 元/月'
],
[
'整租·长桥八村 2室1厅 南\n\n徐汇-长桥-长桥八村 / 73㎡ /南 / 2室1厅1卫\n\n随时看房\n\n贝壳优选 15天前维护\n\n4800 元/月'
],
[
'整租·长桥八村 2室1厅 南\n\n徐汇-长桥-长桥八村 / 73㎡ /南 / 2室1厅1卫\n\n随时看房\n\n贝壳优选 15天前维护\n\n4800 元/月'
],
[
'整租·五浦汇A区新塘苑 2室1厅 南\n\n青浦-盈浦-五浦汇A区新塘苑 / 76㎡ /南 / 2室1厅1卫\n\n随时看房\n\n贝壳优选 3天前维护\n\n2900 元/月'
],
[
'整租·五浦汇A区新塘苑 2室1厅 南\n\n青浦-盈浦-五浦汇A区新塘苑 / 76㎡ /南 / 2室1厅1卫\n\n随时看房\n\n贝壳优选 3天前维护\n\n2900 元/月'
],
[
'整租·长桥三村 2室1厅 南\n\n徐汇-长桥-长桥三村 / 58㎡ /南 / 2室1厅1卫\n\n随时看房\n\n贝壳优选 11天前维护\n\n4400 元/月'
],
[
'整租·长桥三村 2室1厅 南\n\n徐汇-长桥-长桥三村 / 58㎡ /南 / 2室1厅1卫\n\n随时看房\n\n贝壳优选 11天前维护\n\n4400 元/月'
],
[
'整租·帕缇欧香苑 2室2厅 南\n\n青浦-夏阳-帕缇欧香苑 / 79㎡ /南 / 2室2厅1卫\n\n随时看房\n\n贝壳优选 5天前维护\n\n3100 元/月'
],
[
'整租·帕缇欧香苑 2室2厅 南\n\n青浦-夏阳-帕缇欧香苑 / 79㎡ /南 / 2室2厅1卫\n\n随时看房\n\n贝壳优选 5天前维护\n\n3100 元/月'
],
[
'整租·绿园四村 2室2厅 南\n\n长宁-西郊-绿园四村 / 89㎡ /南 / 2室2厅1卫\n\n随时看房\n\n贝壳优选 5天前维护\n\n6300 元/月'
],
[
'整租·绿园四村 2室2厅 南\n\n长宁-西郊-绿园四村 / 89㎡ /南 / 2室2厅1卫\n\n随时看房\n\n贝壳优选 5天前维护\n\n6300 元/月'
],
[
'整租·罗秀二村 2室1厅 南\n\n徐汇-长桥-罗秀二村 / 57㎡ /南 / 2室1厅1卫\n\n随时看房\n\n贝壳优选 1天前维护\n\n4300 元/月'
],
[
'整租·罗秀二村 2室1厅 南\n\n徐汇-长桥-罗秀二村 / 57㎡ /南 / 2室1厅1卫\n\n随时看房\n\n贝壳优选 1天前维护\n\n4300 元/月'
],
[
'整租·仁恒运杰河滨花园 3室1厅 南\n\n青浦-夏阳-仁恒运杰河滨花园 / 86㎡ /南 / 3室1厅1卫\n\n新上 精装 随时看房\n\n贝壳优选 今天维护\n\n3300 元/月'
],
[
'整租·仁恒运杰河滨花园 3室1厅 南\n\n青浦-夏阳-仁恒运杰河滨花园 / 86㎡ /南 / 3室1厅1卫\n\n新上 精装 随时看房\n\n贝壳优选 今天维护\n\n3300 元/月'
],
[
'整租·中心铂庭 1室1厅 西北\n\n静安-西藏北路-中心铂庭 / 50㎡ /西北 / 1室1厅1卫\n\n新上 近地铁 精装 随时看房\n\n贝壳优选 3天前维护\n\n5500 元/月'
],
[
'整租·中心铂庭 1室1厅 西北\n\n静安-西藏北路-中心铂庭 / 50㎡ /西北 / 1室1厅1卫\n\n新上 近地铁 精装 随时看房\n\n贝壳优选 3天前维护\n\n5500 元/月'
],
[
'整租·东湾小区 2室1厅 南/北\n\n徐汇-华泾-东湾小区 / 82㎡ /南 北 / 2室1厅1卫\n\n随时看房\n\n贝壳优选 16天前维护\n\n4300 元/月'
],
[
'整租·东湾小区 2室1厅 南/北\n\n徐汇-华泾-东湾小区 / 82㎡ /南 北 / 2室1厅1卫\n\n随时看房\n\n贝壳优选 16天前维护\n\n4300 元/月'
],
[
'整租·中心铂庭 1室0厅 南\n\n静安-西藏北路-中心铂庭 / 42㎡ /南 / 1室0厅1卫\n\n新上 近地铁 精装 随时看房\n\n贝壳优选 2天前维护\n\n5500 元/月'
],
[
'整租·中心铂庭 1室0厅 南\n\n静安-西藏北路-中心铂庭 / 42㎡ /南 / 1室0厅1卫\n\n新上 近地铁 精装 随时看房\n\n贝壳优选 2天前维护\n\n5500 元/月'
],
[
'整租·茶陵路65弄 1室0厅 南\n\n徐汇-斜土路-茶陵路65弄 / 29㎡ /南 / 1室0厅1卫\n\n近地铁 精装 随时看房\n\n贝壳优选 9天前维护\n\n4850 元/月'
],
[
'整租·茶陵路65弄 1室0厅 南\n\n徐汇-斜土路-茶陵路65弄 / 29㎡ /南 / 1室0厅1卫\n\n近地铁 精装 随时看房\n\n贝壳优选 9天前维护\n\n4850 元/月'
],
[
'整租·红旗花苑 2室2厅 南\n\n闵行-老闵行-红旗花苑 / 75㎡ /南 / 2室2厅1卫\n\n新上 近地铁 精装 随时看房\n\n贝壳优选 1天前维护\n\n3300 元/月'
],
[
'整租·红旗花苑 2室2厅 南\n\n闵行-老闵行-红旗花苑 / 75㎡ /南 / 2室2厅1卫\n\n新上 近地铁 精装 随时看房\n\n贝壳优选 1天前维护\n\n3300 元/月'
],
[
'整租·柳营路1025弄 2室1厅 南\n\n静安-大宁-柳营路1025弄 / 54㎡ /南 / 2室1厅1卫\n\n精装 随时看房\n\n贝壳优选 8天前维护\n\n5490 元/月'
],
[
'整租·柳营路1025弄 2室1厅 南\n\n静安-大宁-柳营路1025弄 / 54㎡ /南 / 2室1厅1卫\n\n精装 随时看房\n\n贝壳优选 8天前维护\n\n5490 元/月'
]
]";
            JArray data = JArray.Parse(json);

            tableDump.Dump(data);
        }

        [TestMethod]
        public void TestMethod2()
        {
            ITableDumpPlugin tableDump = new TableDumpPlugin();

            string json = @"[
[ '序号', '股票代码', '股票简称', '涨跌幅', '所属概念' ],
[
'1',
'688126',
'沪硅产业',
'180.46 %',
'融资融券，新股与次新股'
],
[
'2',
'688399',
'硕世生物',
'18.18 %',
'融资融券，医疗器械概念，新股与次新股，流感'
],
[
'3',
'688068',
'热景生物',
'11.51 %',
'融资融券，食品安全，医疗器械概念，新股与次新股，流感'
],
[
'4',
'002400',
'省广集团',
'10.12 %',
'融资融券，文化传媒，大数据，体育产业，区块链，横琴新区，数据中心'
],
[
'5',
'002421',
'达实智能',
'10.11 %',
'物联网，融资融券，智慧城市，深股通，二维码识别，雄安新区，区块链，互联网医疗，腾讯概念，边缘计算，数字中国，数字孪生，富时罗素概念股，标普道琼斯A股，数据中心'
],
[
'6',
'002480',
'新筑股份',
'10.10 %',
'新能源汽车，高铁，股权转让，燃料电池，超级电容'
],
[
'7',
'002472',
'双环传动',
'10.09 %',
'创投，高端装备，新能源汽车，特斯拉，机器人概念，高铁，独角兽概念，宁德时代概念'
],
[
'8',
'002061',
'浙江交科',
'10.09 %',
'PPP概念，深股通，富时罗素概念股，标普道琼斯A股'
]
]";
            JArray data = JArray.Parse(json);

            tableDump.Dump(data);
        }

        [TestMethod]
        public void TestMethod3()
        {
            ITableDumpPlugin tableDump = new TableDumpPlugin();

            string json = @"[
[
'UiBot开发者指南（必看）：https://docs.uibot.com.cn/guide/\n'
],
[ '命令手册：https://docs.uibot.com.cn/' ],
[ '' ],
[ '【视频教程】\n' ],
[ '' ],
[ '\n' ],
[ '入门教程' ],
[ '' ],
[
'UiBot入门教程- RPA概念介绍：https://forum.uibot.com.cn/thread-1426.htm'
],
[
'UiBot入门教程- UiBot产品介绍：https://forum.uibot.com.cn/thread-1427.htm'
],
[
'UiBot使用教程-软件版本和离线激活：https://forum.uibot.com.cn/thread-1612.htm'
],
[
'UiBot使用教程-流程图界面操作说明：https://forum.uibot.com.cn/thread-1613.htm'
],
[
'UiBot使用教程-编辑器界面操作说明：https://forum.uibot.com.cn/thread-1614.htm'
],
[
'UiBot使用教程-RPA机器人开发基础：https://forum.uibot.com.cn/thread-1615.htm'
],
[
'UiBot使用教程-常用命令：https://forum.uibot.com.cn/thread-1616.htm'
],
[
'UiBot使用教程-可视化语法：https://forum.uibot.com.cn/thread-1617.htm'
],
[ '\n' ],
[ '使用教程' ],
[
'3/25更新-鼠标功能详解：https://forum.uibot.com.cn/thread-378.htm'
],
[
'3/25更新-键盘功能详解：https://forum.uibot.com.cn/thread-379.htm'
],
[
'4/1更新-变量与数据类型（上）：https://forum.uibot.com.cn/thread-404.htm'
],
[
'4/1更新-变量与数据类型（下）：https://forum.uibot.com.cn/thread-405.htm'
],
[
'4/2更新-判断表达式：https://forum.uibot.com.cn/thread-425.htm'
],
[
'4/2更新-判断流程详解：https://forum.uibot.com.cn/thread-426.htm'
],
[
'4/4更新-Do循环详解：https://forum.uibot.com.cn/thread-435.htm'
],
[
'4/4更新-For循环详解：https://forum.uibot.com.cn/thread-436.htm'
],
[
'4/15更新-网页数据抓取详解：https://forum.uibot.com.cn/thread-504.htm'
],
[ '' ],
[
'4/19更新-界面元素详解（上）：https://forum.uibot.com.cn/thread-539.htm'
],
[
'4/19更新-界面元素详解（下）：https://forum.uibot.com.cn/thread-540.htm'
],
[
'4/23更新-网页批量抓取实例详解：https://forum.uibot.com.cn/thread-565.htm'
],
[
'4/28更新-Function函数详解：https://forum.uibot.com.cn/thread-593.htm'
],
[ '' ],
[
'4/30更新-File文件目录详解：https://forum.uibot.com.cn/thread-605.htm'
],
[ '' ],
[
'9/19更新-微信群发：https://forum.uibot.com.cn/thread-2632.htm'
],
[
'9/19更新-钉钉群发：https://forum.uibot.com.cn/thread-2628.htm'
],
[ '' ],
[
'9/28更新-邮箱操作 一：https://forum.uibot.com.cn/thread-2852.htm'
],
[
'9/28更新-邮箱操作 二：https://forum.uibot.com.cn/thread-2853.htm'
],
[
'9/28更新-邮箱操作 三：https://forum.uibot.com.cn/thread-2854.htm'
],
[ '' ],
[
'10/8更新-数据表命令详解 一：https://forum.uibot.com.cn/thread-3112.htm'
],
[
'10/8更新-数据表命令详解 二：https://forum.uibot.com.cn/thread-3113.htm'
],
[
'10/8更新-数据表命令详解 三：https://forum.uibot.com.cn/thread-3114.htm'
],
[
'10/23更新-数据表命令详解 四：https://forum.uibot.com.cn/thread-3370.htm'
],
[
'11/4更新- INI文件使用 一：https://forum.uibot.com.cn/thread-3590.htm'
],
[
'11/4更新- INI文件使用 二：https://forum.uibot.com.cn/thread-3591.htm'
],
[
'11/12更新- 字符串使用 一：https://forum.uibot.com.cn/thread-3774.htm'
],
[
'11/12更新- 字符串使用 二：https://forum.uibot.com.cn/thread-3775.htm'
],
[
'11/12更新- 字符串使用 三：https://forum.uibot.com.cn/thread-3776.htm'
],
[
'11/12更新- 字符串使用 四：https://forum.uibot.com.cn/thread-3777.htm'
],
[
'11/12更新- 字符串使用 五：https://forum.uibot.com.cn/thread-3778.htm'
],
[ '' ],
[
'12/25更新-数组之插入元素：https://forum.uibot.com.cn/thread-4799.htm'
],
[
'12/25更新-数组之删除修改与查找：https://forum.uibot.com.cn/thread-4800.htm'
],
[
'12/25更新- OCR之本地OCR识字找字：https://forum.uibot.com.cn/thread-4801.htm'
],
[
'12/25更新- OCR之百度OCR识字找字：https://forum.uibot.com.cn/thread-4802.htm'
],
[ '\n' ],
[
'5/6更新-文件读写函数优化之读写一维数组：https://forum.uibot.com.cn/thread-638.htm'
],
[
'5/6更新-文件读写函数优化之读写二维数组：https://forum.uibot.com.cn/thread-639.htm'
],
[
'5/6更新-文件读写函数优化之读取指定行：https://forum.uibot.com.cn/thread-640.htm'
],
[
'5/6更新-文件读写函数优化之插入指定行：https://forum.uibot.com.cn/thread-641.htm'
],
[
'5/6更新-文件读写函数优化之替换指定行：https://forum.uibot.com.cn/thread-642.htm'
],
[
'5/6更新-文件读写函数优化之删除指定行：https://forum.uibot.com.cn/thread-643.htm'
],
[ '' ],
[
'5/13更新-系统命令行之遍历文件与文件夹：https://forum.uibot.com.cn/thread-686.htm'
],
[ '' ],
[
'5/15更新-流程概念详解：https://forum.uibot.com.cn/thread-704.htm'
],
[
'7/23更新-动态随机元素处理：https://forum.uibot.com.cn/thread-1385.htm'
],
[ '' ],
[ '' ],
[
'7/17更新-数组（一）：https://forum.uibot.com.cn/thread-1311.htm'
],
[
'7/17更新-数组（二）： https://forum.uibot.com.cn/thread-1312.htm'
],
[ '' ],
[
'7/26更新-数组与随机数：https://forum.uibot.com.cn/thread-1436.htm'
],
[ '' ],
[
'8/1更新-字典的基础知识：https://forum.uibot.com.cn/thread-1520.htm'
],
[
'8/1更新-复合数据类型：https://forum.uibot.com.cn/thread-1532.htm'
],
[
'8/1更新-遍历复合类型：https://forum.uibot.com.cn/thread-1534.htm'
],
[ '\n' ],
[
'5/22更新-Excel命令详解 一：https://forum.uibot.com.cn/thread-745.htm'
],
[
'5/22更新-Excel命令详解 二：https://forum.uibot.com.cn/thread-746.htm'
],
[
'5/22更新-Excel命令详解 三：https://forum.uibot.com.cn/thread-747.htm'
],
[ '' ],
[
'6/10更新-Excel命令详解 四：https://forum.uibot.com.cn/thread-886.htm'
],
[ '' ],
[
'8/7更新-Excel命令详解 五：https://forum.uibot.com.cn/thread-1626.htm'
],
[
'8/7更新-Excel命令详解 六：https://forum.uibot.com.cn/thread-1627.htm'
],
[ '' ],
[
'8/30更新-Excel命令详解 七：https://forum.uibot.com.cn/thread-2138.htm'
],
[
'8/30更新-Excel命令详解 八：https://forum.uibot.com.cn/thread-2139.htm'
],
[
'8/19更新-图像命令讲解（上）：https://forum.uibot.com.cn/thread-421.htm'
],
[
'8/19更新-图像命令讲解（下）：https://forum.uibot.com.cn/thread-427.htm'
],
[
'9/2更新-窗口与应用命令：https://forum.uibot.com.cn/thread-2278.htm'
],
[ '\n' ],
[ '\n' ],
[
'5/30更新-获取日期时间函数：https://forum.uibot.com.cn/thread-817.htm'
],
[
'5/30更新-时间数据的转换和加减计算：https://forum.uibot.com.cn/thread-818.htm'
],
[
'5/31更新-每隔一段时间执行一次代码：https://forum.uibot.com.cn/thread-832.htm'
],
[
'5/31更新-每天定时执行代码：https://forum.uibot.com.cn/thread-833.htm'
],
[ '' ],
[ '\n' ],
[
'UiBot使用教程-字符串操作：https://forum.uibot.com.cn/thread-1620.htm'
],
[
'UiBot使用教程-数组字典操作：https://forum.uibot.com.cn/thread-1623.htm'
],
[
'UiBot使用教程-数学操作：https://forum.uibot.com.cn/thread-1624.htm'
],
[
'UiBot使用教程-窗口操作：https://forum.uibot.com.cn/thread-1625.htm'
],
[
'4/2更新-图像命令讲解（上）：https://forum.uibot.com.cn/thread-421.htm'
],
[
'4/2更新-图像命令讲解（下）：https://forum.uibot.com.cn/thread-427.htm'
],
[
'4/3更新-OCR识别详解（上）：https://forum.uibot.com.cn/thread-432.htm'
],
[
'4/3更新-OCR识别详解（下）：https://forum.uibot.com.cn/thread-434.htm'
],
[
'4/9更新-网页使用详解（一）：https://forum.uibot.com.cn/thread-467.htm'
],
[
'4/9更新-网页使用详解（二）：https://forum.uibot.com.cn/thread-468.htm'
],
[
'4/9更新-网页使用详解（三）：https://forum.uibot.com.cn/thread-469.htm'
],
[
'4/12更新-JS的标签查找：https://forum.uibot.com.cn/thread-502.htm'
],
[
'4/12更新-JS的鼠标事件：https://forum.uibot.com.cn/thread-503.htm'
],
[ '' ],
[
'4/12更新-Word功能详解 上：https://forum.uibot.com.cn/thread-506.htm'
],
[
'4/12更新-Word功能详解 下：https://forum.uibot.com.cn/thread-507.htm'
],
[ '' ],
[
'4/17更新-Python函数构造（一）：https://forum.uibot.com.cn/thread-525.htm'
],
[
'4/17更新-Python流程控制（二）：https://forum.uibot.com.cn/thread-526.htm'
],
[
'4/17更新-Python运用示例（三）：https://forum.uibot.com.cn/thread-527.htm'
],
[ '' ],
[
'4/18更新-字符串命令详解（上）：https://forum.uibot.com.cn/thread-534.htm'
],
[
'4/18更新-字符串命令详解（下）：https://forum.uibot.com.cn/thread-535.htm'
],
[ '\n' ],
[
'4/5更新-css-selector基础教程一：https://forum.uibot.com.cn/thread-445.htm'
],
[
'4/5更新-css-selector基础教程二：https://forum.uibot.com.cn/thread-447.htm'
],
[
'4/6更新-JSON、字典、jsonPath 基础教程一：https://forum.uibot.com.cn/thread-452.htm'
],
[
'4/6更新-JSON、字典、jsonPath 基础教程二：https://forum.uibot.com.cn/thread-453.htm'
],
[
'4/13更新-正则表达式教程（一）：https://forum.uibot.com.cn/thread-493.htm'
],
[
'4/14更新-正则表达式教程（二）：https://forum.uibot.com.cn/thread-494.htm'
],
[
'4/15更新-正则表达式教程（三）：https://forum.uibot.com.cn/thread-500.htm'
],
[
'4/16更新-正则表达式教程（四）：https://forum.uibot.com.cn/thread-511.htm'
],
[ '' ],
[
'4/17更新-正则表达式教程（五）：https://forum.uibot.com.cn/thread-518.htm'
],
[
'4/21更新-XPath基础教程（一）：https://forum.uibot.com.cn/thread-553.htm'
],
[ '' ],
[
'4/27更新-XPath基础教程（二）：https://forum.uibot.com.cn/thread-584.htm'
],
[
'4/27更新-XPath基础教程（三）：https://forum.uibot.com.cn/thread-585.htm'
],
[
'5/4更新-XPath基础教程（四）：https://forum.uibot.com.cn/thread-619.htm'
],
[
'5/4更新-XPath基础教程（五）：https://forum.uibot.com.cn/thread-620.htm'
],
[
'5/5更新-XPath基础教程（六）：https://forum.uibot.com.cn/thread-625.htm'
],
[ '' ],
[
'5/15更新-ADODB Excel基础教程一：https://forum.uibot.com.cn/thread-637.htm'
],
[
'5/15更新-ADODB Excel基础教程二：https://forum.uibot.com.cn/thread-646.htm'
],
[
'5/15更新-ADODB CSV、MDB基础教程三：https://forum.uibot.com.cn/thread-660.htm'
],
[
'5/15更新-ADODB 实战教程四：https://forum.uibot.com.cn/thread-700.htm'
],
[
'5/15更新-ADODB 实战教程五：https://forum.uibot.com.cn/thread-702.htm'
],
[
'5/15更新-ADODB 实战教程六：https://forum.uibot.com.cn/thread-703.htm'
],
[ '' ],
[
'5/29-数据库插件使用教程 一：https://forum.uibot.com.cn/thread-797.htm'
],
[
'5/29-数据库插件使用教程 二：https://forum.uibot.com.cn/thread-798.htm'
],
[ '\n' ],
[ '实战案例' ],
[ '' ],
[
'3/20更新-验证码识别：https://forum.uibot.com.cn/thread-254.htm'
],
[
'3/20更新-本地图片制作字库：https://forum.uibot.com.cn/thread-350.htm'
],
[
'4/1更新-浏览器自动验证、自动登录实例：https://forum.uibot.com.cn/thread-409.htm'
],
[ '4/11更新-自动登陆：https://forum.uibot.com.cn/thread-484.htm' ],
[ '' ],
[ '' ],
[
'5/5更新-小说数据采集案例：https://forum.uibot.com.cn/thread-633.htm'
],
[
'5/5更新-使用Python采集小说案例：https://forum.uibot.com.cn/thread-634.htm'
],
[
'5/5更新-自动登录邮箱案例：https://forum.uibot.com.cn/thread-635.htm'
],
[
'9/21更新-Excel数据填写到网页表单：https://forum.uibot.com.cn/thread-422.htm'
],
[ '\n' ],
[ '零基础学UiBot实战案例' ],
[ '' ],
[ '基本概念：https://forum.uibot.com.cn/thread-2214.htm' ],
[ '数据查询：https://forum.uibot.com.cn/thread-2098.htm' ],
[ '数据抓取：https://forum.uibot.com.cn/thread-2140.htm' ],
[ '工资计算：https://forum.uibot.com.cn/thread-2217.htm' ],
[ '时间设定：https://forum.uibot.com.cn/thread-2277.htm' ],
[ '\n' ],
[ '【界面操作】' ],
[
'2.0流程视图基本介绍：https://forum.uibot.com.cn/thread-370.htm'
],
[ '软件主界面操作：https://forum.uibot.com.cn/thread-176.htm' ],
[ '可视化视图操作：https://forum.uibot.com.cn/thread-177.htm' ],
[ '源代码视图操作：https://forum.uibot.com.cn/thread-178.htm' ],
[ ' ' ],
[ '【常见问题】' ],
[
'系统环境及配置要求：https://forum.uibot.com.cn/thread-174.htm'
],
[ '调节系统DPI：https://forum.uibot.com.cn/thread-181.htm' ],
[ '\n' ],
[ '【使用技巧】' ],
[
'巧用变量使数据搬运功能更简单更稳定：https://forum.uibot.com.cn/thread-13.htm'
],
[
'时间库怎么用（共3节）：https://forum.uibot.com.cn/thread-25.htm'
],
[
'数据抓取功能使用教学（共2节）：https://forum.uibot.com.cn/thread-32.htm'
],
[
'关于如何使用浏览器调用JS命令的说明：https://forum.uibot.com.cn/thread-61.htm?tdsourcetag=s_pcqq_aiomsg'
],
[ ' ' ],
[ '【实战案例】' ],
[
'只要5行代码就能扒小说！？（共3节）：https://forum.uibot.com.cn/thread-29.htm'
],
[
'梦想云ERP系统数据获取和填写（共2节）：https://forum.uibot.com.cn/thread-37.htm'
],
[ '' ],
[
'利用遍历子元素来获取文件列表：https://forum.uibot.com.cn/thread-28.htm'
],
[
'使用 UiBot 查询快递信息的代码（可改造为批量查询）：https://forum.uibot.com.cn/thread-23.htm'
],
[ '\n' ],
[ '【插件开发】' ],
[
'使用 Python 扩展 UiBot 的功能：https://forum.uibot.com.cn/thread-51.htm'
],
[
'使用 Lua 扩展 UiBot 的功能：https://forum.uibot.com.cn/thread-52.htm'
],
[
'使用 C/C++ 扩展 UiBot 的功能：https://forum.uibot.com.cn/thread-71.htm'
],
[
'使用.net为UiBot扩展功能：https://forum.uibot.com.cn/thread-70.htm'
]
]";
            JArray data = JArray.Parse(json);

            tableDump.Dump(data);
        }
    }
}
