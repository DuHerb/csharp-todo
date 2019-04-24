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
      string userChoice = newProgram.GetUserChoice();

      if (userChoice == "1")
      {
        List<Item> todoList =  Item.GetAll();
        foreach(Item todo in todoList)
        {
          Console.WriteLine(todo.GetDescription());
        }
      }
      else if(userChoice == "2")
      {
        Console.WriteLine("Type in your Todo item: ");
        string newDescription = Console.ReadLine();
        Item newItem = new Item(newDescription);
      }

      Console.WriteLine("Would you like to Exit: Press Y");
      if(Console.ReadLine() == "y" || Console.ReadLine() == "Y")
      {
        Environment.Exit(0);
      }
      else
      {
        Program.Main();
      }
    }

    public string GetUserChoice()
    {
      Console.WriteLine("Welcome To Your ToDo List");
      Console.WriteLine("To view your ToDo List, press 1");
      Console.WriteLine("To add an item to your list, press 2");
      string choice = Console.ReadLine();

      return choice;
    }
  }
}
