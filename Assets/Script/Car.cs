using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
   public float speed = 1.5f;
   public float rotationSpeed = 200f;
   bool hasPakage = false;

   public GameController  gameController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log ("Game Over;"+ gameController.gameOver);
        if (gameController.gameOver == false){
           Movecar();
        }
    }
    void Movecar(){
        float throttle = Input.GetAxis("Vertical");
        float steer = Input.GetAxis ("Horizontal");
        
        transform.Translate(0,throttle * speed * Time.deltaTime,0);
        transform.Rotate (0,0,-steer * rotationSpeed * Time.deltaTime);
    }


    
    void OnCollisionEnter2D (Collision2D other)
    
       {
        if(other.gameObject.CompareTag("Pakage")){
             Debug.Log("Pakketje geraakt");
            if (hasPakage == false)
            Destroy(other.gameObject);
            hasPakage = true;
        } 
        if (other.gameObject.CompareTag("Customer")){
               Debug.Log("Klant geraakt");
            if (hasPakage == true){
            Destroy(other.gameObject);
            hasPakage = false;
            gameController.score +=1;}

        }
    }
}
