using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class PipemoveScript : MonoBehaviour
{
    public LogicScript logic;
    public float deadZone = -65;
    public GameObject cloud1;
    public GameObject cloud2;
    public GameObject cloud3;
    public float cloudType;
    public int cloudInt;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        cloudType = Random.Range(1, 4);
        cloudInt = (int)cloudType;
        SpawnClouds(cloudInt);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * logic.moveSpeed) * Time.deltaTime;
        
        if (transform.position.x < deadZone) {
            Destroy(gameObject);
        }
    }

    void SpawnClouds(int cloudInt)
    {
        if (cloudInt == 1) {
            cloud1.SetActive(true);
        }
        
        else if (cloudInt == 2) {
            cloud2.SetActive(true);
        }
        
        else 
        {
            cloud3.SetActive(true);
        }
        
    }

    
}
