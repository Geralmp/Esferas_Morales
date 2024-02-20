using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public bool onGround;
    // Start is called before the first frame update
    void Start()
    {
       onGround = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            print("Space key was released");
            if(GetComponent<Rigidbody>() != null){
            GetComponent<Rigidbody>().useGravity = true;

            }
        }

                if(Input.GetKeyUp(KeyCode.A))
                {
                    if (onGround){
                        
                     Vector3 fuerza = new Vector3(0,500,0);
                    GetComponent<Rigidbody>().AddForce(fuerza);
                       
                    }
    
                }

    }

    void OnCollisionEnter(Collision c){
        Debug.Log("Colision");
        onGround = true; 

    }

    
    void OnCollisionStay(Collision c){
        
        onGround = true; 

    }

     void OnCollisionExit(Collision c){
        Debug.Log("Libre");
        onGround = false; 

    }

}