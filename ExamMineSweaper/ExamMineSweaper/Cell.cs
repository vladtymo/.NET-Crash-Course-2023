

namespace ExamMineSweaper
{
    class Cell
    {
        public bool IsMine { get; set; }
        public bool IsRevealed { get; set; }
        public int Neighbors { get; set; }

        public char DisplayCharacter
        {
            get
            {
                if (!IsRevealed)
                {
                    return '-';
                }
                if (IsMine)
                {
                    return '*';
                }
                if (Neighbors == 0)
                {
                    return ' ';
                }
                return Neighbors.ToString()[0];
            }
        }
    }
}
