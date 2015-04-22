using UnityEngine;
using System.Collections;

public class MusicManagerScript : MonoBehaviour {

	private static bool isCreated = false;

	// Use this for initialization
	void Start () {

		if (!isCreated){
			DontDestroyOnLoad(this.gameObject);
			isCreated = true;
		}else{
			Destroy(this.gameObject);
		}
		
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
