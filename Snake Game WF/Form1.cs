﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game_WF
{
    public partial class Form1 : Form
    {
        int cols = 50, rows = 25, score = 0, dx = 0, dy = 0, front = 0, back = 0;
        Piece[] snake = new Piece[1250];
        List<int> available = new List<int>();
        bool[,] visit;

        Random rand = new Random();
        Timer timer = new Timer();


        public Form1()
        {
            InitializeComponent();
            initial();
        }

        private void initial()
        {
            visit = new bool[rows, cols];
            Piece head = new Piece((rand.Next() % cols) * 20, (rand.Next() % rows) * 20);
            labelFood.Location = new Point((rand.Next() % cols) * 20, (rand.Next() % rows) * 20);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    visit[i, j] = false;
                    available.Add(i * cols + j);
                }
            }

            visit[head.Location.Y / 20, head.Location.X / 20] = true;
            available.Remove(head.Location.Y / 20 * cols + head.Location.X / 20);
            Controls.Add(head);
            snake[front] = head;
        }
    }
}
