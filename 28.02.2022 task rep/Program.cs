using System;

namespace _28._02._2022_task_rep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ad ve soyad daxil edin");
            string FullName = Console.ReadLine();
            Console.WriteLine("Qrup daxil edin");
            string GroupNo = Console.ReadLine();    
            Console.WriteLine("Yas daxil edin");
            int num = Convert.ToInt32(Console.ReadLine());
            Student student = new Student(FullName, GroupNo,num);
        }
    }
}
