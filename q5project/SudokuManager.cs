using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace q5project
{
    class SudokuManager
    {
        
        int[,] ans ={ { 5, 6, 4, 7, 3, 8, 2, 9, 1 }, { 7, 3, 8, 9, 2, 1, 6, 5, 4 }, { 9, 2, 1, 6, 5, 4, 8, 7, 3 }, { 8, 9, 7, 5, 6, 3, 4, 1, 2 }, { 6, 5, 3, 4, 1, 2, 9, 8, 7 }, { 4, 1, 2, 8, 9, 7, 5, 3, 6, }, { 3, 8, 9, 2, 7, 6, 1, 4, 5, }, { 2, 7, 5, 1, 4, 9, 3, 6, 8 }, { 1, 4, 6, 3, 8, 5, 7, 2, 9 } };
        int[,] ansx = { { 7, 1, 6, 2, 8, 4, 5, 9, 3 }, { 4, 5, 9, 3, 1, 6, 7, 2, 8 }, { 8, 2, 3, 5, 7, 9, 4, 6, 1 }, { 5, 4, 2, 8, 3, 7, 6, 1, 9 }, { 6, 3, 8, 4, 9, 1, 2, 7, 5 }, { 9, 7, 1, 6, 5, 2, 3, 8, 4 }, { 2, 6, 5, 9, 4, 8, 1, 3, 7 }, { 3, 8, 7, 1, 6, 5, 9, 4, 2 }, { 1, 9, 4, 7, 2, 3, 8, 5, 6 } };
        int[,] ansC = { { 2, 3, 5, 4, 6, 1, 7, 8, 9 }, { 6, 4, 7, 2, 9, 8, 1, 3, 5 }, { 8, 9, 1, 3, 5, 7, 2, 4, 6 }, { 3, 2, 4, 5, 8, 6, 9, 1, 7 }, { 5, 1, 8, 9, 7, 2, 3, 6, 4 }, { 7, 6, 9, 1, 3, 4, 5, 2, 8 }, { 1, 5, 2, 6, 4, 9, 8, 7, 3 }, { 9, 8, 6, 7, 2, 3, 4, 5, 1 }, { 4, 7, 3, 8, 1, 5, 6, 9, 2 } };
        int[,] ans4 ={ { 4, 8, 9, 3, 1, 2, 6, 7, 5 }, { 5, 2, 7, 4, 8, 6, 1, 3, 9 }, { 6, 3, 1, 9, 7, 5, 2, 8, 4 }, { 1, 6, 8, 5, 3, 7, 9, 4, 2 }, { 2, 7, 5, 6, 9, 4, 8, 1, 3 }, { 9, 4, 3, 8, 2, 1, 7, 5, 6 }, { 3, 9, 2, 7, 5, 8, 4, 6, 1 }, { 7, 5, 6, 1, 4, 9, 3, 2, 8 }, { 8, 1, 4, 2, 6, 3, 5, 9, 7 } };
        int[,] save = new int[9, 9];
        ToolTip tt = new ToolTip();
        int var;

        public SudokuManager()
        {
            
        }
        public void setPuzzle()
        {
            switch (var)
            {
                case 0:
                    save = ans;
                    break;
                case 1:
                    save = ansx;
                    break;
                case 2:
                    save = ansC;
                    break;
                case 3:
                    save = ans4;
                    break;
            }
        }
        public void create(TextBox[,] txtar, ComboBox cmb_level, int variation, SudokuManager objGrid, Label lblPencilMark)
        {
            sudokugrid obj = new sudokugrid();
            var = variation;
            setPuzzle();
            obj.generate(txtar, save, cmb_level, variation, objGrid, lblPencilMark);

        }
        public void savegrid(TextBox[,] txtar)
        {
            Storage obj = new Storage();
            obj.save(txtar, save, var);
        }
        public void loadgrid(TextBox[,] txtar, SudokuManager objGrid)
        {
            Storage obj = new Storage();
            obj.load(txtar, save, objGrid);
        }
        public void check(TextBox[,] txtar)
        {
            Features obj = new Features();
            obj.check(txtar, save, var);
           
        }

        public void submit(TextBox[,] txtar)
        {
            Features obj = new Features();
            if (obj.check(txtar, save, var))
            {
                for (int i = 1000; i <= 6000; i = i + 1000)
                    System.Console.Beep(i, 100);
                for (int i = 6000; i >= 1000; i = i - 1000)
                    System.Console.Beep(i, 100);
                MessageBox.Show("Congratulations!!! You won the game!!!");
            }
            else
            {
                for (int i = 1000; i <= 6000; i = i + 1000)
                    System.Console.Beep(i, 100);
                for (int i = 6000; i >= 1000; i = i - 1000)
                    System.Console.Beep(i, 100);
                MessageBox.Show("You lose the game. Better luck next time!!!");
            }
        }

        public void cheat(TextBox[,] txtar)
        {

            Features obj = new Features();
            obj.hint(txtar, save);
            
        }
        public void showans(TextBox[,] txtar)
        {
            Features obj = new Features();
            obj.showanswer(txtar, save);
           
        }
        public void changeGrid(TextBox[,] txtar, int var)
        {
            Form1 tryobj = new Form1(); 
            tryobj.changeBackground(txtar, var);
            
        }
        public void pencilMarking(TextBox[,] txtar, Label lblPencilMark)
        {
            Features obj = new Features();
            switch (var)
            {
                case 0:
                    obj.pencilMarking(txtar, lblPencilMark, tt);
                    break;
                case 1:
                    obj.pencilMarkingX(txtar, lblPencilMark, tt);
                    break;
                case 2:
                    obj.pencilMarkingC(txtar, lblPencilMark, tt);
                    break;
                case 3:
                    obj.pencilMarking4(txtar, lblPencilMark, tt);
                    break;
                
            }
        }
        public void pencilMarkReset()
        {
            Features obj = new Features();
            obj.toolTipReset(tt);
        }

    }
}
