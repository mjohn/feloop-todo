using System;
using System.Collections.Generic;

namespace FeloopTodo
{
    class Program
    {
        public static List<Task> TaskList { get; set; }
        static void Main(string[] args)
        {
            TaskList = new List<Task>();

            // Konsolda unicode karakterlerin gözükmesi için gerekli, yoksa Türkçe karakterler gözükmeyecek.
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            while (true)
            {
                Console.WriteLine("###########################################");
                Console.WriteLine("# 1- Yeni bir görev tanımla.              #");
                Console.WriteLine("# 2- Görevi tamamlanmış olarak işaretle.  #");
                Console.WriteLine("# 3- Görevleri listele.                   #");
                Console.WriteLine("# 9- Görev sil.                           #");
                Console.WriteLine("###########################################");

                Console.WriteLine("Lütfen seçim yapınız: ");
                var key = Console.ReadKey();
                Console.Write(Environment.NewLine);
                

                if (key.Key == ConsoleKey.D1)
                {
                    Task task = new Task();
                    task.CreatedAt = DateTime.Now;
                    task.IsCompleted = false;
                    Console.WriteLine("Görev açklaması giriniz: ");
                    task.Description = Console.ReadLine();
                    AddTask(task);
                }
                else if (key.Key == ConsoleKey.D2)
                {
                    ListTasks();
                    Console.WriteLine("Tamamlandı olarak işaretlenecek görevin id'sini yazınız: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    CompleteTask(index);
                }
                else if (key.Key == ConsoleKey.D3)
                {
                    ListTasks();
                }
                else if (key.Key == ConsoleKey.D9)
                {
                    ListTasks();
                    Console.WriteLine("Silinecek görevin id'sini yazınız: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    DeleteTask(index);
                }
            }
        }

        static void AddTask(Task task)
        {
            TaskList.Add(task);
        }
        static void CompleteTask(int i)
        {
            TaskList[i].IsCompleted = true;
        }
        static void DeleteTask(int i)
        {
            TaskList.RemoveAt(i);
        }
        static void ListTasks()
        {
            foreach (var task in TaskList)
            {
                int index = TaskList.IndexOf(task);
                Console.WriteLine($"{index} - {task.Description} - {task.IsCompleted}");
            }
        }
    }
}