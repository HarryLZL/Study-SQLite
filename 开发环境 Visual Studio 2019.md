# Study-SQLite
## 系统环境
   Visual studio 2019
   
   
   
## 备忘录
### NuGet 无法联网解决方法

 1. 工具 - NuGet包管理 - NuGet控制台

 2. 输入以下代码后，按回车
   [Net.ServicePointManager]::SecurityProtocol=[Net.ServicePointManager]::SecurityProtocol-bOR [Net.SecurityProtocolType]::Tls12

 3. 再打开 项目 - 管理NuGet程序包 就可以检索安装包插件了

 4. 但是有个问题，就是关闭VS后，重新打开就会失去效果，需要再次输入代码，按回车才能生效。

	用上面的方法如果还不行，那么直接去官网下载。
	官网网址：https://www.nuget.org/

	下载方法：
		直接在输入框输入检索词。
		例如输入：NanUI，就会打开搜索列表
		选择第一个点进去
		这里可以用两种方式安装：
			1.复制PM>后面的指令代码，NuGet 控制台安装，
			2.在版本列表右侧下载安装包，下载完成双击就可以安装了
