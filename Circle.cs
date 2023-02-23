using System;

public class Circle
{
    private Point center;
    private double r;

    public Circle(Point point, double givenR)
    {
        center = point;
        r = givenR;
    }

    //given a point, check if this point is in the circle
    public bool isIn(Point point)
    {
        double x1 = this.center.getX(); double y1 = this.center.getY();
        double x2 = point.getX(); double y2 = point.getY();
        double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        if (distance <= r) { return true; }
        return false;
    }
}
