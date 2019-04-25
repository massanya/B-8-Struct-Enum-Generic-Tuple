using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_8_Struct_Enum_Tuple_Generic
{
	partial class Practice
	{
		public static Random random = new Random();


		/// <summary>
		/// BL8-P1/3. Cоздать структуру 2DRectangle, которая будет содержать ширину, высоту и координату.
		/// </summary>

		public static void Lb8_P1_3()
		{
			Rectangle rectangle = new Rectangle(10, 20, 50, 50);
			Console.WriteLine(rectangle);
			Console.ReadLine();
		}
		public struct Rectangle
		{
			public int H, B;
			public Coordinate Coord;
			public Rectangle(int H, int B, int X, int Y)
			{
				Coord = new Coordinate(X, Y);
				this.H = H;
				this.B = B;
				Console.WriteLine($"Высота = {this.H}; Ширина = {this.B}; {Coord}");
			}
		}
		public struct Coordinate
		{
			public int X, Y;
			public Coordinate(int X, int Y)
			{
				this.X = X;
				this.Y = Y;
			}
			public override string ToString()
			{
				return $"Координата Х = {this.X}; Координата У = {this.Y}";
			}
		}

		/// <summary>
		/// BL8-P2/3. Cоздать случайный массив квадратов с количеством элементов 100. 
		/// Используйте класс Random(10), чтоб установить значения сторон. 
		/// </summary>
		public static void Lb8_P2_3()
		{

			Random rnd = new Random();
			Rectangle[] massivRec = new Rectangle[100];

			for (int i = 0; i < 100; i++)
			{
				massivRec[i] = new Rectangle(rnd.Next(10), 5, 0, 0);
			}

			foreach (Rectangle rectangle in massivRec)
			{
				Console.WriteLine(rectangle.ToString());
			}
			Console.WriteLine(" ");
			
			Rectangle[] kol = massivRec.Distinct().ToArray();
			foreach (Rectangle rectangle in kol)
			{
				Console.WriteLine(rectangle.ToString());
			}
			Console.WriteLine(" ");
			Console.WriteLine($"Количество дубликатов={massivRec.Length-kol.Length}");
			Console.ReadKey();

		}

		/// <summary>
		/// BL8-P3/3.Anonymous. Создать метод GetSongData, 
		/// который принимает обьекта типа Song и возвращает анонимный тип, 
		/// который содержит Title, Minutes, Seconds и AlbumYear. 
		/// </summary>
		public static void Lb8_P3_3_Anonymous()
		{
		}
	}
}
