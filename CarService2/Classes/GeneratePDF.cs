using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using System.IO;
    using iTextSharp.text;
    using iTextSharp.text.pdf;

namespace CarService2.Classes
{
  public class GeneratePDF
    {
   
    public static void GeneratePDFfile(string content, string filePath, float width, float height)
    {
        // Create a new document with the specified page size.
        Document doc = new Document(new Rectangle(width, height), 0, 0, 0, 0);

        try
        {
            // Create a PdfWriter to write the content to the file.
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

            // Open the document to write content.
            doc.Open();

            // Create a paragraph to hold the string content.
            Paragraph paragraph = new Paragraph(content);

            // Add the paragraph to the document.
            doc.Add(paragraph);
        }
        catch (Exception ex)
        {
            // Handle exceptions if any.
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            // Close the document.
            doc.Close();
        }
    }

}
}
