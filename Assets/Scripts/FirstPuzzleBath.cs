using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPuzzleBath : MonoBehaviour
{
    PuzzleScript puzzleScript;
    public GameObject puzzleContainer;

    public GameObject Knife;
    public GameObject bulletPrefab;

    public GameObject BathRing;

    // Start is called before the first frame update
    void Start()
    {
        puzzleScript = puzzleContainer.GetComponent<PuzzleScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Knife && !BathRing.activeSelf)
        {
            puzzleScript.completionCounter++;
            BathRing.SetActive(true);
        }
    }
}
