using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw_2
{
    class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string FN { get; set; }
        public string LN { get; set; }
        public static string Group { get; set; }
        int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 18 && value < 60)
                    age = value;
                else
                    WriteLine("К сожалению, Вы не можете быть зачислены в данную группу");
            }
        }

        public override string ToString()
        {
            return $"{Group} {Id}  {FN}  {LN}  {Age}";
        }

        public int CompareTo(Student item)
        {
            return this.age.CompareTo(item.age);
        }
    }
    class Compare_FN : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
                return string.Compare((x as Student).FN, (y as Student).FN);
            }
            throw new NotImplementedException();
        }
    }
    class Compare_LN : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
                return string.Compare((y as Student).LN, (x as Student).LN);
            }
            throw new NotImplementedException();
        }
    }

    class Group_st : IEnumerable
    {
        Student[] group_st =
        {
            new Student
            {
                Id = 125,
                FN = "Белов",
                LN = "Семен",
                Age = 25
            },
            new Student
            {
                Id = 136,
                FN = "Иванова",
                LN = "Ирина",
                Age = 23
            },
            new Student
            {
                Id = 96,
                FN = "Петров",
                LN = "Иван",
                Age = 36
            },
            new Student
            {
                Id = 13,
                FN = "Смирнова",
                LN = "Екатерина",
                Age = 56
            },
            new Student
            {
                Id = 26,
                FN = "Дмитриева",
                LN = "Светлана",
                Age = 18
            },
            new Student
            {
                Id = 143,
                FN = "Метелкин",
                LN = "Владимир",
                Age = 21
            },
            new Student
            {
                Id = 15,
                FN = "Ивина",
                LN = "Ирина",
                Age = 23
            },
            new Student
            {
                Id = 203,
                FN = "Павлов",
                LN = "Сергей",
                Age = 29
            },
            new Student
            {
                Id = 199,
                FN = "Снежков",
                LN = "Дмитрий",
                Age = 41
            },
            new Student
            {
                Id = 82,
                FN = "Кулемина",
                LN = "Алевтина",
                Age = 33
            }
        };
        public IEnumerator GetEnumerator()
        {
            return group_st.GetEnumerator();
        }

        public void Sort()
        {
            Array.Sort(group_st);
        }

        public void Sort(IComparer comp)
        {
            Array.Sort(group_st, comp);
        }
    }
}
