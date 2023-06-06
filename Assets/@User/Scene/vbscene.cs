using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class vbscene : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject vbBtn;

	public string SceneNameLoad;

	// Use this for initialization
	void Start () {
		vbBtn = GameObject.Find ("vrBtn");
			vbBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}

	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{

			SceneManager.LoadScene (SceneNameLoad);
			Debug.Log ("BTN Pressed");
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{
		Debug.Log ("BTN Released");
	}
		
}
