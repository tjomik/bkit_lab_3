using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Несортированные элементы в порядке добавления:\n");
            Rectangle a = new Rectangle(2, 5);
            a.Print();
            Square b = new Square(5);
            b.Print();
            Circle c = new Circle(2);
            c.Print();
            
            
            Console.WriteLine("\n\nСортированный список ArrayList: \n");
            ArrayList list1 = new ArrayList();
            list1.Add(a);
            list1.Add(b);
            list1.Add(c);
            list1.Sort();
            foreach (Figure obj in list1)
            {
                Console.WriteLine(obj.Type + " площадью равной " + obj.FindArea());
            }

            Console.WriteLine("\n\nСортированный список List: \n");
            List<Figure> list2 = new List<Figure>()
            {
                a,b,c
            };
            list2.Sort();
            foreach (Figure obj in list2)
            {
                Console.WriteLine(obj.Type + " площадью равной " + obj.FindArea());
            }

            Console.WriteLine("\n\nМатрица \n");
            Matrix < Figure > matrix= new Matrix<Figure>(3,3,3, new FigureMatrixCheckEmpty());
            matrix[0, 0, 0] = a;
            matrix[0, 0, 0] = b;
            matrix[2, 2, 2] = c;
            Console.WriteLine(matrix.ToString());
            Console.ReadLine();

            Console.WriteLine("\n\nПример работы стека\n");
            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            stack.Push(a);
            stack.Push(b);
            stack.Push(c);

            while (stack.Count>0)
            {
                Console.WriteLine(stack.Pop().Type);
            }
            Console.ReadLine();
        }
    }
}
