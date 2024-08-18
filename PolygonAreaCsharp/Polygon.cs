namespace PolygonAreaCsharp;

using System;
using System.Collections.Generic;
using System.Drawing;

public class Polygon(List<Point> points, IAreaCalculator areaCalculator) {
	private readonly List<Point>     _points        = points         ?? throw new ArgumentNullException(nameof(points));
	private readonly IAreaCalculator _areaCalculator = areaCalculator ?? throw new ArgumentNullException(nameof(areaCalculator));

	public double CalculateArea() {
		return _areaCalculator.CalculateArea(_points);
	}
}
