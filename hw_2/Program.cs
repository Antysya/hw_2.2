using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group_st group_st = new Group_st();
            Student.Group = "ПВ111";

            WriteLine("***Группа до сортировки***");
            foreach (Student st in group_st)
            {
                WriteLine(st);
            }
            WriteLine();

            WriteLine("***Группа отсортирована по возрасту***");
            group_st.Sort();
            foreach (Student st in group_st)
            {
                WriteLine(st);
            }
            WriteLine();

            WriteLine("***Группа отсортирована по фамилии***");
            group_st.Sort(new Compare_FN());
            foreach (Student st in group_st)
            {
                WriteLine(st);
            }
            WriteLine();
            WriteLine("***Группа отсортирована по имени в обратном порядке***");
            group_st.Sort(new Compare_LN());
            foreach (Student st in group_st)
            {
                WriteLine(st);
            }

        }
    }
}
