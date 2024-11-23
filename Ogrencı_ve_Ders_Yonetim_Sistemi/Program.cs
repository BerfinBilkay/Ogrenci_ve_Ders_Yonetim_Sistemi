using System;
using System.Collections.Generic; // List yapısı ve diğer koleksiyon sınıfları için kullandım

// base class : Öğrenci ve Öğretim Görevlisi sınıfları bu sınıftan türettim
abstract class BasePerson
{
    public int Id { get; set; } // Kişinin Id'si
    public string Name { get; set; } // Kişinin adı

    // Base Class yapıcısı (constructor)
    protected BasePerson(int id, string name)
    {
        Id = id; // Id ataması
        Name = name; // İsim ataması
    }

    // Polymorphism için türetilen sınıflarda özelleştirilecek bir metoddur
    public abstract void ShowInfo();
}

// Kayıt işlemleri için bir interface kullandım
interface IPerson
{
    void Register(); // Tüm kişilerin kayıt olması için metod
}

// Öğrenci sınıfı: BasePerson sınıfından türetilir ve IPerson'u uygular
class Ogrenci : BasePerson, IPerson
{
    // Öğrenci sınıfının yapıcısı (constructor)
    public Ogrenci(int id, string name) : base(id, name) { }

    // Öğrenci bilgilerini gösterir
    public override void ShowInfo()
    {
        Console.WriteLine($"Öğrenci ID: {Id}, Adı: {Name}");
    }

    // Öğrenci kayıt işlemini gerçekleştirir
    public void Register()
    {
        Console.WriteLine($"Öğrenci kaydedildi: {Name}");
    }
}

// Öğretim Görevlisi sınıfı: BasePerson sınıfından türetilir ve IPerson'u uygular
class OgretimGorevlisi : BasePerson, IPerson
{
    // Öğretim Görevlisi sınıf yapıcısı
    public OgretimGorevlisi(int id, string name) : base(id, name) { }

    // Öğretim Görevlisi bilgilerini gösterir
    public override void ShowInfo()
    {
        Console.WriteLine($"Öğretim Görevlisi ID: {Id}, Adı: {Name}");
    }

    // Öğretim Görevlisi kayıt işlemini gerçekleştirir
    public void Register()
    {
        Console.WriteLine($"Öğretim Görevlisi kaydedildi: {Name}");
    }
}

// Ders sınıfı: Ders bilgilerini ve işlemlerini tutar
class Ders
{
    public string Name { get; set; } // Dersin adı
    public int Credit { get; set; } // Dersin kredi sayısı
    public OgretimGorevlisi OgretimGorevlisi { get; set; } // Dersi veren öğretim görevlisi
    public List<Ogrenci> Ogrenciler { get; set; } // Derse kayıtlı öğrencilerin listesi

    // Ders sınıfının yapıcı metodu
    public Ders(string name, int credit, OgretimGorevlisi ogretimGorevlisi)
    {
        Name = name; // Ders adı ataması
        Credit = credit; // Ders kredisi ataması
        OgretimGorevlisi = ogretimGorevlisi; // Öğretim görevlisi ataması
        Ogrenciler = new List<Ogrenci>(); // Öğrenciler listesi oluşturulur
    }

    // Derse öğrenci ekleme işlemi
    public void AddStudent(Ogrenci ogrenci)
    {
        Ogrenciler.Add(ogrenci); // Öğrenci listeye eklenir
        Console.WriteLine($"Öğrenci {ogrenci.Name} dersi aldı: {Name}");
    }

    // Dersin bilgilerini ve kayıtlı öğrencileri gösterir
    public void ShowCourseInfo()
    {
        Console.WriteLine($"Ders Adı: {Name}, Kredi: {Credit}, Öğretim Görevlisi: {OgretimGorevlisi.Name}");
        Console.WriteLine("Kayıtlı Öğrenciler:");
        foreach (var ogrenci in Ogrenciler) // Kayıtlı öğrencileri döngü ile listeler
        {
            Console.WriteLine($"- {ogrenci.Name}");
        }
    }
}

// Ana program: Uygulamanın çalışmasını kontrol eder
class ögrenci_yönetim_sistemi
{
    static void Main(string[] args)
    {
        // Öğrenci listesi
        List<Ogrenci> ogrenciler = new List<Ogrenci>();
        // Öğretim görevlisi listesi
        List<OgretimGorevlisi> ogretimGorevlileri = new List<OgretimGorevlisi>();
        // Ders listesi
        List<Ders> dersler = new List<Ders>();

        // Sürekli çalışacak ana menü döngüsü
        while (true)
        {
            // Menü seçeneklerini yazdırır
            Console.WriteLine("\n--- Öğrenci ve Ders Yönetim Sistemi ---");
            Console.WriteLine("1. Yeni Öğrenci Ekle");
            Console.WriteLine("2. Yeni Öğretim Görevlisi Ekle");
            Console.WriteLine("3. Yeni Ders Ekle");
            Console.WriteLine("4. Ders Bilgilerini Görüntüle");
            Console.WriteLine("0. Çıkış");
            Console.Write("Seçiminiz: ");

            // Kullanıcıdan seçim alır
            int secim = int.Parse(Console.ReadLine());

            // Kullanıcının seçimine göre işlem yapar
            switch (secim)
            {
                case 1: // Yeni öğrenci ekleme işlemi
                    Console.Write("Öğrenci Adı: "); // Kullanıcıdan öğrenci adını alır
                    string ogrenciAdi = Console.ReadLine();
                    // Yeni öğrenci nesnesi oluşturur ve listeye ekler
                    Ogrenci ogrenci = new Ogrenci(ogrenciler.Count + 1, ogrenciAdi);
                    ogrenciler.Add(ogrenci);
                    ogrenci.Register(); // Öğrenciyi kaydeder
                    break;

                case 2: // Yeni öğretim görevlisi ekleme işlemi
                    Console.Write("Öğretim Görevlisi Adı: "); // Kullanıcıdan öğretim görevlisi adını alır
                    string ogretimAdi = Console.ReadLine();
                    // Yeni öğretim görevlisi nesnesi oluşturur ve listeye ekler
                    OgretimGorevlisi ogretimGorevlisi = new OgretimGorevlisi(ogretimGorevlileri.Count + 1, ogretimAdi);
                    ogretimGorevlileri.Add(ogretimGorevlisi);
                    ogretimGorevlisi.Register(); // Öğretim görevlisini kaydeder
                    break;

                case 3: // Yeni ders ekleme işlemi
                    Console.Write("Ders Adı: "); // Kullanıcıdan ders adını alır
                    string dersAdi = Console.ReadLine();
                    Console.Write("Ders Kredisi: "); // Kullanıcıdan ders kredisi alır
                    int kredi = int.Parse(Console.ReadLine());

                    // Tüm öğretim görevlilerini listeler ve seçim yapmasını ister
                    Console.WriteLine("Öğretim Görevlisi Seç (ID):");
                    foreach (var ogretim in ogretimGorevlileri)
                    {
                        Console.WriteLine($"{ogretim.Id}. {ogretim.Name}");
                    }

                    // Seçilen öğretim görevlisini alır
                    int ogretimId = int.Parse(Console.ReadLine());
                    OgretimGorevlisi secilenOgretim = ogretimGorevlileri.Find(o => o.Id == ogretimId);

                    // Yeni ders nesnesi oluşturur ve listeye ekler
                    Ders ders = new Ders(dersAdi, kredi, secilenOgretim);
                    dersler.Add(ders);

                    // Derse öğrenci eklemek için kullanıcıdan öğrenci seçmesini ister
                    Console.WriteLine("Derse Öğrenci Eklemek İçin Öğrenci ID Giriniz (-1 Çıkış):");
                    foreach (var ogr in ogrenciler) // Tüm öğrencileri listeler
                    {
                        Console.WriteLine($"{ogr.Id}. {ogr.Name}");
                    }

                    // Öğrencileri derse eklemek için döngü
                    while (true)
                    {
                        int ogrenciId = int.Parse(Console.ReadLine()); // Kullanıcıdan öğrenci ID'si alır
                        if (ogrenciId == -1) break; // Çıkış için -1 kontrolü
                        Ogrenci secilenOgrenci = ogrenciler.Find(o => o.Id == ogrenciId); // Seçilen öğrenciyi bulur
                        ders.AddStudent(secilenOgrenci); // Öğrenciyi derse ekler
                        break;
                    }
                    break;

                case 4: // Ders bilgilerini görüntüleme işlemi
                    Console.WriteLine("Ders Listesi:");
                    for (int i = 0; i < dersler.Count; i++) // Tüm dersleri listeler
                    {
                        Console.WriteLine($"{i + 1}. {dersler[i].Name}");
                    }
                    Console.Write("Ders ID seçin: "); // Kullanıcıdan ders seçmesini ister
                    int dersId = int.Parse(Console.ReadLine());
                    dersler[dersId - 1].ShowCourseInfo(); // Seçilen dersin bilgilerini gösterir
                    break;

                case 0: // Çıkış işlemi
                    Console.WriteLine("Çıkış yapılıyor...");
                    return; // Programdan çıkış

                default: // Geçersiz seçim durumu
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }
        }
    }
}
