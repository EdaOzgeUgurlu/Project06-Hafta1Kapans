
Console.Write("Ay No = ");
int ay = Convert.ToInt32(Console.ReadLine());
int adet;
string ayAdı = string.Empty;

switch (ay)
{
    case 1:
        ayAdı = "Ocak";
        adet = 31;
        break;
    case 2:
        ayAdı = "Şubat";
        adet = 28; // Şubat için 28 gün
        break;
    case 3:
        ayAdı = "Mart";
        adet = 31;
        break;
    case 4:
        ayAdı = "Nisan";
        adet = 30;
        break;
    case 5:
        ayAdı = "Mayıs";
        adet = 31;
        break;
    case 6:
        ayAdı = "Haziran";
        adet = 30;
        break;
    case 7:
        ayAdı = "Temmuz";
        adet = 31;
        break;
    case 8:
        ayAdı = "Ağustos";
        adet = 31;
        break;
    case 9:
        ayAdı = "Eylül";
        adet = 30;
        break;
    case 10:
        ayAdı = "Ekim";
        adet = 31;
        break;
    case 11:
        ayAdı = "Kasım";
        adet = 30;
        break;
    case 12:
        ayAdı = "Aralık";
        adet = 31;
        break;
    default:
        Console.WriteLine("Geçersiz bir ay numarası girdiniz!");
        Console.ReadKey();
        return; 
}

Console.WriteLine($"Ay {ayAdı} toplam {adet} gün içerir.");

Console.ReadKey(); 
    