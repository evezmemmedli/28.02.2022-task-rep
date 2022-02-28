using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._02._2022_task_rep
{
    internal class Student
    {
        public string FullName;
        public string GroupNo;
        public int Age;
        private static bool hasDigit = true;
        private static bool capitalLetter = false;
        private static string[] nameAndSurname = new string[2];

        public Student(string _fullName, string _groupNo, int _age)
        {
            fullName = _fullName;
            groupNo = _groupNo;
            age = _age;

        }
        private string fullName
        {
            get
            {
                return FullName;
            }
            set
            {
                if (CheckFullName(value))
                {
                    FullName = value;
                }
            }
        }
        private string groupNo
        {
            get
            {
                return GroupNo;
            }
            set
            {
                if (CheckGroupNo(value))
                {
                    GroupNo = value;
                }
            }
        }
        private int age { get; set; }
        public static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length == 4 && char.IsUpper(groupNo[0]))
            {
                capitalLetter = true;

            }
            else
            {
                Console.WriteLine("Deyerlere uygun qrup qeyd edin! , Birinci herf boyuk sonra ise 3 reqem !");

            }
            for (int i = 1; i < groupNo.Length; i++)
            {
                if (!char.IsDigit(groupNo[i]))
                {
                    hasDigit = false;
                }
            }
            if (hasDigit && capitalLetter)
            {
                return true;
            }
            return false;
        }
        public static bool CheckFullName(string fullname)
        {
            try
            {
                nameAndSurname = fullname.Split(' ');
                if (nameAndSurname.Count() == 2)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (char.IsUpper(nameAndSurname[i][0]))
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

            }
            return false;
        }
    }
}
