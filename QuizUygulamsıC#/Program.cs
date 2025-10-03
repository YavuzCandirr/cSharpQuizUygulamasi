// See https://aka.ms/new-console-template for more information

//.Trim()=> boşlukları yok eder
//.ToLower()=> küçük harf olarak kabul eder


int score = 0;

string soru1 = "Sivasın plakası kaçtır? ";
string cevap1 = "58";

string soru2 = "Türkiyenin başkenti neresidir?";
string cevap2 = "Ankara";

string soru3 = "MAKÜ nerede?";
string cevap3 = "Burdur";

Console.WriteLine(soru1);
string kullanıcıCevabı = Console.ReadLine();

if(kullanıcıCevabı.Trim().ToLower() == cevap1.ToLower())
{
    Console.WriteLine("Tebrikler");
    score++;

}
else
{
   Console.WriteLine("Yanlış cevap!");
}

Console.WriteLine(soru2);
string kullanıcıCevabı2 = Console.ReadLine();

if (kullanıcıCevabı2.Trim().ToLower() == cevap2.ToLower())
{
    Console.WriteLine("Tebrikler");
    score++;

}
else
{
    Console.WriteLine("Yanlış cevap!");
}

Console.WriteLine(soru3);
string kullanıcıCevabı3 = Console.ReadLine();

if (kullanıcıCevabı3.Trim().ToLower() == cevap3.ToLower())
{
    Console.WriteLine("Tebrikler");
    score++;

}
else
{
    Console.WriteLine("Yanlış cevap!");
}

if (score == 3)
{
    Console.WriteLine("tebrikler hepsi doğru  skorunuz = " + score);
}
else if (score == 2)
{
    Console.WriteLine("bir yanlışınız var  skorunuz = " + score);
}
else if(score == 1)
{
    Console.WriteLine("iki yanlışınız var skorunuz = " + score);
}
else
{
    Console.WriteLine("Hepsi yanlış");
}
    Console.ReadLine(); 