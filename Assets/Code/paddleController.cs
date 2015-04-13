using UnityEngine;
using System.Collections;

public class paddleController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//1. Get mouse position
		Vector3 mousePos = Input.mousePosition;
		//2. translate the mouse position to world points
		mousePos = Camera.main.ScreenToWorldPoint (mousePos);
		//3. set the paddle position
		transform.position = new Vector3 (mousePos.x, transform.position.y, 10f);

		//4. check if the left mouse button is pressed
		if (Input.GetMouseButton (0)) 
		{

		}
	
	}
}
