using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public GameObject SpaceToStart;
    public GameObject PauseMenu;
    public GameObject PauseMenuUI;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive == true || Input.GetMouseButtonDown(0) && birdIsAlive == true && Time.timeScale == 1f)
        {

            if (PauseMenuUI.gameObject.activeInHierarchy == true) {
                
            }

            else {
                Time.timeScale = 1;
                SpaceToStart.SetActive(false);
                myRigidBody.velocity = Vector2.up * flapStrength;
            
            
                // PauseMenu.SetActive(true);
                AudioManager.Instance.playSFX("Jump");
            }
            
            
            
        }
        
        

        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
        gameObject.SetActive(false);
    }
}
