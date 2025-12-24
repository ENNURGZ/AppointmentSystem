
# AppointmentSystem

AppointmentSystem, bir güzellik salonu için geliştirilmiş **Windows Forms tabanlı randevu ve salon yönetim sistemi**dir.  
Uygulama; hizmet, personel ve randevu işlemlerini dosya tabanlı olarak yönetir ve gerçek hayata uygun iş kuralları içerir.

---

## 🎯 Projenin Amacı

Bu projenin amacı, küçük ve orta ölçekli bir güzellik salonunda:
- Hizmetlerin yönetilmesi
- Personel bilgilerinin tutulması
- Randevu süreçlerinin kontrollü bir şekilde yürütülmesi
- Günlük ciro hesaplamalarının yapılması  

işlemlerini tek bir masaüstü uygulaması üzerinden sağlamaktır.

---

## 🚀 Temel Özellikler

### 🔹 Hizmet Yönetimi
- Hizmet ekleme, silme, güncelleme
- Hizmet türü, süresi ve ücret bilgileri
- Hizmet süresine göre otomatik saat planlaması

### 🔹 Personel Yönetimi
- Personel ekleme, silme, güncelleme
- Aktif / Pasif personel durumu
- Telefon numarası doğrulama
- Pozisyona göre çalışma saatleri

### 🔹 Randevu Yönetimi
- Randevu alma, silme, güncelleme
- Geçmiş tarihlere randevu alınamaz
- Hafta sonu randevu kısıtı
- Personel kapasitesine göre randevu sınırı
- Hizmet süresine göre otomatik saat aralıkları

### 🔹 Raporlama
- Tarihe göre randevu listeleme
- Hizmet türüne göre filtreleme
- Günlük toplam ciro hesaplama (₺)

---

## 🧠 İş Kuralları

- Aynı tarih, saat ve hizmet türünde alınabilecek randevu sayısı,
  **aktif personel sayısı ile sınırlandırılmıştır**
- Sadece aktif personeller randevu kapasitesine dahil edilir
- Hizmet süresine göre zaman dilimleri otomatik oluşturulur
- Tarihler sistem tarihine göre kontrol edilir.
- Aynı saat aralığında çakışan randevular kontrol edilir.


---

## Personel Kapasite Kuralları (Kritik)

1. Aynı tarih, saat ve hizmet türünde alınabilecek randevu sayısı:
   - İlgili hizmet türünde **aktif personel sayısı** kadar olabilir.
2. Kapasite doluysa yeni randevu eklenemez.
3. Kapasite hesabı randevu ekleme sırasında dinamik olarak yapılır.

---

## 🧱 Proje Yapısı

```
AppointmentSystem
│
├── Form1                → Ana Menü
├── Form_salon           → Salon Yönetim Menüsü
├── Form_hizmet          → Hizmet Yönetimi
├── Form_personel        → Personel Yönetimi
├── Form_randevu         → Randevu Menüsü
├── Form_randevualma     → Randevu Alma
├── Form_randevuListe    → Randevu Listeleme & Günlük Ciro
│
└── README.md
```

---

## 🛠️ Kullanılan Teknolojiler

- C#
- .NET (Windows Forms)
- DataTable & DataGridView
- TXT dosya tabanlı veri yönetimi
- Regex & manuel doğrulama
- CultureInfo (Türk Lirası formatı)

---

## ▶️ Uygulamayı Çalıştırma

1. Projeyi Visual Studio ile açın
2. `Program.cs` üzerinden projeyi çalıştırın
3. Gerekli `.txt` dosyaları otomatik olarak oluşturulur

> Not: Proje **Windows Forms** ortamında çalışmaktadır.

---

## 🎓 Akademik Not

**Bu proje eğitim amaçlıdır.**  
Basitlik ve anlaşılabilirlik adına:
- Veritabanı yerine TXT dosyaları
- Katmanlı mimari yerine Form tabanlı yapı
kullanılmıştır.

Büyük ölçekli sistemlerde:
- Veritabanı
- Katmanlı mimari
- Nesne tabanlı modeller
önerilmektedir.
