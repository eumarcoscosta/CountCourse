using System;
using countCourse.Entities;
using System.Collections.Generic;

namespace countCourse
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<Teacher> quant = new HashSet<Teacher>();

            Console.Write("How many students for course A? ");
            int nA = int.Parse(Console.ReadLine());

            for (int i=0; i<nA; i++)
            {
                int idCourse = int.Parse(Console.ReadLine());
                quant.Add(new Teacher(idCourse));
            }

            Console.Write("How many students for course B? ");
            int nB = int.Parse(Console.ReadLine());

            for (int i = 0; i < nB; i++)
            {
                int idCourse = int.Parse(Console.ReadLine());
                quant.Add(new Teacher(idCourse));
            }

            Console.Write("How many students for course C? ");
            int nC = int.Parse(Console.ReadLine());

            for (int i = 0; i < nC; i++)
            {
                int idCourse = int.Parse(Console.ReadLine());
                quant.Add(new Teacher(idCourse));
            }

            Console.WriteLine("Total students: " + quant.Count);
        }
    }
}