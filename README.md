# HRMaster

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


--------------------------


# HRMaster

## 🧾 Project Overview  
`HRMASTER` is a Human Resources / Personnel Management web application developed using ASP.NET Core MVC.  
In this project, administrators can perform functions such as adding, deleting, and listing personnel, as well as managing profile pictures. Personnel users can view and update their own information.

## 🎯 Key Features  
- User authentication and authorization (distinguishing administrators & personnel users)  
- Profile-based user management: Personnel profile pictures are stored in the `wwwroot/UserPicture` folder.  
- Email activation: When new personnel are added, administrators can send activation emails.  
- MVC Core architecture: Layered structure, security with Identity, data access with Entity Framework Core.  
- Personnel management: Personnel list, personnel detail page, update functionality, etc.  
- Flexible image storage: Options for storing images as `byte[]` in the database or as files.  

## 🛠 Technologies  
- ASP.NET Core MVC  
- ASP.NET Identity  
- Entity Framework Core  
- MS SQL Server  
- HTML5 / CSS3 / JavaScript  
- (Optional) SMTP or similar service for sending emails  

## 🧩 Installation & Running  
1. Clone the project to your local machine:  
   ```bash
   git clone https://github.com/EmreBarisErdem/MVC_Project_Group_4.git
