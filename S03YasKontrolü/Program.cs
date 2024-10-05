
Console.Write("Yaşınız= ");
int yas = Convert.ToInt32(Console.ReadLine());

#region yontem1
if (yas >= 18)
    Console.WriteLine("Yetişkinsiniz");
else
    Console.WriteLine("Çocuksunuz");

#endregion


#region yontem2

bool büyükmü = yas >= 18;

if (büyükmü)
    Console.WriteLine("Yetişkinsiniz");
else
    Console.WriteLine("Çocuksunuz");

#endregion

#region yontem3

Console.WriteLine(yas >= 18 ? "Yetişkinsiniz" : "Çocuksunuz"  );

#endregion


Console.ReadKey();

