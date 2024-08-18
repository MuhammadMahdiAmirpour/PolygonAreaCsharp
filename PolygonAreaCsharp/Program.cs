using System.Drawing;

namespace PolygonAreaCsharp;

public static class Program {
	public static void Main() {
		List<Point> points = [
			new Point(-2, -5),
			new Point(-3, 4),
			new Point(5, -6),
			new Point(7, 8),
			new Point(0, 10),
			new Point(0, -10),
			new Point(10, 0),
			new Point(-10, 0)
		];

		var polygon     = PolygonFactory.CreatePolygon(points);
		var polygonArea = polygon.CalculateArea();
		Console.WriteLine($"Polygon area: {polygonArea}");
	}
}
