Console.Write("1 ile 7 arasında bir sayı girin = ");
int gun = Convert.ToInt32(Console.ReadLine());

#region yontem1
if (gun == 1) 
{
    Console.WriteLine("pazartesi");
}
else if  (gun == 2) 
{
    Console.WriteLine("salı");
}
else if (gun == 3)
{
    Console.WriteLine("çarşamba");
}
else if (gun == 4)
{
    Console.WriteLine("perşembe");
}
else if (gun == 5)
{
    Console.WriteLine("cuma");
}
else if (gun == 6)
{
    Console.WriteLine("cumartesi");
}
else if (gun == 7)
{
    Console.WriteLine("pazar");
}
else
{
    Console.WriteLine("geçersiz bir gün girdiniz");
}
#endregion


#region yöntem2
switch (gun)
{
    case 1:
        Console.WriteLine("pazartesi");
        break;
    case 2:
        Console.WriteLine("salı");
        break;
    case 3:
        Console.WriteLine("çarşamba");
        break;
    case 4:
        Console.WriteLine("perşembe");
        break;
    case 5:
        Console.WriteLine("cuma");
        break;
    case 6:
        Console.WriteLine("cumartesi");
        break;
    case 7:
        Console.WriteLine("pazar");
        break;
    default:
        Console.WriteLine("geçersiz bir gün girdiniz");
        break;
}
#endregion


Console.ReadKey();
