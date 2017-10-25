using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace stack_calc
{
    class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader("..\\..\\input.txt");

            var size = Int64.Parse(sr.ReadLine());

            string[] str = new string[2];
            
            Stack<Int64> st = new Stack<Int64>();
            Int64 v1 = 0, v2 = 0;

            for (Int64 i = 0; i < size; ++i)
            {
                str = sr.ReadLine().Split(' ');

                switch (str[0])
                {
                    case "push":
                        st.Push(Int64.Parse(str[1]));
                        break;
                    case "add":
                        v1 = st.Pop();
                        v2 = st.Pop();
                        st.Push(v1 + v2);
                        break;
                    case "sub":
                        v1 = st.Pop();
                        v2 = st.Pop();
                        st.Push(v1 - v2);
                        break;
                    case "mul":
                        v1 = st.Pop();
                        v2 = st.Pop();
                        st.Push(v1 * v2);
                        break;
                    case "top":
                        Console.WriteLine(st.First());
                        break;
                }
            }

            sr.Close();
        }
    }
}
