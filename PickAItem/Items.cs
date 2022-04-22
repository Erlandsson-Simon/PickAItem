class Items
{
    public static void ItemList()
    {
        int num = 1;

        bool loop = true;
        bool catagoryLoop = true;

        List<string> listSelected = new List<string>();

        string itemSelected = "";


        String[] fruits = { "Apple", "Pineapple", "Bannana" };
        String[] meats = { "Chicken", "Lamb", "Cow" };
        String[] drinks = { "Coke", "Fanta", "Sprite" };

        Console.WriteLine("From which catagory would you like to pick from:");
        Console.WriteLine("1. Fruits");
        Console.WriteLine("2. Meats");
        Console.WriteLine("3. Drinks");
        Console.WriteLine("Type 1, 2 or 3");

        while (loop)
        {
            string ans = Console.ReadLine();

            if (ans == "1")
            {
                loop = false;
                foreach (var item in fruits)
                {
                    listSelected.Add(item);
                }
            }
            else if (ans == "2")
            {
                loop = false;
                foreach (var item in meats)
                {
                    listSelected.Add(item);
                }
            }
            else if (ans == "3")
            {
                loop = false;
                foreach (var item in drinks)
                {
                    listSelected.Add(item);
                }
            }
            else
            {
                Console.WriteLine("That was not the answer I was looking for. Try typing 1 or 2 or 3");
            }
        }

        Console.WriteLine("What from the catagory would you like to pick?");

        foreach (var item in listSelected)
        {
            Console.WriteLine(num + "." + item);
            num++;
        }

        Console.WriteLine("Type 1, 2 or 3");


        while (catagoryLoop)
        {
            string ans = Console.ReadLine();

            if (ans == "1")
            {
                catagoryLoop = false;
                itemSelected = listSelected[0];
            }
            else if (ans == "2")
            {
                catagoryLoop = false;
                itemSelected = listSelected[1];
            }
            else if (ans == "3")
            {
                catagoryLoop = false;
                itemSelected = listSelected[2];
            }
            else
            {
                Console.WriteLine("That was not the answer I was looking for. Try typing 1 or 2 or 3");
            }
        }


    }
}