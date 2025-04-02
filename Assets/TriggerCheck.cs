using UnityEngine;
using System.Collections;

public class TriggerCheck : MonoBehaviour {
	public GameObject place;
	// Use this for initialization
	void Start () {
	
		place.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay(Collider col)
	{
		
		if (col.gameObject.CompareTag ("Player")) {	

			place.SetActive (true);
		}

	}

	void OnTriggerExit(Collider col)
	{

		if (col.gameObject.CompareTag ("Player")) {

			place.SetActive (false);
		}

	}
}
