using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called b

    CubeGenerator cg;

    void Start()
    {
        cg = transform.parent.gameObject.GetComponent<CubeGenerator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && this.gameObject.CompareTag("rightCube"))
        {
            cg.createCube();
            cg.createCube();
        }
    }
}
