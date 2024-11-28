# Öğrenci ve Ders Yönetim Sistemi
# Öğrenci ve Ders Yönetim Sistemi

Bu proje, bir *Öğrenci ve Ders Yönetim Sistemi* tasarımıdır. Sistem, temel OOP (Nesne Yönelimli Programlama) prensiplerini kullanarak, öğrenci, öğretim görevlisi ve ders yönetimini sağlar. 

## Gereksinimler ve Özellikler

### Sınıflar (Classes)
- *Base Class:*  
  - Sistemde *Kisi* adlı bir temel sınıf tanımlanmıştır. Ortak özellikler ve davranışlar bu sınıfta tanımlanmıştır.
  - Ogrenci ve OgretimGorevlisi sınıfları, *Kisi* sınıfından türetilmiştir.
- *Ders Sınıfı (Course):*
  - Derslerin adını, kredilerini ve hangi öğretim görevlisinin dersi verdiğini tutar.
  - Öğrencilerin derslere kayıt olabileceği bir yapı sağlar.

### Interface Kullanımı
- *IPerson Interface’i:*  
  - Ortak özellikler ve davranışlar için *IPerson* adında bir interface tasarlanmıştır.
  - Bu interface, *Kisi* sınıfında uygulanmış ve zorunlu metotlar eklenmiştir.

### Polymorphism (Çok Biçimlilik)
- *BilgiGoster() Metodu:*  
  - Temel sınıfta tanımlanmıştır ve türetilmiş sınıflarda override edilerek, her sınıfa özgü detaylı bilgi sunması sağlanmıştır.

## Uygulamanın Özellikleri
- *Ogrenci, OgretimGorevlisi ve Ders Tanımlama:*  
  Kullanıcı, console üzerinden öğrenci, öğretim görevlisi ve ders tanımlayabilir.
- *Ders Bilgileri ve Kayıtlı Öğrenciler:*  
  Her dersin adı, kredisi, hangi öğretim görevlisinin dersi verdiği ve derse kayıtlı öğrencilerin listesi görüntülenebilir.

## Nasıl Kullanılır?
1. *Console Uygulaması Çalıştırma:*  
   Projeyi çalıştırın ve aşağıdaki işlemleri gerçekleştirin:
   - Öğrenci ve öğretim görevlisi ekleyin.
   - Ders ekleyin ve öğretim görevlisini atayın.
   - Öğrencileri derslere kaydedin.
   - Dersin detaylı bilgilerini listeleyin.
   
2. *Gereksinimler:*  
   - Proje bir .NET Core console uygulaması olarak geliştirilmiştir. Çalıştırmak için .NET Core SDK gereklidir.

## Projenin Yapısı

├── Classes
│   ├── Kisi.cs         (Base Class)
│   ├── Ogrenci.cs      (Derived Class)
│   ├── OgretimGorevlisi.cs (Derived Class)
│   ├── Ders.cs         (Course Management)
├── Interfaces
│   ├── IPerson.cs      (Interface)
├── Program.cs          (Entry Point)

### Örnek Çıktılar
*Öğrenci Tanımlama:*

Ogrenci Eklendi: Ali Veli

*Ders Detayları:*

Ders Adı: Matematik
Kredi: 3
Öğretim Görevlisi: Dr. Ahmet Kaya
Kayıtlı Öğrenciler:
	1.	Ali Veli
	2.	Ayşe Yılmaz

*Polymorphism Örneği:*

Öğrenci BilgiGoster():
Ad: Ali
Soyad: Veli
Numara: 12345
