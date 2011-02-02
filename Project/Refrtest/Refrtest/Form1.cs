using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PG;
using SoundProcessing;
namespace Refrtest
{
    public partial class Form1 : Form
    {
        static FrequencyMod[] FM ={ new FrequencyMod(0.5f, 128), 
                             new FrequencyMod(0.4f, 256),
                             new FrequencyMod(0.5f,512), 
                             new FrequencyMod(0.4f,1024),
                             new FrequencyMod(0.4f,2048), 
                             new FrequencyMod(0.3f,4096),
                             new FrequencyMod(0.5f, 100000)};
        
        static Modifier m = new Modifier(0, FM);
        List<BTreeNode<Wave>> AAA;
        Polygon room = new Polygon(new List<PG.Point>(), m);
        List<Polygon> polygons = new List<Polygon>();
        List<Sourse> sourses = new List<Sourse>();
        int k = 0;
        int dx = 20;
        int dy = 400;
       /* ModifiersKnot[,] result;*/
    
        public Form1()
        {

           
            InitializeComponent();
            DoubleBuffered = true;
            room.mods.soundSpeed = 600f;
            room.Tops.Add(new PG.Point(0, 0));
            room.Tops.Add(new PG.Point(40, 0));
            room.Tops.Add(new PG.Point(40, 40));
            room.Tops.Add(new PG.Point(0, 40));
            Polygon p = new Polygon();

            p = new Polygon();
            p.Tops.Add(new PG.Point(10, 10));
            p.Tops.Add(new PG.Point(35, 10));
            p.Tops.Add(new PG.Point(35, 20));
            p.Tops.Add(new PG.Point(10, 35));

            p.mods = room.mods;
            polygons.Add(p);

            pX1.Text = p.Tops[0].x.ToString();
            pX2.Text = p.Tops[1].x.ToString();
            pX3.Text = p.Tops[2].x.ToString();
            pX4.Text = p.Tops[3].x.ToString();

            pY1.Text = p.Tops[0].y.ToString();
            pY2.Text = p.Tops[1].y.ToString();
            pY3.Text = p.Tops[2].y.ToString();
            pY4.Text = p.Tops[3].y.ToString();


            roomX1.Text = room.Tops[0].x.ToString();
            roomX2.Text = room.Tops[1].x.ToString();
            roomX3.Text = room.Tops[2].x.ToString();
            roomX4.Text = room.Tops[3].x.ToString();

            roomY1.Text = room.Tops[0].y.ToString();
            roomY2.Text = room.Tops[1].y.ToString();
            roomY3.Text = room.Tops[2].y.ToString();
            roomY4.Text = room.Tops[3].y.ToString();

            sourses.Add(new Sourse(new PG.Point(20, 5)));

            sX.Text = sourses[0].Coords.x.ToString();
            sY.Text = sourses[0].Coords.y.ToString();


            
            AAA = new List<BTreeNode<Wave>>();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int rayCount=0 ;
            int reflCount=0;
            try
            {
                Polygon p = new Polygon();
                p.Tops.Add(new PG.Point((float)Convert.ToDouble(pX1.Text), (float)Convert.ToDouble(pY1.Text)));
                p.Tops.Add(new PG.Point((float)Convert.ToDouble(pX2.Text), (float)Convert.ToDouble(pY2.Text)));
                p.Tops.Add(new PG.Point((float)Convert.ToDouble(pX3.Text), (float)Convert.ToDouble(pY3.Text)));
                p.Tops.Add(new PG.Point((float)Convert.ToDouble(pX4.Text), (float)Convert.ToDouble(pY4.Text)));
                p.mods = room.mods;
                polygons.Clear();
                polygons.Add(p);
                p = new Polygon();
                p.Tops.Add(new PG.Point((float)Convert.ToDouble(roomX1.Text), (float)Convert.ToDouble(roomY1.Text)));
                p.Tops.Add(new PG.Point((float)Convert.ToDouble(roomX2.Text), (float)Convert.ToDouble(roomY2.Text)));
                p.Tops.Add(new PG.Point((float)Convert.ToDouble(roomX3.Text), (float)Convert.ToDouble(roomY3.Text)));
                p.Tops.Add(new PG.Point((float)Convert.ToDouble(roomX4.Text), (float)Convert.ToDouble(roomY4.Text)));
                p.mods = polygons[0].mods;
                room = p;
                sourses.Clear();
                Sourse s = new Sourse(new PG.Point((float)Convert.ToDouble(sX.Text), (float)Convert.ToDouble(sY.Text)));
                sourses.Add(s);

                rayCount = Convert.ToInt16(RayCount.Text);
                reflCount = Convert.ToInt16(refl.Text);

            }
            catch { }

            AAA = Phisics.GetModifiersKnots(polygons, sourses, room, 1, 1, rayCount, 0.01f, reflCount);
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            

            float scale = 7;
            int nomb=0;
            try
            {
                nomb = Convert.ToInt16(textBox1.Text);
            }
               
            catch { }
            nomb=k;
            if (k > Convert.ToInt16(RayCount.Text))
                k = 0;
            for (int i = 0; i < room.Tops.Count; i++)
            {
                if (i != room.Tops.Count - 1)
                    e.Graphics.DrawLine(Pens.Black, scale * room.Tops[i].x + dx, scale * room.Tops[i].y + dy, scale * room.Tops[i + 1].x + dx, scale * room.Tops[i + 1].y + dy);
                else
                    e.Graphics.DrawLine(Pens.Black, scale * room.Tops[i].x + dx, scale * room.Tops[i].y + dy, scale * room.Tops[0].x + dx, scale * room.Tops[0].y + dy);
            }

            for (int i = 0; i < polygons.Count; i++)
                for (int j = 0; j < polygons[i].Tops.Count; j++)
                {
                    if (j != polygons[i].Tops.Count - 1)
                        e.Graphics.DrawLine(Pens.Black, scale * polygons[i].Tops[j].x + dx, scale * polygons[i].Tops[j].y + dy, scale * polygons[i].Tops[j + 1].x + dx, scale * polygons[i].Tops[j + 1].y + dy);
                    else
                        e.Graphics.DrawLine(Pens.Black, scale * polygons[i].Tops[0].x + dx, scale * polygons[i].Tops[0].y + dy, scale * polygons[i].Tops[j].x + dx, scale * polygons[i].Tops[j].y + dy);
                }
            for (int i = 0; i < sourses.Count; i++)
                e.Graphics.DrawEllipse(Pens.Red, scale * sourses[i].Coords.x - 5 + dx, scale * sourses[i].Coords.y - 5 + dy, 10, 10);
            try
            {
                Paint_Wave(sender, e, AAA[nomb], scale, Pens.Black);
            }
            catch { }

        }

        private void Paint_Wave(object sender, PaintEventArgs e, BTreeNode<Wave> A, float scale, Pen p)
        {
            if (A.L != null)
                Paint_Wave(sender, e, A.L,scale, Pens.Green);
            if(A.R!=null)
                Paint_Wave(sender, e, A.R, scale, Pens.Red);
            DrawWave(sender, e, A.Value, scale, p);
        }
        private void DrawWave(object sender, PaintEventArgs e, Wave A, float scale, Pen p)
        {
            if (A.end.x != 0 || A.end.y != 0)
                try
                {
                    
                    e.Graphics.DrawLine(p, scale * A.direct.nullP.x + dx, scale * A.direct.nullP.y + dy,
                                                  scale * A.end.x + dx, scale * A.end.y + dy);
                }
                catch { }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            k++;
            textBox1.Text = k.ToString();
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                k = Convert.ToInt16(textBox1.Text);
            }
            catch { }
            Refresh();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                timer1.Interval = Convert.ToInt16(textBox2.Text);
            }
            catch { }
        }     
    }
}
