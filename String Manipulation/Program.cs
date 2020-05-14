using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string name = Console.ReadLine();

            string underscores = name.Replace(" ", "_");
            string leadingSpace = name.TrimStart();
            string trailingSpace = name.TrimEnd();
            string upperCase = name.Replace("a", "A");

            Console.WriteLine("The space into _:" +underscores);
            Console.WriteLine("The a into A:" +upperCase);
            Console.WriteLine("Remove Leading spaces:" + leadingSpace);
            Console.WriteLine("Remove Trailing spaces:" + trailingSpace);
            Console.ReadLine();

            //Replaces all lowercase  by uppercase
            //string upperCase = string.Empty;
            //for(int i=0;i<name.Length;i++)
            //{
            //   if(name[i]>='a' && name[i]<='z')
            //    {
            //        upperCase += (char)(name[i] - 'a' + 'A');
            //    }
            //    else
            //    {
            //        upperCase += name[i];
            //    }
            //}
            //Console.WriteLine(upperCase);

        }

    }
    }
