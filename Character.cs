using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment18;

public class Character
{
    public string name;
    private int health;
    protected Position position;
    public int Health
    {
        get { return health; }
        set
        {
            if (value < 0)
                health = 0;
            else if (value > 100)
                health = 100;
            else
                health = value;
        }
    }
    public Character(string Name, int health2, Position poss)
    {
        name = Name;
        health = health2;
        position = poss;
    }
    public Character() : this("", 100, new Position(0, 0, 0))
    {

    }
    public virtual void DisplayInfo()
    {
        Debug.Log("Name = " + name + " & " + "Health = " + health + " & " + "Position = ");
        position.printPosition();
    }
    public void Attack(int damage, Character target)
    {
        if (damage > 0)
        {
            target.health -= damage;

        }
        else
        {
            Debug.Log("damage must be positive value");
        }
    }
    public void Attack(int damage, Character target, string attackType)
    {
        Attack(damage, target);
        Debug.Log("Attack type = " + attackType);
    }

}
