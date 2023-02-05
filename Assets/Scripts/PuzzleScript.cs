using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleScript : MonoBehaviour
{
    public GameObject Hand;
    public GameObject Wind;
    public GameObject Wings;

    public GameObject HandRing;
    public GameObject WindRing;
    public GameObject WingsRing;

    public GameObject BottomWall;
    public GameObject ExitRoom;

    public int HandCounter = 0;
    public int completionCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(completionCounter == 2)
        {
            //open door
            BottomWall.SetActive(false);
            ExitRoom.SetActive(true);
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
        }
        if (other.gameObject == Wings)
        {
            WingsRing.SetActive(true);
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
        }
        if (other.gameObject == Wings)
        {
            WingsRing.SetActive(false);
        }
    }
}
