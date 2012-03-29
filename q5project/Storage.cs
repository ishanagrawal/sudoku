using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace q5project
{
    class Storage
    {
        StreamReader sr;
        FileStream fs;
        StreamWriter sw;
        public Storage()
        {

        }
        public void save(TextBox[,] txtar, int[,] save, int var)
        {
            fs = new FileStream(Directory.GetCurrentDirectory() + "\\Save.txt", FileMode.Create, FileAccess.Write);
            sw = new StreamWriter(fs);

            //variation so that coloring can be found out
            sw.WriteLine(var);

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    //the value in box, 0 for blank
                    if (txtar[i, j].Text.Equals(""))
                        sw.WriteLine("0");
                    else
                        sw.WriteLine(txtar[i, j].Text + "");

                    //for the readonly values
                    if (txtar[i, j].ReadOnly == true)
                        sw.WriteLine("1");
                    else
                        sw.WriteLine("0");
                }
                //sw.WriteLine();
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sw.WriteLine(save[i, j]);
                }
            }
            sw.Close();
            fs.Close();

        }

        public void load(TextBox[,] txtar, int[,] save, SudokuManager objGrid)
        {
            fs = new FileStream(Directory.GetCurrentDirectory() + "\\Save.txt", FileMode.Open, FileAccess.Read);
            sr = new StreamReader(fs);
            objGrid.changeGrid(txtar, int.Parse(sr.ReadLine()));
            String s;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    s = sr.ReadLine();
                    if (!s.Equals("0"))
                    {
                        txtar[i, j].Text = s;
                        if (sr.ReadLine().Equals("1"))
                        {
                            txtar[i, j].ForeColor = System.Drawing.Color.DarkBlue;
                            txtar[i, j].ReadOnly = true;
                        }
                    }
                    else
                        sr.ReadLine();
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    save[i, j] = int.Parse(sr.ReadLine());
                }
            }


            sr.Close();
            fs.Close();

        }

    }
}
