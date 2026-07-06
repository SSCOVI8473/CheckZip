string[] zipCodes =
{
    "40165", "40202", "40205", "40214", "40218",
    "40229", "40299", "40047", "40118", "42701"
};

double[] deliveryCharges =
{
    6.50, 5.99, 7.49, 7.00, 8.25,
    8.50, 8.99, 6.25, 7.95, 9.75
};

int choice = 0;

while (choice != 4)
{
    Console.WriteLine();
    Console.WriteLine("Package Delivery Menu");
    Console.WriteLine("1. Print all zip codes");
    Console.WriteLine("2. Print all zip codes and delivery charges");
    Console.WriteLine("3. Search for a zip code");
    Console.WriteLine("4. Exit");
    Console.Write("Choice: ");

    choice = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    switch (choice)
    {
        case 1:
            foreach (string zip in zipCodes)
            {
                Console.WriteLine(zip);
            }
            break;

        case 2:
            for (int i = 0; i < zipCodes.Length; i++)
            {
                Console.WriteLine($"{zipCodes[i]} - {deliveryCharges[i]:C}");
            }
            break;

        case 3:
            {
                Console.Write("Enter a zip code: ");
                string searchZip = Console.ReadLine();

                bool found = false;

                for (int i = 0; i < zipCodes.Length; i++)
                {
                    if (zipCodes[i] == searchZip)
                    {
                        Console.WriteLine($"Delivery charge: {deliveryCharges[i]:C}");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Sorry, we do not deliver to that zip code.");
                }
            }
            break;

        case 4:
            Console.WriteLine("Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
}