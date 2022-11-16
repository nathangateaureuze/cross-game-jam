using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_cible : MonoBehaviour
{
    [SerializeField] GameObject disque;
    [SerializeField] GameObject trace;

    int mini = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(disque.transform.position.x + Random.Range(-1f, 1f), disque.transform.position.y + Random.Range(-1f, 1f), disque.transform.position.z - 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "balle")
        {
            mini++;

            trace.GetComponent<Script_trace>().nscore += 1;
            trace.GetComponent<Script_trace>().nballes += 1;

            disque.GetComponent<Script_cylinder>().fortnitesauverlemondepasbattleroyal();

            if (mini == 5 && transform.localScale.x >= 0.07)
            {
                mini = 0;
                transform.localScale = new Vector3(transform.localScale.x*0.9f, transform.localScale.y*0.9f, transform.localScale.z);
            }

            transform.position = new Vector3(disque.transform.localPosition.x + Random.Range(-1f, 1f), disque.transform.localPosition.y + Random.Range(-1f, 1f), disque.transform.position.z - 0.2f);
        }
    }
}