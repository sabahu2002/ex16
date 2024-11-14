using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;
using Assignment18;

public struct Position
{
    float X, Y, Z;
    public Position(float x, float y, float z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }
    public void printPosition()
    {
        Debug.Log("Value of X=" + X + " & " + "Value of Y=" + Y + " & " + "Value of Z=" + Z);
    }

    void Start()
    {
        Position saba = new Position(4, 5, 6);
        saba.printPosition();

    }


}
