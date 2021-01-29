using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightController : MonoBehaviour
{

    public GameObject targetLight;
    public GameObject targetMainCamera;
    public Material[] skys;
    public float dayTimer;
    public bool isCycle;


    private void Awake()
    {
        targetLight = GameObject.FindGameObjectWithTag("Light");
        targetMainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }


    void Start()
    {
        dayTimer = targetLight.GetComponent<Light>().intensity;
    }

    void Update()
    {
        if (!isCycle)
        {
        targetLight.GetComponent<Light>().intensity = dayTimer -= Time.deltaTime * 0.05f;
            if(dayTimer <= 0)
            {
                isCycle = true;
            }
        } else if (isCycle)
        {
            targetLight.GetComponent<Light>().intensity = dayTimer += Time.deltaTime * 0.05f;
            if (dayTimer >= 1)
            {
                isCycle = false;
            }
        }

        ChangeCycle();
    }


    void ChangeCycle()
    {
        if (dayTimer >= 0.7f)
        {
            targetMainCamera.GetComponent<Skybox>().material = skys[0];
        }
        else if (dayTimer >= 0.5f)
        {
            targetMainCamera.GetComponent<Skybox>().material = skys[1];
        }
        else if (dayTimer >= 0.3f)
        {
            targetMainCamera.GetComponent<Skybox>().material = skys[2];
        }
        else if (dayTimer >= 0.1f)
        {
            targetMainCamera.GetComponent<Skybox>().material = skys[3];
        }
        else if (dayTimer >= 0.5f)
        {
            targetMainCamera.GetComponent<Skybox>().material = skys[4];
        }
        else if (dayTimer >= 0.4f)
        {
            targetMainCamera.GetComponent<Skybox>().material = skys[5];
        }
        else if (dayTimer >= 0.3f)
        {
            targetMainCamera.GetComponent<Skybox>().material = skys[6];
        }
        else if (dayTimer >= 0.2f)
        {
            targetMainCamera.GetComponent<Skybox>().material = skys[7];
        }
        else if (dayTimer >= 0.1f)
        {
            targetMainCamera.GetComponent<Skybox>().material = skys[8];
        }
    }





}
