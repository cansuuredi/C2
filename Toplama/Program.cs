
Console.WriteLine("Aşağıdaki Toplama İşlemini Yapınız.");

//randomu başa çekersen eğer sürekli ilk sorduğu soruya döner. 
//randomu for'un içine alırsan sürekli farklı bir işlem üretir. 
//break ilk "if"ten sonra çünkü döngünün orada kırılması lazım. 
//for'un baştaki hali sonsuz döngü oluşturur.
for (; ; )
{
    Random rnd = new Random();
    int sayi1 = rnd.Next(1, 101);
    int sayi2 = rnd.Next(1, 101);
    Console.WriteLine("{0} + {1} = ?", sayi1, sayi2);
    Console.WriteLine("Cevabınız Nedir?");
    int sonuc = int.Parse(Console.ReadLine());

    if (sonuc == (sayi1 + sayi2))
    {
        Console.WriteLine("Tebrikler");
        
        break;
    }
    else {
        Console.WriteLine("Tekrar dene!");
    }
        
    }
