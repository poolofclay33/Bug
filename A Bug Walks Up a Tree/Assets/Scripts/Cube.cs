using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour, PooledObject {

	public void OnObjectSpawn()
    {
        transform.position = new Vector3(0, 10f);
    }
}
