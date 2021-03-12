using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = paramDemo(1, 2, 3, 4);
            //Console.WriteLine(a.Length);
            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //int[] b = paramDemo(arr);
            //Console.WriteLine(b.Length);

            ShowTest();
            ShowTest(new Test() { Name="一月",Id=1});
            ShowTest(new Test() { Name="一月",Id=1},new Test() { Name = "二月", Id = 2 },new Test() { Name = "三月", Id = 3 });

            Console.ReadLine();
        }

        /// <summary>
        /// 可变参数，在参数前面添加params关键字，比如
        /// 下面方法是要传入一个int数组类型。那么，加入params后
        /// 调用的时候直接传入一个 例如pparamDemo(1,2,3)这样一个 数组也是不会报错的
        /// 但是注意参数列表必须是参数的最后一个参数才可以
        /// </summary>
        /// <param name="arr"></param>
        public static int[] paramDemo(params int[] arr)
        {
            return arr;
        }

        public static void ShowTest(params Test[] tests)
        {
            foreach (Test item in tests)
            {
                Console.WriteLine($"{item.Name} {item.Id}");
            }
        }

        /// <summary>
        /// 测试用 无意义
        /// </summary>
        public class Test
        {
            public string Name { get; set; }
            public int Id { get; set; }
        }
    }
}
