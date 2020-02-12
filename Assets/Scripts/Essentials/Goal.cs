using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject respawn;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && PhaseManager.PlayerOne == false)
        {
            PhaseManager.p2timer = PhaseManager.timer;

            if (PhaseManager.p2timer < PhaseManager.p1timer)
            {
                Debug.Log("Player 2 Wins");
                //PhaseManager.Reset();
                SceneManager.LoadScene(5);
            }
            else
            {
                Debug.Log("Player 1 Wins");
                SceneManager.LoadScene(4);
            }
        }
        if (other.tag == "Player" && PhaseManager.PlayerOne == true)
        {
            PhaseManager.PlayerOne = false;
            PhaseManager.PlayerTwo = true;
            respawn = GameObject.FindWithTag("Respawn");
            other.transform.position = respawn.transform.position;
        }
    }
}
