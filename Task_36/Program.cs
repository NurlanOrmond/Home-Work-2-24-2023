/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int [] MyArray () {
    Random rnd = new Random();
    
    int [] arr = new int [4];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-100,101);
    }
    return arr;
}

 int SumOddPositions (int [] mssv) 
 {
    int i = 1;
    int sum=0;
    while (i< mssv.Length)
    {
        sum=sum+mssv[i];
        i=i+2;

    }
    return sum;
    
    
 }

 void ShowProduct (int[] mssv, int num)
 
 {
    System.Console.Write("\nArray elements: [");
    for (int i = 0; i < mssv.Length-1; i++)
    {
        System.Console.Write(mssv[i]+", ");
    }
    System.Console.Write(mssv[mssv.Length-1]);
    System.Console.WriteLine("]");

    System.Console.Write("Elements in Odd position int the Array: [" );
    for (int i = 1; i < mssv.Length-1; i=i+2)
    {
        System.Console.Write(mssv[i]);
        System.Console.Write(", ");
    }
    System.Console.Write (mssv[mssv.Length-1]);
    System.Console.Write("]");


        System.Console.WriteLine("\nSum of all odd elements in the Array is: "+ num+"\n");

 }


int [] a = MyArray();
int b = SumOddPositions(a);

ShowProduct (a, b);

