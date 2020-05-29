using System;
using System.Collections.Generic;

namespace zadanie6
{
    class Program
    {
        public class Student
        {
            public string id;
            public string fio;
            public string group;
            public string birthDate;
        }

        static List<Student> studentList = new List<Student>();

        static void AddStudent(string id, string fio, string birthDate, string group)
        {
            studentList.Add(new Student() { id = id, fio = fio, birthDate = birthDate, group = group });
        }


        static void DelStudent(string id)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id) studentList.RemoveAt(i);
            }
        }

        static void ChangeStudent(string id, string fio, string birthDate, string group)
        {

            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id)
                {
                    studentList[i].fio = fio;
                    studentList[i].birthDate = birthDate;
                    studentList[i].group = group;
                }
            }

        }

        static void ShowStudentFio()
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                Console.WriteLine((i + 1) + ") " + studentList[i].fio);
            }
            Console.WriteLine();
        }

        static void ShowStudentById(string id)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id)
                    Console.WriteLine(
                        studentList[i].id + " - "
                        + studentList[i].fio + " - "
                        + studentList[i].birthDate + " - "
                        + studentList[i].group
                    );
            }
            Console.WriteLine();
        }

        static void ShowStudentAge(string id)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].id == id)
                {
                    string[] studentListSplit = studentList[i].birthDate.Split(".");
                    int ourYear = 2020;

                    if (int.TryParse(studentListSplit[2], out int res)) Console.Write("Возраст студента с id " + id + ": " + (ourYear - res) + " лет");
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Student first = new Student();

            AddStudent("1000", "Владимиров Владимир Владимирович", "11.12.2002", "ASAP");
            AddStudent("1001", "Дмитриев Дмитрий Дмитриевич", "11.09.1991", "ISIP");
            AddStudent("1002", "Александров Александр Александрович", "09.10.1941", "ACAB");
            ShowStudentFio();
            ShowStudentById("1002");
            ShowStudentAge("1000");
        }
    }
}