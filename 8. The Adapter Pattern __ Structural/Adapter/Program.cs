// See https://aka.ms/new-console-template for more information
using System.Drawing;


var adapter = new SquareAdapter(new LegacySquare());
adapter.Draw(new Point(0, 0), new Point(4, 4));


Console.ReadKey();
