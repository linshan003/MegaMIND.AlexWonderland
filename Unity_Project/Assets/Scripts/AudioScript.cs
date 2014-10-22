using UnityEngine;
using System.Collections;

public class AudioScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump")){
			if(audio.isPlaying)
				audio.Play ();
			else
				audio.Play ();
		}

	
	}
}
