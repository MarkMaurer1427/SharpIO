namespace SharpIO
{
    /*
     * Written by Mark Maurer
     * 
     * IO class to simplify data input and display in C#
     * 
     */

    public class SharpIO
    {
        public void print(string input) { Console.WriteLine(input); }

        public string getString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public int getInt(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                try { return int.Parse(input); }
                catch (FormatException e) { Console.WriteLine($"{input} is not a valid input for this operation."); ; }
            }

            
        }
    }

    
}