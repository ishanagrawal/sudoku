using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace q5project
{
    class Features
    { 

        public Features()
        {

        }

        public bool check(TextBox[,] txtar, int[,] ans, int variation)
        {
            bool solved=true;
            int count = 0;
            bool error;

            //check algo
            int c1, c2;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    error = false;

                    //changing errors back to black
                    if (txtar[i, j].ForeColor == System.Drawing.Color.Red)
                    {
                        txtar[i, j].ForeColor = System.Drawing.Color.Black;
                    }

                    //check if all filled
                    if (!txtar[i, j].Text.Equals("") && txtar[i, j].ForeColor == System.Drawing.Color.Black)
                    {

                        //column and row
                        for (int k = 0; k < 9; k++)
                        {
                            if (txtar[k, j].Text.Equals(txtar[i, j].Text) && i!=k)
                            {
                                error = true;
                                //txtar[k, j].ForeColor = System.Drawing.Color.Red;
                                System.Console.Beep();
                                solved = false;
                            }
                            if (txtar[i, k].Text.Equals(txtar[i, j].Text) && j != k)
                            {
                                error = true;
                                //txtar[i, k].ForeColor = System.Drawing.Color.Red;
                                System.Console.Beep();
                                solved = false;
                            }
                        }
                        //cube
                        c1 = (i / 3) * 3;
                        c2 = (j / 3) * 3;
                        for (int a = c1; a <= c1 + 2; a++)
                            for (int b = c2; b <= c2 + 2; b++)
                            {
                                if (txtar[a, b].Text.Equals(txtar[i, j].Text) && i != a && j != b)
                                {
                                    error = true;
                                    //txtar[a, b].ForeColor = System.Drawing.Color.Red;
                                    System.Console.Beep();
                                    solved = false;
                                }
                            }
                        #region variation
                        switch (variation)
                        {

                            case 1:
                                if (i + j == 8)
                                {
                                    for (int k = 0; k < 9; k++)
                                        for (int f = 0; f < 9; f++)
                                        {
                                            if (k + f == 8)
                                                if (txtar[k, f].Text.Equals(txtar[i, j].Text) && i != k && j != f)
                                                {
                                                    error = true;
                                                    //txtar[k, f].ForeColor = System.Drawing.Color.Red;
                                                    System.Console.Beep();
                                                    solved = false;
                                                }
                                        }
                                }
                                if (i == j)
                                {
                                    for (int k = 0; k < 9; k++)
                                        for (int f = 0; f < 9; f++)
                                        {
                                            if (k == f)
                                                if (txtar[k, f].Text.Equals(txtar[i, j].Text) && i != k && j != f)
                                                {
                                                    error = true;
                                                    //txtar[k, f].ForeColor = System.Drawing.Color.Red;
                                                    System.Console.Beep();
                                                    solved = false;
                                                }
                                        }
                                }
                                break;
                            case 2:
                                if ((i == 1 || i == 4 || i == 7) && (j == 1 || j == 4 || j == 7))
                                {
                                    for (int k = 0; k < 9; k++)
                                        for (int f = 0; f < 9; f++)
                                        {
                                            if ((k == 1 || k == 4 || k == 7) && (f == 1 || f == 4 || f == 7))
                                                if (txtar[k, f].Text.Equals(txtar[i, j].Text) && i != k && j != f)
                                                {
                                                    error = true;
                                                    //txtar[k, f].ForeColor = System.Drawing.Color.Red;
                                                    System.Console.Beep();
                                                    solved = false;
                                                }
                                        }
                                }
                                break;
                            case 3:
                                if (i != 0 && j != 0 && i != 4 && j != 4 && i != 8 && j != 8)
                                {
                                    if(i>3)
                                        c1 = (i / 4) * 3 + 2;
                                    else
                                        c1 = (i / 4) * 3 + 1;
                                    if(j>3)
                                        c2 = (j / 4) * 3 + 2;
                                    else
                                        c2 = (j / 4) * 3 + 1;
                                    for (int a = c1; a <= c1 + 2; a++)
                                        for (int b = c2; b <= c2 + 2; b++)
                                        {
                                            if (txtar[a, b].Text.Equals(txtar[i, j].Text) && i != a && j != b)
                                            {
                                                error = true;
                                                System.Console.Beep();
                                                solved = false;
                                            }
                                        }
                                }
                                break;
                        }
                        #endregion
                    }
                    if(!txtar[i, j].Text.Equals(""))
                        count++;
                    if(error)
                        txtar[i, j].ForeColor = System.Drawing.Color.Red;
                }
            }
            if (count == 81 && solved)
                return true;
            else
                return false;
            //if (solved && count == 81)
            //{
            //    //for (int i = 1000; i <= 6000; i = i + 1000)
            //    //    System.Console.Beep(i, 100);
            //    //for (int i = 6000; i >= 1000; i = i - 1000)
            //    //    System.Console.Beep(i, 100);
            //    //MessageBox.Show("Congratulations!!! You won the game!!!");
            //    return true;

            //}
            //if (!solved && count == 81)
            //{
            //    //for (int i = 1000; i <= 6000; i = i + 1000)
            //    //    System.Console.Beep(i, 100);
            //    //for (int i = 6000; i >= 1000; i = i - 1000)
            //    //    System.Console.Beep(i, 100);
            //    //MessageBox.Show("You lose the game. Better luck next time!!!");
            //    return false;
            //}
            //return solved; ;

        }
        public void hint(TextBox[,] txtar, int[,] ans)
        {
            Random number;
            int seed;
            seed = DateTime.Now.Millisecond;
            number = new Random(seed);
            int r, s;
            r = number.Next(0, 9);
            s = number.Next(0, 9);
            while (!txtar[r, s].Text.Equals(""))
            {
                r = number.Next(0, 9);
                s = number.Next(0, 9);
            }
            txtar[r, s].Text = ans[r, s].ToString();
            txtar[r, s].ReadOnly = true;
            txtar[r, s].ForeColor = System.Drawing.Color.DarkBlue;
        }


        public void pencilMarking(TextBox[,] txtar, Label lblPencilMark, ToolTip tt)
        {
            string[] nine;
            string s = "";
            int c1, c2;

            lblPencilMark.Text = "";

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (txtar[i, j].ReadOnly == false)
                    {
                        nine = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                        if (txtar[i, j].Focused)
                        {
                            //column and row
                            for (int k = 0; k < 9; k++)
                                for (int h = 0; h < 9; h++)
                                {
                                    if (txtar[k, j].Text.Equals(nine[h]))
                                        nine[h] = "";
                                    if (txtar[i, k].Text.Equals(nine[h]))
                                        nine[h] = "";
                                }
                            //cube
                            c1 = (i / 3) * 3;
                            c2 = (j / 3) * 3;
                            for (int a = c1; a <= c1 + 2; a++)
                                for (int b = c2; b <= c2 + 2; b++)
                                {
                                    for (int h = 0; h < 9; h++)
                                        if (txtar[a, b].Text.Equals(nine[h]))
                                        {
                                            nine[h] = "";
                                        }
                                }

                            for (int k = 0; k < 9; k++)
                            {
                                lblPencilMark.Text += nine[k];
                                if (!nine[k].Equals(""))
                                    s += nine[k] + " ";
                            }
                            if(lblPencilMark.Visible)
                            {
                                tt.Active = true;
                                tt.SetToolTip(txtar[i, j], s);
                            }
                        }
                    }
                }
            }
        }

        public void pencilMarkingX(TextBox[,] txtar, Label lblPencilMark, ToolTip tt)
        {
            string[] nine;
            string s = "";
            int c1, c2;

            lblPencilMark.Text = "";

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (txtar[i, j].ReadOnly == false)
                    {
                        nine = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                        if (txtar[i, j].Focused)
                        {
                            //column and row
                            for (int k = 0; k < 9; k++)
                                for (int h = 0; h < 9; h++)
                                {
                                    if (txtar[k, j].Text.Equals(nine[h]))
                                        nine[h] = "";
                                    if (txtar[i, k].Text.Equals(nine[h]))
                                        nine[h] = "";
                                }

                            //cube
                            c1 = (i / 3) * 3;
                            c2 = (j / 3) * 3;
                            for (int a = c1; a <= c1 + 2; a++)
                                for (int b = c2; b <= c2 + 2; b++)
                                {
                                    for (int h = 0; h < 9; h++)
                                        if (txtar[a, b].Text.Equals(nine[h]))
                                            nine[h] = "";
                                }
                            //X
                            if (i == j)
                            {
                                for (int k = 0; k < 9; k++)
                                    for (int f = 0; f < 9; f++)
                                    {
                                        if (k == f)
                                            for (int h = 0; h < 9; h++)
                                                if (txtar[k, f].Text.Equals(nine[h]))
                                                    nine[h] = "";
                                    }
                            }
                            if (i + j == 8)
                            {
                                for (int k = 0; k < 9; k++)
                                    for (int f = 0; f < 9; f++)
                                    {
                                        if (k + f == 8)
                                            for (int h = 0; h < 9; h++)
                                                if (txtar[k, f].Text.Equals(nine[h]))
                                                    nine[h] = "";
                                    }
                            }

                            for (int k = 0; k < 9; k++)
                            {
                                lblPencilMark.Text += nine[k];
                                if (!nine[k].Equals(""))
                                    s += nine[k] + " ";
                            }
                            if (lblPencilMark.Visible)
                            {
                                tt.Active = true;
                                tt.SetToolTip(txtar[i, j], s);
                            }
                        }
                    }
                }
            }
        }

        public void pencilMarkingC(TextBox[,] txtar, Label lblPencilMark, ToolTip tt)
        {
            string[] nine;
            string s = "";
            int c1, c2;

            lblPencilMark.Text = "";

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (txtar[i, j].ReadOnly == false)
                    {
                        nine = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                        if (txtar[i, j].Focused)
                        {
                            //column and row
                            for (int k = 0; k < 9; k++)
                                for (int h = 0; h < 9; h++)
                                {
                                    if (txtar[k, j].Text.Equals(nine[h]))
                                        nine[h] = "";
                                    if (txtar[i, k].Text.Equals(nine[h]))
                                        nine[h] = "";
                                }

                            //cube
                            c1 = (i / 3) * 3;
                            c2 = (j / 3) * 3;
                            for (int a = c1; a <= c1 + 2; a++)
                                for (int b = c2; b <= c2 + 2; b++)
                                {
                                    for (int h = 0; h < 9; h++)
                                        if (txtar[a, b].Text.Equals(nine[h]))
                                            nine[h] = "";
                                }
                            //C
                            if ((i == 1 || i == 4 || i == 7) && (j == 1 || j == 4 || j == 7))
                            {
                                for (int k = 0; k < 9; k++)
                                    for (int f = 0; f < 9; f++)
                                    {
                                        if ((k == 1 || k == 4 || k == 7) && (f == 1 || f == 4 || f == 7))
                                            for (int h = 0; h < 9; h++)
                                                if (txtar[k, f].Text.Equals(nine[h]))
                                                    nine[h] = "";
                                    }
                            }

                            for (int k = 0; k < 9; k++)
                            {
                                lblPencilMark.Text += nine[k];
                                if (!nine[k].Equals(""))
                                    s += nine[k] + " "; 
                            }
                            if (lblPencilMark.Visible)
                            {
                                tt.Active = true;
                                tt.SetToolTip(txtar[i, j], s);
                            }
                        }
                    }
                }
            }
        }

        public void pencilMarking4(TextBox[,] txtar, Label lblPencilMark, ToolTip tt)
        {
            string[] nine;
            string s = "";
            int c1, c2;
          
            lblPencilMark.Text = "";

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (txtar[i, j].ReadOnly == false)
                    {
                        nine = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                        if (txtar[i, j].Focused)
                        {
                            //column and row
                            for (int k = 0; k < 9; k++)
                                for (int h = 0; h < 9; h++)
                                {
                                    if (txtar[k, j].Text.Equals(nine[h]))
                                        nine[h] = "";
                                    if (txtar[i, k].Text.Equals(nine[h]))
                                        nine[h] = "";
                                }

                            //cube
                            c1 = (i / 3) * 3;
                            c2 = (j / 3) * 3;
                            for (int a = c1; a <= c1 + 2; a++)
                                for (int b = c2; b <= c2 + 2; b++)
                                {
                                    for (int h = 0; h < 9; h++)
                                        if (txtar[a, b].Text.Equals(nine[h]))
                                            nine[h] = "";
                                }
                            //4
                            if (i != 0 && j != 0 && i != 4 && j != 4 && i != 8 && j != 8)
                            {
                                if (i > 3)
                                    c1 = (i / 4) * 3 + 2;
                                else
                                    c1 = (i / 4) * 3 + 1;
                                if (j > 3)
                                    c2 = (j / 4) * 3 + 2;
                                else
                                    c2 = (j / 4) * 3 + 1;
                                for (int a = c1; a <= c1 + 2; a++)
                                    for (int b = c2; b <= c2 + 2; b++)
                                    {
                                            for (int h = 0; h < 9; h++)
                                                if (txtar[a, b].Text.Equals(nine[h]))
                                                    nine[h] = "";
                                    }
                            }

                            for (int k = 0; k < 9; k++)
                            {
                                lblPencilMark.Text += nine[k];
                                if(!nine[k].Equals(""))
                                    s += nine[k] + " ";
                            }
                            if (lblPencilMark.Visible)
                            {
                                
                                tt.Active = true;
                                tt.SetToolTip(txtar[i, j], s);
                            }
                        }
                    }
                }
            }
        }

        public void toolTipReset(ToolTip tt)
        {
            tt.RemoveAll();
        }


        public void showanswer(TextBox[,] txtar, int[,] ans)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                         txtar[i, j].Text=ans[i,j].ToString();
                         if (txtar[i, j].BackColor == System.Drawing.Color.Red)
                         {
                             txtar[i, j].BackColor = System.Drawing.Color.White;
                         }
                }
            }
            MessageBox.Show("You lose the game. Better luck next time!!!");
        }

    }
}
