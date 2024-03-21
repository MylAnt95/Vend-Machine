using System;

class Program
{
    static void Main()
    {
        VendingMachine vendMachine = new VendingMachine();

        // Add items to vend
        vendMachine.AddItem(new Item("Coke", 10));
        vendMachine.AddItem(new Item("Chips", 15));
        vendMachine.AddItem(new Item("Water", 8));
        vendMachine.AddItem(new Item("Chocolate", 12));
        vendMachine.AddItem(new Item("Gum", 12));

        // Add person
        Person person = new Person("Anton", 100);

        // Display items
        vendMachine.DisplayAvailableItems();

        // Run program until 'q' is entered
        while (true)
        {
            
            Console.WriteLine("\nSelect product to buy or 'help' for commands: ");

            string input = Console.ReadLine();

            if (input == "q")
            {
                break;
            }

            if (input == "list")
            {
                vendMachine.DisplaySelectedItems();
                continue;
            }

            if (input == "items")
            {
                vendMachine.DisplayAvailableItems();
                continue;
            }

            if (input == "money")
            {
                Console.WriteLine(person.Money);
                continue;
            }

            if (input == "help")
            {
                Console.WriteLine("\nCommands: ");
                Console.WriteLine("q = exit");
                Console.WriteLine("items = display all available items");
                Console.WriteLine("list = display all selected items");
                Console.WriteLine("money = display funds");
                continue;
            }

            vendMachine.BuyItems(input, person);
        }
    }
}