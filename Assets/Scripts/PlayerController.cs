using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 20.0f;
    public float xRange = 20.0f;

    //Game Object associated with the character
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If position of character is less than -20
        if (transform.position.x < -xRange)
        {
            //Set new position to be at -20
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }


        horizontalInput = Input.GetAxis("Horizontal");
        //Move player in right/left direction / get the user input for the right/left keys / move character at a constant speed per time and not framerate / use the custom speed set
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //Get key that's pressed down from the keycode of spacebar i.e space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Create new instance of projectile each time the spacebar is pressed, based on player's position, going in one direction only
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
