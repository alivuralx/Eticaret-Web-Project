# E-Ticaret Web Projesi (Katmanlı Mimari)

Bu proje, üniversite **Önlisans** eğitimim süresinde geliştirdiğim, modern yazılım prensiplerini ve katmanlı mimari yapısını temel alan bir e-ticaret otomasyonudur.

## 🚀 Proje Hakkında
Bu çalışma, bir e-ticaret platformunun temel işleyişini (Ürün listeleme, kategori yönetimi, kullanıcı işlemleri vb.) simüle etmek amacıyla geliştirilmiştir. Veri yönetimi tarafında **ADO.NET** kullanılarak performanslı bir yapı hedeflenmiştir.

## 🛠 Kullanılan Teknolojiler
* **Dil:** C#
* **Framework:** .NET Framework
* **Veritabanı:** MSSQL (Microsoft SQL Server)
* **Mimari:** Katmanlı Mimari (N-Tier Architecture)
  * **Core:** Temel varlıklar (Entities)
  * **Data:** Veritabanı erişim katmanı ve Migration işlemleri
  * **WebUI:** Kullanıcı arayüzü ve yönetim paneli
* **Teknolojiler:** ADO.NET, Entity Framework (Migrations), Bootstrap (Frontend tarafında)

## 📦 Kurulum ve Çalıştırma
Projenin yerel ortamda çalıştırılabilmesi için şu adımların izlenmesi gerekmektedir:

1. Bu depoyu (repository) klonlayın.
2. Klasör içerisinde yer alan `eticaret_db.sql` (veya ilgili .sql dosyası) dosyasını SQL Server Management Studio (SSMS) üzerinden kendi veritabanınıza **Execute** ederek tabloları oluşturun.
3. Veritabanı Bağlantısı: Projenin veritabanına bağlanabilmesi için Eticaret.Data katmanındaki DatabaseContext.cs dosyasını açın. OnConfiguring metodu içerisindeki Server=... kısmını kendi yerel SQL Server isminizle güncelleyin.
4. Visual Studio üzerinden projeyi açın ve **Build** ederek çalıştırın.

---
*Bu proje eğitim amaçlı geliştirilmiş olup, üniversite dönemindeki çalışmalarımın bir parçasıdır.*
