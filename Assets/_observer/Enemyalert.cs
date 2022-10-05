using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemyalert
{
    public abstract bool getAlert();
}


public class GetAlert : Enemyalert
{
    public override bool getAlert()
    {
        return true;
    }
}
