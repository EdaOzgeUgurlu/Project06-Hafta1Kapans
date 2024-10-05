
başla:
Console.Write("Notunuzu girin = ");
int not = Convert.ToInt32(Console.ReadLine());
string sonuc;

if (not < 0 || not > 100)
    goto başla;


#region yontem1


if (not > 80)
{
    sonuc = "başarılı";

}
else if (not < 61)
{
    sonuc = "başarısız";
}
else
{
    sonuc = "orta";
}

Console.WriteLine("Sonuç = " + sonuc);

#endregion


#region yöntem2

Console.WriteLine("Sonuç = " + (not > 80 ? "başarılı" : not < 61 ? "başarısız" : "orta"));

#endregion


Console.ReadKey();