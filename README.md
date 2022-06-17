
# Team Delta Sınav Sistemi

Bu uygulama okullardaki, kurslardaki veya herhangi bir uygulama sınavını kolayca koordine etmemizi sağlar.

## Ekran Görüntüleri

**Ana Ekran**

![Ana Ekran](https://raw.githubusercontent.com/deltaware/ExamManagament/main/screenshots/Ekran%20görüntüsü%202022-06-17%20203736.png)

**Bilgi Giriş**

![Bilgi Giriş](https://raw.githubusercontent.com/deltaware/ExamManagament/main/screenshots/Ekran%20görüntüsü%202022-06-17%20203810.png)

**Sonuç** (Masaüstüne geliyor.)

![Sonuç](https://raw.githubusercontent.com/deltaware/ExamManagament/main/screenshots/Ekran%20görüntüsü%202022-06-17%20203912.png)

  
## Kullanım/Örnekler

**ÖNEMLİ!!**
- **appInformation.toml** konfigürasyon dosyamızı **%appdata%** dosya dizinine atmalısınız.

**appInformation.toml** örneği; 
```
examConfigLink = "https://github.com/deltaware/ExamManagament/releases/download/2.4/examInformation.toml"
examFinished = "False"
```
- **examConfigLink** değişkenine değer olarak **examInformation.toml** dosyanızın linkini koymalısınız.
- **examFinished** değişkeni sınavın tamamlanıp tamamlanmadığını kontrol eder. Eğer sınav tamamlanmamışsa **"False"** değeri alır. Tamamlandığı takdirde **"True"** değerini otomatik olarak alacaktır. Varsayılan olarak **"False"** yapmanız gerekmektedir.


**examInformation.toml** örneği;
```
schoolName = "Mehmet Tuğrul Tekbulut Mesleki ve Teknik Anadolu Lisesi"

[examInfo]
name = "Nesne Tabanlı Programlama"
creators = "Berivan TOLA, Hüsnü KÜÇÜKKÖYLÜ, Halil İbrahim ALTUNDAĞ"
time = "120"

[examLinks]
firstLink = "https://github.com/deltaware/ExamManagament/releases/download/2.3/exam.zip"
secondLink = ""
thirdLink = ""
```
- **schoolName** değişkenine değer olarak okul ismini girmelisiniz.
- **name** değişkenine değer olarak sınav ismini girmelisiniz.
- **creators** değişkenine değer olarak sınavı hazırlayan öğretmenin/eğitimcinin adını/adlarını girmelisiniz.
- **time** değişkenine değer olarak sınavın süresini dakika cinsinden girmelisiniz.
- **[examLinks]** alanında sınavın **direkt indirilebilir** linkini **"zip"** dosya türünde girmelisiniz.
## MaterialSkin

- [@orapps44](https://github.com/orapps44/MaterialSkin) form tasarımı için.

  
## Lisans

[MIT](https://choosealicense.com/licenses/mit/)

  
