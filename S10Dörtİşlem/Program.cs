int a;
int b;
string islem;

Console.Write("Birinci sayıyı girin: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayıyı girin: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("İşlemi girin (+, -, *, /): ");
islem = Console.ReadLine();


switch (islem)
{
    case "+":
        Console.WriteLine($"{a} {islem} {b} = {a+b}");
        break;
    case "-":
        Console.WriteLine($"{a} {islem} {b} = {a-b}");
        break;
    case "*":
        Console.WriteLine($"{a} {islem} {b} = {a*b}");
        break;
    case "/":
        Console.WriteLine($"{a} {islem} {b} = {a/b}");
        break;
    default:
        Console.WriteLine("Geçersiz işlem");
        break;
}

Console.ReadKey();
