using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public class StackNode
    {
        public int Data { get; set; }
        public StackNode Next { get; set; }
        public StackNode(int x)
        {
            Data = x;
            Next = null;
        }
    }
}
