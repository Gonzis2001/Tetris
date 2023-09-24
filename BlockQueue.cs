using System;
namespace Tetris
{
    public class BlockQueue
    {
        private readonly Block[] blocks = new Block[]
        {
            new IBlock(),
            new JBlock(),
            new LBlock(),
            new OBlock(),
            new SBlock(),
            new TBlock(),
            new ZBlock()

        };
        private readonly Random rand = new Random();

        public Block NextBloack { get; private set; }

        public BlockQueue() { 
        
            NextBloack =RandomBlock();
       }

        private Block RandomBlock()
        {
            return blocks[rand.Next(blocks.Length)];
        }
        public Block GetAndUpdate()
        {
            Block block = NextBloack;
            do
            {
                NextBloack= RandomBlock();
            }
            while (block.Id== NextBloack.Id);
            return block;
        }

    }
}
