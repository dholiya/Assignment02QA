using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02QA
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Execute();
            Console.ReadKey();
        }

        private void Execute()
        {
            // no need to pass value already asssign in default constructor
            Rectangle rectangle = new Rectangle();
            int choice = 0;
            do
            {
                string optionTOSelect = String.Empty;
                do
                {
                    Console.WriteLine("1. Get Rectangle Length");
                    Console.WriteLine("2. Change Rectangle Length");
                    Console.WriteLine("3. Get Rectangle Width");
                    Console.WriteLine("4. Change Rectangle Width");
                    Console.WriteLine("5. Get Rectangle Height");
                    Console.WriteLine("6. Change Rectangle Height");
                    Console.WriteLine("7. Get Rectangle Volume");
                    Console.WriteLine("8. Exit");
                    Console.WriteLine();
                    Console.Write("Choose function to execute[1:8] ");
                    optionTOSelect = Console.ReadLine();
                    Console.WriteLine();
                }
                while (!(int.TryParse(optionTOSelect, out choice) && (choice > 0 && choice < 9)));

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Length = " + rectangle.GetLength());
                        break;
                    case 2:
                        rectangle.SetLength(GetLengthInput());
                        break;
                    case 3:
                        Console.WriteLine("Width = " + rectangle.GetWidth());
                        break;
                    case 4:
                        rectangle.SetWidth(GetWidthInput());
                        break;
                    case 5:
                        Console.WriteLine("Heighth = " + rectangle.GetHeight());
                        break;
                    case 6:
                        rectangle.SetHeight(GetAddHeightInput());
                        break;
                    case 7:
                        Console.WriteLine("Volume = " + rectangle.GetVolume());
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine();
            } while (choice!=8);
         }

        // get new input for lenght 
        private int GetLengthInput()
        {
            int length;
            bool isContinue = false;
            string lengthInput = String.Empty;
            do
            {
                Console.Write("Enter Length: ");
                lengthInput = Console.ReadLine();
                isContinue = (int.TryParse(lengthInput, out length) && (length > 0));
                if (!isContinue) {
                    Console.WriteLine("Length should be greater than zero.");
                }
            }
            while (!isContinue);
            return length;
        }

        // get new input for width 
        private int GetWidthInput()
        {
            int width;
            bool isContinue = false;
            string widthInput = String.Empty;
            do
            {
                Console.Write("Enter Width: ");
                widthInput = Console.ReadLine();
                isContinue = (int.TryParse(widthInput, out width) && (width > 0));
                if (!isContinue){
                      Console.WriteLine("Width should be greater than zero.");
                }
            }
            while (!isContinue);
            return width;
        }

        // get new input for height 
        private int GetAddHeightInput()
        {
            int height;
            bool isContinue = false;
            string heightInput = String.Empty;
            do
            {
                Console.Write("Enter Height: ");
                heightInput = Console.ReadLine();
                isContinue = int.TryParse(heightInput, out height) && (height > 0);
                if (!isContinue){
                   Console.WriteLine("Height should be greater than zero.");
                }
            }
            while (!isContinue);
            return height;
        }
    }
}
