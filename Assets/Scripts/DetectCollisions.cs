using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //Destroy the current game object with this script
        Destroy(gameObject);
        //Destroy the game object that the one with this script collides with
        Destroy(other.gameObject);
    }

}
