using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPuzHeart : MonoBehaviour
{
    ThirdPuzScript thirdPuzzleScript;
    public GameObject puzzleContainer;

    public GameObject Knife;
    public GameObject bulletPrefab;

    public GameObject HeartRing;

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
        if (other.gameObject == Knife && !HeartRing.activeSelf)
        {
            thirdPuzzleScript.completionCounterlvl3++;
            HeartRing.SetActive(true);
        }
    }
}
