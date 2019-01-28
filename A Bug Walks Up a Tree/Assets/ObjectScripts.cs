using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScripts : MonoBehaviour {

    public float turnSpeed;

    public GameObject tree;

    public float speed;

    public float jump;

    void Update()
    {
        //transform.Rotate(Vector3.up, -turn * Time.deltaTime);

        transform.RotateAround(tree.transform.position, tree.transform.up, -turnSpeed * Time.deltaTime);

        //transform.Translate(Vector3.forward * Time.deltaTime * speed);

        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
