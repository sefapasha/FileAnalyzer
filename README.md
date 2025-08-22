# 📂 FileAnalyzer

**FileAnalyzer**, C# Windows Forms ile geliştirilmiş bir dosya analiz uygulamasıdır.  
Bu uygulama, `.txt` ve `.docx` gibi metin tabanlı dosyaları okuyarak içerik üzerinde detaylı analizler yapar.  
Amacı; kullanıcıya dosya içeriği hakkında istatistiksel bilgiler sunmak ve farklı dosya türlerini kolayca işleyebilmektir.

---

## ✨ Özellikler

- 📑 **Dosya Türü Seçimi**: Açılış ekranında `.txt` veya `.docx` dosya seçimi yapılabilir.  
- 📂 **Dosya Yükleme**: OpenFileDialog ile seçilen dosya kolayca yüklenir.  
- 📊 **İçerik Analizi**:  
  - Toplam kelime sayısı  
  - Farklı kelime sayısı  
  - Her kelimenin tekrar sayısı (sıklık analizi)  
  - Noktalama işaretleri sayısı  
- 🚫 **Filtreleme**: Bağlaçlar ve sayılar analiz dışında tutulur.  
- 📈 **Sonuçların Sıralanması**: Kelimeler en çok tekrar edilenden en aza doğru sıralanır.  
- 🔧 **Genişletilebilir Mimari**: İleride `.pdf` gibi yeni dosya türleri kolayca eklenebilir.  
- 📝 **Hata & Log Yönetimi**: Kullanıcı hataları ve uygulama logları kaydedilir.  

---

## 🖼️ Ekran Görüntüleri

<img width="1401" height="548" alt="dd2" src="https://github.com/user-attachments/assets/d27a81f6-070f-41e0-b99a-20b74184cff3" />


---

## 🛠️ Gereksinimler

- [Visual Studio 2019](https://visualstudio.microsoft.com/) veya üzeri  
- .NET Framework / .NET 6+ (projeye göre ayarlanmış sürüm)  
- `Microsoft.Office.Interop.Word` NuGet paketi (`.docx` desteği için)  

---

## 🚀 Kurulum ve Çalıştırma

1. Reponun en güncel halini klonlayın:
   ```bash
   git clone https://github.com/sefapasha/FileAnalyzer.git

# 👤 Geliştirici
Ahmet Sefa Ünal  
