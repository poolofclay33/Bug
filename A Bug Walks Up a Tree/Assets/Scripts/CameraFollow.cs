using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject objectToFollow;
    
    public float speed = 2.0f;

    public float turnSpeed;

    public GameObject tree;
    public GameObject player;

    void Update () {
        /*
        float interpolation = speed * Time.deltaTime;
        
        Vector3 position = this.transform.position;
        position.y = Mathf.Lerp(this.transform.position.y, objectToFollow.transform.position.y, interpolation);
        position.x = Mathf.Lerp(this.transform.position.x, objectToFollow.transform.position.x, interpolation);
        
        this.transform.position = position;
        */

        transform.RotateAround(tree.transform.position, tree.transform.up, -turnSpeed * Time.deltaTime);

        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
