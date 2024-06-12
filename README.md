
# Dernek Takip Uygulaması
# Muhammet Çelik

















# 1-Veritabanı Tasarımı
	Bu kısımda Access veritabanında hangi İsimlendirmeyle hangi tabloları ve verileri oluşturacağımıza bakıyoruz.
 
Şekil 1 Tablolar
	Veritabanı olarak Access veritabanını kullanıyoruz. Access dosyasının ismi olarak DernekTakip isimlendirmesini kullanıyoruz. Şekil 1 de görülen tablo isimlendirmelerini kullanarak tablolarımızı oluşturuyoruz. 

 
Şekil 2 Members Tablosu
	Members isimli yani üye bilgilerinin tutulacağı tablomuzun alan adı kısımlarını ve veri türlerini şekil 2 görüldüğü gibi oluşturuyoruz. Bu tablomuzda üyenin tc bilgisini unique olarak ayarlıyoruz. Çünkü aynı Tc bilgisiyle bir kişi kaydetmemiz gerekiyor. Bunun dışında üyenin adını, soyadını, kan grubunu, cinsiyetini, telefon numarasını, email adresini, adresini, şehir bilgisini, durumu(aktif/pasif) ve kayıt tarih, bilgilerini veritabanında Members isimli tablomuzda tutuyoruz.
 
Şekil 3 DuesPlan Tablosu
	DuesPlans isimli tablomuzun alan adı kısımları ve veri türü kısmını şekil 3 de görüldüğü gibi oluşturuyoruz. Bu tablomuzda yeni bir aidat oluşturulunca, bu aidata ait ay, yıl, ve aidat miktarını tutuyoruz.
 
Şekil 4 DuesPayments Tablosu
	DuesPayments isimli tablomuzun alan adı kısımları ve veri türü kısmını şekil 4 de görüldüğü gibi oluşturuyoruz. Bu tablomuzda, aidatını yatıran üyenin bilgilerini tutuyoruz. Bu tablomuza member_id bilgisi foreign key olarak geliyor. Yine aynı şekilde dues_plan_id bilgiside foreign key olarak geliyor. Bunların dışında yatırılan tutar ve yatırılan tarih bilgisinide tutuyoruz. Buradaki foreign key alanlarını kullanarak üye bilgilerine veya aidat bilgilerine ulaşabiliriz. Bu sayede hangi kullanıcının hangi tarihteki aidatı ödediğini bulup, ödenen tutara göre de borcu olup olmadığını hesaplayabiliriz.

 
Şekil 5 İlişkiler Tablosu
	Tablolarımızın ilişki şemasını şekil 5 de görebiliriz. Burada dues_plan_id bilgisi ve member_id bilgisi DuesPayments tablosunda çoklanmış durumdadır. Yani aralarında 1’e çok ilişkisi vardır. Oluşturmuş olduğumuz bu tabloyu, projemizle aynı klasörde tutuyoruz.

 
Şekil 6 Örnek Members Tablosu Verileri



 
Şekil 7 Örnek DuesPlans Tablosu Verileri

 
Şekil 8 Örnek DuesPayments Tablosu Verileri





2-Kodlama Bölümü
	Bu kısım, Dernek Takip uygulamamızdaki isterlere göre yazılan kodların açıklamalarını içermektedir. 
 
Şekil 9 Oluşturulan Proje İsimlendirmeleri
	Projemizde şekil 9 da görüldüğü üzere 3 katmandan oluşmaktadır. DernekUI kısmında formlarımızın da tutulduğu, arayüz kısmını oluşturmaktadır. DataAccess kısmında veri tabanına erişeceğimiz kodlar yani sorgularımız bulunmaktadır. BusinessService kısmında ise sorguları veritabanına yollamadan önceki iş kurallarımızı yazdığımız kısmı oluşturuyor. Verilerin uygunluğunu bu kısımda kontrol ederek DataAccess kısmına yolluyoruz.




 
Şekil 10 DernekUI
Şekil 10 da arayüz katmanımızda oluşturduğumuz formları görmekteyiz. Form1 yapısında üye ekleme, güncelleme ve listeleme işlemlerini yapıyoruz. ListByCity formumuzda, eklediğimiz üyelerin şehir bilgilerine göre listelenmesini yapıyoruz. ListByBloodGroup formumuzda, üyelerin kan gruplarına göre listelenmesini yapıyoruz. ListByStatus formumuzda, üyelerin aktif/pasif durumlarına göre listelenmesini yapıyoruz. DuesPlans formumuzda Yeni aidat girişleri yapıyoruz. DuesPayments formumuzda mevcut aidatların ödeme işlemini yapıyoruz.
Debts formumuzda, aktif olan üyelerin borç bilgilerini görüntülüyoruz. Bu kısımda borcu olanları pdf dosyası şeklinde bilgisayarımıza kaydedip, borcu olanlara toplu olarak mail atıyoruz. CityZedgraph formumuzda, şehirlere göre üyelerin grafiğini oluşturuyoruz. DuesIncomeZedgraph formumuzda, aylık ve yıllık aidat gelirlerinin tarihlere göre grafiğini oluşturuyoruz. RouterForm yapısında ise oluşturmuş olduğumuz formlar arasında geçiş yapıyoruz.

 
Şekil 11 DataAccess
	Şekil 11 de DataAccess katmanında oluşturduğumuz sınıf yapılarını görüyoruz. BaseDal sınıfında sorgu operasyonlarının tanımlamasını yapıyoruz. Eğer ileride başka bir veri tabanı desteği gelirse bu sorgu yapılarını onun içinde kullanabiliriz. AccessDatabaseDal, BaseDal sınıfından miras almaktadır. AccessDatabaseDal sınıfında, Veri tabanına atacağımız sorguların operasyonları tanımlanmış ve içlerine gerekli sorgu kodları yazılmıştır.
 
Şekil 12 BusinessService
	Şekil 12 de görüldüğü üzere iş kurallarımızın yazılı olduğu sınıfları görüyoruz. BusinessManager sınıfı arayüz ile veriye erişim arasında köprü görevi görmektedir. DuesPaymentsCheckService sınıfında, üyenin belli bir tarihteki aidatını öderken, zaten ödenmiş olabilmesi kontrol ediliyor. DuesPlanCheckService sınıfında ise yeni bir aidat eklerken, eklenilen aidatın daha önce eklenmiş olabilmesi kontrol ediliyor. MemberCheckService de ise bir üyeyi kaydederken, üyenin daha önce kayıt edilmiş olabilmesi kontrol ediliyor.

Sorgu Kodları Öncesi Temel Yapılarımız
 
Şekil 13 Form
	Şekil 13 de görüldüğü üzere form yapısının içerisine girmiş bulunuyoruz. Bu kısımda ve diğer form yapılarında da üstteki BusinessManager yapısını kullanarak önce service katmanıyla, oradan da veriye erişim katmanıyla iletişim kuruyoruz. Burada AccessDatabaseDal olarak Oluşturmuş olduğumuz Access dosyasının adını veri kaynağı olarak yani connectionString olarak veriyoruz.

 
Şekil 14 BusinessManager
	Şekil 13 deki form yapısında görülen kodların, BusinessManager da karşılık geldiği Contructor yapısını Şekil 14 de görüyoruz. Orada BaseDal olarak AccessDatabaseDal nesnesini vermiştik. Bunu verebilmemizin sebebi aralarında inheritance ilişkisi olmasıdır. Bu yapılar kullanılarak DataAccess katmanıyla gerekli iletişimi sağlıyor olacağız.

 
Şekil 15 BaseDal
	Temel Sorgularımızın tanımlamasını yaptığımız BaseDal classını şekil 15 de görüyoruz. Form yapımızda verdiğimiz connectionString parametre olarak alıyor.
 
Şekil 16 DataAccess
	Şekil 16 da Acces veritabanına erişmek için gerekli nesnelerin tanımlanması yapılıyor. OleDbConncetion bağlantıyı açmak için kullanılıyor. OleDbCommand sorgularımızı yazmak için kullanılıyor. Adapter ve data reader ise gelen verilerin tutulmasını sağlıyor.


Üye Ekleme-Güncelleme-Listeleme
 
Şekil 17 Üye Ekleme/Güncelleme/Listeleme
Şekilde 17 de form1.cs isimli form yapımızda üye ekleme, güncelleme ve listeleme işlemlerini yapıyoruz. Bu formu tasarlarken, kullanılan bileşenlerin isimlendirmesi daha kontrollü olabilmek adına değiştirilmiştir. Bu yapıları kullanırken isimlendirmelerini de görmüş olacağız. (Örnek olarak üye ekleme kısmındaki Ad textbox isimlendirmesi tbxFirstname şeklinde yapılmıştır.)


 
Şekil 18 Üye Listeleme Form
	Üyeleri listelemek için Şekil 18 de görüldüğü gibi bir member_list() metodu oluşturuyoruz ve bunu form load olduğunda çağırıyoruz. Burada businessManager da tanımlı member_list() metodunu çağırıyoruz. Bu metod bize bir dataset dönüyor. Bu dataseti datagridview yapımıza veri kaynağı olarak verip listelenme işlemini yapıyoruz. 



 
Şekil 19 Üye Listeleme BusinessManager
	Şekil 19 da BusinesManager da yazılmış üye listeleme metodunu görüyoruz. Buradan baseDal için AccessDatabaseDal vermiştik. AccessDatabaseDal ın üye listeleme metodunu çağırıyoruz.
 
Şekil 20 Üye Listeleme DataAccess
	Şekil 20 de görüldüğü gibi listeleme metodumuza geldik. Bağlantımızı açtık ve temel listeleme sorgumuzu yazdık ve geriye üyelerin listesini döndük.
 
Şekil 21 Üye Ekleme Form
	Öncelikle textBox alanlarının tümüne veri girilmişmi kontrolünü yapıyoruz. Eğer tümüne veri girilmişse else içerisine giriyoruz. Burada veriler uygun formatta girilmişmi kontrol ediyoruz. Örneğin tc kimlik bilgisinin 11 karakter olması ve sayılardan oluşmasını kontrol ediyoruz. Bu işlemi diğer alanlar içinde yapıyoruz. Eğer tüm alanlara uygun veriler girilmişse businessManager in üye ekleme metodunu çağırıyoruz.  
 
Şekil 22 Text Kontrol
	Şekil 22 de girilen verilerin boş olup olmadığının kontrolü bir fonksiyon içerisinde yapılıyor ve geriye boolean bir değer dönüyor.
 
Şekil 23 Email Kontrol
	Şekil 23 de girilen email bilgisinin verdiğimiz email pattern e uygunluğunu kontrol ediyoruz. Örneğin @ işareti içeriyor mu Türkçe karakter var mı veya nokta işareti var mı gibi kontrolleri yapıyoruz ve geriye boolean bir değer dönüyoruz.
 
Şekil 24 Telefon Numarası Kontrol
Şekil 24 de girilen telefon bilgisinin, sayılardan oluştuğunu ve 10 uzunluğunda mı diye kontrol ediyoruz ve geriye boolean bir değer dönüyoruz. 
 
Şekil 25 Üye Ekleme BusinessManager
	Şekil 25 de BusinessManagerdaki üye ekleme metodunu görüyoruz. Burada, önce bu değer zaten kayıtlımı diye kontrol ediyoruz kayıtlı değilse baseDalın üye ekleme metodunu çağırıyoruz.
 
 Şekil 26 Üye Tc Veritabanı Kontrol
	Şekil 26 da girilen üyenin kayıtlı olup olmama durumunu TC bilgisine göre kontrol ediyoruz. TC, unique olduğu için aynı değerle kaydetme işlemi yapmıyoruz.
 
Şekil 27 Üye Ekleme DataAccess
	Şekil 27 de parametreden gelen değerleri, komut.Parameters.AddWithValue ile sorgudaki @ işareti olan değişkenlerle değiştiryoruz ve sorgumuzu yolluyoruz.
 
Şekil 28 Üye Güncelleme Form
	Şekil 28 de üye güncelleme işlemini yapıyoruz. Burada da girilen verilerin uygunluğunu kontrol ediyoruz.

 
Şekil 29 Üye Güncelleme CellClick
	Şekil 29 da DataGridView da üyeye tıkladığımızda otomatik olarak güncelleme kısmındaki textBox içerisine yazmasını sağlıyoruz.
 
Şekil 30 Üye Güncelleme BusinessManager
	Şekil 30 da üye güncellemenin businessManagerdaki kodunu görüyoruz. Parametreyle gelen değerler ile güncelleme metodunu çağırıyoruz.

 
Şekil 31 Üye Güncelleme DataAccess
	Şekil 31 de parametreyle gelen değerleri sorguya ekleyip, sorgumuzu çalıştırıyoruz.

Kan Grubuna Göre Üye Listeleme

 
Şekil 32 Kan Grubuna Göre Listeleme 
	Şekil 32 de seçtiğimiz kan grubuna göre üyeler listeleniyor.
 
Şekil 33 Kan Grubuna Göre Listeleme Form
	Şekil 33 de Kan grubuna göre listelemek için kan grubu bilgisini parametre olarak yolluyoruz. Aynı zamanda bu metodu şehir bilgisine göre ve duruma göre listeleme işlemlerinde de kullanacağımız için filtre bilgisini de parametre olarak yolluyoruz.
 
Şekil 34 Filtreye Göre Listeleme BusinessManager
	Şekil 34 de BusinessManager daki  filtreye göre  listeleme yapacak kodu görüyoruz.
 
Şekil 35 Filtreye Göre Listeleme DataAccess
Şekil 35 de filtreye göre listeleme yapacak sql sorgusunu görüyoruz. Parametre olarak gelen kolon ismini sorgumuza ekliyoruz. Filter ise hangi veriye göre listeleme yapacağının bilgisini taşıyor.	
Şehir Bilgisine Göre Üye Listeleme
 
Şekil 36 Şehir Bilgisine Göre Üye Listeleme
Şekil 36 da seçilen şehir ismine göre listeleme yapacak form yapısını görüyoruz. 
 
Şekil 37 Şehir Bilgisine Göre Listeleme Form
Şekil 37 de aynı kan grubu listelemesinde olduğu gibi kolon adını ve filtre bilgisini veriyoruz.
Şekil 34 ve Şekil 35 Şehir Bilgisine Göre Listeleme İçinde Kullanılmaktadır.

Durum(Aktif/Pasif) Bilgisine Göre Üye Listeleme
 
Şekil 38 Duruma (Aktif/Pasif)  Göre Üye Listeleme
Şekil 38 de seçilen durum bilgisine göre listeleme yapacak form yapısını görüyoruz. 
 
Şekil 39 Duruma Göre Listeleme Form
Şekil 39 da yine aynı şekilde kolon adını ve filtredeki değeri parametre olarak veriyoruz.
Şekil 34 ve Şekil 35 Durum Bilgisine Göre Listeleme İçinde Kullanılmaktadır.

Yeni Aidat Ekleme
 
Şekil 40 Yeni Aidat Ekleme
	Şekil 40 da yeni aidat ekleme form yapısını görüyoruz.
 
Şekil 41 Yeni Aidat Ekleme ve Listeleme Form
	Şekil 41 de görüldüğü üzere mevcut aidatların listelenmesini yapıyoruz ve yeni aidat ekleme işlemini yapıyoruz. Yine alanların boş olma durumunu kontrol ediyoruz.
 
Şekil 42 Yeni Aidat Ekleme ve Listeleme BusinessManager
	Şekil 42 de BusinessManagerdaki aidat listeleme ve yeni aidat ekleme kodunu görüyoruz. Aidat ekleme, parametre olarak ay yıl ve miktar bilgisini içeriyor. Eğer eklenen aidat zaten varsa bunu eklememeliyiz. Bunun kontrolünü yapıyoruz.
 
Şekil 43 Aidat Ekle Kontrol DuesPlanCheckService
	Şekil 43 de parametreyle gelen bilgilere ait aidat zaten var mı kontrol ediyoruz. Bunun için ay  ve yıl bilgisini parametre olarak DataAccess katmanına yolluyoruz.

 
Şekil 44 Aidat Ekle Kontrol DataAccess
	Şekil 44 de parametre olarak gelen ay ve yıl bilgisini sorgumuza ekleyip çalıştırıyoruz ve geriye boolean bir değer dönüyoruz.


 
Şekil 45 Aidat Listeleme DataAccess
	Şekil 45 de Aidat listelemenin DataAccess de çalıştırılan kodunu görüyoruz.
 
Şekil 46 Yeni Aidat Ekleme DataAccess
	Şekil 46 da eğer aidat verit abanın da yoksa çalışacak kodu görüyoruz. Parametreyle gelen ay yıl ve miktarı veri tabanına ekliyoruz

Aidat Ödeme ve Listeleme
 
Şekil 47 Aidat Ödeme ve Listeleme
Şekil 47 de Aidat Ödeme ve Listeleme formunu görüyoruz. Burada DataGridView üzerindeki satırlara tıkıldığımızda bilgiler textbox içerisine otomatik olarak yazıyor.

 
Şekil 48 Aktif Üyeleri/ Aidat Planlarını /Aidat Ödemelerini Listeleme Form
Şekil 48 de Aktif olan üyelerin listelenmesi, Aidat planlarının listelenmesi ve Aidat ödemesi yapan üyelerin bilgilerinin listelenmesi işlemi yapılmıştır.
 
Şekil 49 Aidat Ekleme Form
	Şekil 49 da aidat ödemesi yapan ekle butonu kodları bulunmaktadır. Burada aidat miktarının 0’dan büyük ve yatırılması gereken aidattan küçük olması kontrol edilmiştir.
 
Şekil 50 Aktif Üye Listeleme/Aidat Ödeme Listeleme/Aidat Ödeme Ekleme BusinessManager
	Şekil 50 de aidat ödemesi yapan kullanıcının BusinessManagerda ki kodu yazmaktadır. Burada Parametreyle üyenin id ve yatırılan aidat id bilgileri kullanılarak önce böyle bir üye daha önce bu değerlerle ödeme yapmış mı kontrol ediyoruz. Eğer böyle bir ödeme yoksa o zaman yatırılan miktar ve tarih bilgisiyle DataAccess kısmına gidiyoruz. 

 
Şekil 51 Ödeme Ekleme Kontrol DuesPaymentCheckService
	Şekil 51 de parametreyle gelen değerlerle zaten ödeme yapılmış mı diye kontrol ediyoruz.
 
Şekil 52 Ödeme Ekleme Kontrol DataAccess
	Şekil 52 de ödemenin zaten daha önce yapılmış olmasının kontrolü yapılıyor ve boolean bir değer dönüyor.
 
Şekil 53 Aidat Ödeme Listeleme DataAccess
Şekil 53 de Aidat ödeme bilgilerini listeleyeceğimiz için Üye bilgilerinin tutulduğu ve Aidat bilgilerinin tutulduğu tabloları ödeme tablosuyla join ediyoruz. Üye tablosundan, üye adına, soyadına, TC bilgisine ve email bilgisine ulaşıyoruz. Aidat planları tablundanda aidat ay, yıl ve miktarına ulaşıyoruz.
 
Şekil 54 Aktif Üye Listeleme Data Access 
	Şekil 54 de Aktif olan üyeleri listeliyoruz. Burada Aktifliği kontrol etmek için status kolonunu kullanıyoruz.
 
Şekil 55 Aidat Ödeme Ekleme Data Access
	Şekil 55 de görüldüğü üzere parametreyle gelen aidat yatırma bilgilerini veritabanına ekliyoruz.
Borcu Olanları Listeleme /Pdf olarak Kaydetme/Mail Gönderme
 
Şekil 56 Borcu Olanları Listeleme /Pdf olarak Kaydetme/Mail Gönderme
	Şekil 56 da Borcu olan üyelerin listelenmesi, bunların pdf olarak kaydedilmesi ve toplu olarak mail atılması işlemini yapıyoruz.
 
Şekil 57 Borcu Olan Üyeleri Listeleme
	Şekil 57 de Borçlu olan üyelerin listelenmesini başlatan kodu yazıyoruz.
 
Şekil 58 Borcu Olanları Pdf Dosyasına Kaydetme Form
	Şekil 58 de Borçlu olan üyeleri alıp pdf olarak kaydediyoruz. Bunun için SaveFileDialog ve ITextSharp kullanıyoruz. Bir pdf dosyası oluşturup borçlu olan üyelerin bilgilerini pdfe ekliyoruz. 
 
Şekil 59 Borcu Olanlara Mail Atma Form
Şekil 59 Borcu olan kullanıcılara mail atma işlemini yapıyoruz. SmtpClien adresini varsayılan olarak alıyoruz. Gönderen olarak gmail adresinde bir uygulama şifresi oluşturup bunu credentials olarak veriyoruz. Veriler üzerinde gmail bilgisini alıp bunun üzerinde bir foreach döngüsüyle tümüne mail atma işlemini yapıyoruz.
 
Şekil 60 Borcu Olanlara Mail Gönderme

Şekil 60 da Mesaj gönderme işlemini yapıyoruz. Parametre olarak gelen değerleride kullanıp bir e posta  oluşturup gönderiyoruz.
 
Şekil 61 Borcu Olanları Listeleme BusinessManager
Şekil 61 de borcu olanların Listelenmesini sağlayacak BusinessManager daki kodu görüyoruz.
 
Şekil 62 Borcu Olanları Listeleme DataAccess
Burada borcu olan kullanıcıların bilgilerine join işlemleriyle ulaşıyoruz. Burada yatırdığımız tutardan, aidat miktarını çıkarıp borç bilgisinide hesaplıyoruz.

Şehir Bilgisine Göre Üye Dağılım Grafiği
 
Şekil 63 Şehir Bilgisine Göre Üye Dağılımı
	Şekil 63 de Şehir Bilgisine göre üye dağılımını gösterecek Zedgraph bileşenini görüyoruz.

 
Şekil 64 Şehir Bilgisine Göre Üye Dağılımı Form
Şekil 64 Üye Sayısına ve şehre göre üyelerin dağılımını gösterecek kodu yazıyoruz.
 
Şekil 65 Grafiği Çizme Metodu
 
Şekil 66 Şehir Dağılımları BusinessManager
 
Şekil 67 Şehir Dağılımları DataAccess
	Şekil 67 de üye sayısını,  şehir adına göre gruplayan sql kodunu görüyoruz.
Aylık ve Yıllık Aidata Göre Dağılımlar
 
Şekil 68 Aylık ve Yıllık Gelir Dağılımı
 
Şekil 69 Aylık ve Yıllık Gelir Dağılımı Form
 
Şekil 70 Grafiği Çizme Metodu Form
 
Şekil 71 Aylık ve Yıllık Gelir Dağılımı BusinessManager
 
Şekil 71 Aylık ve Yıllık Gelir Dağılımı DataAccess

Yönlendirme Anasayfası
 
Şekil 72 Yönlendirme
 
Şekil 73 Yönlendirme Form

