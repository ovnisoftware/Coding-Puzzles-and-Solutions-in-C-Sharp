namespace CodingPuzzles
{
    public class NodeBT
    {
        public int Data { get; set; }
        public NodeBT Left { get; set; }
        public NodeBT Right { get; set; }

        public NodeBT(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
