using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeScript : MonoBehaviour
{
    Animator anim;
    public BoxCollider KnifeCollider;
    public GameObject Knife;

    // Start is called before the first frame update
    void Start()
    {
        anim= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("attacking", true);
            KnifeCollider.enabled = true;
        }

        else if (Input.GetButtonUp("Fire1"))
        {
            anim.SetBool("attacking", false);
            KnifeCollider.enabled = false;
        }
    }
}
