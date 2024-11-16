using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockRandomiser : MonoBehaviour
{
    // Minimum and maximum scale values for each axis
    public Vector3 minScale = new Vector3(0.8f, 0.8f, 0.8f);
    public Vector3 maxScale = new Vector3(1.2f, 1.2f, 1.2f);

    // Rotation range in degrees for each axis
    public float minRotationX = 0f;
    public float maxRotationX = 360f;
    public float minRotationY = 0f;
    public float maxRotationY = 360f;
    public float minRotationZ = 0f;
    public float maxRotationZ = 360f;

    void Start()
    {
        RandomizeObjectScale();
        RandomizeObjectRotation();
    }

    // Randomizes the scale within the specified range
    void RandomizeObjectScale()
    {
        float randomScaleX = Random.Range(minScale.x, maxScale.x);
        float randomScaleY = Random.Range(minScale.y, maxScale.y);
        float randomScaleZ = Random.Range(minScale.z, maxScale.z);

        transform.localScale = new Vector3(randomScaleX, randomScaleY, randomScaleZ);
    }

    // Randomizes the rotation within the specified range
    void RandomizeObjectRotation()
    {
        float randomRotationX = Random.Range(minRotationX, maxRotationX);
        float randomRotationY = Random.Range(minRotationY, maxRotationY);
        float randomRotationZ = Random.Range(minRotationZ, maxRotationZ);

        transform.rotation = Quaternion.Euler(randomRotationX, randomRotationY, randomRotationZ);
    }
}
