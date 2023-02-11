try
{
Console.WriteLine("Enter string:");
string str = Console.ReadLine();
int point_one=str.IndexOf(".");
    Console.WriteLine("1)"+point_one);
int point_two=(str.IndexOf(".",point_one))+point_one;
    Console.WriteLine("2)"+point_two);
    Console.WriteLine("3)"+str.Remove(point_one, point_two));
string strRemove =str.Remove(point_one,point_two);
    Console.WriteLine("4)"+strRemove);
    str.Replace(strRemove, " ");
    Console.WriteLine("5)"+str);
    strRemove.Replace(" ", "");
    Console.WriteLine("6)"+str);
    str.Insert(point_one,strRemove);
    Console.WriteLine("7)"+str);
}
catch (Exception ex)
{
    Console.WriteLine($"Error : {ex.Message}");
    return;
}

