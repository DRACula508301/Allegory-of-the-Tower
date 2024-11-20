using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float minX = -10.0f;
    public float maxX = 10.0f;
    public float minZ = -15.0f;
    public float maxZ = 10.0f;
    public float speed = 5.0f;

    private Vector3 targetPosition;
    private bool isMoving = true;

    void Start()
    {
        SetRandomTargetPosition();
        StartCoroutine(RandomBreak());
    }

    void Update()
    {
        if (isMoving)
        {
            MoveToTarget();
        }
    }

    void SetRandomTargetPosition()
    {
        float x = Random.Range(minX, maxX);
        float z = Random.Range(minZ, maxZ);
        targetPosition = new Vector3(x, transform.position.y, z);
    }

    void MoveToTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (transform.position == targetPosition)
        {
            SetRandomTargetPosition();
        }
    }

    IEnumerator RandomBreak()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(4.0f, 5.0f));
            isMoving = !isMoving;
            yield return new WaitForSeconds(Random.Range(1.0f, 5.0f));
            isMoving = !isMoving;
        }
    }
}
