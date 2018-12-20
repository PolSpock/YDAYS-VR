using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mi24 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        AudioSource sound = GetComponent<AudioSource>();
        sound.Play(0);
    }
	
	// Update is called once per frame
	void Update () {
        Animation animations = GetComponent<Animation>();
        animations.Play("Roatation+ Wheels");
    }
}
