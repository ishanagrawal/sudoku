using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Design;


namespace q5project
{
    public partial class Form1 : Form
    {
        
        TextBox[,] txtar = new TextBox[9, 9];  // Array of Five TextBox object variables.
        int seconds;

        //sudokugrid obj = new sudokugrid();
        SudokuManager obj = new SudokuManager();
        public Form1()
        {
            InitializeComponent();

            seconds = 0;
            

            txtar[0, 0] = txt00;
            txtar[0, 1] = txt01;
            txtar[0, 2] = txt02;
            txtar[0, 3] = txt03;
            txtar[0, 4] = txt04;
            txtar[0, 5] = txt05;
            txtar[0, 6] = txt06;
            txtar[0, 7] = txt07;
            txtar[0, 8] = txt08;
            txtar[1, 0] = txt10;
            txtar[1, 1] = txt11;
            txtar[1, 2] = txt12;
            txtar[1, 3] = txt13;
            txtar[1, 4] = txt14;
            txtar[1, 5] = txt15;
            txtar[1, 6] = txt16;
            txtar[1, 7] = txt17;
            txtar[1, 8] = txt18;
            txtar[2, 0] = txt20;
            txtar[2, 1] = txt21;
            txtar[2, 2] = txt22;
            txtar[2, 3] = txt23;
            txtar[2, 4] = txt24;
            txtar[2, 5] = txt25;
            txtar[2, 6] = txt26;
            txtar[2, 7] = txt27;
            txtar[2, 8] = txt28;
            txtar[3, 0] = txt30;
            txtar[3, 1] = txt31;
            txtar[3, 2] = txt32;
            txtar[3, 3] = txt33;
            txtar[3, 4] = txt34;
            txtar[3, 5] = txt35;
            txtar[3, 6] = txt36;
            txtar[3, 7] = txt37;
            txtar[3, 8] = txt38;
            txtar[4, 0] = txt40;
            txtar[4, 1] = txt41;
            txtar[4, 2] = txt42;
            txtar[4, 3] = txt43;
            txtar[4, 4] = txt44;
            txtar[4, 5] = txt45;
            txtar[4, 6] = txt46;
            txtar[4, 7] = txt47;
            txtar[4, 8] = txt48;
            txtar[5, 0] = txt50;
            txtar[5, 1] = txt51;
            txtar[5, 2] = txt52;
            txtar[5, 3] = txt53;
            txtar[5, 4] = txt54;
            txtar[5, 5] = txt55;
            txtar[5, 6] = txt56;
            txtar[5, 7] = txt57;
            txtar[5, 8] = txt58;
            txtar[6, 0] = txt60;
            txtar[6, 1] = txt61;
            txtar[6, 2] = txt62;
            txtar[6, 3] = txt63;
            txtar[6, 4] = txt64;
            txtar[6, 5] = txt65;
            txtar[6, 6] = txt66;
            txtar[6, 7] = txt67;
            txtar[6, 8] = txt68;
            txtar[7, 0] = txt70;
            txtar[7, 1] = txt71;
            txtar[7, 2] = txt72;
            txtar[7, 3] = txt73;
            txtar[7, 4] = txt74;
            txtar[7, 5] = txt75;
            txtar[7, 6] = txt76;
            txtar[7, 7] = txt77;
            txtar[7, 8] = txt78;
            txtar[8, 0] = txt80;
            txtar[8, 1] = txt81;
            txtar[8, 2] = txt82;
            txtar[8, 3] = txt83;
            txtar[8, 4] = txt84;
            txtar[8, 5] = txt85;
            txtar[8, 6] = txt86;
            txtar[8, 7] = txt87;
            txtar[8, 8] = txt88;
        }
        //sudokugrid obj = new sudokugrid();
       
        #region sudokugrid
        /*
        public void generate()
        {
            //clear obj=new clear();
            settimezero();
            clearall();
            swap();
            int diff;
            diff = difficulty();

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
                txtar[r, s].BackColor = System.Drawing.Color.LightYellow;
            }
        }


        public int difficulty()
        {
            int diff = 60;
            switch (cmb_level.SelectedIndex)
            {
                case 0: diff = 60;
                    break;
                case 1: diff = 40;
                    break;
                case 2: diff = 23;
                    break;
            }
            return diff;
        }

        public void clearall()
        {

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    txtar[i, j].Text = "";
                    txtar[i, j].ReadOnly = false;
                    txtar[i, j].MaxLength = 1;
                    txtar[i, j].BackColor = System.Drawing.Color.White;

                }
            }

        }

        public void swap()
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

        */
        #endregion 
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void txt00_TextChanged(object sender, EventArgs e)
        {
            lblmsg.Text = "Have a good game!!";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (txtar[i, j].Focused && !txtar[i,j].Text.Equals(""))
                    {
                        if (!(char.Parse(txtar[i, j].Text) > 48 && char.Parse(txtar[i, j].Text) < 58))
                        {
                            MessageBox.Show("Please enter only 1-9 digits!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtar[i, j].Text = "";
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
           
            WindowState = FormWindowState.Maximized;
            for (int i = 1000; i <= 6000; i = i + 1000)
                System.Console.Beep(i, 100);
            this.cmb_level.SelectedIndex = 0;

            pencilMarkReset();
            obj.create(txtar,cmb_level,0, obj, lblPencilMark);
            settimezero();
            
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            pencilMarkReset();
            obj.create(txtar,cmb_level,0,obj, lblPencilMark);
            settimezero();
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            obj.savegrid(txtar);
            lblmsg.Text = "";
            lblmsg.Text = "Game saved successfully!!";
        }

        private void btnload_Click(object sender, EventArgs e)
        {
           
            obj.loadgrid(txtar, obj);
            lblmsg.Text = "";
            lblmsg.Text = "Game loaded successfully!!";
        }

        private void btnchk_Click(object sender, EventArgs e)
        {

            obj.check(txtar);
        }

        private void btnhint_Click(object sender, EventArgs e)
        {
            obj.cheat(txtar);
        }

        public void settimezero()
        {
            seconds = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = "Time: " + seconds + " sec";
            seconds++;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            pencilMarkReset();
            obj.showans(txtar);
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            pencilMarkReset();
            pencilMarkReset();
            obj.create(txtar, cmb_level, 1, obj, lblPencilMark);
            settimezero();
            
        }

        //Sudoku
        private void sudokuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pencilMarkReset();
            obj.create(txtar, cmb_level, 0, obj, lblPencilMark);
            settimezero();
        }

        //SudokuX
        private void XdokuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.create(txtar, cmb_level, 1, obj, lblPencilMark);
            settimezero();
        }

        public void changeBackground(TextBox[,] txtar, int var)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    txtar[i, j].Text = "";
                    txtar[i, j].ReadOnly = false;
                    txtar[i, j].MaxLength = 1;
                    txtar[i, j].ForeColor = System.Drawing.Color.Black;

                    txtar[i, j].BackColor = System.Drawing.Color.White;
                    if ((j > 2 && j < 6 || i > 2 && i < 6) && !(j > 2 && j < 6 && i > 2 && i < 6) && var!=3)
                    {
                        txtar[i, j].BackColor = System.Drawing.Color.LightSkyBlue;
                    }
                    else
                        txtar[i, j].BackColor = System.Drawing.Color.White;
                    if (var == 1 && (i == j || i + j == 8))
                        txtar[i, j].BackColor = System.Drawing.Color.Aqua;
                    if (var == 2 && (i == 1 || i == 4 || i == 7) && (j == 1 || j == 4 || j == 7))
                        txtar[i, j].BackColor = System.Drawing.Color.Aqua;
                    if (var == 3 && (i != 0 && j != 0 && i != 4 && j != 4 && i != 8 && j != 8))
                        txtar[i, j].BackColor = System.Drawing.Color.LightSkyBlue;
                }
            }

        }

        private void pencilMarkReset()
        {
            if (lblPencilMark.Visible == true)
            {
                btnPencilM.Text = "Show Pencil Marking";
                lblPencilMark.Visible = false;
            }
            
        }

        private void btnPencilM_Click(object sender, EventArgs e)
        {
            if (lblPencilMark.Visible == true)
            {
                btnPencilM.Text = "Show Pencil Marking";
                lblPencilMark.Visible = false;
            }
            else
            {
                btnPencilM.Text = "Hide Pencil Marking";
                lblPencilMark.Visible = true;
            }
        }

        private void txt00_Enter(object sender, EventArgs e)
        {
            obj.pencilMarking(txtar,lblPencilMark);
            
        }

        private void cdokuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pencilMarkReset();
            obj.create(txtar, cmb_level, 2, obj, lblPencilMark);
            settimezero();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pencilMarkReset();
            obj.create(txtar, cmb_level, 3, obj, lblPencilMark);
            settimezero();
        }



        private void TableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Point currentPoint = new Point(90, 90);
            Size size = new Size(150, 150);
            Pen myPen = new Pen(Color.LightBlue, 7);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    currentPoint.X = i * 150;
                    currentPoint.Y = j * 150;
                    Rectangle rect = new Rectangle(currentPoint, size);
                    gfx.DrawRectangle(myPen, rect);

                }
            }
        }

        private void cheatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.cheat(txtar);
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.check(txtar);
        }

        private void showAnswerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.showans(txtar);
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sudoku# \n\n\nThe objective of the game is to fill all the blank squares in a game with the correct numbers. There are three very simple constraints to follow. In a 9 by 9 square Sudoku game: \n•  Every row of 9 numbers must include all digits 1 through 9 in any order\n•  Every column of 9 numbers must include all digits 1 through 9 in any order\n•  Every 3 by 3 subsection of the 9 by 9 square must include all digits 1 through 9\n\nXdoku\nFill in the grid so that every row, every column, every 3x3 box and the diagonals contain the digits 1 through 9.\n\nCdoku\nFill in the grid so that every row, every column, every 3x3 box and the cyan cells contain the digits 1 through 9.\n\n4doku\nFill in the grid so that every row, every column, and every 3x3 box contains the digits 1 through 9. The colored extra-regions must contain each the digits 1 through 9.\n \n \n \n Version 0.2.0", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This has been developed by Q5 team \n\n\nPlease mail me any suggestions you have to improve the product at ishan.agrawal90@gmail.com \n \n \n Version 0.2.0" , "About Sudoku#",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_newC_Click(object sender, EventArgs e)
        {
            pencilMarkReset();
            obj.create(txtar, cmb_level, 2, obj, lblPencilMark);
            settimezero();
        }

        private void btn_new4_Click(object sender, EventArgs e)
        {
            pencilMarkReset();
            obj.create(txtar, cmb_level, 3, obj, lblPencilMark);
            settimezero();
        }

        private void txt00_Leave(object sender, EventArgs e)
        {
            obj.pencilMarkReset();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            obj.submit(txtar);
        }

    }
}