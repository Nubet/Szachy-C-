using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szachy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }
        public void Tworzenie_szachownicy()
        {
                //Rysowanie szachownicy
                PictureBox[,] P;
                int n = 8;
                P = new PictureBox[n, n]; // 8x8 -< 64 czyli tyle ile pol ma szachownica
                int lewo = 2, gora = 2;
                for (int i = 0; i < n; i++){
                    lewo = 2;

                    for (int j = 0; j < n; j++)
                    {
                        P[i, j] = new PictureBox();


                        //Kolorowanie pol
                        if (i % 2 == 0)
                        { // jesli linia jest podzielna przez 2 to wtedy bialo,czarne,bialo,czarne,bialo,czarne,bialo,czarne,bialo,czarne,bialo,czarne,bialo,czarne,bialo,czarne ---> B C B C B C B C
                            if (j % 2 == 0) // jesli pozycja na szachownicy gora dzieli sie przez 2 to jest to czarne pole -> czyli co 2 pole
                                P[i, j].BackColor = Color.White;
                            else
                                P[i, j].BackColor = Color.SaddleBrown;
                        }
                        else
                        {
                            if (j % 2 == 0) // czarno,biale --->C B C B C B C B
                                P[i, j].BackColor = Color.SaddleBrown;
                            else
                                P[i, j].BackColor = Color.White;
                        }
                        //

                        P[i, j].Location = new Point(lewo, gora);
                        P[i, j].Size = new Size(90, 90);
                        P[i, j].Name = i + " " + j;
                        //Ustawianie figur Dla czarnych
                        if (i == 0)
                        {
                            if (j == 0 || j == 7)
                                P[i, j].Image = Properties.Resources.cW;
                            if (j == 1 || j == 6)
                                P[i, j].Image = Properties.Resources.cS;
                            if (j == 2 || j == 5)
                                P[i, j].Image = Properties.Resources.cG;
                            if (j == 3)
                                P[i, j].Image = Properties.Resources.cH;
                            if (j == 4)
                                P[i, j].Image = Properties.Resources.cK;
                        }
                        else if (i == 1)
                            P[i, j].Image = Properties.Resources.cP;

                        //Dla Bialych
                        if (i == 7)
                        {
                            if (j == 0 || j == 7)
                                P[i, j].Image = Properties.Resources.bW;
                            if (j == 1 || j == 6)
                                P[i, j].Image = Properties.Resources.bS;
                            if (j == 2 || j == 5)
                                P[i, j].Image = Properties.Resources.bG;
                            if (j == 3)
                                P[i, j].Image = Properties.Resources.bH;
                            if (j == 4)
                                P[i, j].Image = Properties.Resources.bK;
                        }
                        else if (i == 6)
                            P[i, j].Image = Properties.Resources.bP;

                        lewo = lewo + 90;

                        P[i, j].SizeMode = PictureBoxSizeMode.CenterImage;
                        P[i, j].Click +=(sender3, e3) =>
                        {
                            PictureBox p = sender3 as PictureBox;
                            if(p.Image != null)
                            {

                            }
                        };


                         szachownica.Controls.Add(P[i, j]);
                    }
                    gora = gora + 90;

                //Przy sprawdzaniu czy jest bicie wykorzystamy sprawdzenie czy P[i,j].Image != Null
                //Notatka 
                //Do poprawienia to iz wielkosc pol jest na sztywno powinno byc chyba, ze X pola = width_screen / board_Xboxes      | y pola, = wysokosc_okienka / boardYboxes
           

            }   
        
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Tworzenie_szachownicy();

            
        }


    }

   
}
