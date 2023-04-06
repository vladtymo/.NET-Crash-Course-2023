

namespace ExamTask
{
    internal class Program
    {
        const int width = 30, height = 40;
        const int x = 10, y = 2;

        /*struct Pixel
        {
            public int X { get; set; }
            public int Y { get; set; }
            public ConsoleColor Color { get; set; }
            public Pixel(int x, int y, ConsoleColor color)
            {
                X = x;
                Y = y;
                Color = color;

                Draw();
            }

            public void Draw()
            {
                Console.SetCursorPosition(X, Y);
                Console.WriteLine('#');
            }

            public void Clear()
            {

            }
        }*/
        class Figura
        {

            public enum KindFigure { I_Block, O_Block, J_Block, Z_Block};
            public Figura()
            {
                Formation();
                Draw(x, y);
            }

            public bool[,] figura = new bool[4, 4];
            public void Formation()
            {
                Array.Clear(figura);
                Random random = new Random();
                KindFigure type =(KindFigure)random.Next(0, 4);
                switch (type)
                {
                    case KindFigure.I_Block:
                        Console.ForegroundColor=ConsoleColor.Red;
                        for (int i = 0; i < 4; i++)
                            figura[i, 0] = true;
                        break;

                    case KindFigure.O_Block:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        for (int i = 2; i < 4; i++)
                            for (int j = 0; j < 2; j++)
                                figura[i, j] = true;
                        break;

                    case KindFigure.J_Block:
                        Console.ForegroundColor = ConsoleColor.Green;
                        for (int i = 0; i<3; i++)
                            figura[3 , i] = true;
                        figura[2, 0] = true;
                        break;

                    case KindFigure.Z_Block:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        figura[2, 0] = true;
                        figura[2, 1] = true;
                        figura[3, 1] = true;
                        figura[3, 2] = true;
                        break;
                }
            }

            public void Draw(int startX, int startY)
            {
                Console.SetCursorPosition(startX, startY);
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                        if (figura[i, j] == true)
                        {
                            Console.SetCursorPosition(startX + j, startY + i);
                            Console.Write("0");
                        }
            }

            public bool IsTouch(int x, int y)
            {
                return false;
            }

            private void Clear(int startX, int startY)
            {
                Console.SetCursorPosition(startX, startY);
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 4; j++)
                        if (figura[i, j] == true)
                        {
                            Console.SetCursorPosition(startX + j, startY + i);
                            Console.Write(' ');
                        }
            }

            public void Move(int startX, int startY)
            {
                Clear(startX, startY);
                Thread.Sleep(200);
                Draw(startX, startY + 1);

            }


        }


        class Field
        {

            public bool[,] field = new bool[height, width];
            public ConsoleColor Color { get; set; }
            public Field(int width, int height, ConsoleColor color)
            {
                Color = color;

                Draw(Color);
            }

            public void CheckLine()
            {

            }
            public Field()
            {

                Color = ConsoleColor.Blue;

                Draw(Color);
            }
            public void Draw(ConsoleColor color)
            {
                for (int i = 0; i < height; i++)
                    for (int j = 0; j < width; j++)
                    {
                        if (j==width -1|| i == 0 || i == height - 1 || j == 0)
                            field[i, j] = true;
                        else
                            field[i, j] = false;
                    }


                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (field[i, j]==true)
                        {
                            Console.SetCursorPosition(j, i);
                            Console.Write("0");
                        }
                            
                    }
                    Console.WriteLine();
                }


                /*for (int i = 0; i < height; i++)
                 {
                     Console.SetCursorPosition(0, i);
                     field[0,i]= true;
                     Console.Write("0");
                     Console.SetCursorPosition(width - 1,i );
                     field[width - 1,i] = true;
                     Console.Write("0");
                 }

                 for (int i = 0; i < width; i++)
                 {
                     Console.SetCursorPosition(i, 0);
                     field[i, 0] = true;
                     Console.Write("0");
                     Console.SetCursorPosition(i, height - 1);
                     field[i, height - 1] = true;
                     Console.Write("0");
                 }*/
            }
        }

        static void Start()
        {
            Field field = new Field();

            while (true)
            {
                int cutX = x;
                int cutY = y;
                Figura figura = new Figura();

                while (!figura.IsTouch(cutX, cutY) && cutY < height - 5)
                {
                    Thread.Sleep(100);
                    figura.Move(cutX, cutY);
                    cutY++;
                }
                field.CheckLine();
            }
        }

        static void Main(string[] args)
        {
            Start();
        }
    }
}

/* 
namespace EventProject
{
    delegate void Up();
    delegate void Down();
    delegate void Left();
    delegate void Right();

    class EventUp
    {
        // Объявляем событие
        public event Up UpEvent;

        // Используем метод для запуска события
        public void UpUserEvent()
        {
            UpEvent();
        }
    }


    class EventDown
    {
        // Объявляем событие
        public event Down DownEvent;

        // Используем метод для запуска события
        public void DownUserEvent()
        {
            DownEvent();
        }
    }

    class EventLeft
    {
        // Объявляем событие
        public event Left LeftEvent;

        // Используем метод для запуска события
        public void LeftUserEvent()
        {
            LeftEvent();
        }
    }

    class EventRight
    {
        // Объявляем событие
        public event Right RightEvent;

        // Используем метод для запуска события
        public void RightUserEvent()
        {
            RightEvent();
        }
    }

    public enum FigType { line, square, rightL, leftL, pyramide, leftZ, rightZ }; //перечисление возможных фигур

    //класс фигура
    class Figura
    {
        public bool[,] matrix = new bool[4, 4]; //матрица контейнер для размещения фигур
        public FigType type; //тип фигуры
        public int position; //положение фигуры


        //стирание фигуры
        public void Clear(bool[,] m)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    m[i, j] = false;
        }

        //создание фигуры
        public void Create(FigType figtype)
        {
            Clear(matrix); //стираем фигуру
            this.type = figtype;
            this.position = 1;
            switch (figtype) //анализируем переданную в функцию фигуру
            {
                case FigType.line: //линия
                    {
                        for (int i = 0; i < 4; i++)
                            matrix[0, i] = true;
                        break;
                    }

                case FigType.square: //квадрат
                    {
                        for (int i = 0; i < 2; i++)
                            for (int j = 0; j < 2; j++)
                                matrix[i, j] = true;
                        break;
                    }

                case FigType.leftL:
                    {
                        for (int i = 0; i < 3; i++)
                            matrix[0, i] = true;
                        matrix[1, 2] = true;
                        break;
                    }

                case FigType.rightL:
                    {
                        for (int i = 0; i < 3; i++)
                            matrix[0, i] = true;
                        matrix[1, 0] = true;
                        break;
                    }

                case FigType.pyramide:
                    {
                        for (int i = 0; i < 3; i++)
                            matrix[1, i] = true;
                        matrix[0, 1] = true;
                        break;
                    }

                case FigType.leftZ:
                    {
                        matrix[0, 0] = true; matrix[1, 0] = true;
                        matrix[1, 1] = true; matrix[2, 1] = true;
                        break;
                    }

                case FigType.rightZ:
                    {
                        matrix[0, 1] = true; matrix[1, 0] = true;
                        matrix[1, 1] = true; matrix[2, 0] = true;
                        break;
                    }
            }

        }

        //вращение фигуры
        public void Rotate()
        {
            if (this.position == 4) this.position = 1; //в начальном положении
            this.position++; //меняем положение

            switch (type)
            {
                case FigType.line: //если линия
                    {
                        int k;
                        if (matrix[0, 0] == true)
                        {
                            Clear(matrix);
                            for (k = 0; k < 4; k++)
                                matrix[k, 1] = true;
                        }
                        else
                        {
                            Clear(matrix);
                            for (k = 0; k < 4; k++)
                                matrix[0, k] = true;
                        }
                        break;
                    }

                case FigType.square: //если квадрат
                    {
                        return;
                    }

                default: //остальные виды фигур (так как они зеркально похожи)
                    {
                        bool[,] tempFig = new bool[4, 4];
                        Clear(tempFig);

                        for (int j = 3 - 1, c = 0; j >= 0; j--, c++)
                            for (int i = 0; i < 3; i++)
                                tempFig[c, i] = matrix[i, j];

                        Clear(matrix);

                        for (int f = 0; f < 3; f++)
                            for (int d = 0; d < 3; d++)
                                matrix[f, d] = tempFig[f, d];
                        break;
                    }
            }

        }


    }

    //класс игрового поля
    class Field
    {
        public Figura fig = new Figura(); //фигура
        int width; //ширина поля
        int height; //высота поля
        static bool[,] tetrisField; //игровое поле
        int curY; //текущая координата у
        int curX; //текущая координата х
        public int scores; //очки за игру
        public int level;

        //конструктор
        public Field(int w, int h)
        {
            this.width = w;
            this.height = h;
            tetrisField = new bool[height, width];
            level = 0;
            scores = 0;
        }
        //отрисовка поля
        public void DrawField()
        {

            for (int i = 0; i < height - 1; i++)
            {
                for (int j = 1; j < width - 1; j++)
                {
                    Console.CursorLeft = j;
                    Console.CursorTop = i;
                    if (tetrisField[i, j] == false) Console.WriteLine(" ");
                    else Console.WriteLine("0");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n   Level " + this.level);
            Console.WriteLine("\n  Scores " + this.scores);
        }

        //отбражение фигуры на игровом поле
        public void Copy()
        {
            int x = curX; //временные переменные координаты для заполнения части поля
            int y = curY;

            for (int i = 0; i < 4; i++)
            {
                x = curX;

                for (int j = 0; j < 4; j++)
                {
                    if (fig.matrix[i, j] == true) tetrisField[y, x] = true;
                    x++;
                }
                y++;
            }
        }

        //создание новой фигуры
        public void NewFig()
        {
            Random r = new Random();
            curY = 0;
            curX = 5;

            FigType t = (FigType)r.Next(0, 7);
            fig.Create(t);

            this.Copy(); //отображение         

        }

        //движение фигуры вниз
        public void Move()
        {
            this.ClearPrevious();
            curY++;
            this.Copy();
            this.DrawField();

        }

        //стирание предыдущего шага
        public void ClearPrevious()
        {
            int m = 0;
            int n = 0;

            for (int i = curY; i < curY + 4; i++)
            {
                for (int j = curX; j < curX + 4; j++)
                {
                    if (fig.matrix[m, n] == true) tetrisField[i, j] = false;
                    n++;
                }
                m++;
                n = 0;
            }

        }

        //проверка возможности вращения фигуры
        public bool CheckRotation()
        {

            return false;
        }

        //проверка возможности смещения влево
        public bool CheckLeft()
        {
            switch (fig.type)
            {
                case FigType.line:
                    {
                        if (fig.position == 1 || fig.position == 3)
                        {
                            if (tetrisField[curY, curX - 1] == true || curX == 1) return false;
                            else return true;
                        }

                        else
                        {
                            if (fig.position == 2 || fig.position == 4)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    if (tetrisField[curY + i, curX] || curX == 0) return false;
                                }
                                return true;
                            }
                        }
                        break;
                    }

                case FigType.square:
                    {
                        if (tetrisField[curY, curX - 1] == true || tetrisField[curY + 1, curX - 1] == true || curX == 1) return false;
                        else return true;
                    }

                case FigType.rightL:
                    {
                        if (fig.position == 1)
                        {
                            if (tetrisField[curY, curX - 1] == true || tetrisField[curY + 1, curX - 1] == true || curX == 1) return false;
                            else return true;
                        }

                        else
                        {
                            if (fig.position == 2)
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    if (tetrisField[curY + i, curX - 1] == true || curX == 1) return false;
                                }
                                return true;
                            }

                            if (fig.position == 3)
                            {
                                if (tetrisField[curY + 2, curX - 1] == true || tetrisField[curY + 1, curX + 1] == true || curX == 1) return false;
                                else return true;
                            }

                            if (fig.position == 4)
                            {
                                if (tetrisField[curY, curX] == true || tetrisField[curY + 1, curX + 1] == true || tetrisField[curY + 2, curX + 1] || curX == 0) return false;
                                else return true;
                            }

                        }
                        break;
                    }

                case FigType.leftL:
                    {
                        if (fig.position == 1)
                        {
                            if (tetrisField[curY, curX - 1] == true || tetrisField[curY + 1, curX + 1] == true || curX == 1) return false;
                            else return true;
                        }

                        else
                        {
                            if (fig.position == 2)
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    if (tetrisField[curY + i, curX - 1] == true || curX == 1) return false;
                                }
                                return true;
                            }

                            if (fig.position == 3)
                            {
                                if (tetrisField[curY + 1, curX - 1] == true || tetrisField[curY + 2, curX - 1] == true || curX == 1) return false;
                                else return true;
                            }

                            if (fig.position == 4)
                            {
                                if (tetrisField[curY + 2, curX] == true || tetrisField[curY + 1, curX + 1] == true || tetrisField[curY, curX + 1] == true || curX == 0) return false;
                                else return true;
                            }

                        }
                        break;
                    }

                case FigType.pyramide:
                    {
                        if (fig.position == 1)
                        {
                            if (tetrisField[curY, curX] == true || tetrisField[curY + 1, curX - 1] == true || curX == 1) return false;
                            else return true;
                        }

                        else
                        {
                            if (fig.position == 2)
                            {
                                if (tetrisField[curY, curX] == true || tetrisField[curY + 1, curX - 1] == true || tetrisField[curY + 2, curX] == true || curX == 1) return false;
                                else return true;
                            }

                            if (fig.position == 3)
                            {
                                if (tetrisField[curY + 1, curX - 1] == true || tetrisField[curY + 2, curX] == true || curX == 1) return false;
                                else return true;
                            }

                            if (fig.position == 4)
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    if (tetrisField[curY + i, curX] == true || curX == 0) return false;
                                }
                                return true;
                            }


                        }

                        break;
                    }

                case FigType.leftZ:
                    {
                        if (fig.position == 1)
                        {
                            if (tetrisField[curY, curX - 1] == true || tetrisField[curY + 1, curX - 1] == true || tetrisField[curY + 2, curX] == true || curX == 1) return false;
                            else return true;
                        }

                        else
                        {
                            if (fig.position == 2)
                            {
                                if (tetrisField[curY + 1, curX] == true || tetrisField[curY + 2, curX - 1] == true || curX == 1) return false;
                                else return true;
                            }

                            if (fig.position == 3)
                            {
                                if (tetrisField[curY, curX] == true || tetrisField[curY + 1, curX] == true || tetrisField[curY + 2, curX + 1] == true || curX == 0) return false;
                                else return true;
                            }

                            if (fig.position == 4)
                            {
                                if (tetrisField[curY, curX] == true || tetrisField[curY + 1, curX - 1] == true || curX == 1) return false;
                                else return true;
                            }

                        }


                        break;
                    }

                case FigType.rightZ:
                    {
                        if (fig.position == 1)
                        {
                            if (tetrisField[curY, curX] == true || tetrisField[curY + 1, curX - 1] == true || tetrisField[curY + 2, curX - 1] == true || curX == 1) return false;
                            else return true;
                        }

                        else
                        {
                            if (fig.position == 2)
                            {
                                if (tetrisField[curY + 1, curX - 1] == true || tetrisField[curY + 2, curX] == true || curX == 1) return false;
                                else return true;
                            }

                            if (fig.position == 3)
                            {
                                if (tetrisField[curY, curX + 1] == true || tetrisField[curY + 1, curX] == true || tetrisField[curY + 2, curX] == true || curX == 0) return false;
                                else return true;
                            }

                            if (fig.position == 4)
                            {
                                if (tetrisField[curY, curX - 1] == true || tetrisField[curY + 1, curX] == true || curX == 1) return false;
                                else return true;
                            }

                        }
                        break;
                    }
            }

            return false;

        }

        //проверка возможности смещения вправо
        public bool CheckRight()
        {
            switch (fig.type)
            {
                case FigType.line:
                    {
                        if (fig.position == 1 || fig.position == 3)
                        {
                            if (tetrisField[curY, curX + 4] == true || curX == this.width - 5) return false;
                            else return true;
                        }

                        else
                        {
                            if (fig.position == 2 || fig.position == 4)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    if (tetrisField[curY + i, curX + 2] || curX == this.width - 3) return false;
                                }
                                return true;
                            }
                        }
                        break;
                    }

                case FigType.square:
                    {
                        if (tetrisField[curY, curX + 2] == true || tetrisField[curY + 1, curX + 2] == true || curX == this.width - 3) return false;
                        else return true;
                    }

                case FigType.rightL:
                    {
                        if (fig.position == 1)
                        {
                            if (tetrisField[curY, curX + 3] == true || tetrisField[curY + 1, curX + 1] == true || curX == this.width - 4) return false;
                            else return true;
                        }

                        else
                        {
                            if (fig.position == 2)
                            {
                                if (tetrisField[curY, curX + 1] == true || tetrisField[curY + 1, curX + 1] == true || tetrisField[curY + 2, curX + 2] || curX == this.width - 3) return false;
                                else return true;
                            }

                            if (fig.position == 3)
                            {
                                if (tetrisField[curY + 1, curX + 3] == true || tetrisField[curY + 2, curX + 3] == true || curX == this.width - 4) return false;
                                else return true;
                            }

                            if (fig.position == 4)
                            {
                                if (tetrisField[curY, curX + 3] == true || tetrisField[curY + 1, curX + 3] == true || tetrisField[curY + 2, curX + 3] || curX == this.width - 4) return false;
                                else return true;
                            }

                        }
                        break;
                    }

                case FigType.leftL:
                    {
                        if (fig.position == 1)
                        {
                            if (tetrisField[curY, curX + 3] == true || tetrisField[curY + 1, curX + 3] == true || curX == this.width - 4) return false;
                            else return true;
                        }

                        else
                        {
                            if (fig.position == 2)
                            {
                                if (tetrisField[curY, curX + 2] == true || tetrisField[curY + 1, curX + 1] == true || tetrisField[curY + 2, curX + 1] == true || curX == this.width - 3) return false;
                                else return true;
                            }

                            if (fig.position == 3)
                            {
                                if (tetrisField[curY + 1, curX + 1] == true || tetrisField[curY + 2, curX + 3] == true || curX == this.width - 4) return false;
                                else return true;
                            }

                            if (fig.position == 4)
                            {
                                if (tetrisField[curY, curX + 3] == true || tetrisField[curY + 1, curX + 3] == true || tetrisField[curY + 2, curX + 3] == true || curX == this.width - 4) return false;
                                else return true;
                            }

                        }
                        break;
                    }

                case FigType.pyramide:
                    {
                        if (fig.position == 1)
                        {
                            if (tetrisField[curY, curX + 2] == true || tetrisField[curY + 1, curX + 3] == true || curX == this.width - 4) return false;
                            else return true;
                        }

                        else
                        {
                            if (fig.position == 2)
                            {
                                if (tetrisField[curY, curX + 2] == true || tetrisField[curY + 1, curX + 2] == true || tetrisField[curY + 2, curX + 2] == true || curX == this.width - 3) return false;
                                else return true;
                            }

                            if (fig.position == 3)
                            {
                                if (tetrisField[curY + 1, curX + 3] == true || tetrisField[curY + 2, curX + 2] == true || curX == this.width - 4) return false;
                                else return true;
                            }

                            if (fig.position == 4)
                            {
                                if (tetrisField[curY, curX + 2] == true || tetrisField[curY + 1, curX + 3] == true || tetrisField[curY + 2, curX + 2] == true || curX == this.width - 4) return false;
                                else return true;
                            }


                        }

                        break;
                    }

                case FigType.leftZ:
                    {
                        if (fig.position == 1)
                        {
                            if (tetrisField[curY, curX + 1] == true || tetrisField[curY + 1, curX + 2] == true || tetrisField[curY + 2, curX + 2] == true || curX == this.width - 3) return false;
                            else return true;
                        }

                        else
                        {
                            if (fig.position == 2)
                            {
                                if (tetrisField[curY + 1, curX + 3] == true || tetrisField[curY + 2, curX + 2] == true || curX == this.width - 4) return false;
                                else return true;
                            }

                            if (fig.position == 3)
                            {
                                if (tetrisField[curY, curX + 2] == true || tetrisField[curY + 1, curX + 3] == true || tetrisField[curY + 2, curX + 3] == true || curX == this.width - 4) return false;
                                else return true;
                            }

                            if (fig.position == 4)
                            {
                                if (tetrisField[curY, curX + 3] == true || tetrisField[curY + 1, curX + 2] == true || curX == this.width - 4) return false;
                                else return true;
                            }

                        }


                        break;
                    }

                case FigType.rightZ:
                    {
                        if (fig.position == 1)
                        {
                            if (tetrisField[curY, curX + 2] == true || tetrisField[curY + 1, curX + 2] == true || tetrisField[curY + 2, curX + 1] == true || curX == this.width - 3) return false;
                            else return true;
                        }

                        else
                        {
                            if (fig.position == 2)
                            {
                                if (tetrisField[curY + 1, curX + 2] == true || tetrisField[curY + 2, curX + 3] == true || curX == this.width - 4) return false;
                                else return true;
                            }

                            if (fig.position == 3)
                            {
                                if (tetrisField[curY, curX + 3] == true || tetrisField[curY + 1, curX + 3] == true || tetrisField[curY + 2, curX + 2] == true || curX == this.width - 4) return false;
                                else return true;
                            }

                            if (fig.position == 4)
                            {
                                if (tetrisField[curY, curX + 2] == true || tetrisField[curY + 1, curX + 3] == true || curX == this.width - 4) return false;
                                else return true;
                            }

                        }
                        break;
                    }
            }

            return false;



        }

        //проверка возможности смещения вниз
        public bool CheckDown()
        {
            switch (fig.type)
            {
                case FigType.line:
                    {
                        if (fig.position == 1 || fig.position == 3)
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                if (tetrisField[curY + 1, curX + i] == true || (curY + 1) == this.height - 1) return false;
                            }
                            return true;

                        }

                        else
                        {
                            if (fig.position == 2 || fig.position == 4)
                            {
                                if (tetrisField[curY + 4, curX + 1] == true || (curY + 4) == this.height - 1) return false;
                            }
                            return true;
                        }
                    }

                case FigType.square:
                    {
                        if (tetrisField[curY + 2, curX] == true || tetrisField[curY + 2, curX + 1] == true || (curY + 2) == this.height - 1) return false;
                        return true;
                    }

                case FigType.rightL:
                    {
                        if (fig.position == 1)
                        {
                            if (tetrisField[curY + 2, curX] == true || tetrisField[curY + 1, curX + 1] == true || tetrisField[curY + 1, curX + 2] || (curY + 2) == this.height - 1) return false;
                            else return true;
                        }

                        else
                        {
                            if (fig.position == 2)
                            {
                                if (tetrisField[curY + 3, curX] == true || tetrisField[curY + 3, curX + 1] == true || (curY + 3) == this.height - 1) return false;
                                else return true;
                            }

                            if (fig.position == 3)
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    if (tetrisField[curY + 3, curX + i] || (curY + 3) == this.height - 1) return false;
                                }
                                return true;
                            }

                            if (fig.position == 4)
                            {
                                if (tetrisField[curY + 1, curX + 1] == true || tetrisField[curY + 3, curX + 2] || (curY + 3) == this.height - 1) return false;
                                else return true;
                            }
                        }

                        break;
                    }

                case FigType.leftL:
                    {
                        if (fig.position == 1)
                        {
                            if (tetrisField[curY + 1, curX] == true || tetrisField[curY + 1, curX + 1] == true || tetrisField[curY + 2, curX + 2] || (curY + 2) == this.height - 1) return false;
                            else return true;
                        }

                        else
                        {
                            if (fig.position == 2)
                            {
                                if (tetrisField[curY + 3, curX] == true || tetrisField[curY + 1, curX + 1] || curY + 3 == this.height - 1) return false;
                                else return true;
                            }

                            if (fig.position == 3)
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    if (tetrisField[curY + 3, curX + i] == true || (curY + 3) == this.height - 1) return false;
                                }
                                return true;
                            }

                            if (fig.position == 4)
                            {
                                if (tetrisField[curY + 3, curX + 1] == true || tetrisField[curY + 3, curX + 2] == true || (curY + 3) == this.height - 1) return false;
                                else return true;
                            }

                        }
                        break;
                    }

                case FigType.pyramide:
                    {
                        if (fig.position == 1)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                if (tetrisField[curY + 2, curX + i] == true || (curY + 2) == this.height - 1) return false;
                            }
                            return true;
                        }

                        else
                        {
                            if (fig.position == 2)
                            {
                                if (tetrisField[curY + 2, curX] == true || tetrisField[curY + 3, curX + 1] == true || (curY + 3) == this.height - 1) return false;
                                else return true;
                            }

                            if (fig.position == 3)
                            {
                                if (tetrisField[curY + 2, curX] == true || tetrisField[curY + 3, curX + 1] == true || tetrisField[curY + 2, curX + 2] == true || (curY + 3) == this.height - 1) return false;
                                else return true;
                            }

                            if (fig.position == 4)
                            {
                                if (tetrisField[curY + 3, curX + 1] == true || tetrisField[curY + 2, curX + 2] == true || (curY + 3) == this.height - 1) return false;
                                else return true;
                            }

                        }

                        break;
                    }

                case FigType.leftZ:
                    {
                        if (fig.position == 1)
                        {
                            if (tetrisField[curY + 2, curX] == true || tetrisField[curY + 3, curX + 1] == true || (curY + 3) == this.height - 1) return false;
                            else return true;
                        }

                        else
                        {
                            if (fig.position == 2)
                            {
                                if (tetrisField[curY + 3, curX] == true || tetrisField[curY + 3, curX + 1] == true || tetrisField[curY + 2, curX + 2] == true || (curY + 3) == this.height - 1) return false;
                                else return true;
                            }

                            if (fig.position == 3)
                            {
                                if (tetrisField[curY + 2, curX + 1] == true || tetrisField[curY + 3, curX + 2] == true || curY + 3 == this.height - 1) return false;
                                else return true;
                            }

                            if (fig.position == 4)
                            {
                                if (tetrisField[curY + 2, curX] == true || tetrisField[curY + 2, curX + 1] == true || tetrisField[curY + 1, curX + 2] == true || curY + 2 == this.height - 1) return false;
                                else return true;
                            }

                        }
                        break;
                    }

                case FigType.rightZ:
                    {
                        if (fig.position == 1)
                        {
                            if (tetrisField[curY + 3, curX] == true || tetrisField[curY + 2, curX + 1] == true || curY + 3 == this.height - 1) return false;
                            else return true;
                        }

                        else
                        {
                            if (fig.position == 2)
                            {
                                if (tetrisField[curY + 2, curX] == true || tetrisField[curY + 3, curX + 1] == true || tetrisField[curY + 3, curX + 2] == true || curY + 3 == this.height - 1) return false;
                                else return true;
                            }

                            if (fig.position == 3)
                            {
                                if (tetrisField[curY + 3, curX + 1] == true || tetrisField[curY + 2, curX + 2] == true || curY + 3 == this.height - 1) return false;
                                else return true;
                            }

                            if (fig.position == 4)
                            {
                                if (tetrisField[curY + 1, curX] == true || tetrisField[curY + 2, curX + 1] == true || tetrisField[curY + 2, curX + 2] == true || curY + 2 == this.height - 1) return false;
                                else return true;
                            }

                        }

                        break;
                    }

                default:
                    {
                        return false;
                    }

            }
            return false;


        }

        //проверка достижения "потолка"
        public bool IsAtBottom()
        {
            switch (fig.type)
            {
                case FigType.line:
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (tetrisField[1, curX + i] == true) return true;
                        }

                        break;
                    }

                case FigType.square:
                    {
                        if (tetrisField[2, curX] == true || tetrisField[2, curX + 1] == true) return true;
                        break;
                    }

                case FigType.rightL:
                    {
                        if (tetrisField[2, curX] == true || tetrisField[1, curX + 1] == true || tetrisField[1, curX + 2] == true) return true;
                        break;
                    }

                case FigType.leftL:
                    {
                        if (tetrisField[1, curX] == true || tetrisField[1, curX + 1] == true || tetrisField[2, curX + 2]) return true;
                        break;
                    }

                case FigType.pyramide:
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            if (tetrisField[2, curX + i] == true) return true;
                        }
                        break;
                    }

                case FigType.leftZ:
                    {
                        if (tetrisField[2, curX] == true || tetrisField[3, curX + 1] == true) return true;
                        break;
                    }

                case FigType.rightZ:
                    {
                        if (tetrisField[3, curX] == true || tetrisField[2, curX + 1] == true) return true;
                        break;
                    }
            }

            return false;
        }

        //проверка линии
        public bool CheckLine()
        {
            int counter = 0; //счетчик занятых ячеек в линии
            int k = 0;

            for (int i = 0; i < height; i++)
            {
                counter = 0;
                for (int j = 0; j < width; j++)
                {
                    if (tetrisField[i, j] == true) counter++; //подсчет занятых ячеек в линии
                    if (counter == 10)
                    {
                        k = i; //запоминаем линию в которой все ячейки заняты
                        break;
                    }
                }
            }

            if (k == 0) return false;

            else
            {
                for (int i = 0; i < width; i++)
                {
                    tetrisField[k, i] = false;
                }

                for (int i = k; i > 0; i--)
                {
                    for (int j = 0; j < width; j++)
                    {
                        tetrisField[i, j] = tetrisField[i - 1, j];
                    }
                }
                this.scores += 100;
                if (scores == 1000)
                {
                    level++;
                    scores = 0;
                }
                return true;
            }

        }

        //обработчик события вверх: поворот фигуры
        public void UpFig()
        {
            this.ClearPrevious();
            fig.Rotate();
            this.Copy();//отображение
        }

        //обработчик события вниз: падение фигуры
        public void DownFig()
        {
            while (this.CheckDown() == true) this.Move();
        }

        //обработчик события влево: смещение фигуры влево
        public void LeftFig()
        {
            if (CheckLeft() == true)
            {
                this.ClearPrevious();
                curX--;
                this.Copy();
            }
            else return;
        }

        //обработчик события вправо: смещение фигуры вправо
        public void RightFig()
        {
            if (CheckRight() == true)
            {
                this.ClearPrevious();
                curX++;
                this.Copy();
            }
            else return;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            for (int i = 0; i < 20; i++)
            {

                Console.CursorLeft = 0;
                Console.CursorTop = i;
                Console.WriteLine("0");
            }

            for (int i = 1; i < 12; i++)
            {
                Console.CursorLeft = i;
                Console.CursorTop = 19;
                Console.WriteLine("0");
            }

            for (int i = 0; i < 20; i++)
            {
                Console.CursorLeft = 11;
                Console.CursorTop = i;
                Console.WriteLine("0");
            }

            Console.BackgroundColor = ConsoleColor.Black;

            Field f = new Field(12, 20);

            f.NewFig();

            f.DrawField();

            //создание объектов событий нажатия клавиш
            EventUp up = new EventUp(); //вверх
            EventDown down = new EventDown(); //вниз
            EventLeft left = new EventLeft(); // влево
            EventRight right = new EventRight(); //вправо

            up.UpEvent += f.UpFig;
            down.DownEvent += f.DownFig;
            left.LeftEvent += f.LeftFig;
            right.RightEvent += f.RightFig;

            ConsoleKeyInfo cki;

            while (true)
            {
                if (f.CheckDown() == true) f.Move();
                else
                {
                    while (true)
                    {
                        bool flag = f.CheckLine();
                        if (flag == false) break;
                    }
                    f.NewFig();
                    if (f.IsAtBottom() == true) break;
                }


                for (int i = 0; i < 10 - f.level; i++) //количество итераций цикла имитирует скорость
                {
                    System.Threading.Thread.Sleep(50);
                    if (Console.KeyAvailable)
                    {
                        cki = Console.ReadKey();


                        switch (cki.Key)
                        {
                            case ConsoleKey.UpArrow: //стрелка вверх
                                {
                                    //if (f.CheckRotation() == false) break;
                                    up.UpUserEvent(); //обработчик события
                                    f.DrawField(); //перерисовка поля
                                    break;
                                }

                            case ConsoleKey.DownArrow:
                                {
                                    down.DownUserEvent();
                                    break;
                                }

                            case ConsoleKey.LeftArrow:
                                {
                                    left.LeftUserEvent();
                                    f.DrawField(); //перерисовка поля
                                    break;
                                }

                            case ConsoleKey.RightArrow:
                                {
                                    right.RightUserEvent();
                                    f.DrawField();
                                    break;
                                }

                            default:
                                {
                                    break;
                                }
                        }

                    }
                }


            }

            Console.Clear();

            Console.WriteLine("\n\n\n      GAME OVER");
            Console.WriteLine("\n   TOTAL SCORES " + (f.level * 1000 + f.scores) + "\n\n\n\n\n\n\n\n\n");

        }
    }
}*/