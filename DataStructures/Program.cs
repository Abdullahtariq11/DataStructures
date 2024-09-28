// See https://aka.ms/new-console-template for more information
using DataStructures.LinkedList;

Console.WriteLine("Data Structures");


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
