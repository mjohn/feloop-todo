using System;

namespace FeloopTodo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Konsolda unicode karakterlerin gözükmesi için gerekli, yoksa Türkçe karakterler gözükmeyecek.
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("###########################################");
            Console.WriteLine("# 1- Yeni bir görev tanımla.              #");
            Console.WriteLine("# 2- Görevi tamamlanmış olarak işaretle.  #");
            Console.WriteLine("# 3- Görev sil.                           #");
            Console.WriteLine("###########################################");
            Console.ReadKey();
        }
    }
}