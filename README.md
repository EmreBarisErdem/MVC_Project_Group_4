# HRMASTER

## 🧾 Proje Özeti  
`HRMASTER`, ASP.NET Core MVC teknolojileri kullanılarak geliştirilmiş bir İnsan Kaynakları / Personel Yönetimi senaryolu web uygulamasıdır.  
Proje kapsamında yöneticiler; Personel ekleme, silme, listeleme, profil resmi yönetimi gibi fonksiyonları kullanabilir. Personel kullanıcıları ise kendi bilgilerinin görüntülenmesi ve güncellenmesi gibi işlemleri gerçekleştirebilir.

## 🎯 Öne Çıkan Özellikler  
- Kullanıcı kimlik doğrulaması ve yetkilendirme (yöneticiler & personel kullanıcısı ayrımı)  
- Profilli kullanıcı yönetimi: Personellerin profil resimleri `wwwroot/UserPicture` klasörüne kaydedilir.  
- Email aktivasyonu: Yeni personel eklendiğinde yöneticiler tarafından email aktivasyonu gönderilir.  
- MVC Core mimarisi: Katmanlı yapı, Identity ile güvenlik, Entity Framework Core ile veri erişimi.  
- Personel yönetimi: Personel listesi, personel detay sayfası, güncelleme vb.  
- Görsel yedekleme: Veritabanında resimlerin `byte[]` olarak saklanması veya dosya olarak kaydedilmesi gibi seçeneklerin açık olması.  

## 🛠 Teknolojiler  
- ASP.NET Core MVC  
- ASP.NET Identity  
- Entity Framework Core  
- MS SQL Server  
- HTML5 / CSS3 / JavaScript  
- (Opsiyonel) Mail gönderimi için SMTP veya benzeri servis  

## 🧩 Kurulum & Çalıştırma  
1. Projeyi yerel bilgisayarınıza klonlayın  
   ```bash
   git clone https://github.com/EmreBarisErdem/MVC_Project_Group_4.git


🔐 Kullanım Örnekleri

Yönetici girişi: → Personel ekle → E-postaya aktivasyon gönder → Personel aktivasyon yapar → Personel giriş yapıp profilini görüntüler.

Personel güncelleme: Personel kullanıcı olarak kendi profil resmini yükler veya değiştirir.

Listeleme: Yönetici, tüm personellerin özet bilgilerini PersonnelSummaryInformationVM yapısıyla görüntüler.

🧪 Test & Geliştirme

Unit & Integration testleri eklenebilir.

Kodun okunabilirliği için SRP, SOLID prensiplerine dikkat edilmiştir.

Geliştirme aşamasında bir CI/CD pipeline kurulabilir.
