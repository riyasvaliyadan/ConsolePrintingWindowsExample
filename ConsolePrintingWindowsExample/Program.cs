using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Do you want to print out? [Y/N]");
        var input = Console.ReadLine();
        if (input == "Y")
        {
            Print("Hello");
        } else {
            Console.ReadKey();
        }
        
    }

    static void Print(string text)
    {
        var document = new PrintDocument();
        document.PrintPage += PrintPageHandler;

        // Set printer name (optional)
        //document.PrinterSettings.PrinterName = "Printer Name";

        // Set other print settings if needed (e.g., page orientation, paper size, etc.)
        //document.DefaultPageSettings.Landscape = true;
        //document.DefaultPageSettings.PaperSize = new PaperSize("Custom", 300, 400);

        // Start printing
        document.Print();
    }

    static void PrintPageHandler(object sender, PrintPageEventArgs e)
    {
        // Get the Graphics object to draw on the page
        Graphics graphics = e.Graphics;

        // Specify the font, brush, and coordinates for printing
        var font = new Font("Arial", 12);
        Brush brush = Brushes.Black;
        float x = 10;
        float y = 10;

        // Print the text
        graphics.DrawString("Hello, world!", font, brush, x, y);
    }
}