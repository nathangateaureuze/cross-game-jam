using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.VFX;

public class Script_ball : MonoBehaviour
{
    [SerializeField] ParticleSystem particules;
    GameObject trace;

    private void Start()
    {
        trace = GameObject.Find("line pivot");
    }

    public void shoot(Vector3 direction)
    {
        GetComponent<Rigidbody>().velocity = direction * 22;

        Destroy(gameObject, 2f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject, 0.04f);
    }
    void OnDestroy()
    {
        ParticleSystem effet = Instantiate(particules);
        effet.transform.position = transform.position;
        trace.GetComponent<Script_trace>().Loose();
    }
}
