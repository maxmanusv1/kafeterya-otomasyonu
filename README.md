# Kafeterya Otomasyonu

<h5>Kafeler için kullanılabilecek otomasyon </h5>

<h2>1 Yapılan Çalışma ve Sonuçları </h2>

Yapılan çalışma ile tek bir panel üzerinden 7 adet sekme ile oluşmaktadır. Bu bölmeler sırasıyla; Göz At, Siparişler, Ürünler, Personeller, Veriler, Masalar, Sipariş Hazırla ile oluşur. Sipariş hazırlamak için “Sipariş Hazırla” bölümüne geçilir ve ürünler, masalar ve personel seçilerek ilgili masaya sipariş oluşturulur. Siparişin detayını “Siparişler” ve “Masalar” bölümünden görebiliriz.
<br> <br>

<h2>2 Sistem Tasarımı</h2>
  <h3>2.1 Nasıl Tasarlanmalı?</h3>
Projede hedeflerimden birisi kullanımın kolay olmasıydı. Bunu sağlamak için her şeyi tek bir Windows Form içerisinde gerçekleşmesini sağladım. 
<br><br>
Açtığımızda gelen Göz At ekranımız Ana Form içerisinde bulunan bir panelin içerisine yükleniyor. Diğer Siparisler Butonu gibi butonlara tıklandığı zaman Siparisler Formunu oluşturarak Ana formumuzun içerisindeki Panele aynı şekilde yüklüyor ve bizi bu şekilde üst üste Formlar açarak görüntü kirliliğine yol açmıyor. 
  <h3>2.2 Siparişler Nasıl Oluşturulmalı?</h3>
  
Siparişler Otomasyonumda “Siparis Hazırla” ekranında oluşturulur. Oluşturma esnasında ürün bilgileri, masa bilgisi ve personel bilgisi alınır. Sipariş kodu oluşturarak veri tabanı üzerinde ürünleri sipariş kodu ile her bir ürünü tabloya ekler. Siparişin detayları(Toplam ücret,  Personel Ismi vb.) ayrı bir tabloda yine tutulmaya devam edilir. Masa durumu güncellenir ve personelin gerçekleştirdiği işleri günceller. Ödeme esnasında Masa durumu sıfırlanır, sipariş tablosundan verileri silinir.

<h3>2.3 Masalar ve Urunlerin Oluşturulması</h3>

Formumuza verileri çekerken masalar ve ürünler gibi verileri seçilebilir yapmam gerekiyordu fakat datagridview tam aradığım şey değildi. Bu sorunu çözmek için UserControl oluşturarak ne kadar masa, ürün olursa olsun oluşturarak istediğim masanın, ürünün verisine erişmem kolaylaştı.

<h2>3 ÖNERİLER</h2>

•	Ürünler için resimler eklenebilir. Resimler database üzerinde tutulabilir. <br>
•	Giriş, kayıt ekranı eklenerek yönetici girişi ve personel girişi ayrı yapılabilir. <br>
•	Birden fazla kafenin aynı anda kullanabilmesi için giriş ekranı eklendikten  sonra her kafeye özel kullanıcı adı ve şifre ile erişim sağlanılabilir.<br>
•	Mobil uygulaması yazılabilir.
