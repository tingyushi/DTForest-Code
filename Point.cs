using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point
{
    private double x;
    private double y;

    public Point(double givenX, double givenY)
    {
        x = givenX;
        y = givenY;
    }

    public double getX() {return x;}

    public double getY() {return y;}

    public void setX(double newX){x = newX;}

    public void setY(double newY) {y = newY;}
}
