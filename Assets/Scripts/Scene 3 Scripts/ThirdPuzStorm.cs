using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPuzStorm : MonoBehaviour
{
    ThirdPuzScript thirdPuzzleScript;
    public GameObject puzzleContainer;

    public GameObject Knife;
    public GameObject bulletPrefab;

    public GameObject StormRing;

    // Start is called before the first frame update
    void Start()
    {
        thirdPuzzleScript = puzzleContainer.GetComponent<ThirdPuzScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Gun" && thirdPuzzleScript.HandCounter == 1 && !StormRing.activeSelf)
        {
            thirdPuzzleScript.completionCounterlvl3++;
            StormRing.SetActive(true);
        }
    }
}
