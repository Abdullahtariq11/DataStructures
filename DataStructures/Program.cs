// See https://aka.ms/new-console-template for more information
using DataStructures.LinkedList;

Console.WriteLine("Data Structures");

/*

Console.WriteLine("SinglyList");

SinglyList singlyList= new SinglyList();
singlyList.InsertFirst(4);
singlyList.InsertFirst(5);
singlyList.InsertFirst(6);
singlyList.InsertLast(11);
singlyList.PrintList();
Console.WriteLine("");
singlyList.InsertAtIndex(2,11);
singlyList.PrintList();
Console.WriteLine("");
singlyList.RemoveAt(1);
singlyList.PrintList();
Console.WriteLine("");
*/

 int FindFactorialRecursive(int num)
{
    
    if (num == 1)
    {
        return num;
    } 
    return num * FindFactorialRecursive(num-1);
}

 int FindFactorialIterative(int num)
{
    int factorial = 1;
    for (int i = num;i>=1;i--)
    {
        factorial=factorial * i;
    }
    return factorial;
}

int FibonacciIterative(int num)
{
    
    int prev=0;
    int value = 1;
    int sum=0;
    for (int i = 1;i<num;i++)
    {
        sum=value+prev;
        prev=value;
        value=sum;
    }
    return sum;
}


int FibinnaciRecursive(int num)
{
    
    if(num<2)
    {
        return num;
    }

    return FibinnaciRecursive(num-1)+FibinnaciRecursive(num-2);
}

//Console.WriteLine(FindFactorialIterative(5));
//Console.WriteLine(FindFactorialRecursive(5));

Console.WriteLine(FibonacciIterative(5));
int [] arr= new []{12,3,4,1,5,6};
void bubbleSort(int [] arr)
{
    int temp=0;
    for (int i=0;i<arr.Length;i++)
    {
        for(int j=0;j<arr.Length-1;j++)
        {
            if(arr[j]>arr[j+1])
            {
                temp=arr[j];
                arr[j]=arr[j+1];
                arr[j+1]=temp;
            }
        }
    }
}
//bubbleSort(arr);

void SelectionSort(int [] arr)
{
    int temp;
    for (int i=0;i<arr.Length;i++)
    {
        int min=arr[i];
        for (int j=i;j<arr.Length;j++)
        {
        
            if(min>arr[j])
            {
                temp=min;
                min=arr[j];
                arr[j]=temp;
            }
            
        }
        arr[i]=min;
    }
}
//SelectionSort(arr);

void InsertionSort(int [] arr)
{
    for( int i=0;i<arr.Length;i++)
    {
        if (arr[i]<arr[0])
        {

        }
        

    }
}
InsertionSort(arr);

