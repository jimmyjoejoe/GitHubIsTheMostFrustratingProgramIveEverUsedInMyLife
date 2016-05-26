using UnityEngine;
using System.Collections;

public class KeyPickup : MonoBehaviour {

	private PlayerInventory playerinventory; 
	void Start (){

		playerinventory = GetComponent<PlayerInventory> ();
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Key") {
			Destroy (other.gameObject);
			playerinventory.Haskey = true;
		}

}
}
