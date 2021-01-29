using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class FishingRod : MonoBehaviour
{
    public AudioClip castAudio;
    private AudioSource audioSource;

    public GameObject fish;
    public GameObject bob;
    public float speed = 20;
    public Transform barrel;
    public Transform bucket;

    public int bobLimit = 1;
    List<GameObject> bobs = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        bob.GetComponent<Rigidbody>().useGravity = true;
    }

    public void Cast()
    {
        if (bobs.Count < bobLimit)
        {
            StartCoroutine(FishingTime());

            GameObject spawnedBob = Instantiate(bob, barrel.position, barrel.rotation);
            spawnedBob.GetComponent<Rigidbody>().velocity = speed * barrel.forward;
            audioSource.PlayOneShot(castAudio);
            bobs.Add(bob);
        }
        else 
        {          
            Debug.Log("Oh Yea");
        }
    }

    IEnumerator FishingTime()
    {
        int wait_time = Random.Range(10, 30);
        yield return new WaitForSeconds(wait_time);
        print("I waited for " + wait_time + "sec");
        GameObject spawnedFish = Instantiate(fish, bucket.position, bucket.rotation);
        spawnedFish.GetComponent<Rigidbody>().velocity = speed * bucket.forward;
    }
}


