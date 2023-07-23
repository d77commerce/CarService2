using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService2.Classes
{
    public class HtmlStrings
    {
        private static string _headHtml =
            "<head>\r\n    <title>Current Date and Time</title>\r\n    <style>\r\n        /* Define the CSS styles for the container div */\r\n        .container {\r\n            font-family: Arial, sans-serif;\r\n            font-size: 18px;\r\n            border: 1px solid #ccc;\r\n            padding: 10px;\r\n            width: 250px;\r\n            text-align: center;\r\n        }\r\n\r\n        /* Define the CSS styles for the date and time text */\r\n        .datetime {\r\n            font-size: 24px;\r\n            font-weight: bold;\r\n            margin-bottom: 10px;\r\n        }\r\n    </style>\r\n</head>";

        private string _htmlHead;


        public static string htmlHead
        {
            get => _headHtml;
            private set => _headHtml = value;
        }
        public static string GetHtmlHead() => htmlHead;
    }
}
