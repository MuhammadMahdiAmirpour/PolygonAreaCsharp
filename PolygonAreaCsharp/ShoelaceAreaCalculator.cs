namespace PolygonAreaCsharp;

using System.Collections.Generic;
using System.Drawing;

public class ShoelaceAreaCalculator : IAreaCalculator {
	public double CalculateArea(List<Point> points) {
		double area = 0;
		var    n    = points.Count;

		for (var i = 0; i < n; i++) {
			var j = (i + 1) % n;
			area += points[i].X * points[j].Y;
			area -= points[j].X * points[i].Y;
		}

		return Math.Abs(area) / 2;
	}
}
