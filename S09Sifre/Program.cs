string dogrusifre = "12345";
Console.Write("Şifreyi girin: ");
string girilensifre = Console.ReadLine();


#region yöntem1
if (dogrusifre == girilensifre)
{
    Console.WriteLine("Giriş Başarılı");
}
else
{
    Console.WriteLine("Giriş Başarısız");
}
#endregion


#region yöntem2

switch (girilensifre)
    {
    case "12345":
        Console.WriteLine("Giriş Başarılı");
        break;
    default:
        Console.WriteLine("Giriş Başarısız");
        break;
}
#endregion

#region yöntem3

Console.WriteLine(dogrusifre == girilensifre ? "giriş başarılı" : "giriş başarısız");

#endregion



Console.ReadKey();