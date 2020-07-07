using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyTile : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collisionInfo)
    {
        Destroy(collisionInfo.gameObject);

    }
}
