// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int [] MyArr () 
{
Random rnd = new Random ();
int [] array = new int [6];

for (int i = 0; i < array.Length; i++)
{
   
    array[i] = rnd.Next(100,1000);
   
}
return array;
}

int Even (int [] a) 
{   int cnt = 0;
    foreach (int elem in a)
    {
        if (elem%2==0)
        {
            cnt+=1;
        }
    }
    
    return cnt;  
}

void Show (int [] a , int b)
{   System.Console.Write("\nRandom Array [");
    for (int i = 0; i < a.Length-1; i++)
    {
        System.Console.Write(a[i]+", ");
    }
    System.Console.Write(a[a.Length-1]);
    System.Console.WriteLine("]");

    System.Console.Write("Even elements in the Array are: [");
    for (int i = 0; i < a.Length; i++)

{
    if (a[i]%2==0)
    {
        System.Console.Write(a[i]+" ");
    }
    
}

System.Console.WriteLine("]");

    System.Console.WriteLine("Even elements quantity in array is: [" + b+"]\n");
}

int [] a = MyArr();
int b = Even(a);
Show (a,b);