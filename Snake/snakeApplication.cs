using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Media;

namespace Snake
{
    public partial class snakeApplication : Form
    {
        public snakeApplication()
        {
            InitializeComponent();
        }

        bool check = true, diff = true, soundPlay = true, pause = true;
        int timerInterval = 400, j = 0;
        int number, minTopResult;
        const int LINE_WIDTH = 1;
        const int EASY_SPEED = 400, NORMAL_SPEED = 250, HARD_SPEED = 100, EASY_POINT = 100, NORMAL_POINT = 200, HARD_POINT = 400;
        const int PANEL_SIZE = 502, CELL_SIZE = 25;
        const int MIN_POSSIBLE_CUBE_COORD_X_VALUE = 0, MAX_POSSIBLE_CUBE_COORD_X_VALUE = 19, MIN_POSSIBLE_CUBE_COORD_Y_VALUE = 1, MAX_POSSIBLE_CUBE_COORD_Y_VALUE = 20;
        Snake snake;
        Cube cube;
        Bitmap bmp;
        SoundPlayer soundPlayer = new SoundPlayer("C:\\Users\\Владимир\\source\\repos\\Snake\\Snake\\bin\\Debug\\фон.wav");

        private void SnakeApplication_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(PANEL_SIZE, PANEL_SIZE);
            gameFieldPanel.BackgroundImage = bmp;
            timerInterval = NORMAL_SPEED;
        }

        class Snake
        {
            public List<Coord> coord;
            public Direction direction;
            public Random rnd;
            int headCoordX, headCoordY;
            const int MIN_POSSIBLE_START_VALUE_COORD_X = 4, MAX_POSSIBLE_START_VALUE_COORD_X = 10, MIN_POSSIBLE_START_VALUE_COORD_Y = 1, MAX_POSSIBLE_START_VALUE_COORD_Y = 20;
            const int CELL_CORRECTION = 2, COORD_CORRECTION = 1;
            public Snake()
            {
                coord = new List<Coord>();
                rnd = new Random();
                headCoordX = rnd.Next(MIN_POSSIBLE_START_VALUE_COORD_X, MAX_POSSIBLE_START_VALUE_COORD_X) * CELL_SIZE;
                headCoordY = rnd.Next(MIN_POSSIBLE_START_VALUE_COORD_Y, MAX_POSSIBLE_START_VALUE_COORD_Y) * CELL_SIZE;
                coord.Add(new Coord(headCoordX, headCoordY));
                coord.Add(new Coord(headCoordX - CELL_SIZE * coord.Count, headCoordY));
                coord.Add(new Coord(headCoordX - CELL_SIZE * coord.Count, headCoordY));
                coord.Add(new Coord(headCoordX - CELL_SIZE * coord.Count, headCoordY));
                coord.Add(new Coord(headCoordX - CELL_SIZE * coord.Count, headCoordY));
                direction = Direction.Right;
            }

            public void DrawSnake(Graphics gr, Pen pen)
            {
                Bitmap image = null;
                switch (direction)
                {
                    case Direction.Right:
                        image = (Bitmap)Image.FromFile("вправо.jpg");
                        break;
                    case Direction.Left:
                        image = (Bitmap)Image.FromFile("влево.jpg");
                        break;
                    case Direction.Up:
                        image = (Bitmap)Image.FromFile("вверх.jpg");
                        break;
                    case Direction.Down:
                        image = (Bitmap)Image.FromFile("вниз.jpg");
                        break;
                }
                TextureBrush texture = new TextureBrush(image);
                gr.DrawRectangle(pen, coord[0].x, coord[0].y, CELL_SIZE, CELL_SIZE);
                gr.FillRectangle(texture, coord[0].x + COORD_CORRECTION, coord[0].y + COORD_CORRECTION, CELL_SIZE - CELL_CORRECTION, CELL_SIZE - CELL_CORRECTION);
                for (int i = 1; i < coord.Count; i++)
                {
                    gr.DrawRectangle(pen, coord[i].x, coord[i].y, CELL_SIZE, CELL_SIZE);
                    SolidBrush solidBrush = new SolidBrush(Color.FromArgb(0, 0, 0, 0));
                    gr.FillRectangle(solidBrush, coord[i].x, coord[i].y, CELL_SIZE, CELL_SIZE);
                }
            }

            public void MoveSnake()
            {
                for (int i = coord.Count - COORD_CORRECTION; i >= 0; i--)
                {
                    if (i == 0)
                    {
                        switch (direction)
                        {
                            case Direction.Right:
                                coord[i].x += CELL_SIZE;
                                break;
                            case Direction.Left:
                                coord[i].x -= CELL_SIZE;
                                break;
                            case Direction.Up:
                                coord[i].y -= CELL_SIZE;
                                break;
                            case Direction.Down:
                                coord[i].y += CELL_SIZE;
                                break;
                        }
                    }
                    else
                    {
                        coord[i].x = coord[i - 1].x;
                        coord[i].y = coord[i - 1].y;
                    }
                }
            }
        }
        class Coord
        {
            public int x;
            public int y;

            public Coord(int xx, int yy)
            {
                x = xx;
                y = yy;
            }
        }

        private void SaveNicknameButton_Click(object sender, EventArgs e)
        {
            alertTextBox.Visible = false;
            congratulationsLabel.Visible = false;
            controlButton.Visible = true;
            currentScoreLabel.Visible = false;
            gameDifficultChangeButton.Visible = true;
            gameStartButton.Visible = true;
            inputNicknameTextBox.Visible = false;
            leaderboardButton.Visible = true;
            saveNicknameButton.Visible = false;
            scoreTitleLabel.Visible = false;

            bmp = new Bitmap(PANEL_SIZE, PANEL_SIZE);
            gameFieldPanel.BackgroundImage = bmp;
            string connectionString = @"Data Source = ВЛАДИМИР-ПК\SQLEXPRESS; Initial Catalog = SnakeBase; Trusted_Connection = True";
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            
            SqlCommand sqlInsert = new SqlCommand("insert into leaderboard (nickname, score) values (" + "'" + inputNicknameTextBox.Text + "', " + Convert.ToInt32(currentScoreLabel.Text) + ")", conn);
            sqlInsert.ExecuteNonQuery();

            conn.Close();
            inputNicknameTextBox.Clear();
        }

        private void SnakeApplication_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'D' || e.KeyChar == 'd' || e.KeyChar == 'В' || e.KeyChar == 'в')
            {
                e.Handled = true;
                switch (snake.direction)
                {
                    case Direction.Right:
                        snake.direction = Direction.Down;
                        break;
                    case Direction.Down:
                        snake.direction = Direction.Left;
                        break;
                    case Direction.Left:
                        snake.direction = Direction.Up;
                        break;
                    case Direction.Up:
                        snake.direction = Direction.Right;
                        break;
                }
            }
            if (e.KeyChar == 'A' || e.KeyChar == 'a' || e.KeyChar == 'Ф' || e.KeyChar == 'ф')
            {
                e.Handled = true;
                switch (snake.direction)
                {
                    case Direction.Right:
                        snake.direction = Direction.Up;
                        break;
                    case Direction.Up:
                        snake.direction = Direction.Left;
                        break;
                    case Direction.Left:
                        snake.direction = Direction.Down;
                        break;
                    case Direction.Down:
                        snake.direction = Direction.Right;
                        break;
                }
            }
            if (e.KeyChar == 'P' || e.KeyChar == 'p' || e.KeyChar == 'З' || e.KeyChar == 'з')
            {
                e.Handled = true;
                if (pause == true)
                {
                    pause = false;
                    timer1.Stop();
                    alertTextBox.Text = "Пауза";
                    alertTextBox.Visible = true;
                }
                else
                {
                    pause = true;
                    timer1.Start();
                    alertTextBox.Text = "Игра окончена";
                    alertTextBox.Visible = false;
                }
            }
            if (e.KeyChar == 'M' || e.KeyChar == 'm' || e.KeyChar == 'Ь' || e.KeyChar == 'ь')
            {
                e.Handled = true;
                if (soundPlay == true)
                {
                    soundPlay = false;
                    soundPlayer.Stop();
                }
                else
                {
                    soundPlay = true;
                    soundPlayer.Play();
                }
            }
        }

        private void ControlButton_Click(object sender, EventArgs e)
        {
            controlForm controlForm = new controlForm();
            controlForm.Show();
        }

        private void GameStartButton_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
            j = 0;
            currentScoreLabel.Text = "0";
            Graphics gr = Graphics.FromImage(bmp);
            Pen snakePen = new Pen(Color.FromArgb(255, 0, 0, 255), LINE_WIDTH);
            Pen cubePen = new Pen(Color.FromArgb(255, 255, 0, 0), LINE_WIDTH);
            Random rnd = new Random();
            snake = new Snake();
            cube = new Cube();
            do
            {
                for (int i = 0; i < snake.coord.Count; i++)
                {
                    if (snake.coord[i].x == cube.cubeCoordX && snake.coord[i].y == cube.cubeCoordY)
                    {
                        check = false;

                        cube.cubeCoordX = rnd.Next(MIN_POSSIBLE_CUBE_COORD_X_VALUE, MAX_POSSIBLE_CUBE_COORD_X_VALUE) * CELL_SIZE;
                        cube.cubeCoordY = rnd.Next(MIN_POSSIBLE_CUBE_COORD_Y_VALUE, MAX_POSSIBLE_CUBE_COORD_Y_VALUE) * CELL_SIZE;

                        break;
                    }
                    else
                    {
                        check = true;
                    }
                }
            }
            while (check == false);
            snake.DrawSnake(gr, snakePen);
            cube.DrawCube(gr, cubePen, cube.cubeCoordX, cube.cubeCoordY);

            alertTextBox.Visible = false;
            controlButton.Visible = false;
            currentScoreLabel.Visible = true;
            easyDiffButton.Visible = false;
            gameDifficultChangeButton.Visible = false;
            gameStartButton.Visible = false;
            hardDiffButton.Visible = false;
            leaderboardButton.Visible = false;
            normalDiffButton.Visible = false;
            scoreTitleLabel.Visible = true;
            timer1.Start();
        }

        private void LeaderboardButton_Click(object sender, EventArgs e)
        {
            leaderboardForm leaderboard = new leaderboardForm();
            leaderboard.Show();
        }

        private void ShowDiffButton()
        {
            easyDiffButton.Visible = true;
            normalDiffButton.Visible = true;
            hardDiffButton.Visible = true;
        }

        private void HideDiffButton()
        {
            diff = true;
            easyDiffButton.Visible = false;
            normalDiffButton.Visible = false;
            hardDiffButton.Visible = false;
        }

        private void GameDifficultChangeButton_Click(object sender, EventArgs e)
        {
            if (diff == true)
            {
                diff = false;
                ShowDiffButton();
            }
            else
            {
                HideDiffButton();
            }
        }

        private void EasyDiffButton_Click(object sender, EventArgs e)
        {
            timerInterval = EASY_SPEED;
            HideDiffButton();
        }

        private void NormalDiffButton_Click(object sender, EventArgs e)
        {
            timerInterval = NORMAL_SPEED;
            HideDiffButton();
        }

        private void HardDiffButton_Click(object sender, EventArgs e)
        {
            timerInterval = HARD_SPEED;
            HideDiffButton();
        }

        private void ShowRecordMenu()
        {
            congratulationsLabel.Visible = true;
            inputNicknameTextBox.Visible = true;
            saveNicknameButton.Visible = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = timerInterval;
            Bitmap bmp = new Bitmap(PANEL_SIZE, PANEL_SIZE);
            gameFieldPanel.BackgroundImage = bmp;
            Graphics gr = Graphics.FromImage(bmp);
            Pen snakePen = new Pen(Color.FromArgb(255, 0, 0, 255), LINE_WIDTH);
            Pen cubePen = new Pen(Color.FromArgb(255, 255, 0, 0), LINE_WIDTH);
            Random rnd = new Random();
            snake.MoveSnake();
            for (int i = 1; i < snake.coord.Count; i++)
            {
                if ((snake.coord[0].x == snake.coord[i].x && snake.coord[0].y == snake.coord[i].y) || snake.coord[0].x > (PANEL_SIZE - CELL_SIZE) || snake.coord[0].x < 0 || snake.coord[0].y > (PANEL_SIZE - CELL_SIZE) || snake.coord[0].y < 0)
                {
                    timer1.Stop();
                    soundPlayer.Stop();
                    string connectionString = @"Data Source = ВЛАДИМИР-ПК\SQLEXPRESS; Initial Catalog = SnakeBase; Trusted_Connection = True";
                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();
                    SqlCommand sqlCount = new SqlCommand("select count(*) from leaderboard", conn);
                    number = (int)sqlCount.ExecuteScalar();
                    if (number > 0)
                    {
                        SqlCommand sqlMinTopScore = new SqlCommand("select (score) from leaderboard order by score", conn);
                        minTopResult = (int)sqlMinTopScore.ExecuteScalar();
                    }
                    if (number < 10)
                    {
                        ShowRecordMenu();
                    }
                    else
                    {
                        if (Convert.ToInt32(currentScoreLabel.Text) > minTopResult)
                        {
                            SqlCommand sqlDelete = new SqlCommand("delete from leaderboard where score = " + minTopResult, conn);
                            sqlDelete.ExecuteNonQuery();
                            ShowRecordMenu();
                        }
                        else
                        {
                            gameStartButton.Visible = true;
                            controlButton.Visible = true;
                            gameDifficultChangeButton.Visible = true;
                            leaderboardButton.Visible = true;
                        }
                    }
                    conn.Close();
                    alertTextBox.Visible = true;
                }
            }
            if (snake.coord[0].x == cube.cubeCoordX && snake.coord[0].y == cube.cubeCoordY)
            {
                j++;
                if (timerInterval == EASY_SPEED)
                {
                    currentScoreLabel.Text = Convert.ToString(EASY_POINT * j);
                }
                if (timerInterval == NORMAL_SPEED)
                {
                    currentScoreLabel.Text = Convert.ToString(NORMAL_POINT * j);
                }
                if (timerInterval == HARD_SPEED)
                {
                    currentScoreLabel.Text = Convert.ToString(HARD_POINT * j);
                }
                cube = new Cube();
                do
                {
                    for (int i = 0; i < snake.coord.Count; i++)
                    {
                        if (snake.coord[i].x == cube.cubeCoordX && snake.coord[i].y == cube.cubeCoordY)
                        {
                            check = false;

                            cube.cubeCoordX = rnd.Next(MIN_POSSIBLE_CUBE_COORD_X_VALUE, MAX_POSSIBLE_CUBE_COORD_X_VALUE) * CELL_SIZE;
                            cube.cubeCoordY = rnd.Next(MIN_POSSIBLE_CUBE_COORD_Y_VALUE, MAX_POSSIBLE_CUBE_COORD_Y_VALUE) * CELL_SIZE;

                            break;
                        }
                        else
                        {
                            check = true;
                        }
                    }
                }
                while (check == false);
                snake.coord.Add(new Coord(cube.cubeCoordX, cube.cubeCoordY));
                snake.DrawSnake(gr, snakePen);
                cube.DrawCube(gr, cubePen, cube.cubeCoordX, cube.cubeCoordY);
            }
            else
            {
                cube.DrawCube(gr, cubePen, cube.cubeCoordX, cube.cubeCoordY);
                snake.DrawSnake(gr, snakePen);
            }
            gameFieldPanel.Refresh();
        }

        enum Direction
        {
            Right, Left, Up, Down
        }

        class Cube
        {
            public int cubeCoordX;
            public int cubeCoordY;
            public Random rnd;

            public Cube()
            {
                rnd = new Random();
                cubeCoordX = rnd.Next(MIN_POSSIBLE_CUBE_COORD_X_VALUE, MAX_POSSIBLE_CUBE_COORD_X_VALUE) * CELL_SIZE;
                cubeCoordY = rnd.Next(MIN_POSSIBLE_CUBE_COORD_Y_VALUE, MAX_POSSIBLE_CUBE_COORD_Y_VALUE) * CELL_SIZE;
            }

            public void DrawCube(Graphics gr, Pen pen, int cubeCoordX, int cubeCoordY)
            {
                gr.DrawRectangle(pen, cubeCoordX, cubeCoordY, CELL_SIZE, CELL_SIZE);
                SolidBrush solidBrush = new SolidBrush(Color.FromArgb(0, 0, 0, 0));
                gr.FillRectangle(solidBrush, cubeCoordX, cubeCoordY, CELL_SIZE, CELL_SIZE);
            }
        }
    }
}
