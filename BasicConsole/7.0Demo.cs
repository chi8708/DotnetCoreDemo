using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsole
{
    public class _7
    {
        public static void Run()
        {
            OutVar();
            Tuple();
            var list= GetCharList("hello");
            PrintStars(11);
            Console.Read();
        }

        //out变量 out var result
        public static void OutVar()
        {
            var input = "1";
            if (int.TryParse(input, out var result))
            {
                Console.WriteLine("您输入的数字是：{0}", result);
            }

            int num;
            string s ="2";
            if (int.TryParse(s, out num))
            {
                Console.WriteLine("您输入的数字是：{0}", num);
            }

        }

       // Install-Package System.ValueTuple
        //tuple 元组
        public static void Tuple()
        {
            var tuple1 = (1, 2);           // 使用语法糖创建元组
            var tuple2 = ValueTuple.Create(1, 2); // 使用静态方法【Create】创建元组
            var tuple3 = new ValueTuple<int, int>(1, 2);// 使用 new 运算符创建元组
            Console.WriteLine($"first：{tuple1.Item1}, second：{tuple2.Item2}, 上面三种方式都是等价的。");


            // 左边指定字段名称
            (int one, int two) tuple4 = (1, 2);
            Console.WriteLine($"first：{tuple4.one}, second：{tuple4.two}");

            // 右边指定字段名称
            var tuple5 = (one: 1, two: 2);
            Console.WriteLine($"first：{tuple5.one}, second：{tuple5.two}");

            // 左右两边同时指定字段名称
            (int one, int two) tuple6 = (first: 1, second: 2);   
            /* 此处会有警告：由于目标类型（xx）已指定了其它名称，因为忽略元组名称xxx */
            Console.WriteLine($"first：{tuple6.one}, second：{tuple6.two}");

            //解构元组
            var (Name, Age) = new Peole();
            Console.WriteLine($"Name:{Name},Age:{Age}");


        }

        //局部函数
       public static IEnumerable<char> GetCharList(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                throw new ArgumentNullException(nameof(str));

            return GetList();

            IEnumerable<char> GetList()
            {
                for (int i = 0; i < str.Length; i++)
                {
                    yield return str[i];
                }
            }
            //            使用方法：

            //[数据类型, void] 方法名（[参数]）
            //  {
            //     // Method body；[] 里面都是可选项
            //  }
        }

        /// <summary>
        /// 具有模式的 IS 表达式
        /// </summary>
        /// <param name="o"></param>
        public static void PrintStars(object o)
        {
            if (o is null) return;     // 常量模式 "null"
            if (!(o is int i)) return; // 类型模式 定义了一个变量 "int i" i的值就是o的值 相当于is类型判断
            Console.WriteLine($"i={i}");

            //如果数字太长，可以按照一定的位数用“_”进行分割
            long big = 100_000_000;
             Console.WriteLine($"big={big}");
        }
    }
}
