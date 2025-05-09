string meyve;
Console.WriteLine("Rüya Manavına Hoşgeldiniz.");
Console.WriteLine("Elma = 2TL");
Console.WriteLine("Armut = 3TL");
Console.WriteLine("Çilek = 2TL");
Console.WriteLine("Muz = 3TL");
Console.WriteLine("Diğer bütün meyveler = 4TL\n");
Console.Write("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer):");
meyve = Console.ReadLine().ToLower(); //büyük küçük harf duyarlılığı kaldırıldı

int fiyat;

/* 
if (meyve == "elma" || meyve == "çilek")
    fiyat = 2;
else if (meyve == "armut" || meyve == "muz")
    fiyat = 3;
else
    fiyat = 4;

switch-case yapısı, if yapısındaki her bir koşulu kontrol etme durumuna kıyasla tüm caseleri kontrol etmek yerine doğrudan uyuşan case'e gitmesi sayesinde özellikle bu tarz sabit ve tek değişkenli durumlarda daha verimli olacaktır.
*/

switch (meyve)
{
    case "elma":
        fiyat = 2;
        break;
    case "armut":
        fiyat = 3;
        break;
    case "çilek":
        fiyat = 2;
        break;
    case "muz":
        fiyat = 3;
        break;
    default:
        fiyat = 4;
        break;
}
Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {fiyat} TL");