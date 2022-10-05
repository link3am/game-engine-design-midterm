using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Wants to know when another object does something interesting 
public abstract class Observer
{
    public abstract void OnNotify();
}

public class Enemy : Observer
{
    //The box gameobject which will do something
    GameObject enemyObj;
    //What will happen when this box gets an event
    Enemyalert enemyalert;

    public Enemy(GameObject enemyObj, Enemyalert enemyalert)
    {
        this.enemyObj = enemyObj;
        this.enemyalert = enemyalert;
    }

    //What the box will do if the event fits it (will always fit but you will probably change that on your own)
    public override void OnNotify()
    {
       
        isAlert();
    }

    //The box will always jump in this case
    void isAlert()
    {
        //If the box is close to the ground
        enemyObj.GetComponent<enemy>().alert = true;
    }
}