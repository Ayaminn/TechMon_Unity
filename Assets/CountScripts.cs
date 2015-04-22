using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountScripts : MonoBehaviour {

	public int number;
	public Text text;
	public Text damage;
	
	public int total;
	public AudioSource sound;

	// Use this for initialization
	void Start () {
		number = 0;
		sound = GetComponent<AudioSource> ();	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CountUp () {
		number += 1;
		text.text = number.ToString ();
	}

	public void Attack (){
		total += number;
		damage.text = total.ToString ();
		sound.PlayOneShot (sound.clip);
	}

}
