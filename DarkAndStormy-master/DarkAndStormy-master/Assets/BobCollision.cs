using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobCollision : MonoBehaviour
{
    public AudioSource collisionSound;
    public ParticleSystem effect;
    public GameObject bob;

    void Start()
    {
        effect = GetComponent<ParticleSystem>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        effect.Play();
    }
}
