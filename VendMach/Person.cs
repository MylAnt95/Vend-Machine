class Person
{
    public string Name { get; }
    public int Money { get; set; }

    public Person(string name, int money)
    {
        Name = name;
        Money = money;
    }
}