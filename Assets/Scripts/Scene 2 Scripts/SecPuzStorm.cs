using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecPuzStorm : MonoBehaviour
{
    SecPuzzleScript secPuzzleScript;
    public GameObject puzzleContainer;

    public GameObject Knife;
    public GameObject bulletPrefab;

    public GameObject StormInnerRing;
    public GameObject StormSecondaryRing;

    // Start is called before the first frame update
    void Start()
    {
        secPuzzleScript = puzzleContainer.GetComponent<SecPuzzleScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Gun" && secPuzzleScript.WindCounter == 1 && !StormInnerRing.activeSelf)
        {
            secPuzzleScript.completionCounterlvl2++;
            StormInnerRing.SetActive(true);
        }
        if (other.gameObject == Knife && !StormSecondaryRing.activeSelf)
        {
            secPuzzleScript.completionCounterlvl2++;
            StormSecondaryRing.SetActive(true);
        }
    }
}
