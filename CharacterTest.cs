using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JetBrains.Annotations;
namespace Assignment18
{



    public class CharacterTest : MonoBehaviour
    {

        Soldier soldier;
        Officer officer;

        void Start()
        {
            soldier = new Soldier();
            officer = new Officer("f1", 50, new Position(14, 15, 16));
            Character[] arr = new Character[2];
            arr[0] = soldier;
            arr[1] = officer;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].DisplayInfo();
            }
            Debug.Log("Solider Health befor Attack = " + soldier.Health);
            officer.Attack(10, soldier);
            Debug.Log("Solider Health After Attack = " + soldier.Health);






        }
    }
}


