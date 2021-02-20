# C# dilinde "while döngüsü"
* İfade doğru olduğu sürece işleme alınır. İfadenin değerini arttırmak önemlidir. Döngünün nerede biteceğini bilemiyorsan while döngüsü kullanmak daha kolay olacaktır.
```c#
            int b = 12;
            int t = 0;
            while (b < 15)
            {
                t = t + b;
                b++;
            }
            Console.WriteLine("Toplam: " + t);
```
