using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPuzBlood : MonoBehaviour
{
    ThirdPuzScript thirdPuzzleScript;
    public GameObject puzzleContainer;

    public GameObject Knife;
    public GameObject bulletPrefab;

    public GameObject BloodRing;

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
        if (other.gameObject.tag == "Gun" && thirdPuzzleScript.WindCounter == 1 && !BloodRing.activeSelf)
        {
            thirdPuzzleScript.completionCounterlvl3++;
            BloodRing.SetActive(true);
        }
    }
}
