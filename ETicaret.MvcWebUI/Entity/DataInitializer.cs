using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ETicaret.MvcWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            
                // Mevcut Seed kodunuz...
                var kategoriler = new List<Category>()
            {
                new Category(){ Name = "Kıyafet", Description = "Kıyafet ürünleri",Image = "Kıyafet.jpeg"},
                new Category(){ Name = "Kamera", Description = "kamera ürünleri", Image = "Camera.jpeg"},
                new Category(){ Name = "Bilgisayar", Description = "Bilgisayar ürünleri",Image = "Bilgisayar.jpeg"},
                new Category(){ Name = "Takı", Description = "Takı ürünleri", Image = "Takı.jpeg"},
                new Category(){ Name = "Telefon", Description = "Telefon ürünleri",Image = "Telefon.jpeg"},
                new Category(){ Name = "Beyaz Eşya", Description = "Beyaz Eşya ürünleri", Image = "BeyazEsya.jpeg"}
            };

                foreach (var kategori in kategoriler)
                {
                    context.Categories.Add(kategori);
                }
                context.SaveChanges();

                var urunler = new List<Product>()
            {
                    
                new Product(){ Name = "Colombia Powder Lite Erkek Lacivert Mont Erkek Şişme Mont Wo1111-467 WO1111-467-2", Price =7999 , Stock =250 , IsApproved =true , CategoryId = 1,IsHome = true,Image = "ColombiaMont.jpg",Description="Erkek Mont giyim",DescriptionLong ="Columbia erkek mont, soğuk kış günlerinde sizi sıcak tutan tasarımıyla konfor sunar ve gün boyu rahatlık sağlar. Özel yalıtım unsurlarına sahip olan mont, şık tasarımı ve rahat kesimi ile üzerinize oturur. " +
                "Columbia erkek mont, hafiflik ve sıcaklık gerektiren aktiviteler ile uzun süre soğukta kalınan koşullarda giymek için son derece idealdir. Yüksek nefes alabilme ve nem emme özelliği ile fazla ısının ve nemin atılmasına yardımcı olur. Ürün, hafifliği ve sıcak tutma özellikleriyle çok katmanlı giyinme ihtiyacınızı azaltır. İşlevsel ve güvenli saklama çözümleri sunan mont, sevebileceğiniz alternatif renk seçenekleri ile satışa sunulmuştur.\r\n\r\nIsıyı Yansıtan Teknoloji: " +
                "Omni-Heat Reflective\r\n\r\nColumbia Mont soğuk hava montu; sentetik yalıtımı, termal yansıtıcı astarı ve dayanıklı, hafif suya ve soğuk havaya dirençli dış katmanı ile sıcak kalmanıza yardımcı olur. Omni-Heat Reflective termal yansıtıcı teknolojisi ile üretilen Columbia mont, vücut ısınızı geri yansıtarak ve koruyarak regüle etmeye yardımcı olurken aynı zamanda aşırı teri ve de ısıyı yayarak sizin konforlu kalmanızı sağlar. Nefes alabilir kumaşa birleşik haldeki yansıtıcı " +
                "gümüş noktalar sayesinde Omni-Heat Reflective, size daha fazla ısı sağlar çünkü sizin doğal vücut ısınızı size tekrar geri yansıtır. Bu teknoloji, normal ürünlere göre %20 sıcaklık sağlar. Omni Heat Reflective, Columbia’nın tekstil, ayakkabı, aksesuar gibi tüm ürün gruplarında kullandığı ve kışın ihtiyaç duyacağınız bir teknolojidir. Omni-Heat Reflective, ilk yardım battaniyelerinde kullanılan yansıtıcı teknolojisinden ilham alır.",Payment="Peşin Fiyatına 2 taksit",ShippingInf="Aras Kargo"},

                new Product(){ Name = "Canon Eos 1200D 18-55 mm DC Profesyonel Dijital Fotoğraf Makinesi",DescriptionLong = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 2, IsHome = true,Image = "Camera1.jpeg",Description ="Fotoğraf Makinesi",Payment="Havale ve Eft ile verdiğiniz siparişlerde %2 indirim ile fiyatı 14.699 TL",ShippingInf="Kargo Ücretsiz"},
                new Product(){ Name = "Canon Eos 100D 18-55 mm DC Profesyonel Fotoğraf Makines",DescriptionLong = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 2,IsHome = true,Image = "Camera2.jpeg",Description ="Fotoğraf Makinesi",Payment="Havale ve Eft ile verdiğiniz siparişlerde %2 indirim ile fiyatı 14.699 TL",ShippingInf="Kargo Ücretsiz"},
                new Product(){ Name = "Canon Eos 700D 18-55 DC DSLR Fotoğraf Makinesi",DescriptionLong = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 2,IsHome = true,Image = "Camera3.jpeg",Description ="Fotoğraf Makinesi" ,Payment="Havale ve Eft ile verdiğiniz siparişlerde %2 indirim ile fiyatı 14.699 TL",ShippingInf="Kargo Ücretsiz"},
                
                new Product(){ Name = "Lenovo Ideapad 310 Intel Core i7 7500U 12GB 1TB GT920M Windows 10 Home 15.6 Taşınabilir Bilgisayar 80TV028XTX",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =4500 , Stock =1200 , IsApproved =true , CategoryId = 3,IsHome = true,Image = "Bilgisayar1.jpeg",DescriptionLong ="Bilgisayar",Payment="Kredi Kartı",ShippingInf="PTT Kargo"},
                new Product(){ Name = "Asus UX310UQ-FB418T Intel Core i7 7500U 8GB 512GB SSD GT940MX Windows 10 Home 13.3 QHD Taşınabilir Bilgisayar",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =3400 , Stock =0 , IsApproved =true , CategoryId = 3,IsHome = true,Image = "Bilgisayar1.jpeg", DescriptionLong = "Bilgisayar",Payment="Kredi Kartı",ShippingInf="PTT Kargo"},
                new Product(){ Name = "Asus UX310UQ-FB418T Intel Core i7 7500U 16GB 512GB SSD GT940MX Windows 10 Home 13.3 QHD Taşınabilir Bilgisayar",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =2500 , Stock =600 , IsApproved =true , CategoryId = 3,IsHome = true,Image = "Bilgisayar1.jpeg", DescriptionLong = "Bilgisayar",Payment="Kredi Kartı",ShippingInf="PTT Kargo"},
                new Product(){ Name = "Asus N580VD-DM160T Intel Core i7 7700HQ 16GB 1TB + 128GB SSD GTX1050 Windows 10 Home",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =5200 , Stock =500 , IsApproved =true , CategoryId = 3,IsHome = true,Image = "Bilgisayar1.jpeg", DescriptionLong = "Bilgisayar",Payment="Kredi Kartı",ShippingInf="PTT Kargo"},

                new Product(){ Name = "Apple iPhone 6 32 GB (Apple Türkiye Garantili)", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 5,IsHome = true,Image = "Telefon1.jpeg",DescriptionLong ="Telefon",Payment="Nakit veya Kredi Kartı",ShippingInf="Aras Kargo"},
                new Product(){ Name = "Apple iPhone 7 32 GB (Apple Türkiye Garantili)",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =5600 , Stock =1200 , IsApproved =true , CategoryId = 5,IsHome = true,Image = "Telefon1.jpeg", DescriptionLong = "Telefon",Payment="Kredi Kartı",ShippingInf="Aras Kargo"},
                new Product(){ Name = "Apple iPhone 6S 32 GB (Apple Türkiye Garantili)",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =3400 , Stock =0 , IsApproved =true , CategoryId =5,IsHome = true, DescriptionLong = "Telefon",Payment="Kredi Kartı",ShippingInf="Aras Kargo"},
                new Product(){ Name = "Case 4U Manyetik Mıknatıslı Araç İçi Telefon Tutucu",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =2500 , Stock =600 , IsApproved =true , CategoryId = 5,IsHome = true,Image = "Telefon1.jpeg", DescriptionLong = "Telefon",Payment="Kredi Kartı",ShippingInf="Aras Kargo"},
                new Product(){ Name = "Xiaomi Mi 5S 64GB (İthalatçı Garantili)",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =5200 , Stock =500 , IsApproved =true , CategoryId = 5,IsHome = true,Image = "Telefon1.jpeg", DescriptionLong = "Telefon",Payment="Kredi Kartı",ShippingInf="Aras Kargo"},

            };

                foreach (var urun in urunler)
                {
                    context.Products.Add(urun);
                }

                context.SaveChanges();

                base.Seed(context);
            
            
            
        }
    }
}