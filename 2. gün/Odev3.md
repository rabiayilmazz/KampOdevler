# C# dilinde "switch"
* şartlar ve sonuçlarında yapılması istenenler için kullanılır
* birden fazla değişen durum olduğunda kolaylık sağlar
* örneğin number a atadığımız farklı durumlar için case ler oluşturduk . Aşağıdaki örnekte number 1 olduğu için case1 ( yani number ın 1 olduğu durum çalışacak)
Break eklediğimiz için de case1 çalıştıktan sonra switch yapısından çıkılacak  ve kodun devamı varsa çalışmaya devam edecek
Default ise eğer hiçbir durumda istenen sağlanmadıysa yapılmak istenen eylem için kullanılır
```c#
int number = 1;
switch (number)
{
    case 1:
        Console.WriteLine("case1 calisti");
        break;
    case 2:
        Console.WriteLine("case2 calisti");
        break;
    default:
        Console.WriteLine("istenen sart saglanmadi");
        break;
}
```
