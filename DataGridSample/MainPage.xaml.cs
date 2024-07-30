using Syncfusion.Maui.DataGrid.Exporting;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;

namespace DataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

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
                    e.PdfRow.Style.BackgroundBrush = PdfBrushes.SkyBlue;
                }
                else
                {
                    e.PdfRow.Style.BackgroundBrush = PdfBrushes.Transparent;
                }
            }
        }
    }
}