using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadedWPF
{
    public class Action
    {
        List<int> indices;


        public Action()
        {
            indices = new List<int>();
        }


        public void Add()
        {
            int ret = 0;
            foreach (var item in indices)
            {
                ret += item;
            }
            System.Threading.Thread.Sleep(30000);
        }

        public void Add(int input)
        {
            indices.Add(input);
            System.Threading.Thread.Sleep(30000);
        }



    }
}
