using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    int healthValue = 10;
    Vector3 pos;
    bool levelCompleted = false;
    void changeFinalScore()
    {
        if (levelCompleted == true)
        { 
            score.instance.changescore(healthValue); 
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        levelCompleted = true;
    }

    // Update is called once per frame
    void Update()
    {
        changeFinalScore();
    }
}
