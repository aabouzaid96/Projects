using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubyWindows
{


   

    public partial class Form1 : Form
    {
        public int Row = 0, Col = 0;
        public Form1()
        {
            InitializeComponent();
           
        
        }


        class node
        {
            public int x, y;
        }       

        string strCurrentColor;
        Button btn;
        private void button1_Click(object sender, EventArgs e)
        {
            panelBtns.Controls.Clear();

            Row = int.Parse(txtrow.Text);
            Col = int.Parse(txtcol.Text);

           // Button[,] btnarray = new Button[Col,Row];
            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Col;j++ )
                {
                    btn = new Button();
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.BackColor = Color.White;
                    btn.Left = 10 + ((i) * 30);
                    btn.Top = 10 + ((j) * 30);
                    btn.Name = j.ToString() +"_"+ i.ToString();

                    panelBtns.Controls.Add(btn);

                    btn.Click += new EventHandler(btn_Click);

                   }
        }

        string btnName;
        bool green = false, red = true;
        void btn_Click(object sender, EventArgs e)
        {

            label6.Controls.Clear();
            Button b = sender as Button;

            label6.Text =   b.Name.ToString();
            
            if (strCurrentColor == "green")
            {

                foreach (Button btn in this.panelBtns.Controls)
                {
                    if (btn.BackColor == Color.Green)
                    {
                        btn.BackColor = Color.White;
                        
                    }
                }

                (sender as Button).BackColor = Color.Green;
                
            }
            else if (strCurrentColor == "red")
            {
                foreach (Button btn in this.panelBtns.Controls)
                {
                    if (btn.BackColor == Color.Red)
                        btn.BackColor = Color.White;
                }
                (sender as Button).BackColor = Color.Red;
            }

            else if (strCurrentColor == "wall")
                (sender as Button).BackColor = Color.Brown;
            else if (strCurrentColor == "clearCell")
                (sender as Button).BackColor = Color.White;
            
        }

       

      

        
        // algorithm Container
        char[,] arr = new char[100, 100];
        int x, y;
        int s_i, s_j, e_i, e_j;
        
        Queue<node> Q = new Queue<node>();
        bool[,] vis = new bool[100, 100];
        Dictionary<node, node> Parent = new Dictionary<node, node>();

        int[] dx = new int[] { -1, 0, 1, 0 , -1, 1, 1, -1 };   // row
        int[] dy = new int[] { 0, -1, 0, 1 , -1, -1, 1, 1 };     // col
        bool ok = false; 
           
        
        private void button7_Click(object sender, EventArgs e)
        {

            //panelArr.Controls.Clear();
            //button7.BackColor = Color.Yellow;
            Row = int.Parse(txtrow.Text);
            Col = int.Parse(txtcol.Text);


            foreach (Button btn in panelBtns.Controls)
            {
                string[] subarray = btn.Name.Split('_');
                if (btn.BackColor == Color.Green)
                {
                    s_i = int.Parse(subarray[0].ToString());
                    s_j = int.Parse(subarray[1].ToString());

                    arr[s_i, s_j] = 'S';
                }
                else if (btn.BackColor == Color.Red)
                {
                    e_i = int.Parse(subarray[0].ToString());
                    e_j = int.Parse(subarray[1].ToString());

                    arr[e_i, e_j] = 'E';
                }
                else if (btn.BackColor == Color.Brown)
                {
                    x = int.Parse(subarray[0].ToString());
                    y = int.Parse(subarray[1].ToString());

                    arr[x, y] = '#';
                }
                else
                {
                    x = int.Parse(subarray[0].ToString());
                    y = int.Parse(subarray[1].ToString());

                    arr[x, y] = '.';
                }
            }
            //  Start the Algorithm 

            //Q.Clear();
            //Parent.Clear();
            node cur = new node();
            cur.x = s_i; cur.y = s_j;
            Q.Enqueue(cur);
            int s = Q.Count();
             ok = false;
            vis[s_i, s_j] = true;
            while (!ok && Q.Count() != 0)
            {
                cur = Q.Dequeue();

                for (int i = 0; i < 8; i++)
                {
                    node temp = new node();
                    temp.x = cur.x + dx[i];
                    temp.y = cur.y + dy[i];
                    if (temp.x < 0 || temp.x >= Col || temp.y < 0 || temp.y >= Row || vis[temp.x, temp.y] == true || arr[temp.x, temp.y] == '#') continue;

                    Parent.Add(temp, cur);
                    if (temp.x == e_i && temp.y == e_j) { ok = true; break; }
                    vis[temp.x, temp.y] = true;
                    Q.Enqueue(temp);

                }
            
            }
            if (ok != false)
            {

                node t1 = new node();
                node t2 = new node();

                foreach (KeyValuePair<node, node> myvaluepair in Parent)
                {
                    if (myvaluepair.Key.x == e_i && myvaluepair.Key.y == e_j)
                    { t1 = myvaluepair.Key; break; }
                }

                t2 = Parent[t1];
                int path = 0;
                while (!(t2.x == s_i && t2.y == s_j))
                {

                    foreach (Button btn in panelBtns.Controls)
                    {
                        string path_t = t2.x.ToString() + "_" + t2.y.ToString();
                        if (btn.Name == path_t)
                        {
                            btn.BackColor = Color.Aqua;
                            break;
                        }
                    }
                    path++;
                    arr[t2.x, t2.y] = '*';
                    t1 = t2;
                    t2 = Parent[t1];

                }
                label5.Text = "The Shortest Path =" + path;
            }
            else
            {
                label5.Text = "No Path";
           
            }
            

        }

        private void start_Click(object sender, EventArgs e)
        {
            strCurrentColor = "green";
        }

        private void end_Click(object sender, EventArgs e)
        {
            strCurrentColor = "red";
        }

        private void wall_Click(object sender, EventArgs e)
        {
            strCurrentColor = "wall";
        }

        private void C_wall_Click(object sender, EventArgs e)
        {
            strCurrentColor = "clearCell";
        }

        private void AC_Click(object sender, EventArgs e)
        {
            foreach(Button btn in panelBtns.Controls)
            btn.BackColor = Color.White;
            Q.Clear();
            Parent.Clear();
            ok = false;
           for(int i=0;i<Row;i++)
               for (int j = 0; j < Col; j++)
               {
                   vis[i,j] = false;
                   arr[i, j] = '.';
               }
        }

      

        private void button2_Click_1(object sender, EventArgs e)
        {
            Parent.Clear();
            Q.Clear();
            ok = false;
            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Col; j++)
                {
                    vis[i, j] = false;
                    arr[i, j] = '.';
                }
            foreach (Button btn in panelBtns.Controls)
                if (btn.BackColor == Color.Aqua)
                    btn.BackColor = Color.White; 
        }

    }
}
