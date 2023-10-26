using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService2.Classes
{
    public class Car
    {
        public Car() { }

        public int Id { get; set; }
        public string RegistrationNumber { get; set; }
        public string ArtEndDate { get; set; } = "Pending";
        public int Co2Emissions { get; set; } = 0;
        public string Colour { get; set; } = "Pending";
        public int EngineCapacity { get; set; } = 0;
        public string FuelType { get; set; } = "Pending";
        public string Make { get; set; } = "Pending";
        public bool MarkedForExport { get; set; } = false;
        public string MonthOfFirstRegistration { get; set; } = "Pending";
        public string MotStatus { get; set; } = "Pending";
        public int RevenueWeight { get; set; } = 0;
        public string TaxDueDate { get; set; } = "Pending";
        public string TaxStatus { get; set; } = "Pending";
        public string TypeApproval { get; set; } = "Pending";
        public string Wheelplan { get; set; } = "Pending";
        public int YearOfManufacture { get; set; } = 1900;
        public string EuroStatus { get; set; } = "EURO 3";
        public string RealDrivingEmissions { get; set; } = "Pending";
        public string DateOfLastV5CIssued { get; set; } = "Pending";
        public int CustomerId { get; set; } = 1;

        /// <summary>
        /// Returns an HTML table of the car's parameters and their values.
        /// </summary>
        /// <typeparam name="T">The type of the car object.</typeparam>
        /// <param name="obj">The car object.</param>
        /// <returns>An HTML table of the car's parameters and their values.</returns>
        public static string ToHtmlTable<T>(T obj)
        {
            var html = new StringBuilder("<table border='2' class='center'>");
            html.Append("<tr><th style=\"width:220px\">PARAMETER</th><th style=\"width:220px\">RESULT</th></tr>");
            foreach (var prop in typeof(T).GetProperties())
            {
                if (prop.GetValue(obj) != null)
                {
                    html.Append($"<tr><td>{prop.Name}</td><td>{prop.GetValue(obj)}</td></tr>");
                }
            }
            html.Append("</table>");
            return html.ToString();
        }
    }
}
