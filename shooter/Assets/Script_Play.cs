using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Play : MonoBehaviour
{
    [SerializeField] GameObject Joystick;
    [SerializeField] GameObject menu;
    [SerializeField] GameObject pause;
    private void Start()
    {
        Time.timeScale = 0;
        Joystick.SetActive(false);
        pause.SetActive(false);
    }
    public void Play()
    {
        Time.timeScale = 1;
        Joystick.SetActive(true);
        pause.SetActive(true);
        menu.SetActive(false);
    }
}
