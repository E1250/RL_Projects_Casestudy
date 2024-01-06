using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    // references, to talk to other interface objects.
    public Rigidbody2D myRigidbody; // public so you can edit from outside.
    // And now we have a line of communication with RigidBody2D.

    public float flapStrenth;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.name = "Bob Bird";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        // key down means clicked
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true) { 
            myRigidbody.velocity = Vector2.up * flapStrenth; // Sends the bird up.
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        logic.gameOver();
        birdIsAlive = false;
    }
}
