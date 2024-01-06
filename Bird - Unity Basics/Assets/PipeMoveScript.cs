using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{

    // camera moving speed
    public float moveSpeed = 5; // it is just the default value, you can change later.
                                // Start is called before the first frame update

    public float deadZone = -45;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // moving speed is depending on the frame, so you will get different speed at the same speed value
        // so we will use delta time
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        // Deleting the pipe in a specific zone
        if (transform.position.x < deadZone) {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
