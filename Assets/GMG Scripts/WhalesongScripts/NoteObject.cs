using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this code is to detect if, when note crosses button threshhold, 
// the player is pressing the right button. if so, delete and add points

public class NoteObject : MonoBehaviour
{

    public bool canBePressed = false;

    public KeyCode keyToPress;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress)) // if we press the right button...
        {
            if (canBePressed) // and the note is in the right area...
            {
                gameObject.SetActive(false); // destroy it and give points!
                //TODO: points?
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("hey ive detected something!");
        if (other.CompareTag("Activator")) // when note enters a potential shield space
        {
            //Debug.Log("hey ive detected an Activator!");
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) // when note exits a potential shield space
    {
        //Debug.Log("hey ive left something!");
        if (other.CompareTag("Activator"))
        {
            canBePressed = false;
        }
    }
}
