using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoundProcessing;

namespace PG
{
    public class Point
    {
        
        public float x;
        public float y;

        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(float xCoord, float yCoord)
        {
            x = xCoord;
            y = yCoord;
        }
    }


    public class Polygon
    {
        public List<Point> Tops;
        public Modifier mods;

        public Polygon()
        {
            Tops = new List<Point>();
        }
        public Polygon(List<Point> ListOfTops, Modifier md)
        {
            Tops = new List<Point>(ListOfTops);
            mods = md;
        }

        public float GetMinX()
        {
            float Min = float.PositiveInfinity;
            for (int i = 0; i < Tops.Count; i++)
                if (Tops[i].x < Min)
                    Min = Tops[i].x;
            return Min;
        }

        public float GetMinY()
        {
            float Min = float.PositiveInfinity;
            for (int i = 0; i < Tops.Count; i++)
                if (Tops[i].y < Min)
                    Min = Tops[i].y;
            return Min;
        }

        public float FindMaxDeltaX()
        {
            float Min = float.PositiveInfinity;
            float Max = float.NegativeInfinity;
            for (int i = 0; i < Tops.Count; i++)
            {
                if (Tops[i].x < Min)
                    Min = Tops[i].x;
                if (Tops[i].x > Max)
                    Max = Tops[i].x;
            }
            return Max - Min;
        }
        
        public float FindMaxDeltaY()
        {
            float Min = float.PositiveInfinity;
            float Max = float.NegativeInfinity;
            for (int i = 0; i < Tops.Count; i++)
            {
                if (Tops[i].y < Min)
                    Min = Tops[i].y;
                if (Tops[i].y > Max)
                    Max = Tops[i].y;
            }
            return Max - Min;
        }
    }


    public class Vector
    {
        public Point nullP;
        public float x;
        public float y;

        public Vector()
        {
            x=0;
            y=0;
            nullP = new Point();
        }

        public Vector(float xCoord, float yCoord, Point start)
        {
            x = xCoord;
            y = yCoord;
            nullP = start;
        }


        public void NormalizeVector()
        {
           float r = (float)Math.Sqrt(x * x + y * y);
            x = x / r;
            y = y / r;
        }

        public static float DOT(Vector v1, Vector v2)
        {
            return v1.x * v2.x + v1.y * v2.y;
        }

        public static Vector Mul(float k, Vector v)
        {
            return new Vector(k * v.x, k * v.y, v.nullP);
        }

        public static Vector Minus(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, null);
        }
    
    }


    public class FrequencyMod
    {
        public float Amplitude;
        public float Freq;
        public FrequencyMod()
        {
            Amplitude = 0;
            
            Freq = 0;
        }
        public FrequencyMod(float Ampl, float F)
        {
            Amplitude = Ampl;
            Freq = F;
        }

        /// <summary>
        /// Изменяет амплитуду после отражения
        /// </summary>
        /// <param name="FM1"></param>
        /// <param name="FM2"></param>
        /// <returns></returns>
        public static Modifier Refl(Modifier M1, Modifier M2)
        {
            if (M1.AmpMod.Length != M2.AmpMod.Length)
                return null;
            Modifier result = new Modifier(null, M1.soundSpeed);
            FrequencyMod[] FM  = new FrequencyMod[M1.AmpMod.Length];
            for (int i = 0; i < M1.AmpMod.Length; i++)
            {
                FM[i] = new FrequencyMod((1 - M1.AmpMod[i].Amplitude) * M2.AmpMod[i].Amplitude,M1.AmpMod[i].Freq);
            }
            result.AmpMod = FM;
            result.delay = M2.delay;
            return result;
        }
        public static Modifier Refr(Modifier M1, Modifier M2)
        {
            if (M1.AmpMod.Length != M2.AmpMod.Length)
                return null;
            Modifier result;
            if (M1.soundSpeed != M2.soundSpeed)
                result = new Modifier(null, M2.soundSpeed);
            else
                result = new Modifier(null, 331.2f);
            FrequencyMod[] FM = new FrequencyMod[M1.AmpMod.Length];
            for (int i = 0; i < M1.AmpMod.Length; i++)
            {
                FM[i] = new FrequencyMod((float)0.6 * M1.AmpMod[i].Amplitude * M2.AmpMod[i].Amplitude, M1.AmpMod[i].Freq);
            }
            result.AmpMod = FM;
            result.delay = M2.delay;
            return result;
        }

    }


    public class Modifier
    {
        public float delay;
        public FrequencyMod[] AmpMod;
        public float soundSpeed;

        public Modifier()
        {
            delay = 0;
            AmpMod = new FrequencyMod[0];
        }


        public Modifier(float delay, FrequencyMod[] AM)
        {
            this.delay = delay;
            AmpMod = AM;
        }
        public Modifier(FrequencyMod[] AM, float soundS)
        {
            AmpMod = AM;
            soundSpeed = soundS;
        }

        public void SetAmp(float r)
        {
            float freqKoef = 0;
            float distKoef = 0;
            const float freqMax = 22050;
            const float d = 0.02f;
            distKoef = (float)Math.Exp(-r * d);
            for (int i = 0; i < AmpMod.Length; i++)
            {
                freqKoef = 1 - AmpMod[i].Freq /( 3 * freqMax);
                AmpMod[i].Amplitude = AmpMod[i].Amplitude * distKoef * freqKoef;
            }
        }
    }


    public class ModifiersKnot
    {
        public List<Modifier> modifiers;

        public ModifiersKnot()
        {
            modifiers = new List<Modifier>(1);
        }
        public void AddModifier(Modifier mod)
        {
            modifiers.Add(mod);
        }

        public Modifier GetModifier(int Pos)
        {
            try
            {
                return modifiers[Pos];
            }
            catch
            {
                return null;
            }
        }
    }


    public class Sourse
    {
        public Point Coords;
        public Sourse()
        {
            Coords = new Point();
        }
        public Sourse(Point Coordinates)
        {
            Coords = Coordinates;
        }
    }


    public class Wave
    {
       public Vector direct;
       public Point end;
       public float previousDist;
       public float speed;
       public Modifier waveMod;

       public void SetDelay(float length)
       {
           waveMod.delay = length / speed;
       }

        public Wave()
        {
            direct = new Vector();
            end = new Point();
            previousDist = 0;
            speed = 331.2F;
        }
        public Wave(Vector waveVect, float prevDist)
        {
            direct = waveVect;
            previousDist = prevDist;
            end = new Point();
            speed = 331.2F;
        }
        public Wave(Vector waveVect)
        {
            direct = waveVect;
            previousDist = 0;
            end = new Point();
            speed = 331.2F;
            FrequencyMod[] t = { new FrequencyMod(1f, 128), 
                             new FrequencyMod(1f, 256), 
                             new FrequencyMod(1f, 512),
                             new FrequencyMod(1f, 1024), 
                             new FrequencyMod(1f, 2048),
                             new FrequencyMod(1f, 4096),
                             new FrequencyMod(1f, 10000),
                               };

            waveMod = new Modifier(0, t);
        }
        public Wave(Vector waveVect, float prevDist, Modifier FM)
        {
            if (waveMod == null)
                waveMod = FM;
            else
                for (int i = 0; i < FM.AmpMod.Length; i++)
                    waveMod.AmpMod[i].Amplitude = waveMod.AmpMod[i].Amplitude * FM.AmpMod[i].Amplitude;

                    direct = waveVect;
            previousDist = previousDist + prevDist;
            end = new Point();
            speed = 331.2F;
            
        }

    }

    
    public class Sector
    {
        Vector Left;
        Vector Right;
        public Point binding;
        public Polygon blind;

        public Sector()
        {}
        public Sector(Vector L, Vector R, Point bindingPoint, Polygon blindingPolygon)
        {
            if(L.y*R.x - L.x*R.y > 0)
            {
                Right = R;
                Left = L;
            }
            else
            {
                Right = L;
                Left = R;
            }
            Left.NormalizeVector();
            Right.NormalizeVector();
            binding = bindingPoint;
            blind = blindingPolygon;

        }
        public bool IsInSector(Vector V)
        {
            if(Left.y*V.x - Left.x*V.y >= 0 && V.y*Right.x - V.x*Right.y >= 0)
                return true;
            return false;
        }

    }


    public static class Phisics
    {
        /// <summary>
        /// Функция которая создает сетку модификаторов волны
        /// </summary>
        /// <param name="polygons">список объектов в помещении</param>
        /// <param name="sourses"> источники звука</param>
        /// <param name="room"> комната</param>
        /// <param name="xSizeOfMatr">размер1 матрицы</param>
        /// <param name="ySizeOfMatr">размер2 матрицы</param>
        /// <param name="int">количество лучей для трассировки </param>
        /// <param name="float">порог энергии волны, поле которого она не рассматривается. </param>
        static public /*ModifiersKnot[,]*/List<BTreeNode<Wave>> GetModifiersKnots(List<Polygon> polygons, 
            List<Sourse> sourses, Polygon room, int xSizeOfMatr, int ySizeOfMatr, int RaysCount, float minAmplitude, int reflCount)
        {
            Vector vect = new Vector();
            //List<Wave> wayOfWave = new List<Wave>();
            Wave wave = new Wave();
            BTreeNode<Wave> wayOfWave = new BTreeNode<Wave>();
            List<BTreeNode<Wave>> r = new List<BTreeNode<Wave>>();
            ModifiersKnot[,] result = new ModifiersKnot[xSizeOfMatr + 2, ySizeOfMatr + 2];
            for (int i = 0; i < xSizeOfMatr+2; i++)
                for (int j = 0; j < ySizeOfMatr+2; j++)
                    result[i, j] = new ModifiersKnot();
            xSizeOfMatr = xSizeOfMatr - 2;
            ySizeOfMatr = ySizeOfMatr - 2;

            float stepX = room.FindMaxDeltaX() / xSizeOfMatr;
            float stepY = room.FindMaxDeltaY() / ySizeOfMatr;
            float b=0;
            float temp;
            float koef;
            float x0, y0;
            float xEnd, yEnd;
            float d = 0.02f;

            for (int i = 0; i < sourses.Count; i++)
                for (int j = 0; j < RaysCount; j++)
                {
                  //  j = 36;
                    vect = new Vector((float)Math.Cos(2 * Math.PI * (float)j / (float)RaysCount),
                                      (float)Math.Sin(2 * Math.PI * (float)j / (float)RaysCount), sourses[i].Coords);
                    wave = new Wave(vect);
                    wave.speed = 331.2f;
                    wave.waveMod.soundSpeed = 331.2f;
                    wayOfWave = CreateWave(wave, polygons, room, minAmplitude, 0, reflCount);
                    r.Add(wayOfWave);

                    //result = GetResultMatrix(wayOfWave, minAmplitude, xSizeOfMatr, xSizeOfMatr);
                    /* for (int k = 0; k < wayOfWave.Count; k++)
                    {

                        x0 = (wayOfWave[k].direct.nullP.x / stepX);
                        y0 = (wayOfWave[k].direct.nullP.y / stepY);
                        xEnd = (wayOfWave[k].end.x / stepX);
                        yEnd = (wayOfWave[k].end.y / stepY);


                        if (!(xEnd < x0 + 0.0001 && xEnd > x0 - 0.0001))
                        {
                            koef = (yEnd - y0) / (xEnd - x0);
                            b = y0 - koef * x0;
                            if (x0 > xEnd)
                            {
                                temp = x0;
                                x0 = xEnd;
                                xEnd = temp;
                            }
                            for (float a = x0; a < xEnd; a = a + 1)
                            {
                                wayOfWave[k].waveMod.SetAmp((float)wayOfWave[k].previousDist + Math.Abs(a * stepX - wayOfWave[k].direct.nullP.x)); 
                                wayOfWave[k].SetDelay(Math.Abs(wayOfWave[k].previousDist + Math.Abs(a * stepX - wayOfWave[k].direct.nullP.x)));
                                result[(int)a, (int)(a * koef + b)].AddModifier(wayOfWave[k].waveMod);
                            }
                        }
                        else
                        {
                            if (y0 > xEnd)
                            {
                                temp = y0;
                                y0 = yEnd;
                                yEnd = temp;
                            }
                            for (float a = y0; a < yEnd; a = a + 1)
                            {
                                wayOfWave[k].waveMod.SetAmp(wayOfWave[k].previousDist + Math.Abs(a * stepY - wayOfWave[k].direct.nullP.y));
                                wayOfWave[k].SetDelay(Math.Abs(wayOfWave[k].previousDist + Math.Abs(a * stepY - wayOfWave[k].direct.nullP.y)));
                                result[(int)x0, (int)a].AddModifier(wayOfWave[k].waveMod);
                            }
                        }
                    }*/
                }

            return /*result*/ r;
        }


       /* static ModifiersKnot[,] GetResultMatrix(List<BTreeNode<Wave>> wayOfWave, float minAmplitude, int xSizeOfMatr, int xSizeOfMatr)
        {

        }*/

        static BTreeNode<Wave> CreateWave(Wave prevWave, List<Polygon> polygons, Polygon room, float minAmplitude, int iteration, int maxIter)
        {
            if (prevWave == null || iteration> maxIter || prevWave.waveMod.AmpMod[0].Amplitude< minAmplitude)
                return null;

            BTreeNode<Wave> result = new BTreeNode<Wave>();
            BTreeNode<Wave> nextT;
            Wave nextReflWave = new Wave();
            Wave nextRefrWave = new Wave();
            FindNextWaves(prevWave,polygons,room, out nextReflWave, out nextRefrWave);
            result.Value = prevWave;
            if (nextReflWave != null)
            {
                nextT = new BTreeNode<Wave>();
                nextT = CreateWave(nextReflWave, polygons, room, minAmplitude, iteration + 1, maxIter);
                if (nextT != null)
                {
                    nextT.Value = nextReflWave;
                    result.L = nextT;
                }
            }
            if (nextRefrWave != null)
            {
                nextT = new BTreeNode<Wave>();
                nextT = CreateWave(nextRefrWave, polygons, room, minAmplitude, iteration + 1, maxIter);
                if (nextT != null)
                {
                    nextT.Value = nextRefrWave;
                    result.R = nextT;
                }
            }
            return result;
        }

        /// <summary>
        /// Функция, которая нахоидит конец волны и задает отраженную
        /// </summary>
        /// <param name="prevWave">предыдущая волна </param>
        /// <param name="polygons">препятствия в комнате</param>
        /// <param name="room"> комната </param>
        /// <returns>отраженная волна</returns>
        static void FindNextWaves(Wave prevWave, List<Polygon> polygons, Polygon room, out Wave nextReflWave, out Wave nextRefrWave)
        {
            float A1 = 0, B1 = 0, C1 = 0; // коэффициенты прямой предыдущей волны
            float A2 = 0, B2 = 0, C2 = 0; // коэффициенты прямой, на которой лежит сторона многоугольника
            float x0 = 0, y0 = 0;         // точка 0
            float x1 = 0, y1 = 0;         // точка 1
            float TurnA = 0, TurnB=0;               // угол поворота для отражения
            Point refl = new Point();     // точка начала новой волны 
            List<float> length = new List<float>(); // список длин возможных волн
            List<int> nomb = new List<int>();       // номера многоуголиников, с которыми возможно пересечение
            List<Point> points = new List<Point>(); // точки пересечения стороны многоугольника и волны
            List<float> AAll = new List<float>(); // списки 
            List<float> BAll = new List<float>(); //    коэффицентов
            List<float> CAll = new List<float>(); //        для прямых
            float temp = float.PositiveInfinity;
            Vector vect = new Vector();
            int k = 0;

            polygons.Add(room);
            nextReflWave = null;
            nextRefrWave = null;

            A1 = - prevWave.direct.y; // находим коэффициенты прямой предыдущей волны
            B1 = prevWave.direct.x;
            C1 = -B1 * prevWave.direct.nullP.y - A1 * prevWave.direct.nullP.x;

            for (int i = 0; i < polygons.Count; i++)
                for (int j = 0; j < polygons[i].Tops.Count; j++)
                {
                    x0 = polygons[i].Tops[j].x;
                    y0 = polygons[i].Tops[j].y;
                    if (j != polygons[i].Tops.Count - 1)
                    {
                        x1 = polygons[i].Tops[j+1].x;
                        y1 = polygons[i].Tops[j+1].y;
                    }
                    else
                    {
                        x1 = polygons[i].Tops[0].x;
                        y1 = polygons[i].Tops[0].y;
                    }

                    A2 = y0 - y1; // составляем уравнение прямой, на которой лежит сторона многоугольника
                    B2 = x1 - x0;
                    C2 = -y0 * B2 - x0 * A2; 

                    refl.x = (C2 * B1 - C1 * B2) / (A1 * B2 - A2 * B1); // ищем точку пересечения волны и стороны
                    refl.y = (A2 * C1 - A1 * C2) / (A1 * B2 - A2 * B1);

                    if (((x0 <= refl.x && refl.x <= x1) || (x0 >= refl.x && refl.x >= x1)) &&
                        ((y0 <= refl.y && refl.y <= y1) || (y0 >= refl.y && refl.y >= y1)) &&
                        (((refl.x - prevWave.direct.nullP.x) / prevWave.direct.x > 0.0001) || ((refl.y - prevWave.direct.nullP.y) / prevWave.direct.y > 0.0001))) // если точка пересечения принадлежит стороне многоугольника
                    { // если точка лежит по ходу движения волны и на стороне многоугольника
                        length.Add(GetLengthFromTo(prevWave.direct.nullP, refl));
                        nomb.Add(i); // запонимаем её характеристики
                        nomb.Add(j);
                        points.Add(refl);
                        refl = new Point();
                        AAll.Add(A2);
                        BAll.Add(B2);
                        CAll.Add(C2);
                    }
                }
            if (length.Count == 0)
            {
                polygons.RemoveAt(polygons.Count - 1);
                return;
            }
            for (int i = 0; i < length.Count; i++) //находим самую короткую новую волну
                if (length[i] < temp)
                {
                    temp = length[i];
                    k = i * 2;
                    refl = points[i];
                }

            prevWave.end = refl;  
            A2 = AAll[k / 2];
            B2 = BAll[k / 2];
            C2 = CAll[k / 2];
          
            Vector wallNorm = new Vector(A2, B2, null);
            wallNorm.NormalizeVector();
            vect = Vector.Minus(prevWave.direct, Vector.Mul(2 * Vector.DOT(wallNorm, prevWave.direct), wallNorm));
            vect.NormalizeVector();
            vect.nullP = refl;
            nextReflWave = new Wave(vect, prevWave.previousDist + temp,FrequencyMod.Refl( polygons[nomb[k]].mods , prevWave.waveMod)); // отраженная волна

            TurnA = (float)Math.PI / 2 - (float)Math.Acos((A1 * A2 + B1 * B2) / Math.Sqrt((A1 * A1 + B1 * B1) * (A2 * A2 + B2 * B2)));//Math.PI/2 - Math.Asin(prevWave.direct.x * polygons[nomb[k]].mods.soundSpeed / prevWave.speed);
            if (prevWave.speed != polygons[nomb[k]].mods.soundSpeed)
                TurnB = (float)Math.Asin(Math.Sin(TurnA) * polygons[nomb[k]].mods.soundSpeed / prevWave.speed);
            else
            {
                TurnB = -(float)Math.Asin(Math.Sin(TurnA) * 331.2f / prevWave.speed);
                TurnA = -TurnA;
            }
            if (TurnB > Math.Abs(Math.PI / 2))
            {
                polygons.RemoveAt(polygons.Count - 1);
                return;//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            }
            else
            {
                x0 = prevWave.direct.nullP.x;
                y0 = prevWave.direct.nullP.y;
                TurnB = -TurnB + (float)Math.PI + TurnA;
                x1 = (float)((x0 - refl.x) * Math.Cos(TurnB) - (y0 - refl.y) * Math.Sin(TurnB)) + refl.x;  //преломление волны
                y1 = (float)((x0 - refl.x) * Math.Sin(TurnB) + (y0 - refl.y) * Math.Cos(TurnB)) + refl.y;
                vect = new Vector(x1 - refl.x, y1 - refl.y, refl);
                vect.NormalizeVector();
                nextRefrWave = new Wave(vect, prevWave.previousDist + temp, FrequencyMod.Refr(prevWave.waveMod, polygons[nomb[k]].mods));
                if (prevWave.speed != polygons[nomb[k]].mods.soundSpeed)
                    nextRefrWave.speed = polygons[nomb[k]].mods.soundSpeed;
                else
                    nextRefrWave.speed = 331.2f;
                polygons.RemoveAt(polygons.Count - 1);
            }

            /*Turn = 2 * (float)(Math.PI / 2 - Math.Acos((A1 * A2 + B1 * B2) / Math.Sqrt((A1 * A1 + B1 * B1) * (A2 * A2 + B2 * B2)))); //считаем угол поворота для прямой

            x0 = prevWave.direct.nullP.x;
            y0 = prevWave.direct.nullP.y;
            x1 = (float)((x0 - refl.x) * Math.Cos(Turn) - (y0 - refl.y) * Math.Sin(Turn)) + refl.x;  //отражение волны
            y1 = (float)((x0 - refl.x) * Math.Sin(Turn) + (y0 - refl.y) * Math.Cos(Turn)) + refl.y;

            vect = new Vector( x1 - refl.x ,y1 - refl.y , refl);
            vect.NormalizeVector();
            result = new Wave(vect, prevWave.previousDist + temp,FrequencyMod.Mul( polygons[nomb[k]].mods.AmpMod , prevWave.waveMod.AmpMod)); // отраженная волна
            polygons.RemoveAt(polygons.Count-1);*/
        }

        static float GetLengthFromTo(Point p1, Point p2)
        {
            return (float)Math.Sqrt((p1.x - p2.x) * (p1.x - p2.x) + (p1.y - p2.y) * (p1.y - p2.y));
        }

        /*static Sector[] CreateVectorMapForPolygons(Point sourse,List<Polygon> polygons,Polygon room)
        {
            List<Sector> result = new List<Sector>();
            for (int i = 0; i < room.Tops.Count; i++)
            {
                if (i != room.Tops.Count - 1)
                    result.Add(new Sector(new Vector(room.Tops[i].x, room.Tops[i].y, sourse),
                                          new Vector(room.Tops[i + 1].x, room.Tops[i + 1].y, sourse), room.Tops[i].x));
                else
                    result.Add(new Sector(new Vector(room.Tops[i].x, room.Tops[i].y, sourse),
                                          new Vector(room.Tops[1].x, room.Tops[1].y, sourse), room.Tops[i].x));
            }
            for (int i = 0; i < polygons.Count; i++)
                for (int j = 0; j < polygons[i].Tops.Count; j++)
                {
                    if (j != polygons[i].Tops.Count - 1)
                        result.Add(new Sector(new Vector(polygons[i].Tops[j].x, polygons[i].Tops[j].y, sourse),
                                              new Vector(polygons[i].Tops[j + 1].x, polygons[i].Tops[j + 1].y, sourse), room.Tops[i].x));
                    else
                        result.Add(new Sector(new Vector(polygons[i].Tops[j].x, polygons[i].Tops[j].y, sourse),
                                              new Vector(polygons[i].Tops[1].x, polygons[i].Tops[1].y, sourse), room.Tops[i].x));
        
                }
            return result;
        }*/
    }
}


/* List<Sector> sectors = CreateVectorMapForPolygons(prevWave.direct.nullP, polygons, room);

 for (int i = 0; i < sectors.Count; i++)
     if (sectors[i].IsInSector(prevWave.direct))
         nomb.Add(i);
 for (int i = 0; i < nomb.Count; i++)
 {
     temp = GetLegthFromTo(prevWave.direct.nullP, sectors[nomb[i]].binding);
     if (temp < length)
     {
         length = temp;
         k = nomb[i];
     }
 }
 x0 = sectors[k].binding.x;
 y0 = sectors[k].binding.y;

 for (int i = 0; i < sectors[k].blind.Tops.Count; i++)
 {
     if (sectors[k].blind.Tops[i] == sectors[k].binding)
     {
         if (i != sectors[k].blind.Tops.Count - 1)
         {
             x1 = sectors[k].blind.Tops[i + 1].x;
             y1 = sectors[k].blind.Tops[i + 1].y;
         }
         else
         {
             x1 = sectors[k].blind.Tops[1].x;
             y1 = sectors[k].blind.Tops[1].y;
         }
     }
 }*/