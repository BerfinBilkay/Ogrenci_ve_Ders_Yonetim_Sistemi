# Öğrenci ve Ders Yönetim Sistemi
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Öğrenci ve Ders Yönetim Sistemi</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            line-height: 1.6;
            margin: 0;
            padding: 0;
            background-color: #f4f4f9;
            color: #333;
        }

        header {
            background: #0078d7;
            color: #fff;
            padding: 1rem 0;
            text-align: center;
        }

        header h1 {
            margin: 0;
            font-size: 2rem;
        }

        .container {
            max-width: 900px;
            margin: 2rem auto;
            background: #fff;
            padding: 2rem;
            border-radius: 8px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        }

        h2 {
            color: #0078d7;
            margin-top: 1.5rem;
        }

        code {
            background: #f4f4f4;
            padding: 0.2rem 0.4rem;
            border-radius: 4px;
            font-family: 'Courier New', Courier, monospace;
        }

        pre {
            background: #f4f4f4;
            padding: 1rem;
            border-left: 4px solid #0078d7;
            overflow-x: auto;
        }

        ul {
            list-style-type: disc;
            margin: 1rem 0;
            padding-left: 2rem;
        }

        li {
            margin-bottom: 0.5rem;
        }

        .license {
            margin-top: 2rem;
            font-style: italic;
            color: #555;
        }
    </style>
</head>
<body>
    <header>
        <h1>Öğrenci ve Ders Yönetim Sistemi</h1>
    </header>
    <div class="container">
        <h2>Gereksinimler ve Özellikler</h2>
        <h3>Sınıflar (Classes)</h3>
        <ul>
            <li><strong>Base Class:</strong> Sistemde <code>Kisi</code> adlı bir temel sınıf tanımlanmıştır. Ortak özellikler ve davranışlar bu sınıfta tanımlanmıştır.</li>
            <li><code>Ogrenci</code> ve <code>OgretimGorevlisi</code> sınıfları, <code>Kisi</code> sınıfından türetilmiştir.</li>
            <li><strong>Ders Sınıfı (Course):</strong> Derslerin adını, kredilerini ve hangi öğretim görevlisinin dersi verdiğini tutar. Öğrencilerin derslere kayıt olabileceği bir yapı sağlar.</li>
        </ul>

        <h3>Interface Kullanımı</h3>
        <p><strong>IPerson Interface’i:</strong> Ortak özellikler ve davranışlar için <code>IPerson</code> adında bir interface tasarlanmıştır. Bu interface, <code>Kisi</code> sınıfında uygulanmış ve zorunlu metotlar eklenmiştir.</p>

        <h3>Polymorphism (Çok Biçimlilik)</h3>
        <p><strong>BilgiGoster() Metodu:</strong> Temel sınıfta tanımlanmıştır ve türetilmiş sınıflarda <code>override</code> edilerek, her sınıfa özgü detaylı bilgi sunması sağlanmıştır.</p>

        <h2>Uygulamanın Özellikleri</h2>
        <ul>
            <li><strong>Ogrenci, OgretimGorevlisi ve Ders Tanımlama:</strong> Kullanıcı, console üzerinden öğrenci, öğretim görevlisi ve ders tanımlayabilir.</li>
            <li><strong>Ders Bilgileri ve Kayıtlı Öğrenciler:</strong> Her dersin adı, kredisi, hangi öğretim görevlisinin dersi verdiği ve derse kayıtlı öğrencilerin listesi görüntülenebilir.</li>
        </ul>

        <h2>Nasıl Kullanılır?</h2>
        <ol>
            <li><strong>Console Uygulaması Çalıştırma:</strong> Projeyi çalıştırın ve aşağıdaki işlemleri gerçekleştirin:
                <ul>
                    <li>Öğrenci ve öğretim görevlisi ekleyin.</li>
                    <li>Ders ekleyin ve öğretim görevlisini atayın.</li>
                    <li>Öğrencileri derslere kaydedin.</li>
                    <li>Dersin detaylı bilgilerini listeleyin.</li>
                </ul>
            </li>
            <li><strong>Gereksinimler:</strong> Proje bir .NET Core console uygulaması olarak geliştirilmiştir. Çalıştırmak için .NET Core SDK gereklidir.</li>
        </ol>

        <h2>Projenin Yapısı</h2>
        <pre>
├── Classes
│   ├── Kisi.cs         (Base Class)
│   ├── Ogrenci.cs      (Derived Class)
│   ├── OgretimGorevlisi.cs (Derived Class)
│   ├── Ders.cs         (Course Management)
├── Interfaces
│   ├── IPerson.cs      (Interface)
├── Program.cs          (Entry Point)
        </pre>

        <h2>Örnek Çıktılar</h2>
        <p><strong>Öğrenci Tanımlama:</strong></p>
        <pre>
Ogrenci Eklendi: Ali Veli
        </pre>
        <p><strong>Ders Detayları:</strong></p>
        <pre>
Ders Adı: Matematik
Kredi: 3
Öğretim Görevlisi: Dr. Ahmet Kaya
Kayıtlı Öğrenciler:
  1. Ali Veli
  2. Ayşe Yılmaz
        </pre>
        <p><strong>Polymorphism Örneği:</strong></p>
        <pre>
Öğrenci BilgiGoster():
Ad: Ali
Soyad: Veli
Numara: 12345
        </pre>

        <p class="license">Bu proje açık kaynaklıdır ve eğitim amaçlı kullanılabilir.</p>
    </div>
</body>
</html>
