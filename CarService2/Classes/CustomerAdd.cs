using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService2.Classes
{
    public class CustomerAdd
    {
        public int Id { get; set; } = 1;
        public string FullName { get; set; } = "John Doe";
        public string CompanyName { get; set; } = "non";
        public string PhoneNumber { get; set; } = "077777777";
        public string Email { get; set; } = "john.doe@example.com";
        public bool IsDeleted { get; set; } = false;

        public static string ToHtmlTable2<T>(T obj)
        {
            var html = "<table class='center'>";
           // html += "<tr><th style=\"width:220px\"></th><th style=\"width:220px\"></th></tr>";
            foreach (var prop in typeof(T).GetProperties())
            {
                if (prop.Name == "Id"|| prop.Name== "IsDeleted")
                {
                    continue;
                }

                html += $"<tr><td>{prop.Name}</td><td>{prop.GetValue(obj)}</td></tr>";
            }
            html += "</table>";
            return html;
        }
    }
}
