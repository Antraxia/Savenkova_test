char[] delimiterChars = { '"', ',' };
string s=Console.ReadLine();
string[] array=s.Split(delimiterChars,StringSplitOptions.RemoveEmptyEntries);
string[] newArray=new string[array.Length];
correctLength(array);
Print(newArray);


void correctLength(string[] array)
{
    int count =0;
    for (int i=0;i<array.Length;i++)
    {
        if(array[i].Length<=3)
        {
            newArray[count]=array[i];
            count++;
        }
    }
 }

 void Print(string[] array)
 {
    array=array.Where(x=>x!=null).ToArray();
    for (int i=0;i<array.Length;i++)
     {
        System.Console.Write($"{array[i]} ");
     }
 }
