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

		//5. create a variable for the x position, and fill it with the clamped mouse position value
		float xpos = Mathf.Clamp (mousePos.x, -3.6f, 3.6f);


		//3. set the paddle position
		transform.position = new Vector3 (xpos, transform.position.y, 10f);

		//4. check if the left mouse button is pressed
		if (Input.GetMouseButton (0)) 
		{
			//6. create a reference to the sphere so we can manipulate it programmatically
			GameObject theball = GameObject.FindGameObjectWithTag ("sphere");

			//7. disconnect the ball from the paddle
			theball.transform.parent = null;

			//8. rotate the ball 45 degrees from vertical
			theball.transform.rotation = Quaternion.Euler (0f,0f,45f);

			//9. hit the ball forward.  20f is the speed of the ball
			theball.GetComponent<Rigidbody2D>().velocity = theball.transform.up * 20f;

		}
	
	}
}
