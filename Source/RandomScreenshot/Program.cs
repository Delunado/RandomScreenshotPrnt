using System;

namespace RandomScreenshot
{
    class Program
    {
        static private Random random = new Random();
        static string chars = "abcdefghijklmnopqrstuvwxyz";

        static void Main(string[] args)
        {
            int numberOfImages = NumberOfImagesInput();

            do
            {
                for (int i = 0; i < numberOfImages; i++)
                {
                    OpenImage();
                }

                numberOfImages = NumberOfImagesInput();
            } while (numberOfImages != 0);
        }


        private static char GetRandomCharacter(string text)
        {
            int index = random.Next(text.Length);
            return text[index];
        }

        /// <summary>
        /// Gets the number of images to open
        /// </summary>
        /// <returns></returns>
        private static int NumberOfImagesInput()
        {
            int input = 0;
            bool success = false;

            do
            {
                Console.WriteLine("How many pictures do you want to see? (Example: 2)");
                Console.Write("> ");
                success = int.TryParse(Console.ReadLine(), out input);
            } while (!success);

            return input;
        }

        /// <summary>
        /// Opens an image from the web
        /// </summary>
        private static void OpenImage()
        {
            System.Diagnostics.Process.Start("https://prnt.sc/" + GetRandomCharacter(chars) + GetRandomCharacter(chars) + random.Next(0, 10) + random.Next(0, 10) + random.Next(0, 10) + random.Next(0, 10));
            System.Threading.Thread.Sleep(500);
        }
    }
}
