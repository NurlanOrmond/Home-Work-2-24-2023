 //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double [] MyArray () 
{
double [] arr = new double [5];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.NextDouble()*((9.99 - 0.01)+0.01);
    
}
return arr;
}

double MaxValueOfArray (double [] mssv)

{
    double maxValue = mssv[0];
    for (int i = 0; i < mssv.Length; i++)
    {
        if (mssv[i]>maxValue)
        {
            maxValue = mssv[i];
        }
    }
    return maxValue;
}

double MinValueOfArray (double [] mssv)

{
    double minValue = mssv[0];
    for (int i = 0; i < mssv.Length; i++)
    {
        if (mssv[i]<minValue)
        {
            minValue = mssv[i];
        }
    }
    return minValue;
}

void ViewProduct (double [] mssv , double num1, double num2)
{   System.Console.Write("\nRandom Array [");
    for (int i = 0; i < mssv.Length-1; i++)
    {
        System.Console.Write(mssv[i]+", ");
    }
    System.Console.Write(mssv[mssv.Length-1]);
    System.Console.WriteLine("]");
    System.Console.WriteLine("Greatest element in the Array is: [" + num1+"]");
    System.Console.WriteLine("Smallest element in the Array is: [" + num2+"]\n");
}

double [] a = MyArray();
double min = MinValueOfArray (a);
double max = MaxValueOfArray (a);

MyArray();
MaxValueOfArray(a);
MinValueOfArray (a);
ViewProduct (a, max, min);



    

