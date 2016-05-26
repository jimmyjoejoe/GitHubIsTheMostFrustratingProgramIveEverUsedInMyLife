using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class RobotLabText : MonoBehaviour {
	
	public Text Textbot1;
	
	IEnumerator Text1(){
		
		Textbot1.text = ("Welcome to the Robot Lab"); 
		yield return new WaitForSeconds (3);
		Textbot1.text = ("test1");
		yield return new WaitForSeconds (5);
		Textbot1.text = ("test2");
		yield return new WaitForSeconds (4);
		Textbot1.text = ("test3");
		yield return new WaitForSeconds (4);
		Textbot1.text = ("test4");
		yield return new WaitForSeconds (4);
		Textbot1.text = ("");
		
	}
	
	
}