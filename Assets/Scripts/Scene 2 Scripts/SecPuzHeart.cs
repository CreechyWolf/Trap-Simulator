using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecPuzHeart : MonoBehaviour
{
    SecPuzzleScript secPuzzleScript;
    public GameObject puzzleContainer;

    public GameObject Knife;
    public GameObject bulletPrefab;

    public GameObject HeartRing;
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
        if (other.gameObject.tag == "Gun" && secPuzzleScript.WingsCounter == 1 && !HeartRing.activeSelf)
        {
            secPuzzleScript.completionCounterlvl2++;
            HeartRing.SetActive(true);
        }
    }
}
