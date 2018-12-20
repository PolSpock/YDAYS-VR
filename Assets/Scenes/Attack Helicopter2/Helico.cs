using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helico : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        Animation animations = GetComponent<Animation>();
        animations.Play("Roatation+ Wheels");
    }
}
