using UnityEngine;
using System.Collections;

public class HandListener : MonoBehaviour {

	private HandController handController;
	private HandStore handStore;

	// Use this for initialization
	void Start () {
		handController = GetComponent<HandController>();
		handStore = HandStore.Instance;
	}
	
	// Update is called once per frame
	void Update () {
		UpdateHandStore (); // Updating graphical hands
	}

	private void UpdateHandStore () {
		HandModel[] handModelArray = handController.GetAllGraphicsHands ();
		handStore.SetHandModels(handModelArray);
		// Temp
//		Debug.Log ("====Hand model array: " + handModelArray.Length);
//		for (int i = 0; i < handModelArray.Length; i++) {
//			HandModel handModel = handModelArray [i];
//			Leap.Hand hand = handModel.GetLeapHand ();
//			Debug.Log ("======hand is left? " + hand.IsLeft);
//			Debug.Log ("======hand is right? " + hand.IsRight);
//		}
	}
}
