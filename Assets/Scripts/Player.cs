using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 0.1f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy") 
        {
            Debug.Log(message: "Triggered");
            collision.gameObject.transform.position = new Vector3(x: Random.Range(-3f,3f) ,y: 3f, z:0f);
        }
        
    }
    
    void Update()
    {
       
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(x: (-0.1f*speed), y: 0f, z: 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(x: (0.1f*speed), y: 0f, z: 0f);
        }

       
    }
}
