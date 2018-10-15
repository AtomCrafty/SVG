using System;
using System.IO;
using System.Reflection;
using Svg;

namespace Convert {
	public class Program {
		public static void Main(string[] args) {
			switch(args.Length) {
				case 1:
					Convert(args[0], Path.ChangeExtension(args[0], "png"));
					break;
				case 2:
					Convert(args[0], args[1]);
					break;
				default:
					Console.WriteLine("Usage: dotnet convert.dll <input.svg> [<output.png>]");
					Console.ReadLine();
					return;
			}
		}

		private static void Convert(string source, string destination) {
			var document = SvgDocument.Open(source);

			using(var bitmap = document.Draw()) {
				bitmap.Save(destination);
			}
		}
	}
}
