# Unity 2D Flappy Bird Clone

Bu proje, Unity 6 kullanılarak geliştirilmiş tam döngü (Core Loop) bir 2D Arcade oyunudur. Oyun mekaniklerinin arka planını ve UI yaşam döngüsünü kavramak amacıyla sıfırdan kodlanmıştır.

## Oynanış ve Mekanikler
* **Tam Oyun Döngüsü:** Ana Menü -> Oynanış -> Ölüm Ekranı -> Yeniden Başlatma.
* **Fizik Sistemi:** `Rigidbody2D` ve `Collider2D` bileşenleri kullanılarak karakter ve engel etkileşimleri kurgulandı.
* **Dinamik Obje Üretimi:** `IEnumerator` (Coroutine) ve `Instantiate` metotları kullanılarak rastgele yüksekliklerde sürekli engel üreten bir **Spawner** sistemi oluşturuldu.
* **UI (Arayüz) Yönetimi:** `TextMeshPro` kullanımı ve oyun durduğunda (`Time.timeScale = 0`) kod üzerinden dinamik olarak tetiklenen ölüm ekranı.
* **Geliştirilebilir Yapı:** Scriptler; GameManager, Birdy ve Spawner olarak görevlerine göre ayrıştırıldı, modüler bir temel atıldı.

## Kullanılan Teknolojiler
* Unity 6
* C# (.NET)
* 2D Physics Engine

> *Bu proje, Yönetim Bilişim Sistemleri (YBS) eğitimimin analitik altyapısını oyun geliştirme süreçlerine entegre etme serüvenimin bir parçasıdır.*
