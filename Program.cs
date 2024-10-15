using System.Collections;

namespace A_Todo_List_App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Welcome & Intro
            Console.WriteLine("Welcome to Todo List App.");
            Console.WriteLine("What would you like to do ?");

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("Enter a to add a task.");
            Console.WriteLine("Enter r to remove a task.");
            Console.WriteLine("Enter v to view a task.");
            Console.WriteLine("Enter e to exit the Program."); 
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
            #endregion


            char action;
            bool flag, condition = true;
            int numOfTask;
            string task;
            List<string> todoList = new();


        while (condition)
        {

             Console.WriteLine("");
             Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");

            do
            {
                Console.WriteLine("Enter only (a, r, v, e):");
                flag = char.TryParse(Console.ReadLine(), out action);
            } while (!flag || !(action == 'a' || action == 'r' || action == 'v' || action == 'e'));



                #region Add Task
                if (action == 'a')
                {
                    Console.WriteLine("Enter your task:");
                    task = Console.ReadLine();
                    todoList.Add(task);
                    Console.WriteLine("The task is added.");
                } 
                #endregion



                #region Remove Task
                else if (action == 'r')
                {

                    Console.WriteLine("Current List:");
                    for (int i = 0; i < todoList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} : {todoList[i]}");
                    }

                    do
                    {
                        Console.WriteLine("Enter the number of the task:");
                        flag = int.TryParse(Console.ReadLine(), out numOfTask);
                    } while (!flag || numOfTask > todoList.Count || numOfTask < 0);

                    todoList.RemoveAt(numOfTask - 1);
                    Console.WriteLine("The task is removed.");
                }
                #endregion



                #region View List
                else if (action == 'v')
                {

                    Console.WriteLine("Current List:");
                    for (int i = 0; i < todoList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} : {todoList[i]}");
                    }
                } 
                #endregion



                #region Exit Program
                else
                {
                    condition = false;
                } 
                #endregion
            }        

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("*************************************");
            Console.WriteLine("Your Todo List:");
            for (int i = 0; i < todoList.Count; i++)
            {
                Console.WriteLine($"{i + 1} : {todoList[i]}");
            }
            Console.WriteLine("*************************************");
        }
    }
}
