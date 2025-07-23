using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlaySongAfterText : MonoBehaviour
{
    [SerializeField] NoteScroller TheArrowsFolder;
    public int NumberOfStartBalloons;
    public int NumberOfEndBalloons;

    public string levelName = "Full EXACT name of next level goes here";

    private int StartCountDown = 1;
    private int FullCountDown = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCountDown = NumberOfStartBalloons;
        FullCountDown = NumberOfStartBalloons + NumberOfEndBalloons;
    }

    // Update is called once per frame
    void Update()
    {
        // if KeyCode Return pressed NumBalloons times, trigger Arrows play
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartCountDown = StartCountDown - 1;
            FullCountDown = FullCountDown - 1;
        }

        if (StartCountDown == 0)
        {
            TheArrowsFolder.beatHasStarted = true;
        }

        if (FullCountDown == 0) {
            SceneManager.LoadScene(levelName, LoadSceneMode.Single);
        }
    }
}
