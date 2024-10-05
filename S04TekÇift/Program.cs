Console.Write("Bir sayı giriniz = "  );
int sayı = Convert.ToInt32(Console.ReadLine());

#region yontem1
if (sayı % 2 == 0)
    Console.WriteLine("sayı çift bir sayıdır");
else
    Console.WriteLine("sayı tek bir sayıdır");
#endregion


#region yontem2

string sonuc = sayı % 2 == 0 ? "sayı çift bir sayıdır" : "sayı tek bir sayıdır";
#endregion


#region yöntem3
bool basarılımı = sayı % 2 == 0;
if (basarılımı)
{
    Console.WriteLine("sayı çift bir sayıdır");
}
else
{
    Console.WriteLine("sayı tek bir sayıdır");
}
#endregion


Console.ReadKey();
