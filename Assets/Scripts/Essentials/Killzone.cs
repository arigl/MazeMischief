using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Killzone : MonoBehaviour
{
    public int sceneNumber;
    public GameObject respawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            respawn = GameObject.FindWithTag("Respawn");
            other.transform.position = respawn.transform.position;
            //SceneManager.LoadScene(sceneNumber);
        }
    }
}
