using CSharpProject.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //ユーザー定義の例外処理
                throw new CustomException("ユーザー定義の例外");
            }
            catch (CustomException customEx)
            {
                Console.WriteLine("CustomException: " + customEx.Message);
                try
                {
                    throw new Exception("Exception Throw");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
