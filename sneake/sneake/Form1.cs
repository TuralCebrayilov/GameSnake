namespace sneake
{
    public partial class Form1 : Form
    {
        public enum Direction
        {
            Up,
            Down, Left, Right
        }
        public int score =0;
        public int x = 1, y = 1;
        Direction dr = Direction.Right;
        public Location Food = new Location(-1, -1);
        public List<Location> FoodLocations = new List<Location>();
        public Form1()
        {
            InitializeComponent();
            FoodLocations.Add(new sneake.Location(0, 0));
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
                    Thread.Sleep(100);
                }

            })));
            thread.Start();
        }
        public void SnakeCalc()
        {
            try
            {
                Invoke(new Action(() => label1.Text = "Total" + score));
            }
            catch 
            {

                
            }
            Random random = new Random();
            Bitmap bitmap = new Bitmap(500, 500);

            if (x == Food.x && y == Food.y)
            {
                score++;
                FoodLocations.Add(new sneake.Location(Food.x, Food.y));
                Food = new Location(-1, -1);

            }


            //snake

            for (int i = (x - 1) * 10; i < x * 10; i++)
            {
                for (int j = (y - 1) * 10; j < y * 10; j++)
                {
                    bitmap.SetPixel(i, j, color: Color.Black);
                }
            }


            if (FoodLocations.Count != 1)
            {
                for (int k = 0; k < FoodLocations.Count; k++)
                {
                    for (int i = (FoodLocations[k].x - 1) * 10; i < FoodLocations[k].x * 10; i++)
                    {
                        for (int j = (FoodLocations[k].y - 1) * 10; j < FoodLocations[k].y * 10; j++)
                        {
                            bitmap.SetPixel(i, j, color: Color.Black);
                        }
                    }
                }
            }

            FoodLocations[0] = new sneake.Location(x, y);
            for (int i = FoodLocations.Count - 1; i > 0; i--)
            {
                FoodLocations[i] = FoodLocations[i - 1];
            }
            if (FoodLocations.Count != 1)
            {
                for (int k = 0; k < FoodLocations.Count; k++)
                {
                    for (int i = (FoodLocations[k].x - 1) * 10; i < FoodLocations[k].x * 10; i++)
                    {
                        for (int j = (FoodLocations[k].y - 1) * 10; j < FoodLocations[k].y * 10; j++)
                        {
                            bitmap.SetPixel(i, j, color: Color.Black);
                        }
                    }
                }
            }

            //food
            if (Food.x == -1)
            {
                Food = new Location(random.Next(1, 50), random.Next(1, 50));
            }
            for (int i = (Food.x - 1) * 10; i < Food.x * 10; i++)
            {
                for (int j = (Food.y - 1) * 10; j < Food.y * 10; j++)
                {
                    bitmap.SetPixel(i, j, color: Color.Red);
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
    public class Location
    {
        public int x, y;
        public Location(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
    }
}