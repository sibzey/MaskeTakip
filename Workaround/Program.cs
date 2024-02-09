using Business.Concrete;
using Entities.Concrete;

SelamVer("Furkan");
SelamVer();

Topla(10, 30);

string ogrenci1 = "Furkan";
string ogrenci2 = "Engin";
string ogrenci3 = "Kerem";

Console.WriteLine(ogrenci1);
Console.WriteLine(ogrenci2);
Console.WriteLine(ogrenci3);

string[] ogrenciler = new string[3];
ogrenciler[0] = "Furkan";
ogrenciler[1] = "Engin";
ogrenciler[2] = "Kerem";

ogrenciler = new string[4];
ogrenci3 = "İlker";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}


string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

int sayi1 = 10;
int sayi2 = 20;
sayi2 = sayi1;
sayi1 = 30;
Console.WriteLine(sayi2);

Person person1 = new Person { FirstName = "FURKAN", LastName = "DEMİR", DateOfBirthYear = 2005, NationalIdentity = 123 };


foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
yeniSehirler1.Add("Adana");
foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine(); 


static void SelamVer(string isim = "isimsiz")
{
    Console.WriteLine("Merhaba " + isim);
}


static int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc);
    return sonuc;
}

//MyListApp();

static void MyListApp()
{
    MyList<string> myList = new MyList<string>("İrem", "Demir", "Furkan");//constructor ile gelen veriler

    myList.Add("Furkan");
    myList.AddRange("Furkan", "Ayaz", "İrem");
}

class MyList<T> //generic <> :
                //bu iki işaret arasına yazılan T herhangi bir isimde olabilir.
                //generic, biz oraya istediğimiz bir veri türünü verebiliriz string olabilir int olabilir class olabilir..vb
{

    //Params -> method parametresine verilen bir anahtar kelimedir.
    //bu anahtar kelime bir veri türünün tek bir eleman ile değilde birden fazla veri vermemizi sağlar.

    //cgeneric yapıda constructor ile params keyword sayesinde verilen veri tipinde verileri
    //foreach ile tek tek dönüp ekrana yazdırıyor. Basir bir MyList uygulaması.
    public MyList(params T[] items)
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    //constructor halinin method versiyonu.
    public void AddRange(params T[] items)
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    public void Add(T item)
    {
        Console.WriteLine(item);
    }
}

//static void degiskenler()
//{
//    string mesaj = "Selam";
//    double tutar = 1000000.5;
//    int sayi = 100;
//    bool girisYapmisMi = false;

//    string ad = "Furkan";
//    string soyad = "Demir";
//    int dogumYili = 2005;
//    long tcNo = 50185045625;

//    Console.WriteLine(tutar * 1.18);
//}

//public class Vatandas
//{
//    public string Ad { get; set; }
//    public string soyad { get; set; }
//    public int DogumYili { get; set; }
//    public long TcNo { get; set; }
//}

