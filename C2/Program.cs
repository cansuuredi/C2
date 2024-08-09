// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//2. Dereceden denklemlerin koklerini inceleyen kodu yazınız
//1.ihtiyaca göre değişkenleri tanımla
int a, b, c, delta;
//2. katsayıları kullanıcıdan al
Console.Write("a katsayisini gir");
a = Convert.ToInt32((Console.ReadLine()));
Console.Write("b katsayisini gir");
b = Convert.ToInt32((Console.ReadLine()));
Console.Write("c katsayisini gir");
c = Convert.ToInt32((Console.ReadLine()));
//3. deltayı hesapla
delta = b * b - (4 * a * c);

//4. deltaya göre kök durumunu incele

if (delta > 0)
    Console.WriteLine("Reel iki kök var");
else if (delta == 0)
    Console.WriteLine("Tek kök var");
else
    Console.WriteLine("Reel kök yok");
