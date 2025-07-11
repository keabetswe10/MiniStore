


Console.WriteLine("Welcometo kea's Mini Store");
Console.WriteLine();

        Console.WriteLine("Enter the name of item1: ");
        string item1 = Console.ReadLine();

        Console.WriteLine("Enter the price for item1: ");
        double price1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the name of item2: ");
        string item2 = Console.ReadLine();

        Console.WriteLine("Enter the price of item2: ");
        double price2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the name of item3: ");
        string item3 = Console.ReadLine();

        Console.WriteLine("Enter the price of item3: ");
        double price3 = Convert.ToDouble(Console.ReadLine());


        //Now we are calculating the total price of the items all together.

        double subtotal =  price1 + price2 + price3;

Console.WriteLine("Do you want to include VAT? (yes/no): ");
string vatChoice = Console.ReadLine().ToLower();

double vatAmount = 0;
double total = subtotal;

if (vatChoice == "yes")
{
    vatAmount = subtotal * 0.15;
    total = subtotal + vatAmount;
}
else
{
    Console.WriteLine("VAT not included.");
    // You can display subtotal here if you want:
    Console.WriteLine("Total (No VAT): R" + subtotal.ToString("F2"));
}
Console.WriteLine();
Console.WriteLine("\n===RECEIPT===");
Console.WriteLine(item1 + ":R" + price1.ToString("F2"));
Console.WriteLine(item2 + ":R" + price2.ToString("F2"));
Console.WriteLine(item3 + ":R" + price3.ToString("F2")); ;
Console.WriteLine("----------------");
Console.WriteLine("Subtotal: R" + subtotal.ToString("F2"));

if (vatChoice == "yes")
{
    Console.WriteLine("VAT (15%): R" + vatAmount.ToString("F2"));
}
Console.WriteLine("Total: R" + total.ToString("F2"));
Console.WriteLine("Thank you for shopping at Kea's Store!");