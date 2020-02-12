using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] trapPrefabs;
    private Transform playerTransform;
    private Vector3 spawn = new Vector3(5.90404f, 10.020874f, 9.50113f);
    private float prefabLength = 50.48f;
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        SpawnSequence();
        SpawnSequence();
        SpawnSequence();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.z > (spawn.z - 5 * prefabLength))
        {
            SpawnSequence();
        }
    }

    private void SpawnSequence(int index = -1)
    {
        GameObject go;
        go = Instantiate(trapPrefabs[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = spawn;
        spawn.z += prefabLength;
    }
}
