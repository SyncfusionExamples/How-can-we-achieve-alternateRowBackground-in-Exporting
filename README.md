# How can we achieve alternateRowBackground in DataGrid Pdf Exporting?
In this article, we will show you how to achieve alternateRowBackgroud in [.Net Maui DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid) Exporting.

Please note that exporting does not support AlternateRowBackground in the MAUI SfDataGrid. However, you can achieve alternate row background color using the [RowExporting](https://help.syncfusion.com/maui/datagrid/export-to-pdf#rowexporting) event.

## C#
The below code illustrates how to achieve alternateRowBackgroud in DataGrid Pdf Exporting.
```
    private void Button_Clicked(object sender, EventArgs e)
    {
        MemoryStream stream = new MemoryStream();
        DataGridPdfExportingController pdfExport = new DataGridPdfExportingController();
        pdfExport.RowExporting += pdfExport_RowExporting;
        DataGridPdfExportingOption option = new DataGridPdfExportingOption();
        var pdfDoc = new PdfDocument();
        pdfDoc = pdfExport.ExportToPdf(this.dataGrid, option);
        pdfDoc.Save(stream);
        pdfDoc.Close(true);
        SaveService saveService = new();
        saveService.SaveAndView("ExportFeature.pdf", "application/pdf", stream);
    }

    void pdfExport_RowExporting(object sender, DataGridRowPdfExportingEventArgs e)
    {
        if (e.RowType == ExportRowType.RecordRow)
        {
            var index = dataGrid?.View?.Records.IndexOf(e.Record);
            if (index % 2 == 0)
            {
                e.PdfRow.Style.BackgroundBrush = PdfBrushes.Yellow;
            }
            else
            {
                e.PdfRow.Style.BackgroundBrush = PdfBrushes.Transparent;
            }
        }
    }
```
 ![PdfExport.png](https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI3NDI0Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.V7Xbok1tK2nU00-zlzaP_dK8Q9DKcuv5dR8h-YA6T-Y)

[View sample in GitHub](https://github.com/SyncfusionExamples/How-can-we-achieve-alternateRowBackground-in-Exporting)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to achieve alternateRowBackgroud in .NET MAUI DataGrid (SfDataGrid) Pdf Exporting.
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!