using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecPuzHat : MonoBehaviour
{
    SecPuzzleScript secPuzzleScript;
    public GameObject puzzleContainer;

    public GameObject Knife;
    public GameObject bulletPrefab;

    public GameObject HatRing;
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
        if (other.gameObject.tag == "Gun" && !HatRing.activeSelf)
        {
            secPuzzleScript.completionCounterlvl2++;
            HatRing.SetActive(true);
        }
    }
}
