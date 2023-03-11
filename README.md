# BlazorServerRdlcReport
試著在 .NET6 Blazor Server App 使用 RDLC 報表。   
依官方說明 Blaozr 不(直接)支援 RDLC 報表，不過不反對第三方支援。經再次查找再次確認 Blaozr 不支援 RDLC Viewer 不過可以產生 RDLC report。   
雖可以產生 RDLC 報表，但不能預覽，不過可以轉成 PDF 直接下載。

## [ReportViewer Core](https://github.com/lkosson/reportviewercore) 套件
用此第三方套件產生 RDLC 報表並轉存成 PDF 格式。

## 開發環境
* Visual Studio 2022 Community
* 需安裝 [Microsoft RDLC Report Designer 2022](https://marketplace.visualstudio.com/items?itemName=ProBITools.MicrosoftRdlcReportDesignerforVisualStudio2022)
* .NET6
* Blazor Server App 
   
> ### 有點冏的地方
> .NET6 Blazor Server App 類型的專案無法 “新增RDLC 報表定義檔”。   
> 要繞一下程序，需另開一個 WinFormForRdlcFile 的專案只為專門加入『*.rdlc』『*.xsd』等檔案然後複製到 .NET6 Blaozr Server App 類型的專案才能【新增】RDLC 報表定義檔。
 
## 參考文件
* [YouTube - RDLC Report in Blazor Web Assembly | PDF & Excel Export using RDLC in Blazor](https://www.youtube.com/watch?v=7V0Yb5drLgQ&ab_channel=AshProgHelp-ProgrammingHelp)   
  --- 這是用於 2019年 .NET5 時期，然在 .NET6 已過時，不過操作程序仍俱有參考性。其中使用第三方套件 _AspNetCore.Reporting_ 但已不維護了的樣子。  
* [YouTube - RDLC Sub Report in Blazor | Display Image on RDLC Report](https://www.youtube.com/watch?v=6U72bdyMahg&ab_channel=doTNETMania)   
  --- 子報表與圖片範例。 
