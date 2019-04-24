using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public static voide Main()
    {
      Console.WriteLine("1st thing to do: ");
      string stringToDo1 = Console.ReadLine();

      Item newItem1 = new Item(stringToDo1);
      List<Item> newList = new List<Item> {stringToDo1};
    }



    Item newItem1 = new Item(description01);
    Item newItem2 = new Item(description02);
    List<Item> newList = new List<Item> { newItem1, newItem2 };

    //Act
    List<Item> result = Item.GetAll();


    //Assert
    CollectionAssert.AreEqual(newList, result);
  }


    Console.WriteLine();
    private string _description;
    private static List<Item> _instances = new List<Item> {};


    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public Item (string description)
    {
      _description = description;
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
