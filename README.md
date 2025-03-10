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
List

<h2>Boxing, UnBoxing</h2>
Value tipin Objekt yaxud Referans tipe çevrilməsi Boxingdir. <br>
Əksi isə UnBoxingdir.
UnBoxing prosesində Objecti Value tipe çecirmeden əvvəl Array[0] elementi İnt-ə çevrilə bilib bilmədiyini yoxla, <br>
Əks halda <br>
İf (Array[0] is int)<br>
{              <br>
   int x = (int)Array[0];           <br>
   Console.WritLine(x);             <br>
}


