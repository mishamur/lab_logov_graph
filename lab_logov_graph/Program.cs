using System;

namespace lab_logov_graph
{
    class Program
    {
       

       


        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество населённых пунктов: ");
            int quantity = int.Parse(Console.ReadLine());
            Graph graph = new Graph(quantity);

            graph.PrintMatrix();
            Console.WriteLine("Самый длинный простой путь " + graph.FindLength(0, 1)); //1->3 
            
        }
    }
}
