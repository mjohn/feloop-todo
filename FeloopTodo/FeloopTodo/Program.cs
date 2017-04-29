using System;
using System.Collections.Generic;

namespace FeloopTodo
{
    class Program
    {
        public static List<Task> TaskList { get; set; }
        static void Main(string[] args)
        {


            // Konsolda unicode karakterlerin gözükmesi için gerekli, yoksa Türkçe karakterler gözükmeyecek.
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("###########################################");
            Console.WriteLine("# 1- Yeni bir görev tanımla.              #");
            Console.WriteLine("# 2- Görevi tamamlanmış olarak işaretle.  #");
            Console.WriteLine("# 3- Görevleri listele.                   #");
            Console.WriteLine("# 9- Görev sil.                           #");
            Console.WriteLine("###########################################");
            while (true)
            {

                var key = Console.ReadKey();
                Console.Write(Environment.NewLine);
                Console.WriteLine("Lütfen seçim yapınız: ");

                if (key.Key == ConsoleKey.D1)
                {
                    Console.WriteLine("1 tuşuna basıldı.");
                }
                else if (key.Key == ConsoleKey.D2)
                {
                    Console.WriteLine("2 tuşuna basıldı.");
                }
                else if (key.Key == ConsoleKey.D3)
                {
                    Console.WriteLine("3 tuşuna basıldı.");
                }
                else if (key.Key == ConsoleKey.D9)
                {
                    Console.WriteLine("9 tuşuna basıldı.");
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