using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{

    // references
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        // after specifying the Tag of the LoSgicManager naming it Logic
        // now you can access it using....
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); // Alternative of draging and droping to fill a var value.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // perdefined function working when two objects collision
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.layer == 3) {
            // True!, so it is the bird layer
            logic.addScore(1);
        }
    }
}
