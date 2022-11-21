using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Pause : MonoBehaviour
{
    [SerializeField] GameObject Joystick;

    public void Paused()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            Joystick.SetActive(false);
        }
        else
        {
            Time.timeScale = 1;
            Joystick.SetActive(true);
        }
    }
}
