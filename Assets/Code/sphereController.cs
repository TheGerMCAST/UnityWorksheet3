using UnityEngine;
using System.Collections;

public class sphereController : MonoBehaviour {

	//11. create variable for hit counter
	int hitcount = 0;


	//10. create the collision function
	void OnCollisionEnter2D(Collision2D ballhit)
	{
		//12. check the tag of the object I hit
		if (ballhit.collider.gameObject.tag == "aipaddle") 
		{
			//13. how many times have I hit the paddle? 
			hitcount++;
			//14. temporarily output the value of hitcount
			Debug.Log (hitcount);
		}

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//1. Reset the scene if the ball goes UP out of the screen or DOWN below the paddle

		//2. Add a light background image and turn the paddles black and the ball red

		//3. Show the hitcount in the top left corner of the screen

		//4. Create a minutes / seconds timer in the top right corner of the screen

	}
}
