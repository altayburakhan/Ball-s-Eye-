using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Playgame : MonoBehaviour
{
    public void OtherScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
