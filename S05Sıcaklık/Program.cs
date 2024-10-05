Console.Write(" sıcaklık değeri girin = ");
int sıcaklık = Convert.ToInt32(Console.ReadLine());


#region yontem1
if (sıcaklık < 0)
{
    Console.WriteLine("donuyor");
}
else
{
    if (sıcaklık <= 30)
        Console.WriteLine("normal");
    else
        Console.WriteLine("sıcak");
}
#endregion


#region yontem2
if (sıcaklık < 0)
{
    Console.WriteLine("donuyor");
}
else if (sıcaklık <= 30)
{
    Console.WriteLine("normal");
}
else
{
    Console.WriteLine("sıcak");
}
#endregion

#region yontem3

Console.WriteLine(sıcaklık < 0 ? "donuyor" : sıcaklık <= 30 ? "normal" : "sıcak" );

#endregion



Console.ReadKey();
