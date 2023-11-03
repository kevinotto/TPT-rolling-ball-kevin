using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    public float RotationSpeed1 = 10;
    public float RotationSpeed2 = 10;
    public float RotationSpeed3 = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotationSpeed1*Time.deltaTime, RotationSpeed2*Time.deltaTime, RotationSpeed3*Time.deltaTime);
    }
}
