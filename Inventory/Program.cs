
string[] inventory = { "Health Potion", "Sword", "Shield", "Bread", "Key" };

Console.WriteLine("Inventory[0]: " + inventory[0]);
Console.WriteLine("Inventory[1]: " + inventory[1]);
Console.WriteLine("Inventory[2]: " + inventory[2]);
Console.WriteLine("Inventory[3]: " + inventory[3]);
Console.WriteLine("Inventory[4]: " + inventory[4]);

string [] Inventory = {"Health Potion", "Sword", "Shield","Bread","Key"};

for (int i = 0; i < Inventory.Length; i++);
{
    Console.WriteLine("$Slot {i}: {Inventory[i]}");
}

Console.WriteLine($"\nTotal items: {Inventory.Length}");

