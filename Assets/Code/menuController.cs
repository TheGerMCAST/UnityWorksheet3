using UnityEngine;
using System.Collections;

public class menuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void ButtonPress()
	{
		//what happens when the button is pressed.  We can put in the name of the scene we 
		//want to load
		Application.LoadLevel ("Game");
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
