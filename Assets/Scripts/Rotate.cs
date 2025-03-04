using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 rotate;

    void Update()
    {
        transform.Rotate(rotate * Time.deltaTime);

        rotate.x += Time.deltaTime;
    }
}
