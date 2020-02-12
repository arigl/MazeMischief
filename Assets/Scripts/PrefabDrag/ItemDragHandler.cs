using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDragHandler : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public GameObject trap;
    
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;

    public GameObject one2;
    public GameObject two2;
    public GameObject three2;
    public GameObject four2;
    public GameObject five2;
    public GameObject six2;

    public bool p1;

    public Camera BuildCam;

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("release");
        DropItem();
        transform.localPosition = Vector3.zero;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void DropItem()
    {
        //Debug.Log("DropItem");
        RaycastHit hit = new RaycastHit();
        Ray ray = BuildCam.ScreenPointToRay(Input.mousePosition);
        Debug.Log(Input.mousePosition);
        if(Physics.Raycast(ray, out hit, 100))
        {
            if (p1 == true)
            {
                Debug.Log("Ray out");
                if (hit.transform.tag == "one")
                {
                    Debug.Log("one");
                    Instantiate(trap, new Vector3(one.transform.position.x, one.transform.position.y, one.transform.position.z), Quaternion.identity);
                    trap.SetActive(true);
                    //trap.transform.position = one.transform.position;
                }
                if (hit.transform.tag == "two")
                {
                    Debug.Log("two");
                    Instantiate(trap, new Vector3(two.transform.position.x, two.transform.position.y, two.transform.position.z), Quaternion.identity);
                    trap.SetActive(true);
                    //trap.transform.position = two.transform.position;
                }
                if (hit.transform.tag == "three")
                {
                    Debug.Log("three");
                    Instantiate(trap, new Vector3(three.transform.position.x, three.transform.position.y, three.transform.position.z), Quaternion.identity);
                    trap.SetActive(true);
                    //trap.transform.position = three.transform.position;
                }
                if (hit.transform.tag == "four")
                {
                    Debug.Log("four");
                    Instantiate(trap, new Vector3(four.transform.position.x, four.transform.position.y, four.transform.position.z), Quaternion.identity);
                    trap.SetActive(true);
                    //trap.transform.position = four.transform.position;
                }
                if (hit.transform.tag == "five")
                {
                    Debug.Log("five");
                    Instantiate(trap, new Vector3(five.transform.position.x, five.transform.position.y, five.transform.position.z), Quaternion.identity);
                    trap.SetActive(true);
                    //trap.transform.position = five.transform.position;
                }
                if (hit.transform.tag == "six")
                {
                    Debug.Log("six");
                    Instantiate(trap, new Vector3(six.transform.position.x, six.transform.position.y, six.transform.position.z), Quaternion.identity);
                    trap.SetActive(true);
                    //trap.transform.position = six.transform.position;
                }
            }

            if (p1 == false)
            {
                Debug.Log("Ray out");
                if (hit.transform.tag == "one2")
                {
                    Debug.Log("one2");
                    Instantiate(trap, new Vector3(one2.transform.position.x, one2.transform.position.y, one2.transform.position.z), Quaternion.identity);
                    trap.SetActive(true);
                    //trap.transform.position = one.transform.position;
                }
                if (hit.transform.tag == "two2")
                {
                    Debug.Log("two2");
                    Instantiate(trap, new Vector3(two2.transform.position.x, two2.transform.position.y, two2.transform.position.z), Quaternion.identity);
                    trap.SetActive(true);
                    //trap.transform.position = two.transform.position;
                }
                if (hit.transform.tag == "three2")
                {
                    Debug.Log("three2");
                    Instantiate(trap, new Vector3(three2.transform.position.x, three2.transform.position.y, three2.transform.position.z), Quaternion.identity);
                    trap.SetActive(true);
                    //trap.transform.position = three.transform.position;
                }
                if (hit.transform.tag == "four2")
                {
                    Debug.Log("four2");
                    Instantiate(trap, new Vector3(four2.transform.position.x, four2.transform.position.y, four2.transform.position.z), Quaternion.identity);
                    trap.SetActive(true);
                    //trap.transform.position = four.transform.position;
                }
                if (hit.transform.tag == "five2")
                {
                    Debug.Log("five2");
                    Instantiate(trap, new Vector3(five2.transform.position.x, five2.transform.position.y, five2.transform.position.z), Quaternion.identity);
                    trap.SetActive(true);
                    //trap.transform.position = five.transform.position;
                }
                if (hit.transform.tag == "six2")
                {
                    Debug.Log("six2");
                    Instantiate(trap, new Vector3(six2.transform.position.x, six2.transform.position.y, six2.transform.position.z), Quaternion.identity);
                    trap.SetActive(true);
                    //trap.transform.position = six.transform.position;
                }
            }
        }
    }
 }
