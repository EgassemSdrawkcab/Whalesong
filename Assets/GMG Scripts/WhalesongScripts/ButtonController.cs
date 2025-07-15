using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{

    //In Unity we can use these to change what the buttons look like on click
    public Sprite defaultImage;
    public Sprite pressedImage;
    // the key to press down to drigger this code:
    public KeyCode keyToPress;

    private SpriteRenderer theSR;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress)) //when we press the button
        {
            theSR.sprite = pressedImage;
        }

        if (Input.GetKeyUp(keyToPress)) //when we release the button
        {
            theSR.sprite = defaultImage;
        }
    }
}
