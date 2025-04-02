using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Webcamtex : MonoBehaviour {
GUITexture gui;
	//Camera c1;
	//Renderer render;
		//Image m1;

	// Use this for initialization
	void Start () {
	//	c1 = GetComponent<Camera> ();
		//render = GetComponent<Renderer> ();
		//m1 = GetComponent<Image> ();
	gui = GetComponent<GUITexture> ();
	
		WebCamTexture webcam = new WebCamTexture ();
		//render.material.mainTexture = webcam;
		//m1.material.mainTexture = webcam;
	gui.texture = webcam;
		webcam.Play ();
	}	
	
	// Update is called once per frame
	void Update () {



	
	}
}
