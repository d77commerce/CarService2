using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService2.Classes
{
    public class PrintOilLabel
    {
        public PrintOilLabel()
        {

        }

        public int Mileage { get; set; } = 1;
        public string? EngineOil { get; set; }
        public string? EngineOilBrand { get; set; }
        public bool OilFilter { get; set; } = false;
        public string? GearOil { get; set; }
        public string? GearOilBrand { get; set; }
        public bool Automatic { get; set; } = false;
        public bool GearFilter { get; set; } = false;
        public string? HydraulicOil { get; set; }
        public string? HydraulicOilBrand { get; set; }
        public string? DifferentialOil { get; set; }
        public string? DifferentialOilBrand { get; set; }
        public bool AirFilter { get; set; } = false;
        public bool CabinFilter { get; set; } = false;
        public bool ResetComputer { get; set; } = false;

        /// <summary>
        /// Generates an HTML table with the parameters and results of the oil label.
        /// </summary>
        /// <typeparam name="T">The type of the object to generate the table for.</typeparam>
        /// <param name="obj">The object to generate the table for.</param>
        /// <returns>The HTML table as a string.</returns>
        public static string GenerateOilLabelTable<T>(T obj)
        {
            var html = "<table border='2' class='center'>";
            html += "<tr><th style=\"width:220px\">PARAMETER</th><th style=\"width:220px\">RESULT</th></tr>";
            foreach (var prop in typeof(T).GetProperties())
            {
                html += $"<tr><td>{prop.Name}</td><td>{prop.GetValue(obj)}</td></tr>";
            }
            html += "</table>";
            return html;
        }


    }
}
