using System;
using System.Drawing;
using System.Drawing.Printing;

class Program
{
    static void Main()
    {
        while(true)
        {
            Console.Clear();

            Console.Write("What you want? [print/help/exit]\n>> ");
            var input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "print":
                    Print(); 
                    break;
                case "help":
                    return;
                case "exit":
                    return;
                default:
                    break;

            }
        }
    }

    static void Print()
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
        graphics.DrawString("The possibilities are endless!", font, brush, x, y);
    }
}