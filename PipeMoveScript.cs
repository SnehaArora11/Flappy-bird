using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float movespeed = 5;
    //adding deadzone because too many pipes will cause memory overhead
    public float deadZone = -40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //multiplying with time.delta time so that it is tied to time and not to frame rate
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;
        
        if(transform.position.x<deadZone)

        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject); 
        }
    }
}
