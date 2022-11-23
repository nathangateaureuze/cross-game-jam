using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Script_trace : MonoBehaviour
{
    [SerializeField] FixedJoystick joystick;
    [SerializeField] GameObject line;
    [SerializeField] GameObject ball;

    [SerializeField] GameObject menu;
    [SerializeField] GameObject pause;
    [SerializeField] GameObject joys;

    [SerializeField] Text balles;
    public int nballes = 5;
    [SerializeField] Text score;
    public int nscore = 0;

    bool shooting;

    Vector3 rotateur;

    float rotationx;
    float rotationy;

    float crotationx;
    float crotationy;

    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        balles.text = nballes.ToString();
        score.text = nscore.ToString();

        transform.rotation = Quaternion.Lerp(transform.rotation, new Quaternion(-1*crotationy/3.5f, crotationx/3.5f, 0, 1).normalized, 0.8f);

        if(joystick.Direction.magnitude > 0)
        {
            crotationx = rotationx + joystick.Direction.x;
            crotationy = rotationy + joystick.Direction.y;

            shooting = true;
            rotateur = transform.forward;
            line.SetActive(true);
        }
        else
        {
            if (shooting == true)
            {
                rotationx += joystick.Direction.x;
                rotationy += joystick.Direction.y;

                if (nballes > 0)
                {
                    nballes -= 1;

                    GameObject pew = Instantiate(ball);
                    pew.transform.position = transform.position;
                    pew.transform.rotation = transform.rotation;
                    pew.GetComponent<Script_ball>().shoot(rotateur);
                    shooting = false;
                }
            }
            line.SetActive(false);
        }
    }
    public void Loose()
    {
        if (nballes == 0)
        {
            menu.SetActive(true);
            joys.SetActive(false);
            pause.SetActive(false);
        } 
    }
}
