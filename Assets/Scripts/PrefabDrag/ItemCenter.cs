using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemCenter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject centeredPos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        if (other.tag == "Trap")
        {
            other.transform.position = centeredPos.transform.position;
        }
    }
}
