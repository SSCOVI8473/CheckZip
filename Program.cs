string[] zipCodes = new string[10];

Console.WriteLine("PLEASE ENTER 10 ZIP CODES");

for (int i = 0; i < zipCodes.Length; i++)
{
    Console.Write("Zip code " + (i + 1) + ": ");
    zipCodes[i] = Console.ReadLine();
}
Console.WriteLine();

Array.Sort(zipCodes);

Console.WriteLine("Sorted zip codes:");
foreach (string z in zipCodes)
{
    Console.WriteLine(z);
}