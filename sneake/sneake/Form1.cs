namespace sneake
{
    public partial class Form1 : Form
    {
        public enum Direction
        {
            Up,
            Down, Left, Right
        }
        public int x = 1, y = 1;
        Direction dr = Direction.Right;
        public Form1()
        {
            InitializeComponent();
            SnakeCalc();
            Thread thread = new Thread(new ThreadStart(new Action(() =>
            {
                while (true)
                {
                    if (dr == Direction.Right) x++;
                    if (dr == Direction.Down) y++;
                    if (dr == Direction.Left) x--;
                    if (dr == Direction.Up) y--;

                    SnakeCalc();
                    Thread.Sleep(500);
                }

            })));
            thread.Start();
        }
        public void SnakeCalc()
        {
            Bitmap bitmap = new Bitmap(500, 500);
            for (int i = (x - 1) * 10; i < x * 10; i++)
            {
                for (int j = (y - 1) * 10; j < y * 10; j++)
                {
                    bitmap.SetPixel(i, j, color: Color.Black);
                }
            }
            game.Image = bitmap;
        }

    
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "S") dr = Direction.Down;
            if (e.KeyCode.ToString() == "A") dr = Direction.Left;
            if (e.KeyCode.ToString() == "D") dr = Direction.Right;
            if (e.KeyCode.ToString() == "W") dr = Direction.Up;
        }
    }
}