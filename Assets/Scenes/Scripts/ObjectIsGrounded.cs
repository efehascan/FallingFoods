using System;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using System.Collections;
using UnityEngine.UI; 

public class ObjectIsGrounded : MonoBehaviour
{
    private float delayTime = 2f;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            StartCoroutine(DestroyWithDelay(delayTime));
        }

        if (other.gameObject.tag == "Player")
        {
            ScoreManager.scoreCount += 1;
        }
    }

    IEnumerator DestroyWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }
}
