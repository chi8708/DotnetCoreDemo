using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;//导入静态类

namespace BasicConsole
{
    //vs2015 支持
    public class _6
    {
        public static void Run()
        {
            AutoPro();
            ImportStaticClass();
            NullCheck();
            DicInit();
           // ExceptionWhen();
            Print();
            Console.Read();
        }

        /// <summary>
        /// 自动属性
        /// </summary>
        public static void AutoPro()
        {
            Peole p = new Peole();
            p.Name = "rose";
            Console.WriteLine($"Name:{p.Name},Age:{p.Age}");

        }

        /// <summary>
        /// 导入静态变量
        /// </summary>
        public static void ImportStaticClass()
        {
            // Console.WriteLine($"之前的使用方式: {Math.Pow(4, 2)}");
            Console.WriteLine($"导入静态Math使用方式: {Pow(4, 2)}");
        }

        /// <summary>
        /// null值判断
        /// </summary>
        public static void NullCheck()
        {
            int? iValue = 10;
            Console.WriteLine(iValue?.ToString());//不需要判断是否为空
            string name = null;
            Console.WriteLine(name?.ToString()); // 程序不会报错，也不会输出任何值
            Console.WriteLine("空值运算符");

             List<string> list= null;
             Console.WriteLine($"空值运算符list:{(list?.Count())??0}");
        }

        /// <summary>
        /// 字典初始化
        /// </summary>
        public static void DicInit()
        {
            //o
            Dictionary<int, string> dic1 = new Dictionary<int, string> { { 1, "jack" }, { 2, "rose" } };
            foreach (var item in dic1)
            {
                Console.WriteLine($"key:{item.Key}value:{item.Value}");
            }

            //n
            Dictionary<int, string> dic2 = new Dictionary<int, string> { [3] = "jack", [4] = "rose" };
            foreach (var item in dic2)
            {
                Console.WriteLine($"key:{item.Key}value:{item.Value}");
            }
        }

        //异常处理when
        public static void ExceptionWhen()
        {

            try
            {
                Int32.Parse("we");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            int exceptionValue = 10;
            try
            {
                Int32.Parse("we");
            }
            catch (Exception e) when (exceptionValue > 10)//满足条件才进入catch
            {
                Console.WriteLine("catch");
            }

        }

        //lambda函数体，无返回值
        public static void  Print() => Console.WriteLine("lambda函数体，无返回值");


        //lambda函数体，返回对象
        public static Peole GetP() => new Peole(); 
   
    }

    public class Peole
    {
        public Peole() { }
        // 7.0Expression-bodied constructor
        public Peole(string name) => this.Name = name;

        private string _email;
        public string Name { get; set; } = "Jack";//属性初始化赋值

        public int Age { get; set; } = 12;

        public string Email { get => _email; set => _email = value ?? "99@qq.com"; }

        //7.0解析函数
        public void Deconstruct(out string name, out int age)
        {
            name = Name;
            age = Age;
        }
    }

}
