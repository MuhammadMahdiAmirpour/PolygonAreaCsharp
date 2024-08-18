namespace PolygonAreaCsharp;

using System.Collections.Generic;
using System.Drawing;

public interface IAreaCalculator {
	double CalculateArea(List<Point> points);
}
