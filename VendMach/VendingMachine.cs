class VendingMachine
{
    public List<Item> items = new List<Item>();
    public List<Item> cart = new List<Item>();
    public Person name;
    public Person money;

    public void AddItem(Item item)
    {
        items.Add(item);
    }

    // Display available items
    public void DisplayAvailableItems()
    {
        Console.WriteLine("Available items:");
        int index = 1;
        foreach (var item in items)
        {
            Console.WriteLine($"{index}. {item.Name} - {item.Price}kr");
            index++;
        }
    }

    public void BuyItems(string input, Person person)
    {
        int itemNumber;
        
        // If input is less than 0 or more than items in machine
        if (!int.TryParse(input, out itemNumber) || itemNumber < 1 || itemNumber > items.Count)
        {
            Console.WriteLine("Please enter a valid item number..");
        } 
        else
        {
            Item selectedItem = items[itemNumber - 1];


            if (person.Money >= selectedItem.Price)
            {
                // Add selected to cart and withdraw money from person
                cart.Add(selectedItem);
                person.Money -= selectedItem.Price;
            }
            else
            {
                Console.WriteLine("Insufficient funds!");
                return;
            }

            Console.WriteLine($"You selected: {selectedItem.Name} - {selectedItem.Price}kr");

        }

    }

    // Display selected products and total cost
    public void DisplaySelectedItems() 
    {
        int total = 0;

        Console.WriteLine("\nPurchased items:");
        foreach (var item in cart)
        {
            total += item.Price;
            Console.WriteLine($"{item.Name} - {item.Price}");
        }

        Console.WriteLine($"Total cost: {total}");
    }
}