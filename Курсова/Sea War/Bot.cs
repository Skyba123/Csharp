using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Sea_War
{
    public class Bot
    {
        private int[,] myMap;
        private int[,] enemyMap;
        private Button[,] myButtons;
        private Button[,] enemyButtons;
        private Random random;

        public Bot(int[,] myMap, int[,] enemyMap, Button[,] myButtons, Button[,] enemyButtons)
        {
            this.myMap = myMap;
            this.enemyMap = enemyMap;
            this.myButtons = myButtons;
            this.enemyButtons = enemyButtons;
            random = new Random();
        }

        private bool IsInsideMap(int i, int j)
        {
            return i >= 0 && i < Form1.mapSize && j >= 0 && j < Form1.mapSize;
        }

        private bool IsEmpty(int i, int j, int length, bool isHorizontal)
        {
            if (isHorizontal)
            {
                for (int k = j; k < j + length; k++)
                {
                    if (!IsInsideMap(i, k) || myMap[i, k] != 0)
                        return false;
                }
            }
            else
            {
                for (int k = i; k < i + length; k++)
                {
                    if (!IsInsideMap(k, j) || myMap[k, j] != 0)
                        return false;
                }
            }

            return true;
        }

        private bool IsNeighboringCellEmpty(int i, int j)
        {
            for (int x = i - 1; x <= i + 1; x++)
            {
                for (int y = j - 1; y <= j + 1; y++)
                {
                    if (IsInsideMap(x, y) && myMap[x, y] != 0)
                        return false;
                }
            }

            return true;
        }

        public int[,] ConfigureShips()
        {
            int[] shipLengths = { 4, 3, 3, 2, 2, 2, 1, 1, 1, 1 };

            foreach (int length in shipLengths)
            {
                bool isShipPlaced = false;

                while (!isShipPlaced)
                {
                    int x = random.Next(0, Form1.mapSize);
                    int y = random.Next(0, Form1.mapSize);
                    bool isHorizontal = random.Next(2) == 0;

                    if (isHorizontal)
                    {
                        if (IsEmpty(x, y, length, true) && IsNeighboringCellEmpty(x, y - 1) && IsNeighboringCellEmpty(x, y + length))
                        {
                            for (int k = y; k < y + length; k++)
                            {
                                myMap[x, k] = 1;
                            }

                            isShipPlaced = true;
                        }
                    }
                    else
                    {
                        if (IsEmpty(x, y, length, false) && IsNeighboringCellEmpty(x - 1, y) && IsNeighboringCellEmpty(x + length, y))
                        {
                            for (int k = x; k < x + length; k++)
                            {
                                myMap[k, y] = 1;
                            }

                            isShipPlaced = true;
                        }
                    }
                }
            }

            return myMap;
        }

        public bool Shoot()
        {
            int x, y;
            bool hit;

            do
            {
                x = random.Next(0, Form1.mapSize);
                y = random.Next(0, Form1.mapSize);
            } while (enemyButtons[x, y].BackColor == Color.Red || enemyButtons[x, y].BackColor == Color.Blue
                     || enemyButtons[x, y].BackColor == Color.Gray); 

            if (enemyMap[x, y] != 0)
            {
                hit = true;
                enemyMap[x, y] = 0;
                enemyButtons[x, y].BackColor = Color.Red;
                enemyButtons[x, y].Text = "X";
            }
            else
            {
                hit = false;
                enemyButtons[x, y].BackColor = Color.Blue;
            }

            if (hit)
                Shoot();

            return hit;
        }
    }
}
