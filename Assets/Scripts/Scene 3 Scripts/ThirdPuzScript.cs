using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPuzScript : MonoBehaviour
{
    public GameObject Hand;
    public GameObject Wind;
    public GameObject Wings;

    public GameObject HandRing;
    public GameObject WindRing;
    public GameObject WingsRing;

    public GameObject ExitDoor;
    public GameObject ExitText;
    public GameObject NextSceneBlock;

    public int HandCounter = 0;
    public int WindCounter = 0;
    public int WingsCounter = 0;

    public int completionCounterlvl3 = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (completionCounterlvl3 == 5)
        {
            //open door
            ExitDoor.SetActive(false);
            print("success");
            ExitText.gameObject.SetActive(true);
            NextSceneBlock.gameObject.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Hand)
        {
            HandRing.SetActive(true);
            HandCounter++;
        }
        if (other.gameObject == Wind)
        {
            WindRing.SetActive(true);
            WindCounter++;
        }
        if (other.gameObject == Wings)
        {
            WingsRing.SetActive(true);
            WingsCounter++;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Hand)
        {
            HandRing.SetActive(false);
            HandCounter--;
        }
        if (other.gameObject == Wind)
        {
            WindRing.SetActive(false);
            WindCounter--;
        }
        if (other.gameObject == Wings)
        {
            WingsRing.SetActive(false);
            WingsCounter--;
        }
    }
}
