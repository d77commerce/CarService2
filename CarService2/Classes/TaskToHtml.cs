using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;


namespace CarService2.Classes
{
    public class TaskToHtml
    {
        public static string ConvertTaskOilToHtml(PrintOilLabel label)
        {
            var labelPrint = label;
            // Generate the HTML content
            string htmlContent = "<html><body>";
         //   htmlContent += "<style> body {\r\n           width: 500px;\r\n            margin: 0 auto; /* Center the content horizontally */\r\n            padding: 20px; /* Add some padding to the content */\r\n            font-family: Arial, sans-serif;\r\n            font-size: 16px;\r\n            line-height: 1.5;\r\n        }\r\nh1 {text-align: center;}\r\np {text-align: center;}\r\ndiv {text-align: center;}\r\ntable {text-align: center;}\r\n .center {\r\n    margin-left: auto;\r\n    margin-right: auto;</style>";
            var tableOfCustomer = new StringBuilder();
            var table = new StringBuilder();
            table.Append(PrintOilLabel.GenerateOilLabelTable(labelPrint));
            htmlContent += table;
            htmlContent += "</body></html>";

            return htmlContent;
        }

        public static string ConvertTaskOrderToHtml(PrintTaskLabel label)
        {
            var labelPrint = label;
            // Generate the HTML content
            string htmlContent = "<html><body>";
            //   htmlContent += "<style> body {\r\n           width: 500px;\r\n            margin: 0 auto; /* Center the content horizontally */\r\n            padding: 20px; /* Add some padding to the content */\r\n            font-family: Arial, sans-serif;\r\n            font-size: 16px;\r\n            line-height: 1.5;\r\n        }\r\nh1 {text-align: center;}\r\np {text-align: center;}\r\ndiv {text-align: center;}\r\ntable {text-align: center;}\r\n .center {\r\n    margin-left: auto;\r\n    margin-right: auto;</style>";
            var tableOfCustomer = new StringBuilder();
            var table = new StringBuilder();
            table.Append(PrintOilLabel.GenerateOilLabelTable(labelPrint));
            htmlContent += table;
            htmlContent += "</body></html>";

            return htmlContent;
        }
    }
}
