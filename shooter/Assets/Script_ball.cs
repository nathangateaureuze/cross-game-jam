using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Script_ball : MonoBehaviour
{
    [SerializeField] GameObject piou;
    [SerializeField] ParticleSystem particules;

    public void shoot(Vector3 direction)
    {
        GetComponent<Rigidbody>().velocity = direction * 22;

        Destroy(gameObject, 2f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(particules, transform);
        Destroy(gameObject, 0.04f);
    }
}
