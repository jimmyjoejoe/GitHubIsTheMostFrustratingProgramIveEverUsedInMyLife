using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutorialLevel : MonoBehaviour {

	public Text Textbot1;
	
	IEnumerator OnTriggerEnter(Collider other){
		
		Textbot1.text = ("The Objective of the Game is to escape the Complex"); 
		yield return new WaitForSeconds (3);
		Textbot1.text = ("Avoid enemies and collect the Keys to Escape");
		yield return new WaitForSeconds (3);
		Textbot1.text = ("Good Luck.");
		yield return new WaitForSeconds (3);
		Textbot1.text = ("");
		
	}
	
	
}