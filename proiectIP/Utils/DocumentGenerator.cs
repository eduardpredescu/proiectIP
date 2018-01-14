using System;
using System.IO;
using System.Globalization;
using System.Linq;

using Word = Microsoft.Office.Interop.Word;
using proiectIP.Models;
using System.Collections.Generic;

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
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";

            document.PageSetup.PaperSize = Word.WdPaperSize.wdPaperA4;

            var headerRange = document.Sections[1].Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
            headerRange.Text = "Spitalul Noua Speranta\nstr.Chibzuintei, nr. 20\nBucuresti, sector 6, Romania";
            var picture = headerRange.InlineShapes.AddPicture(Path.Combine(Directory.GetCurrentDirectory(), "sigla.png"));
            Word.Shape shape = picture.ConvertToShape();
            shape.WrapFormat.Type = Word.WdWrapType.wdWrapSquare;
            headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

            var footerRange = document.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
            footerRange.Text = string.Format("Tipărit la data de {0}", DateTime.Now.ToString("dd MMMM yyyy", new CultureInfo("ro-ro")));
            footerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;

            Word.Paragraph para1;
            para1 = document.Content.Paragraphs.Add(ref oMissing);
            para1.Range.Text = "Prescripție medicală";
            para1.Range.Font.Bold = 1;
            para1.Range.Font.Size = 24;
            para1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            para1.Format.SpaceBefore = 24;
            para1.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
            para1.Range.InsertParagraphAfter();
            para1.Range.InsertParagraphAfter();
            para1.Range.InsertParagraphAfter();


            Word.Paragraph para2;
            object oRng = document.Bookmarks.get_Item(ref oEndOfDoc).Range;
            para2 = document.Content.Paragraphs.Add(ref oRng);
            para2.Range.Font.Bold = 0;
            para2.Range.Font.Size = 12;
            para2.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            para2.Range.Text = "Subsemnatul " + p.Name + " " + p.Surname + ", grupa sanguina "
                + p.BloodType + " a fost consultat de medicul " + m.Name + " " + m.Surname + ", specializarea " +
                m.Specialisation + " si i se recomanda: ";
            para2.Format.SpaceAfter = 6;
            para2.Range.InsertParagraphAfter();


            Word.Paragraph para3;
            oRng = document.Bookmarks.get_Item(ref oEndOfDoc).Range;
            para3 = document.Content.Paragraphs.Add(ref oRng);
            para3.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            para3.Range.Font.Bold = 0;
            para3.Range.Font.Size = 12;
            para3.Range.Text = prescription;
            para3.Format.SpaceAfter = 6;
            para3.Range.InsertParagraphAfter();


            document.SaveAs(wordFilePath);
            wordApp.Quit();
        }

        public static void generatePatientList(Medic m, List<Patient> list)
        {
            var wordApp = new Word.Application() as Word._Application;
            var document = wordApp.Documents.Add();
            var wordFilePath = Path.Combine(Directory.GetCurrentDirectory() + "/Documents",
                DateTime.Now.ToString("yyyyMMdd", new CultureInfo("ro-ro")) +
                "_" + m.Name +
                "_lista" + ".docx");
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";

            document.PageSetup.PaperSize = Word.WdPaperSize.wdPaperA4;

            var headerRange = document.Sections[1].Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
            headerRange.Text = "Spitalul Noua Speranta\nstr.Chibzuintei, nr. 20\nBucuresti, sector 6, Romania";
            var picture = headerRange.InlineShapes.AddPicture(Path.Combine(Directory.GetCurrentDirectory(), "sigla.png"));
            Word.Shape shape = picture.ConvertToShape();
            shape.WrapFormat.Type = Word.WdWrapType.wdWrapSquare;
            headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

            var footerRange = document.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
            footerRange.Text = string.Format("Tipărit la data de {0}", DateTime.Now.ToString("dd MMMM yyyy", new CultureInfo("ro-ro")));
            footerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;

            Word.Paragraph para1;
            para1 = document.Content.Paragraphs.Add(ref oMissing);
            para1.Range.Text = "Lista pacientilor medic "+m.Name + " " + m.Surname;
            para1.Range.Font.Bold = 1;
            para1.Range.Font.Size = 24;
            para1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            para1.Format.SpaceBefore = 24;
            para1.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
            para1.Range.InsertParagraphAfter();
            para1.Range.InsertParagraphAfter();
            para1.Range.InsertParagraphAfter();

            Word.Table oTable;
            Word.Range wrdRng = document.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = document.Tables.Add(wrdRng, list.Count+1, 4, ref oMissing, ref oMissing);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;
            oTable.Range.Font.Bold = 0;
            oTable.Range.Font.Size = 16;
            oTable.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            oTable.Cell(1, 1).Range.Text = "Nr. crt.";
            oTable.Cell(1, 2).Range.Text = "Nume";
            oTable.Cell(1, 3).Range.Text = "Prenume";
            oTable.Cell(1, 4).Range.Text = "Grupa sanguina";
            for (int i = 0; i < list.Count; i++)
            {
                oTable.Cell(i + 2, 1).Range.Text = (i + 1).ToString();
                oTable.Cell(i + 2, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;

                oTable.Cell(i + 2, 2).Range.Text = list[i].Surname;

                oTable.Cell(i + 2, 3).Range.Text = list[i].Name;

                oTable.Cell(i + 2, 4).Range.Text = list[i].BloodType;
            }

            oTable.set_Style("Table Professional");
            oTable.Columns.AutoFit();
            oTable.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitWindow);

            document.SaveAs(wordFilePath);
            wordApp.Quit();
        }
    }
}
