List <int> sA = new List<int> { 1, 2, 3, 4, 5 };
int i= 0; for (int j = 0; j < sA.Count; j++)
{
    Console.Write($"{ sA[j]}");
}
Console.WriteLine(" ");    
int index1 = 0;
int index2 = 0;
int found = 0;
Console.WriteLine("please enter value 1");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("please enter value 2");  
int value2 = Convert.ToInt32(Console.ReadLine());   

while (true)
{
    if (sA[i]==value1)
    {
        index1=i;
        found++;
    }
    else if (sA[i]==value2)
    {
        index2=i;
        found++;
    }
    if (found==2  )
        {
        (sA[index1], sA[index2]) = swapping(sA[index1], sA[index2]);
        break;
    }
    i++;
    if (i==sA.Count)
    {
        Console.WriteLine("not found");
        break;
    }
  
}
for (int j = 0; j < sA.Count; j++)
{
    Console.Write($"{sA[j]}");
}


static (int, int ) swapping (int x , int y)
{ 
int temp = x;
x = y;
y = temp;
    return (x,y);
}