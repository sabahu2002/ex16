using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment18;

public class Soldier : Character
{
    public Soldier() : base("s1", 50, new Position(4, 5, 6))
    {

    }
    public override void DisplayInfo()
    {
        Debug.Log("Soldier");
        base.DisplayInfo();

    }

}
