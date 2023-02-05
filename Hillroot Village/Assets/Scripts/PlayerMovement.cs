using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
	public float horizontalInput;
	public float verticalInput;
	public float speed = 4f;

	Rigidbody2D bod;

	void Start()
	{
		bod = GetComponent<Rigidbody2D> ();
	}

	void Update()
	{
		horizontalInput = Input.GetAxis("Horizontal");
		verticalInput = Input.GetAxis("Vertical");

		transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);
		transform.Translate(Vector2.up * Time.deltaTime * speed * verticalInput);
		var position = new Vector3(transform.position.x, transform.position.y, 0);
		bod.MovePosition(position);															//Move the rigidbody to where the model is for the purpose of trigger events

		if(SceneManager.GetActiveScene () == SceneManager.GetSceneByName("YardScene"))		//Pelialueen rajat pihalla
		{
			if(transform.position.y > 1.1f)
				transform.position =  new Vector2(transform.position.x, 1.1f);
			if(transform.position.y < -4.1f)
				transform.position =  new Vector2(transform.position.x, -4.1f);
			if(transform.position.x < -11f)
				transform.position =  new Vector2(-11f, transform.position.y);
			if(transform.position.x > 6.3f)
				transform.position =  new Vector2(6.3f, transform.position.y);
		}
		else if(SceneManager.GetActiveScene () == SceneManager.GetSceneByName("HouseScene"))	//Pelialueen rajat talossa
		{
			if(transform.position.y > 3.3f)
				transform.position =  new Vector2(transform.position.x, 3.3f);
			if(transform.position.y < -3.4f)
				transform.position =  new Vector2(transform.position.x, -3.4f);
			if(transform.position.x < -9.4f)
				transform.position =  new Vector2(-9.4f, transform.position.y);
			if(transform.position.x > 9.2f)
				transform.position =  new Vector2(9.2f, transform.position.y);
		}
	}
}
