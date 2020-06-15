using System;
using System.Linq;

namespace SqrLib
{
    public class Square
    {
        const float Pi = 3.14f;

        public Square()
        {
        }

        /// <summary>
        /// Вернет площадь фигуры, в зависимости от количества введенных сторон
        /// </summary>
        /// <param name="sides"></param>
        /// <returns></returns>
        public float GetArea(params float[] sides)
        {
            var i = sides.Length;
            #region Провека на работоспособность
            if (i > 5 && sides[0] != sides[1])
            {
                return -1;
            }
            else if (i == 0 ) 
            {
                return -1;
            }
            var min = sides.Min();
            if (min <= 0) 
            {
                return -1;
            }
            #endregion

            switch (i)
            {
                case 1: return GetrAreaOfCircle(sides[0]);
                case 2: return GetrAreaOfElipse(sides);
                case 3: return GetAreaOFTriangle(sides[0], sides[1], sides[2]);
                case 4: return GetrAreaBox(sides);
                default: return GetrAreaRegulaPolygon(sides);
            }


        }


        /// <summary>
        /// Площадь круга
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
         float GetrAreaOfCircle(float radius)
        {
            return Pi * (radius * radius);
        }

        /// <summary>
        /// Площадь элипса
        /// </summary>
        /// <param name="sides">Массив с двумя отрезками</param>
        /// <returns></returns>
        float GetrAreaOfElipse(params float[] sides)
        {
            return Pi * sides[0] * sides[1];
        }


        /// <summary>
        /// Возвращает площадь Квадрата или прямоугольника
        /// </summary>Math.Tan()
        /// <param name="sides"></param>
        /// <returns></returns>
        float GetrAreaBox(float[] sides)
        {
            float max = sides.Max();
            float min = sides.Min();

            return min * max;
        }


        /// <summary>
        /// Возвращает площадь правильного многоугольника
        /// </summary>
        /// <param name="sides"></param>
        /// <returns></returns>
         float GetrAreaRegulaPolygon(float[] sides)
        {
            var n = sides.Length;
            float a = sides.Max();
            var angle = (180 / n) * (Math.PI / 180.0);
            var tg = (Math.Tan(angle));

            var res = (n * (a * a) / (4 * tg));
            return (float)res; ;
        }




        /// <summary>
        /// Возвращает площадь треугольника по сторонам
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
         float GetAreaOFTriangle(float a, float b, float c)
        {
            if ((a + b) < c) return 0;
            else if ((a + c) < b) return 0;
            else if ((c + b) < a) return 0;


            float p = ((a + b + c) / 2);

            var s = (p * (p - a) * (p - b) * (p - c));

            return Sqrt(s);
        }


        /// <summary>
        /// Получние корня числа По методу Ньютона (касательных) 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
         float Sqrt(float s)
        {
            float t;
            float squareRoot = s / 2;
            do
            {
                t = squareRoot;
                squareRoot = (t + (s / t)) / 2;
            } while ((t - squareRoot) != 0);
            return squareRoot;
        }

        /// <summary>
        /// Проверяет к какому типу относится треугольник по трем сторонам
        /// </summary>
        /// <param name="a">сторона </param>
        /// <param name="b">сторона</param>
        /// <param name="c">сторона</param>
        /// <returns></returns>
        public string IsSectangular(float a, float b, float c)
        {
            if (a == b && a == c)
            {
                return "Равносторонний";
            }
            


            float catets = 0;

            float[] arr = new float[] { a, b, c };

            var max = arr.Max();
            var min = arr.Min();
            //Проверяем сколько максимальных значений в массиве
            int iMax = arr.ToList().Where(m => (m == max)).Count();
            int iMin = arr.ToList().Where(m => (m == min)).Count();

            if (iMax != 1 || iMin == 2) return $"Равнобедренный {a} {b} {c} ";

            if (max != a && max != b && max != c)
            {
                if (max == a && max != b && max != c)
                {
                    catets = b * b + c * c;
                }
                else if (max != a && max == b && max != c)
                {
                    catets = a * a + c * c;
                }
                else if (max != a && max != b && max == c)
                {
                    catets = a * a + b * b;
                }
                if ((max * max) == catets) { return $"Прямоугольный {(max * max)}=={catets}"; }
                else return $"He Прямоугольный {(max * max)}!={catets}";
            }


            else return $"Такого треугольника не существует ";


        }


    }
}
