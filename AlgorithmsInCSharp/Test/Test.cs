using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

    public class Test
    {
        static void Main(string[] args)
        {
            Node node = new Node();
            Node nodeNext = new Node();
            node.Next = nodeNext;
            node.Data = "data";

            long size = Utils.ObjectUtils.GetObjectSize(node);
            Console.WriteLine(size);
        }
    }
    
    [Serializable]
    class Node
    {
        public Node Next { get; set; }
        public Object Data { get; set; }
    }
}
