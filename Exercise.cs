namespace ExerciseLibrary
{
    /* EXERCISE Class
     * 
     * This is a utility class for exercises
     * It contains shortcuts for formatting, input taking etc...
     * 
     */
    public static class Exercise
    {

        //Setup console
        //print Welcome message
        static public void Start(string title)
        {

            //Set console title
            Console.Title = title;

            //Write welcome
            Console.WriteLine();
            Console.WriteLine($"    WELCOME TO \"{title.ToUpper()}\"");
            Console.WriteLine("     by Francesco Limpias");
            Console.WriteLine();
            Console.WriteLine();

        }

        //print Goodbye message
        static public void End()
        {
            //Exercise end format
            Console.WriteLine();
            Console.WriteLine();

            //Goodbye
            Console.WriteLine("Thank you!");
        }



        /* AskString( prompt, nullable:false )
         * 
         * base method to request a user input
         * (a little fancier than Console.readLine)
         */
        static public string? AskString(string prompt, bool nullable = false)
        {
            //get user input
            Console.Write(prompt + " ");
            string? input = Console.ReadLine();

            //null check
            if (!nullable && (input == null || input.Length == 0))
            {
                //print error
                Console.WriteLine("This input should not be null!");
                Console.WriteLine();

                //recurively ask for input
                return AskString(prompt, false);
            }

            return input;
        }

        /* AskInt( prompt, nullable:false )
         * 
         * base method to request a user input
         * of type integer
         */
        static public int AskInt(string prompt, bool nullable = false)
        {
            try
            {
                //try to get and convert input
                int input = Convert.ToInt32(
                    AskString(prompt, nullable)
                    );
                return input;
            }
            catch (FormatException)
            {
                //print error
                Console.WriteLine("This input is not an integer!");
                Console.WriteLine();

                //recurively ask for input
                return AskInt(prompt);
            }
        }

    }
}