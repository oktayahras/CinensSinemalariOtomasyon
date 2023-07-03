# CinensSinemalariOtomasyon
Bu otomasyon sistemi sinema sahibi ve çalışanlarına da kolaylık sağlar. Bilet satışları ve rezervasyonları otomatik olarak işlenir ve biletlerin basımı veya dağıtımı gibi fiziksel işlemler minimize edilir.</br>
Sinema bilet satış otomasyonu, kullanıcılar ve sinema sahibi/çalışanları için pratik ve kullanımı kolay bir deneyim sunar. Kullanıcılar film seçimi yapabilir, koltuklarını seçebilir ve ekstra Mısır,İçecek ve su satın alabilirken sinema sahibi ve çalışanları işlemleri otomatik olarak yönetebilir ve verileri daha iyi takip edebilir.</br>
Sinema bilet satış otomasyonunuz, kullanıcılara sinema bileti almak için kolaylık sağlayan bir WindowsForm uygulaması olarak tasarlanmıştır. Üç ana sayfaya sahip olan bu uygulama, sinema sahibi ve çalışanlarına hizmet verirken aynı zamanda kullanıcılara da kolaylık sağlamaktadır.</br>
#  Ana Sayfa 
Ana sayfa, kullanıcılara sinemanın reklamlarını ve sloganlarını göstermek için tasarlanmıştır. Bu sayfada sinemanın öne çıkan filmlerine dair bilgiler ve fragmanlar yer alabilir. Ayrıca sinemanın hizmetleri, özel etkinlikler veya indirimler gibi önemli duyurular da ana sayfada yer alabilir.
![Ana-sayfa-gif](https://github.com/oktayahras/CinensSinemalariOtomasyon/assets/102553352/d16d6799-fced-40ee-b044-84cfab3981f7)
</br>
# Filimler</br>
Filmler sayfası, kullanıcılara haftanın vizyondaki filmlerini gösterir. Bu sayfada her film için film adı, Türleri ve Seans saatleri gibi bilgiler bulunabilir. Kullanıcılar, ilgilendikleri bir filmi seçip Hangi Seans saatinde girmek isterse sean satini seçebilir ve bilet satın alma işlemine devam edebilir.</br>
![filimler-gif](https://github.com/oktayahras/CinensSinemalariOtomasyon/assets/102553352/1428ff5e-ce50-4b46-9fe1-cf0728345e0b) </br>

# Ödeme
</br>
Ödeme sayfası, kullanıcıların sinema bileti satın alma işlemlerini gerçekleştirebilecekleri sayfadır. Kullanıcılar, seçtikleri film için uygun bir seansı seçer ve ardından koltuk numarasını belirler. Ek olarak, mısır ve içecek gibi ekstra ürünleri satın almak isteyip istemediklerini seçebilirler. Kullanıcılar Öğrenci yada Sivil olduklarını belirtip Adını Ve Soyadını yazarak Biletlerini ve fişlerini deme işlemini tamamladıktan sonra hızlıca alabilirler.</br>

![Ödeme-gif](https://github.com/oktayahras/CinensSinemalariOtomasyon/assets/102553352/8fe11424-71f2-4cf2-942c-613d5c016c8e)
# Uygulamanın Yapım Süreci
</br>
*Visual Studio Code'da yeni bir proje aç ve Windows Form Uygulaması (.NET Framework) seç ve projeyi aç.</br>
*Bu sayfaya çıkıcaktır. şimdi birbirine geçerek Başlangıç ​​konumunu (Merkez Ekran) yapın</br>
*Ekranımız tam ekran olmasın diye max Box seçenegini false yapın</br>

![Ekran görüntüsü 2023-07-03 175954](https://github.com/oktayahras/CinensSinemalariOtomasyon/assets/102553352/e468033c-fc39-4146-bd59-fbe72b8126c1)


Daha sonra araç kutusundan</br>
Panel (Arka plan olarak kullandım)</br>
Button (Menü seçeneklerinde(Ana sayfa, Filimler, Ödeme), Hesapla, Öde, +, -, Filim seansları, Koltuk numaraları butonları olarak kullandım)</br>
PictureBox (Resim eklemek için kullandım)</br>
Label (Yazı eklemek için kullandım)</br>
TextBox (Toplam tutarı yazdırmak için kullandım)</br>
İlk sayfa tasarımım bu şekilde siz daha farklı şekilde araç butonundan üstteki özellikleri sürükleyip kullanabilirsiniz ve özellikler kısmından seçenekleri değiştirebilirsiniz.</br>


![Ekran görüntüsü 2023-07-03 175650](https://github.com/oktayahras/CinensSinemalariOtomasyon/assets/102553352/c5b4d502-cd05-4874-a2aa-ba467d06c929)
</br>
*İkinci sayfayı Yukarıdaki Project seçeneğine tıklayıp add user control (Windoes form)'a tıklarsanız oluşturabilirsiniz.</br>
*İkinci sayfayıda bu şekilde tasarladım.</br>
*Bu Benim Ana sayfamda gözükecek olan sayfam olacak bu sayfada kod yazmadım. sadece.</br>

![Ekran görüntüsü 2023-07-03 180307](https://github.com/oktayahras/CinensSinemalariOtomasyon/assets/102553352/c7c82e62-6c59-49ed-8726-64753998e801)</br>

*şimdi sırada Filimler sayfası var tekrardan yeni bir sayfa açıp üstteki verdiğim araçları kullanarak sayfamı tasarladım.</br>

![Ekran görüntüsü 2023-07-03 180544](https://github.com/oktayahras/CinensSinemalariOtomasyon/assets/102553352/17bb7f38-5325-44d4-832a-7962b0a0d873)

*Bu sayfada sadece butonlara kod yazdım her butonda aynı kod var kodları yazarken buton isimlerini kontrol ediniz!.</br>


![Ekran görüntüsü 2023-07-03 180552](https://github.com/oktayahras/CinensSinemalariOtomasyon/assets/102553352/a0017d60-6202-4762-9e23-34c701d73b53)</br>
<code>button2.BackColor = Color.Gold;</code>  </br>
*şimdi sırada Ödeme sayfası var tekrardan yeni bir sayfa açıp üstteki verdiğim araçları kullanarak sayfamı tasarladım.</br>

![Ekran görüntüsü 2023-07-03 180950](https://github.com/oktayahras/CinensSinemalariOtomasyon/assets/102553352/d8c8163b-6e9f-4da8-ab9f-2ec9fe53fc69)</br>
*Tasarımdan sonra kodlara gelelim.</br>
*İlk önce koltuk butonlarına şu kodları ekledim bu kodlar seçilen koltukları yeşil yapar.</br>
![Ekran görüntüsü 2023-07-03 180958](https://github.com/oktayahras/CinensSinemalariOtomasyon/assets/102553352/8fad3d17-3201-491a-b1a4-7cdc33ceda17)</br>
<code>button1.BackColor = Color.Green;</code></br>
Daha adet blgisini hesaplamak için + ve - butonlara kodlarımı ekledim + ve - butonlarına hepsine farklı bir değişken yazdım değişkenleri sayfanın ilk başında belirlemeniz gerekiyor!.</br>
sayfaya çift tıklayın ve bu boşluğa bu değişken isimlerini yazın değişken isimlerini değiştirebilirsiniz.</br>
![Ekran görüntüsü 2023-07-03 181035](https://github.com/oktayahras/CinensSinemalariOtomasyon/assets/102553352/d57586b6-6bd2-4ea1-9412-0913477c08a7)</br>
<code> int sivil = 0;
        int fiyat = 0;
        int öğrenci = 0;
        int öğrencifiyat = 0;
        int mısır = 0;
        int mısırfiyat = 0;
        int kola = 0;
        int kolafiyat = 0;
        int su = 0;
        int sufiyat = 0;
        int hesapla = 0;  </code></br>
        Şimdi + ve - butonlarına teker teker çift tıklayıp şu kodları yazdım.</br>
        Bu kodlar sivil bilet fiyatını belirler ve kaç adet alındıysa miktar ve fiyat bilgisini yanındaki 2 textbox a aktarır textbox lar içinde kod yoktur!.</br>

![Ekran görüntüsü 2023-07-03 181013](https://github.com/oktayahras/CinensSinemalariOtomasyon/assets/102553352/53cb7f47-82c5-46e9-80d2-7d17fc301ea4)</br>
<code> sivil++;
            fiyat = fiyat + 50;
            textBox1.Text = sivil.ToString();
            textBox2.Text = fiyat.ToString(); </code></br>
Hesapla butonuna çift tıklayarak şu kodları ekledim Bu kodlar seçilen herşeyin fiyatını hesaplar.</br>

![Ekran görüntüsü 2023-07-03 182243](https://github.com/oktayahras/CinensSinemalariOtomasyon/assets/102553352/f3806242-92a5-475e-ab4d-759bddfefb82)</br>

<code> hesapla = fiyat + öğrencifiyat + mısırfiyat + sufiyat + kolafiyat;
            textBox15.Text = hesapla.ToString();</code></br>
Son Olarak ise öde butonuna bu kodları ekledim.</br>

![Ekran görüntüsü 2023-07-03 182458](https://github.com/oktayahras/CinensSinemalariOtomasyon/assets/102553352/565fe8fa-dc36-4409-86e5-ed8278bdc7ab)</br>
<code> MessageBox.Show("Ödemeniz Alınmıştır Lütfen Fişinizi Alınız!");</code></br>

 
*şimdi ana sayfaya gelin Araç kutusuna tıklayın ve en üste gelin.</br>
*buradaki sayfaları teker teker ana sayfaya sürükleyerek sabitleyiniz.</br>

![Ekran görüntüsü 2023-07-03 182623](https://github.com/oktayahras/CinensSinemalariOtomasyon/assets/102553352/e9a02f37-9e99-46a9-aadb-02e209502a9b)</br>
*Şimdi Ana sayfa Butonuna çift tıklayınız. Ve bu kodları yazınız</br>
*Bu kod ilk programı çalıştırdığınızda 1. sayfanın önde gözükmesini diğer sayfaların saklanmasını sağlar. bu kodları sayfa isimlerinize göre değiştiriniz.</br>
*Diğer buttonlar içinde aynısını yapıcağız.</br>
<code>  kontrol1.Show();
            kontrol_11.Hide();
            kontrol_21.Hide();
            kontrol1.BringToFront();</code></br>
*Filimler Butonu için bu kodu.</br>
<code>kontrol1.Hide();
            kontrol_11.Show();
            kontrol_21.Hide();
            kontrol_11.BringToFront();</code></br>
*Ödeme Butonu için bu Kodu.</br>
<code> kontrol1.Hide();
            kontrol_11.Hide();
            kontrol_21.Show();
            kontrol_21.BringToFront();</code></br>


*Uygulama şimdi çalışıcaktır sadece gerekli boyut sorunları oluştuysa onları düzeltiniz.</br>
*Ben resimleri ve ikonları internetten buldum siz istediğiniz yerden alabilirsiniz.</br>



