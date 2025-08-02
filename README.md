# 🏗️ Clean Architecture Demo

Bu proje, **Clean Architecture**, **CQRS**, **MediatR** ve **AutoMapper** desenlerini uygulayarak modern, ölçeklenebilir ve sürdürülebilir bir yazılım geliştirme mimarisini göstermektedir.

---

## 📂 Katmanlı Mimari Yapı

### 1. Domain Layer
- Core business logic ve domain modelleri.
- Entity, ValueObject ve domain service tanımları içerir.

### 2. Application Layer
- **CQRS (Command-Query Responsibility Segregation)** uygulanmıştır.
- Komut ve sorgu işlemleri birbirinden ayrılarak esnek ve okunabilir hale getirilmiştir.
- **MediatR** ile handler'lar loosely coupled hâle getirilmiştir.
- DTO, Validator ve AutoMapper profilleri de bu katmandadır.

### 3. Infrastructure Layer
- Veritabanı bağlantısı, dış servis entegrasyonları, e‑posta servisleri vb. içerir.
- **Entity Framework Core** ve/veya **Dapper** kullanılır.

### 4. API Layer
- RESTful endpoint'lerin tanımlandığı sunum katmanıdır.
- Kullanıcıların dışarıdan erişeceği tek katmandır.

---

## 🚀 Özellikler

- ✅ Katmanlı mimari ve sorumluluk ayrımı
- ✅ CQRS ve MediatR ile modern yapı
- ✅ AutoMapper ile hızlı veri eşleme
- ✅ FluentValidation ile veri doğrulama
- ✅ Unit test'e uygun, sade ve modüler yapı
- ✅ SOLID prensiplerine uygun kod

---

## 🧪 Kullanılan Teknolojiler

| Alan               | Teknoloji/Tool              |
|--------------------|-----------------------------|
| Backend Framework  | ASP.NET Core                |
| ORM                | Entity Framework Core, Dapper |
| Pattern            | CQRS, MediatR, AutoMapper   |
| Validasyon         | FluentValidation            |
| Veritabanı         | SQL Server / PostgreSQL     |
| Mesajlaşma (Ops.)  | RabbitMQ (varsa)            |

---

## 🛠️ Kurulum

```bash
# 1. Reposu klonla
git clone https://github.com/Yusuftmle/CleanArchitectureDemo.git

# 2. Gerekli NuGet paketlerini yükle
dotnet restore

# 3. Veritabanı ayarlarını güncelle (appsettings.json)

# 4. Database migration uygula (örnek)
dotnet ef database update

# 5. Uygulamayı başlat
dotnet run
