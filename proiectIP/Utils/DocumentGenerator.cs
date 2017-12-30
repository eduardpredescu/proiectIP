using System;
using System.IO;
using System.Globalization;
using System.Linq;

using Word = Microsoft.Office.Interop.Word;
using proiectIP.Models;

namespace proiectIP.Utils
{
    class DocumentGenerator
    {
        public static void generatePrescription(Medic m, Patient p, string prescription)
        {
            var wordApp = new Word.Application() as Word._Application;
            var document = wordApp.Documents.Add();
            var wordFilePath = Path.Combine(Directory.GetCurrentDirectory()+"/Documents",
                DateTime.Now.ToString("yyyyMMdd", new CultureInfo("ro-ro")) + 
                "_" + m.Name + 
                "_" + p.Name + ".docx");

            document.PageSetup.PaperSize = Word.WdPaperSize.wdPaperA4;

            var headerRange = document.Sections[1].Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
            headerRange.InlineShapes.AddPicture(Path.Combine(Directory.GetCurrentDirectory(), "sigla.png"));
            headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

            var footerRange = document.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
            footerRange.Text = string.Format("Tipărit la data de {0}", DateTime.Now.ToString("dd MMMM yyyy", new CultureInfo("ro-ro")));
            footerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;

            var docRange = document.Range();

            document.SaveAs(wordFilePath);
            wordApp.Quit();
        }
    }
}
