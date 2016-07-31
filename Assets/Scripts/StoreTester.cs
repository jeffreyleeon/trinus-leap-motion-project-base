using UnityEngine;
using System.Collections;

public class StoreTester : MonoBehaviour {

	private HandStore store;

	// Use this for initialization
	void Start () {
		store = HandStore.Instance;
	}
	
	// Update is called once per frame
	void Update () {
		UpdateBullet ();
	}

	void UpdateBullet () {
		Debug.Log("======Hand appears? " + store.IsHandAppearing());
	}
}
