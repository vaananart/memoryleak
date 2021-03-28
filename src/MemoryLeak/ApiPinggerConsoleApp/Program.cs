using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiPinggerConsoleApp
{
	class Program
	{
		private static HttpClient client = new HttpClient();
		public static async Task Main(string[] args)
		{
			var limit = int.Parse(args[0]);
			for (int i = 0; i < limit; i++)
			{
				var result = await client.GetAsync("https://localhost:44332/api/bigstring");
				Console.WriteLine(i);
			}
		}
	}
}
