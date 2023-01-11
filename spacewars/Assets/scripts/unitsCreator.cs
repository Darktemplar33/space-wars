using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class unitsCreator : MonoBehaviour
{

    public enum unitType
    {
        worker,
        researchStation,
        smallShip,
        mediumShip,
        largeShip
    }

    public bool friendly;

    public unitType type;

    public int cost;
    public int health;
    public int attack;
    public int armor;
}
