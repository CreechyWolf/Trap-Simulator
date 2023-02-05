using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Level 1");
    }
}
