using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{

  public class Program
  {
    public static void Main()
    {

      Program newProgram = new Program();
      Console.WriteLine("Welcome To Your ToDo List");
      bool isUsing = true;
      while (isUsing)
      {
        string userChoice = newProgram.GetUserChoice();

        if (userChoice == "1")
        {
          Console.WriteLine("-------");
          List<Item> todoList =  Item.GetAll();
          foreach(Item todo in todoList)
          {
            Console.WriteLine(todo.GetDescription());
          }
          Console.WriteLine("-------");
          Console.WriteLine("Would you like to Exit: Press Y");
          if(Console.ReadLine() == "y" || Console.ReadLine() == "Y")
          {
            isUsing = false;
          }
        }
        else if(userChoice == "2")
        {
          Console.WriteLine("Type in your Todo item: ");
          string newDescription = Console.ReadLine();
          Item newItem = new Item(newDescription);
        }

      }
    }

    public string GetUserChoice()
    {
      Console.WriteLine("To view your ToDo List, press 1");
      Console.WriteLine("To add an item to your list, press 2");
      string choice = Console.ReadLine();

      return choice;
    }
  }
}
