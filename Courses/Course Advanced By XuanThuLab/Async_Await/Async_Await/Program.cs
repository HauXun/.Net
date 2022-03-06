using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await
{
	class Program
	{
		static void doSomthing(int seconds, string messages, ConsoleColor color)
		{
			lock (Console.Out)
			{
				Console.ForegroundColor = color;
				Console.WriteLine($"{messages,10} ...Start");
				Console.ResetColor();
			}

			for (int i = 1; i < seconds; i++)
			{
				lock (Console.Out)
				{
					Console.ForegroundColor = color;
					Console.WriteLine($"{messages,10} {i,2}");
					Console.ResetColor();
				}
				Thread.Sleep(1000);
			}

			lock (Console.Out)
			{
				Console.ForegroundColor = color;
				Console.WriteLine($"{messages,10} ...End");
				Console.ResetColor();
			}
		}

		static async Task Task2()
		{
			Task t2 = new Task(
				() =>
				{
					doSomthing(5, "T2", ConsoleColor.Yellow);
				});
			t2.Start();
			await t2;

			Console.WriteLine("T2 hoan thanh");
		}
		static async Task Task3()
		{
			Task t3 = new Task((object obj) =>
			{
				string str = (string)obj;
				doSomthing(10, str, ConsoleColor.Green);
			}, "T3");
			t3.Start();
			await t3;
			Console.WriteLine("T3 hoan thanh");
		}

		static async Task Abc()
		{
			//Task task = new Task(
			//	() =>
			//	{
			//		// do something
			//	});
			//task.Start();
			//await task;
			//await File.WriteAllLinesAsync("1.txt", "asdads");
		}

		static async Task<string> Task4()
		{
			Task<string> t4 = new Task<string>(() =>
			{
				doSomthing(10, "T4", ConsoleColor.Cyan);
				return "Return from T4";
			});
			t4.Start();
			var kq4 = await t4;
			Console.WriteLine("T4 hoan thanh");
			return kq4;
		}

		static async Task<string> Task5()
		{
			Task<string> t5 = new Task<string>((object obj) =>
			{
				string str = (string)obj;
				doSomthing(4, str, ConsoleColor.DarkBlue);
				return $"Return from {str}";
			}, "T5");
			t5.Start();
			var kq5 = await t5;
			return kq5;
		}

		//static async Task<object> abc()
		//{
		//	Task<object> task = new Task<object>(() =>
		//	{
		//		// do something
		//		return new object();
		//	});
		//	task.Start();
		//	var kq = await task;
		//	return kq;
		//}

		static async Task<string> GetWeb(string url)
		{
			HttpClient httpClient = new HttpClient();
			Console.WriteLine("Bat dau tai");
			HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
			Console.WriteLine("Bat dau doc noi dung");
			string content = await httpResponseMessage.Content.ReadAsStringAsync();
			Console.WriteLine("Hoan thanh");
			return content;	
		}

		static async Task Main(string[] args)
		{
			//Task t2 = Task2();
			//Task t3 = Task3();

			//Task<string> t4 = Task4();
			//Task<string> t5 = Task5();


			//t4.Start();
			//t5.Start();

			var task = GetWeb("https://xuanthulab.net");

			doSomthing(8, "T1", ConsoleColor.Red);

			var content = await task;
			Console.WriteLine(content);

			//Task.WaitAll(t4, t5);

			//var kq4 = await t4;
			//var kq5 = await t5;

			//Console.WriteLine(kq4);
			//Console.WriteLine(kq5);

			//t2.Wait();
			//t3.Wait();

			//Task.WaitAll(t2, t3);
			//await t2;
			//await t3;

			Console.WriteLine("World");
		}
	}
}

