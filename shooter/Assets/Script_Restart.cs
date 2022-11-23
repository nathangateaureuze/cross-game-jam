using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_Restart : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
