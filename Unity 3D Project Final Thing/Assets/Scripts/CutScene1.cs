// Animation Event example
// Small example that can be called on each specified frame.
// The code is executed once per animation loop.

using UnityEngine;
using System.Collections;

public class CutScene1:MonoBehaviour {
	
	public void PrintEvent() {
		Application.LoadLevel (3);
	}
}