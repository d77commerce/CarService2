﻿using System;
using System.IO;
using System.Text;
using CarService2;
using Newtonsoft.Json.Linq;
public class ConvertToHtml

{
    public static string ConvertJsonToHtml(string jsonData,string reg_No)
    {
        // Load the JSON data into a JObject
        JObject jsonObject = JObject.Parse(jsonData);

    
     
        // Generate the HTML content
        string htmlContent = "<html><body>";
        htmlContent += "<head><title>Car info</title></head>";
        htmlContent += "<style> body {\r\n            max-width: 500px;\r\n            margin: 0 auto; /* Center the content horizontally */\r\n            padding: 20px; /* Add some padding to the content */\r\n            font-family: Arial, sans-serif;\r\n            font-size: 16px;\r\n            line-height: 1.5;\r\n        }\r\nh1 {text-align: center;}\r\np {text-align: center;}\r\ndiv {text-align: center;}\r\ntable {text-align: center;}\r\n .center {\r\n    margin-left: auto;\r\n    margin-right: auto;</style>";
        htmlContent += "<h1>Car Info</h1>";
        htmlContent += "<h1 style='background-color: yellow;'>Reg No :" + reg_No+" </h1>";
        foreach (var property in jsonObject.Properties())
        {
            string key = property.Name;
            string value = property.Value.ToString();
            htmlContent += $"<div>{key}: {value}</div>";
        }
        // Create the HTML table structure
        var table = new StringBuilder();
        table.AppendLine("<table border='2' class='center'>");
        table.AppendLine(" <tr><th style=\"width:220px\">PARAMETER</th><th style=\"width:220px\">RESULT</th></tr>");
        foreach (var property in jsonObject.Properties())
        {
            table.AppendLine($"<tr><td>{property.Name}</td><td>{property.Value}</td></tr>");
        }
        table.AppendLine("</table>");
        htmlContent += table;
       
        htmlContent += "</body></html>";

     //ShowDvlaModel dvla = new ShowDvlaModel();
     //   dvla.Show();
      //  html_show_dvla_model.NavigateToString(htmlContent);
      return htmlContent;
    }

}
