Console.WriteLine('Введіть строку для відображення абривіатури');
string InputText=Console.ReadLine();
string[] words = InputText.Split(new[] { ' ', '.', '?', ',' }, StringSplitOptions.RemoveEmptyEntries);
foreach (string word in words) 
{
    Console.Write(word.ToUpper()[0]);
}
