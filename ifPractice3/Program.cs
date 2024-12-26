// Girilen sabit bir sayı ile kontrol yapıyoruz
int sayi = 105; // Sabit olarak 105 kullanıyoruz

// Ekrana sayıyı yazdırıyoruz
Console.WriteLine($"Girilen sayı: {sayi}");

// İlk kontrol: Sayının 10'a eşit, küçük veya büyük olduğunu kontrol ediyoruz
if (sayi == 10)
{
    Console.WriteLine($"{sayi} girilen sayı 10'a eşittir.");
}
else if (sayi < 10)
{
    Console.WriteLine($"{sayi} girilen sayı 10'dan küçüktür.");
}
else
{
    Console.WriteLine($"{sayi} girilen sayı 10'dan büyüktür.");
}

// Çift veya tek olduğunu kontrol ediyoruz
if (sayi % 2 == 0)
{
    Console.WriteLine($"{sayi} girilen sayı çifttir.");
}
else
{
    Console.WriteLine($"{sayi} girilen sayı tektir.");
}
