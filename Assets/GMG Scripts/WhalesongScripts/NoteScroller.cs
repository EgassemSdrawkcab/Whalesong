using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NoteScroller : MonoBehaviour
{

    public float beatTempo = 120; // how fast notes move
    public bool beatHasStarted; // to let us turn on and off the note scrolling
    //public float beatDirection = 0; //which direction notes move

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        beatTempo = beatTempo / 60f; //tells us how fast notes move per second
    }

    // Update is called once per frame
    void Update()
    {
        if (!beatHasStarted)
        {
            // for this test, press Y to get started
            // if (Input.anyKeyDown)
            if (Input.GetKeyDown(KeyCode.Y))
            {
                beatHasStarted = true;
            }
        }
        else
        {
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
            // if we want to make this go different directions, the above line will need changes
            //TODO: change to be multidirectional
        }
        
    }
}