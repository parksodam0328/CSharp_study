using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] words = { "Hello", "Program", "C#", "Collections", "Threading" };
			foreach (string iter in words)
			{
				if (iter.Length > 5)
				{
					Console.WriteLine(iter);
				}
			}

			Console.WriteLine("============Linq1===========");
			IEnumerable<string> resWords1 = words.Where(x => x.Length > 5);
			foreach (string iter in resWords1)
			{
				Console.WriteLine(iter);
			}

			Console.WriteLine("===========Linq2============");
			var resWords2 = from iter in words
							where iter.Length > 5
							select iter;
			foreach (string iter in resWords2)
			{
				Console.WriteLine(iter);
			}

			Console.WriteLine("==============Linq3===========");
			var resWords3 = words.Where(x => x.Length > 5).Select(x => x.Substring(0, 5));
			foreach (string iter in resWords3)
			{
				Console.WriteLine(iter);
			}

			Console.WriteLine("===========Linq4============");
			var resWords4 = from iter in words
							where iter.Length > 5
							select iter.Substring(0, 5);
			foreach (string iter in resWords4)
			{
				Console.WriteLine(iter);
			}

			Console.WriteLine("==============Linq5===========");
			var resWords5 = words.Where(x => x.Contains("o"));
			foreach (string iter in resWords5)
			{
				Console.WriteLine(iter);
			}

			Console.WriteLine("===========Linq6============");
			var resWords6 = from iter in words
							where iter.Contains("o")
							select iter;
			foreach (string iter in resWords6)
			{
				Console.WriteLine(iter);
			}

			Console.WriteLine("==============Linq7===========");
			var resWords7 = words.Where(x => x.Contains("o")).Select(
				x =>
				{
					int tmpIdx = x.IndexOf("o");
					return (x.Substring(0, tmpIdx));
				});
			foreach (string iter in resWords7)
			{
				Console.WriteLine(iter);
			}

			Console.WriteLine("===========Linq8============");
			var resWords8 = from iter in words
							where iter.Contains("o")
							select iter.Substring(0, iter.IndexOf("o") + 1);
			foreach (string iter in resWords8)
			{
				Console.WriteLine(iter);
			}

			int[] numbers = { 35, 10, 27, 31, 23, 30, 40, 74, 81, 56, 45, 93 };
			var resNum1 = numbers.Where(x => x > 30);
			var resNum2 = from num in numbers
						  where num > 30
						  select num;
			PrintNumbers(1, resNum1);
			PrintNumbers(2, resNum2);

			var resNum3 = numbers.Where(num => 10 < num && num < 30);
			var resNum4 = from num in numbers
						  where 10 < num && num < 30
						  select num;
			PrintNumbers(3, resNum3);
			PrintNumbers(4, resNum4);

			var resNum5 = numbers.Where((num, idx) => num > 10 && idx < 5);
			PrintNumbers(5, resNum5);
			var resNum6 = numbers.Where((num, idx) => (num > 10 && idx < 5) || (num > 50 && idx >= 5));
			PrintNumbers(6, resNum6);

			var resNum7 = numbers.OrderBy(num => num);
			var resNum8 = from num in numbers
						  orderby num
						  select num;
			PrintNumbers(7, resNum7);
			PrintNumbers(8, resNum8);

			var resNum9 = numbers.OrderByDescending(num => num);
			var resNum10 = from num in numbers
						   orderby num descending
						   select num;
			PrintNumbers(9, resNum9);
			PrintNumbers(10, resNum10);

			var resNum11 = numbers.OrderBy(num => (num % 10) * 10 + num / 10);
			var resNum12 = from num in numbers
						   orderby (num % 10) * 10 + num / 10
						   select num;

			PrintNumbers(11, resNum11);
			PrintNumbers(12, resNum12);

			var resNum13 = numbers.OrderBy(num => num / 10);
			var resNum14 = from num in numbers
						   orderby num / 10
						   select num;

			PrintNumbers(13, resNum13);
			PrintNumbers(14, resNum14);

			var resNum15 = numbers.OrderBy(num => num % 10);
			var resNum16 = from num in numbers
						   orderby num % 10
						   select num;

			PrintNumbers(15, resNum15);
			PrintNumbers(16, resNum16);

			var resNum17 = numbers.Where(x => x < 40).OrderBy(x => x);
			var resNum18 = from x in numbers
						   where x < 40
						   orderby x
						   select x;

			PrintNumbers(17, resNum17);
			PrintNumbers(18, resNum18);

			var resNum19 = numbers.Where(x => x > 40).OrderBy(x => x);
			var resNum20 = from x in numbers
						   where x > 40
						   orderby x descending
						   select x;

			PrintNumbers(19, resNum19);
			PrintNumbers(20, resNum20);

			Console.WriteLine("Count:{0}", resNum19.Count());
			Console.WriteLine("Max:{0}", resNum19.Max());
			Console.WriteLine("Min:{0}", resNum19.Min());
			Console.WriteLine("Average:{0}", resNum19.Average());

			List<CBook> books = new List<CBook>();
			books.Add(new CBook() { Title = "Java", Author = "Choi", Publisher = "Mirim", Price = 10000 });
			books.Add(new CBook() { Title = "PHP", Author = "Ham", Publisher = "Mirim", Price = 30000 });
			books.Add(new CBook() { Title = "Android", Author = "Ham", Publisher = "Mirim", Price = 25000 });
			books.Add(new CBook() { Title = "swift", Author = "Jung", Publisher = "Mirim", Price = 15000 });
			books.Add(new CBook() { Title = "C#", Author = "Jung", Publisher = "Trutory", Price = 20000 });

			var resBook1 = books.OrderBy(x => x.Price);
			var resBook2 = from book in books
						   orderby book.Price
						   select book;

			Console.WriteLine("*****");
			Console.WriteLine("resBook1");
			foreach (CBook iter in resBook1)
			{
				Console.WriteLine("{0} : {1} : {2}", iter.Title, iter.Author, iter.Price);
			}

			Console.WriteLine("resBook2");
			foreach (CBook iter in resBook2)
			{
				Console.WriteLine("{0} : {1} : {2}", iter.Title, iter.Author, iter.Price);
			}


			var resBook3 = books.OrderBy(x => x.Title);
			var resBook4 = from book in books
						   orderby book.Title
						   select book;

			Console.WriteLine("resBook3");
			foreach (CBook iter in resBook4)
			{
				Console.WriteLine("{0,8} : {1,5} : {2,6}", iter.Title, iter.Author, iter.Price);
			}

			Console.WriteLine("resBook4");
			foreach (CBook iter in resBook3)
			{
				Console.WriteLine("{0,8} : {1,5} : {2,6}", iter.Title, iter.Author, iter.Price);
			}

			var resBook5 = books.Where(x => x.Price < 23000).Select(x => new {Title= x.Title, Price = x.Price});
			var resBook6 = from book in books
						   where book.Price < 23000
						   select new { Title = book.Title, Price = book.Price };

			Console.WriteLine("resBook5");
			foreach (var iter in resBook5)
			{
				Console.WriteLine("{0,8} : {1,6}", iter.Title, iter.Price);
			}

			Console.WriteLine("resBook4");
			foreach (var iter in resBook6)
			{
				Console.WriteLine("{0,8} : {1,6}", iter.Title, iter.Price);
			}

			var resBook7 = books.Where(x => x.Price < 23000).OrderBy(x=> x.Title).Select(x => new { Title = x.Title, Price = x.Price });
			var resBook8 = from book in books
						   where book.Price < 23000
						   orderby book.Title
						   select new { Title = book.Title, Price = book.Price };

			Console.WriteLine("resBook7");
			foreach (var iter in resBook7)
			{
				Console.WriteLine("{0,8} : {1,6}", iter.Title, iter.Price);
			}

			Console.WriteLine("resBook8");
			foreach (var iter in resBook8)
			{
				Console.WriteLine("{0,8} : {1,6}", iter.Title, iter.Price);
			}

			var resBook9 = books.Where(x => x.Author.StartsWith("H")).OrderBy(x => x.Price).Select(x => x.Title);
			var resBook10 = from book in books
						   where book.Author.StartsWith("H")
						   orderby book.Price
							select book.Title;

			Console.WriteLine("resBook9");
			foreach (var iter in resBook9)
			{
				Console.WriteLine("{0,8}", iter);
			}

			Console.WriteLine("resBook10");
			foreach (var iter in resBook10)
			{
				Console.WriteLine("{0,8}", iter);
			}

			var resBook11 = books.Where(x => x.Publisher=="Mirim"&& x.Author.Contains("J")).Select(x => new { x.Title, x.Price });
			var resBook12 = from book in books
							where book.Publisher == "Mirim" && book.Author.Contains("J")
							select new { book.Title, book.Price };

			Console.WriteLine("resBook11");
			foreach (var iter in resBook11)
			{
				Console.WriteLine("{0,8} : {1,6}", iter.Title, iter.Price);
			}

			Console.WriteLine("resBook12");
			foreach (var iter in resBook12)
			{
				Console.WriteLine("{0,8} : {1,6}", iter.Title, iter.Price);
			}

			var resBook13 = books.OrderBy(x=>x.Author).ThenBy(x=>x.Price).Select(x => new { x.Author, x.Price });
			var resBook14 = from book in books
							orderby book.Author, book.Price
							select new { book.Author, book.Price };

			Console.WriteLine("resBook13");
			foreach (var iter in resBook13)
			{
				Console.WriteLine("{0,8} : {1,6}", iter.Author, iter.Price);
			}

			Console.WriteLine("resBook14");
			foreach (var iter in resBook14)
			{
				Console.WriteLine("{0,8} : {1,6}", iter.Author, iter.Price);
			}

			var resBook15 = books.OrderBy(x => x.Author).ThenByDescending(x => x.Price).Select(x => new { x.Author, x.Price });
			var resBook16 = from book in books
							orderby book.Author, book.Price descending
							select new { book.Author, book.Price };

			Console.WriteLine("resBook15");
			foreach (var iter in resBook15)
			{
				Console.WriteLine("{0,8} : {1,6}", iter.Author, iter.Price);
			}

			Console.WriteLine("resBook16");
			foreach (var iter in resBook16)
			{
				Console.WriteLine("{0,8} : {1,6}", iter.Author, iter.Price);
			}

			var resBook17 = books.GroupBy(x=>x.Author).Select(g => new { Author = g.Key, Ave=g.Average(x=>x.Price) });
			var resBook18 = from book in books
							group book by book.Author into g
							select new { Author = g.Key, Ave = g.Average(x => x.Price) };

			Console.WriteLine("resBook17");
			foreach (var iter in resBook17)
			{
				Console.WriteLine("{0,8} : {1,6}", iter.Author, iter.Ave);
			}

			Console.WriteLine("resBook18");
			foreach (var iter in resBook18)
			{
				Console.WriteLine("{0,8} : {1,6}", iter.Author, iter.Ave);
			}

			var resBook19 = books.Join(resBook17, x => x.Author, r => r.Author, (x, r) => new { x.Author, x.Price, r.Ave });
			var resBook20 = from book in books
							join stat in resBook18 on book.Author equals stat.Author
							select new { book.Author, book.Price, stat.Ave };

			Console.WriteLine("resBook19");
			foreach (var iter in resBook19)
			{
				Console.WriteLine("{0,8} : {1,5} : {2,6}", iter.Author, iter.Price, iter.Ave);
			}

			Console.WriteLine("resBook20");
			foreach (var iter in resBook20)
			{
				Console.WriteLine("{0,8} : {1,6} : {2,6}", iter.Author, iter.Price, iter.Ave);
			}

			Console.ReadKey();
		}
		public static void PrintNumbers(int aIndex, IEnumerable<int> aNums)
		{
			Console.WriteLine("=============Linq Number {0}================",aIndex);
			foreach(int iter in aNums)
			{
				Console.Write(iter + ", ");
			}
			Console.WriteLine();
		}
	}
}
