using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPuzBath : MonoBehaviour
{
    ThirdPuzScript thirdPuzzleScript;
    public GameObject puzzleContainer;

    public GameObject Knife;
    public GameObject bulletPrefab;

    public GameObject BathRing;

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
        if (other.gameObject == Knife && !BathRing.activeSelf)
        {
            thirdPuzzleScript.completionCounterlvl3++;
            BathRing.SetActive(true);
        }
    }
}
