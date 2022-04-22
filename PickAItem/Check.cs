class Check
{
    public static bool GoAgain()
    {
        bool gameOver = false;
        bool loop = true;
        Console.WriteLine("Would you like to pick something again?");
        Console.WriteLine("Y (Yes) or N (No)");
        while (loop)
        {
            string ans = Console.ReadLine();

            if (ans.ToUpper() == "Y")
            {
                loop = false;
                gameOver = false;
            }
            else if (ans.ToUpper() == "N")
            {
                loop = false;
                gameOver = true;
            }
            else
            {
                Console.WriteLine("That was not the answer I was looking for. Try typing Y or N");
            }
        }
        return gameOver;
    }
}
