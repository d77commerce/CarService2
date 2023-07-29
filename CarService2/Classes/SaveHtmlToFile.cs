using System;
using System.IO;
using System.Windows;



namespace CarService2.Classes
{
    public class SaveHtmlToFile
    {
        public static void SaveHtml(string htmlContent)
        {
            try
            {
                // Get the application's startup path
                string directory = AppDomain.CurrentDomain.BaseDirectory;

                // Create the path to the HTML file
                string filePath = Path.Combine(directory, "outputInfoDvla.html");

                // Write the HTML content to the file
                File.WriteAllText(filePath, htmlContent);
            


                MessageBox.Show("HTML content has been saved to output.html");
               


            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while trying to print the file: {ex.Message}", "Print Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
