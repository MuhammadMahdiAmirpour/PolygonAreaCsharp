namespace PolygonAreaCsharp;

using System.Collections.Generic;
using System.Drawing;

public static class PolygonFactory {
	public static Polygon CreatePolygon(List<Point> points) {
		// You can add logic to decide which area calculator to use
		IAreaCalculator areaCalculator = new ShoelaceAreaCalculator();
		return new Polygon(points, areaCalculator);
	}
}
