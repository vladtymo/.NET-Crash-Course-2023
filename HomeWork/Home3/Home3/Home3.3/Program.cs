//3. Дано текст.
//Визначте відсоткове відношення малих і великих літер
//до загальної кількості символів в ньому.
using DryIoc.ImTools;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Versioning;

string text = "Alfa romeo is cool car";
int verh = 0;
int niz = 0;



for(int i=0; i < text.Length; ++i)
    {
    if (char.IsUpper(text[i]) & char.IsLetter(text[i]))
    {
        ++verh;
    }
    else if (char.IsLower(text[i]) & char.IsLetter(text[i]))
    {
        ++niz;
    }
}

niz = (niz * 100) / text.Length;
verh = (verh * 100) / text.Length;
Console.WriteLine($"нижній регістр {niz}%");
Console.WriteLine($"верхній регістр {verh}%");


