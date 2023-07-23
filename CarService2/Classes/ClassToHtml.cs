using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace CarService2.Classes
{
    public class ClassToHtml
    {


        public static void ConvertClassToHtmlAndSave(string folderPath, string regNo, int? customerId)
        {
            var customerAdd = new CustomerAdd();
            if (customerId == 1)
            {
                customerAdd.Id = 1;
                customerAdd.FullName = "John Doe";
                customerAdd.PhoneNumber = "0777777";
                customerAdd.Email = "john.doe@example.com";
                customerAdd.CompanyName = "Onyx";
            }
            else
            {

            };



            var car = new Car(regNo);

            Directory.CreateDirectory(folderPath);

            string currentDate = DateTime.Now.ToString("yyyyMMddHHmmss");

            // Combine the folder path with the date and ".html" to get the full output path
            string outputPath = Path.Combine(folderPath, currentDate + "carInfo" + ".html");

            // Generate the HTML content
            string htmlContent = "<html><body>";
            htmlContent += "<head><title>Car info</title></head>";
            htmlContent += "<style> body {\r\n            max-width: 500px;\r\n            margin: 0 auto; /* Center the content horizontally */\r\n            padding: 20px; /* Add some padding to the content */\r\n            font-family: Arial, sans-serif;\r\n            font-size: 16px;\r\n            line-height: 1.5;\r\n        }\r\nh1 {text-align: center;}\r\np {text-align: center;}\r\ndiv {text-align: center;}\r\ntable {text-align: center;}\r\n .center {\r\n    margin-left: auto;\r\n    margin-right: auto;</style>";
            htmlContent += "<h1>Car Info</h1>";
            htmlContent += "<h1 style='background-color: yellow;'>Reg No :" + regNo + " </h1>";
            htmlContent += "";
            htmlContent += "<p>Client</p>";
            htmlContent += "";
            var tableOfCustomer = new StringBuilder();
            tableOfCustomer.Append(CustomerAdd.ToHtmlTable2(customerAdd));
            htmlContent += tableOfCustomer;
            htmlContent += "<p></p>";
            var table = new StringBuilder();

            table.Append(Car.ToHtmlTable(car));

            htmlContent += table;
           
            htmlContent += "</body></html>";

            // Save the HTML content to a file
            File.WriteAllText(outputPath, htmlContent);
        }
    }
}
