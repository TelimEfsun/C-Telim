<h1><b>What is C# ? </h1> 
1.C# kodu anlaşılan dildən kompüterin başa düşəcəyi formata çevrilir. Bu prosesi C# Compiler (CSC.exe) həyata keçirir.
Yəni, C# kodu birbaşa maşın koduna çevrilmir, əvvəlcə ortaq bir dilə Intermediate Language (IL) tərtib edilir.
IL kodu C# və digər .NET dilləri (F#, VB.NET və s.) üçün ortaq bir formatdır. <br>
2. CLR (Common Language Runtime) bu IL kodunu JIT (Just-In-Time Compiler) vasitəsilə maşın koduna çevirir və icra edir. <br>
3. Sonda proqram işləyir və nəticəni göstərir. <br>
Proqramlaşdırma və kompüter sistemlərində bütün məlumatlar 0 və 1 kimi saxlanılır.

<h2>Stack and Heap</h2>
Value tiplər stack yaddaşda saxlanılır ve biri dəyişdikdə digəri dəyişmir LIFO (Last in First out) prinsipi ilə işləyir. <br>
Referans tiplər isə Stack və Heapdə saxlanılır. Biri dəyişdikdə digəridə dəyişir.
<h2>Array</h2>
Array statik ölçüyə malikdir, tip anlayışı var və Add, Remove etmək olmur. <br>
ArrayList dinamik ölçüyə malikdir, tip anlayışı yoxdur və Add, Remove etmək olur. <br>
List: List<T> ad = new List<T>() Statik ölçü deyil, Tip anlayışı var və Add, Remove etmək olur.

<h2>Boxing, UnBoxing</h2>
Value tipin Objekt yaxud Referans tipe çevrilməsi Boxingdir. <br>
Əksi isə UnBoxingdir.
UnBoxing prosesində Objecti Value tipe çevirmeden əvvəl Array[0] elementi İnt-ə çevrilə bilib bilmədiyini yoxla, <br>
Əks halda <br>
İf (Array[0] is int)<br>
{              <br>
   int x = (int)Array[0];           <br>
   Console.WritLine(x);             <br>
}

<h2>Casting</h2>
 Value typelar arasinda gedir <br>
 Implicit Casting (avtomatik olaraq) - daha kiçik bir tipi daha böyük tip
 ölçüsünə çevirmək. char -> int -> long -> float -> double. <br>
 Explicit Casting (əl ilə) - daha böyük tipi daha kiçik ölçülü tipə çevirmək.
 double -> float -> long -> int -> char

 <h2>Generics and non Generics</h2>
 HashTable -- Tip anlayışı yoxdur <br>
 Dictionary -- Tip anlayışı var <br>
 SortedList -- kiçikdən böyükə siralama verir. <br>
 Stack -- Push, Pop. LİFO prinsipi ile işleyir <br>
 Queue -- Enqueue, Dequeue. FİFO prinsipi ilə işləyir.

 <h2>Methods</h2> <br>

 C#-da methodlar bir sinif (class) daxilində müəyyən əməliyyatları yerinə yetirmək üçün istifadə <br>
 olunan funksiyalardır. Metodlar kodun təkrar istifadəsini, oxunaqlılığını və  <br>
 təmin edir. <br>
 C#-da metodlar bir neçə növə bölünür: <br>
 Geri dəyər qaytaran metod: Bir nəticə hesablayıb qaytarır. <br>
 Geri dəyər qaytarmayan metod (void): Heç bir nəticə qaytarmır, sadəcə bir əməliyyatı yerinə <br>
 yetirir. <br>

 <h2>Class</h2>
 C#-da class (sinif) obyekt yönümlü proqramlaşdırmanın (OOP - Object-Oriented Programming) <br>
 əsas elementlərindən biridir. Sinif, obyektlərin xüsusiyyətlərini (fields, properties) və <br>
 davranışlarını (methods) müəyyən edən bir şablondur (template). Yəni, siniflər real dünya <br>
 obyektlərini modelləşdirmək üçün istifadə olunur. <br>

 <h2>Constructors</h2>
 Konstruktorlar obyekt yaradıldıqda avtomatik işləyən xüsusi metodlardır. Sinifin adını daşıyır və <br>
 geri dəyər qaytarmır. Parametrlerin mecburi daxil edilmesi ucun lazimdir.

<h2>Inhertance</h2>
Dilimizə “Törəmə” “Miras almaq” kimi tərcümə edilən Inheritance obyekt yönümlü proqramlaşdırmanın ən vacib <br>
xüsusiyyətlərindən  biridir. Bu bizə icazə verir ki, bir sinfin xüsusiyyətləri başqa bir sinif tərəfindən <br>
istifadə edilə bilsin. Biz yazmasaq da C#-da yaradacağımız istər value type, istər reference type-lar object classından <br> törəyir. Ana class Base ondan töreyen classlar ise Derived classlar adlanır.Base classların instanceni yaratmamaq <br>
ücün “abstract” açar sözündən istifadə edilir  abstract classların instance-ni(new ilə) yaratmaq olmur. <br>
Base classın constructor-nu derived classlarda çağıra bilərik. Bunun üçün derived classın constructorunun <br>
qarşısında “:base”açar sözündən istifadə olunur. Constructor-un məqsədi obyekt yaradılan zaman məcburi <br>
parametrlərin göndərilməsidir. <br>

Base class-da olan methodu derived classda implement etməsək belə default olaraq bütün derived classlarda da olur. <br>
Bəzən base classda olan methodun derived classda fərqli cür həyata keçirilməsi üçün “virtual” açar sözündən <br>
istifadə edirik. Base classda “virtual” olaraq elan etdiyimiz methodu, derived classda “override”açar sözün ilə yazırıq.<br>
Əgər base classda yaradacağımız methodun body-si olmayacaqsa bu zaman methodun qarşısında “abstract” açar <br>
sözündən istifadə edirik. Həmin bu method derived classda override olunmuş şəkildə mütləq implement olmalıdır. <br>

Sealed class-lardan hec bir class törəyə bilməz! Əgər sealed classın daxilində virtual method yaratsaq bu zaman <br>
compile-time errorla qarşılaşacağıq. Çünki bu sealed class törəmir, virtual method isə törəyən classların methodunu <br>
override etmək üçün istifadə edilir.
