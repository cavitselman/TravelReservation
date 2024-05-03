using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {           
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            string Arial_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.ttf");
            BaseFont bf = BaseFont.CreateFont(Arial_TFF, BaseFont.IDENTITY_H, true);
            Font f = new Font(bf, 12, Font.NORMAL);
            Paragraph paragraph = new Paragraph("Traversal - Statik Müşteri Raporu\n\n", f);

            document.Add(paragraph);
            document.Close();
            return File("/pdfreports/dosya1.pdf", "application/pdf", "dosya1.pdf");
        }

        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);

            string Arial_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.ttf");
            BaseFont bf = BaseFont.CreateFont(Arial_TFF, BaseFont.IDENTITY_H, true);
            Font f = new Font(bf, 12, Font.NORMAL);          

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            PdfPTable pdfPTable = new PdfPTable(3);
            pdfPTable.AddCell(new Phrase("Müşteri Adı", f));
            pdfPTable.AddCell(new Phrase("Müşteri Soyadı", f));
            pdfPTable.AddCell(new Phrase("Müşteri TC Kimlik", f));

            pdfPTable.AddCell(new Phrase("Flappy", f));
            pdfPTable.AddCell(new Phrase("Bird", f));
            pdfPTable.AddCell(new Phrase("11122233344", f));

            pdfPTable.AddCell(new Phrase("Ranbo", f));
            pdfPTable.AddCell(new Phrase("Kanbo", f));
            pdfPTable.AddCell(new Phrase("22222222222", f));

            pdfPTable.AddCell(new Phrase("Xuser", f));
            pdfPTable.AddCell(new Phrase("Xname", f));
            pdfPTable.AddCell(new Phrase("33333333333", f));

            document.Add(pdfPTable);
            document.Close();
            return File("/pdfreports/dosya2.pdf", "application/pdf", "dosya2.pdf");
        }
    }
}
