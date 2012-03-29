using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace q5project
{
    class sudokugrid 
    {
        public sudokugrid()
        {
            
        }

        public void generate(TextBox[,] txtar, int[,] ans, ComboBox cmb_level, int variation, SudokuManager objGrid, Label lblPencilMark)
        {
            for (int i = 4000; i <= 15000; i = i + 4000)
                System.Console.Beep(i, 100);
            lblPencilMark.Visible = false;
           
            objGrid.changeGrid(txtar, variation);
            switch (variation)
            {
                case 0:
                    swap(ans);
                    break;
                case 1:
                    swapx(ans);
                    break;
                case 2:
                    swapC(ans);
                    break;
                case 3:
                    swap4(ans);
                    break;
            }
            
            int diff = difficulty(cmb_level);
           
            Random number;
            int seed;
            seed = DateTime.Now.Millisecond;
            number = new Random(seed);
            int r, s;
            for (int i = 0; i < diff; i++)
            {
                r = number.Next(0, 9);
                s = number.Next(0, 9);
                
                txtar[r, s].Text = ans[r, s].ToString();
                txtar[r, s].ReadOnly = true;
                txtar[r, s].ForeColor = System.Drawing.Color.DarkBlue;
                
            }
            lblPencilMark.Text = "";
        }

        public int difficulty(ComboBox cmb_level)
        {
            int diff = 60;
            switch (cmb_level.SelectedIndex)
            {
                case 0: diff = 60;
                    break;
                case 1: diff = 40;
                    break;
                case 2: diff = 25;
                    break;
            }
            return diff;
        }


        public void swap(int[,] ans)
        {
            int x, y;
            do
            {
                Random number;
                int seed;
                seed = DateTime.Now.Millisecond;
                number = new Random(seed);
                x = number.Next(0, 3);
                y = number.Next(0, 3);

            } while (x == y);

            int temp;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    temp = ans[x, j];
                    ans[x, j] = ans[y, j];
                    ans[y, j] = temp;
                }

                for (int j = 0; j < 9; j++)
                {
                    temp = ans[j, x];
                    ans[j, x] = ans[j, y];
                    ans[j, y] = temp;
                }

                x += 3;
                y += 3;
            }
        }
        public void swapC(int[,] ans)
        {
            int x, y;

            int temp;

            Random number;
            int seed;
            seed = DateTime.Now.Millisecond;
            number = new Random(seed);
            int selection = number.Next(0, 3);

            x = 0 + (selection * 3);
            y = x + 2;

            for (int j = 0; j < 9; j++)
            {
                temp = ans[x, j];
                ans[x, j] = ans[y, j];
                ans[y, j] = temp;
            }
            for (int j = 0; j < 9; j++)
            {
                temp = ans[j, x];
                ans[j, x] = ans[j, y];
                ans[j, y] = temp;
            }

            if (selection == 0)
            {
                x = 0;
                y = 3;
            }
            else if (selection == 1)
            {
                x = 0;
                y = 6;
            }
            else if (selection == 2)
            {
                x = 3;
                y = 6;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    temp = ans[x, j];
                    ans[x, j] = ans[y, j];
                    ans[y, j] = temp;
                }
                x++;
                y++;
            }
            for (int i = 0; i < 3; i++)
            {
                x--;
                y--;
                for (int j = 0; j < 9; j++)
                {
                    temp = ans[j, x];
                    ans[j, x] = ans[j, y];
                    ans[j, y] = temp;
                }
            }
        }
        public void swapx(int[,] ans)
        {
            int x, y;
            do
            {
                Random number;
                int seed;
                seed = DateTime.Now.Millisecond;
                number = new Random(seed);
                x = number.Next(0, 3);
                y = number.Next(0, 3);

            } while (x == y);

            int temp;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    temp = ans[x, j];
                    ans[x, j] = ans[y, j];
                    ans[y, j] = temp;
                }

                for (int j = 0; j < 9; j++)
                {
                    temp = ans[j, x];
                    ans[j, x] = ans[j, y];
                    ans[j, y] = temp;
                }

                x = 8-x;
                y = 8-y;
            }

            for (int j = 0; j < 9; j++)
            {
                temp = ans[3, j];
                ans[3, j] = ans[5, j];
                ans[5, j] = temp;
            }

            for (int j = 0; j < 9; j++)
            {
                temp = ans[j, 3];
                ans[j, 3] = ans[j, 5];
                ans[j, 5] = temp;
            }


        }

        public void swap4(int[,] ans)
        {
            int x, y = 0, temp = 0;

            Random number;
            int seed;
            seed = DateTime.Now.Millisecond;
            number = new Random(seed);
            x = number.Next(0, 2);

            if (x == 0)
            {
                for (int i = 1; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        temp = ans[y + i, j];
                        ans[y + i, j] = ans[y + i + 1, j];
                        ans[y + i + 1, j] = temp;
                    }

                    y = 4;
                }

                x = 0; y = 8;

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        temp = ans[x,j];
                        ans[x,j] = ans[y,j];
                        ans[y,j] = temp;

                    }

                    x++; y--;
                }
                
            }

            else
            {
                for (int i = 1; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        temp = ans[j, y + i];
                        ans[j, y + i] = ans[j, y + i + 1];
                        ans[j, y + i + 1] = temp;
                    }

                    y = 4;
                }

                x = 0; y = 8;

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        temp = ans[j,x];
                        ans[j,x] = ans[j,y];
                        ans[j,y] = temp;
            
                    }
                    x++; y--;
                }
            }
        }


    }
}
