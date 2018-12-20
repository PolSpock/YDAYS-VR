using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIHelico : MonoBehaviour {

    private RaycastHit Hit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * 15 * Time.deltaTime);

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit, 2))
        {
            transform.Rotate(Vector3.up * Random.Range(50, 200));
        }
	}
}
