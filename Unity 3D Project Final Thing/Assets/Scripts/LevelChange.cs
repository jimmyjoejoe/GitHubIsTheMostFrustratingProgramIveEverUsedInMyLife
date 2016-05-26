using UnityEngine;
using System.Collections;

public class LevelChange : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		Application.LoadLevel(1);
		}
}
