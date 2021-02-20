# Listeleme
# Döngüler/Loops
```c#
using System;

print("Giriş Yap : ")
kullaniciAdi = "ferhat"
sifre = "123456785"

print("Kullanıcı Adı :" + kullaniciAdi)
print("Şifre :" + sifre)

if (kullaniciAdi == "ferhat" and sifre == "123456785"):
  print("Kullanıcı adı ve şifre doğru")
else:
  print("Kullanıcı adı ve şifre hatalı.Lütfen tekrar deneyiniz.")

print("Kayıt Ol")
def kayıtOl (kullaniciAdi,eposta,sifre):
  print("Kulanıcı Adı :" + kullaniciAdi)
  print("E-Posta :" + eposta)
  print("Şifre :" + sifre)

kayıtOl("ferhat","facar7711@gmail.com", "654411")  

print("Ödevler")
def odevleriListele():
  odevler = ["ödev1", "ödev2", "ödev3","ödev4","ödev5"]
  for odev in odevler:
    print(odev)

odevleriListele()
```
