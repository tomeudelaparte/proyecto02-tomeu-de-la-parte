using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float upperLimit = 30f;
    private float lowerLimit = -10f;

    void Update()
    {
        if (transform.position.z > upperLimit || transform.position.z < lowerLimit)
        {
            Destroy(gameObject);
        }
    }
}
