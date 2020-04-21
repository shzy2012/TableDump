# TableDump


将数据直接保存为文件

```vb
dim arrayData = ''
// 使用步骤：
//1.数据抓取
arrayData = UiElement.DataScrap({"html":{"attrMap":{"aaname":"序号 股票代码 股票简称 涨跌幅 所属概念","tag":"TABLE"},"index":0,"tagName":"TABLE"},"wnd":[{"app":"chrome","cls":"Chrome_WidgetWin_1","title":"*"},{"cls":"Chrome_RenderWidgetHostHWND","title":"Chrome Legacy Window"}]},{"Columns":[],"ExtractTable":1},{"objNextLinkElement":"","iMaxNumberOfPage":5,"iMaxNumberOfResult":-1,"iDelayBetweenMS":1000,"bContinueOnError":false})
//2.将数据保存到桌面
TableDump.Dump(arrayData)
```
