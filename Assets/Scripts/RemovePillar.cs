using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePillar : MonoBehaviour
{
    public float offset = 1.0f;
    public float waitTime = 60.0f;
    public float currentTime = 0.0f;
    public GameObject pillar;
    public GameObject collider;

    private void Start()
    {
    }

    private void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime <= waitTime){
            return;
        }
        if (pillar != null && Mathf.Abs(pillar.transform.position.x - transform.position.x) < offset && Mathf.Abs(pillar.transform.position.z - transform.position.z) < offset)
        {
            Destroy(pillar);
            collider.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
