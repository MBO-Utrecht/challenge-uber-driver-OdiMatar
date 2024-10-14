using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int score = 0;
    public bool gameOver= false;
    public float timer = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       timer = timer - Time.deltaTime;
       if ( timer <= 0f){
        gameOver = true;
       }

    }
}
