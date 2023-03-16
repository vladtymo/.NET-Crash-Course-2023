using System;

namespace Abbrevation{
   class Program{
      static void Main(string[]args){
         Console.WriteLine(GenerationAbbr("cascading style sheets"));
      }
      static string GenerationAbbr(string str){
         string[] words = str.Split(' ');
         string abbreviation = "";
         foreach (string word in words){
                abbreviation += word[0];
         }
         return abbreviation.ToUpper();
      }
   }
}
