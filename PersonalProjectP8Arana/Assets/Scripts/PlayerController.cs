using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float zBound = 6;

    private Rigidbody playerRb;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

        ConstrainPlayerPosition();

    }

  
    void MovePlayer()
    {
        //Moves Player left to Right using Arrow Keys 

        float horizontalInput = Input.GetAxis("Horizontal");

        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    void ConstrainPlayerPosition()
    {
        // This Constrains my player to leave the screen top/buttom  

        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }

        if (transform.position.z > zBound)
        {

            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
    }
}
