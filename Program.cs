double price;
int quantity;
double total;
double sumtotal =0;
int proceed;

do
{
    Console.Write("Enter Price:");
    price = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter Quantity:");
    quantity = Convert.ToInt32(Console.ReadLine());
    total = price * quantity;
    sumtotal += total;
    Console.WriteLine($"Total: {price} * {quantity} = {total}");
    Console.Write("Add another product? 1 = Yes, 0 = No:");

    proceed = Convert.ToInt32(Console.ReadLine());

}
while (proceed == 1);
Console.WriteLine($"Total price of all products: {sumtotal}");
