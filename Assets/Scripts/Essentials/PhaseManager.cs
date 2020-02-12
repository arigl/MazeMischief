using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhaseManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool PlayerOne;
    public static bool PlayerTwo;

    private static bool ResetTimer;

    public GameObject BuildCamera;

    public GameObject MazeCamera;

    public GameObject characterone;

    public GameObject BuildUI;
    public GameObject MazeUI;

    public GameObject MazeGO;

    public GameObject GameController;

    public Text BuildTimer;
    public Text MazeTimer;

    public bool Build;
    public bool Maze;

    public GameObject P1Body;
    public GameObject P2Body;

    Animator CharacterAnimator;

    public Avatar goblin;
    public Avatar knight;

    public static float timer = 0.0f;

    public static float p1timer;
    public static float p2timer;

    void Start()
    {
        Reset();
        BuildPhase();

        CharacterAnimator = characterone.GetComponent<Animator>();

        Debug.Log(CharacterAnimator.avatar);
        PlayerOne = true;
        PlayerTwo = false;
        // start build phase
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerOne == true)
        {
            P1Body.SetActive(true);
        }
        if (PlayerTwo == true && PlayerOne == false && ResetTimer == false)
        {
            P1Body.SetActive(false);
            P2Body.SetActive(true);
            p1timer = timer;
            timer = 0;
            CharacterAnimator.avatar = knight;
            ResetTimer = true;
        }
        timer += Time.deltaTime;
        int seconds = (int)timer % 60;


        if (seconds >= 20 && Build)
        {
            Build = false;
            MazePhase();
            timer = 0;
        }
        if (seconds <= 20 && Build)
        {
            BuildTimer.text = seconds + "";
        }
        else
        {
            MazeTimer.text = seconds + "";
        }
    }

    void BuildPhase()
    {
        Debug.Log("Build Phase");
        Cursor.visible = true;
        BuildCamera.SetActive(true);
        BuildUI.SetActive(true);
    }

    void MazePhase()
    {
        Debug.Log("Maze Phase");
        Cursor.visible = false;
        BuildCamera.SetActive(false);
        BuildUI.SetActive(false);

        
        MazeGO.SetActive(true);
        MazeCamera.SetActive(true);
        characterone.SetActive(true);
        if (PlayerOne == true)
        {
            P1Body.SetActive(true);
        }
        else
        {
            P2Body.SetActive(true);
        }
        MazeUI.SetActive(true);
        GameController.SetActive(true);
        
     
    }
    public void Reset()
    {
        
        MazeGO.SetActive(false);
        BuildCamera.SetActive(false);
        MazeCamera.SetActive(false);

        characterone.SetActive(false);
        P1Body.SetActive(false);
        P2Body.SetActive(false);
     
        BuildUI.SetActive(false);
        MazeUI.SetActive(false);

        Build = true;
        Maze = false;

        Cursor.visible = true;
    }
}
