using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class PlayerInventory : MonoBehaviour {

	public GameObject Player;
	public bool Haskey = false;
	public Text keytext;



	void OnTriggerEnter (Collider other){

		if (other.tag == "Exit") {

			if (Haskey == true)
				Application.LoadLevel (4);

			if (Haskey == false) 
				keytext.text = ("You need a Key To progress");
		}
	}

			void OnTriggerExit (Collider other) {
			keytext.text = ("");
			}
	

		}
	

