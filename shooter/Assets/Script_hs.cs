using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Script_hs : MonoBehaviour
{
    [SerializeField] Text texths;
    // Start is called before the first frame update
    void Update()
    {
        GameObject trace = GameObject.Find("line pivot");
        if (trace.GetComponent<Script_trace>().nscore > PlayerPrefs.GetInt("hs"))
        {
            PlayerPrefs.SetInt("hs", trace.GetComponent<Script_trace>().nscore);
        }
        texths.text = "High Score: " + PlayerPrefs.GetInt("hs");
    }
}
