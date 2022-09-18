int n = 0, s = 0, ss = 1, temp=0; string bac = null; bool isNumber = false, rightone = false;
while (!rightone)
{
    Console.WriteLine("Write the number:");
    string? line = Console.ReadLine();
    isNumber = int.TryParse(line, out n);
    if (!isNumber)
    {
        Console.WriteLine("Wrong input... Try again)");
    }
    else if (n <= 0)
    { Console.WriteLine("Wrong input... Try again)"); }
    else if (n % 2 == 0)
    { Console.WriteLine("Wrong input... Try again)"); }
    else
    {
        rightone = true;
    }
}
for (temp = 0; temp < n; temp += 2)
{
    ss = 1;
    s=(n - 1) / 2;
    for (; ss <= temp; ss += 2)
    {
        for (int i = 0; i < s; i++)
            bac += " ";
        for (int j = 0; j < ss; j++)
            bac += "*";
        for (int i = 0; i < s; i++)
            bac += " ";
        Console.WriteLine(bac);
        bac = null;
        s--;
    }
}
