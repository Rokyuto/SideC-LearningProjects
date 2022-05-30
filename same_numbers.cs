using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class same_numbers
{
    static void Main(string[] args)
    {
        Dictionary<char,int>count=new Dictionary<char,int>();
        double[]n=Console.ReadLine().Split().Select(double.Parse).ToArray();
        double[]m=Console.ReadLine().Split().Select(double.Parse).ToArray();
        for(inti=0;i<n.Length;i++)
        {
            foreach(var item in count)
            {
                Console.WriteLine($"{item.Value}");
            }
        }
        for(inti=0;i<m.Length;i++)
        {
            foreach(var item in count)
            {
                Console.WriteLine($"{item.Value}");
            }
            Console.WriteLine(item{i});
        }
    }
}
