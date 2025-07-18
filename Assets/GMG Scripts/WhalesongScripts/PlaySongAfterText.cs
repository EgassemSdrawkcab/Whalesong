using UnityEngine;

public class PlaySongAfterText : MonoBehaviour
{
    [SerializeField] NoteScroller TheArrowsFolder;
    public int NumberOfBalloons;

    private int CountDown = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CountDown = NumberOfBalloons + 1;
    }

    // Update is called once per frame
    void Update()
    {
        // if KeyCode Return pressed NumBalloons times, trigger Arrows play
        if (Input.GetKeyDown(KeyCode.Return))
        {
            CountDown = CountDown - 1;
        }

        if (CountDown == 0)
        {
            TheArrowsFolder.beatHasStarted = true;
        }
    }
}
