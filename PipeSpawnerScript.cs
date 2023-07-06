using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//purpose of this script is to spawn new versions of pipe prefab every x seconds 
// prefab is hierachy of game objects created manually or predefined
//we can re use our gameobjects when saved in asserts is called prefab
//as the pipe already have the code to move left so we just need to spawn new pipes thats it 

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset =10 ;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
        
    }
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
