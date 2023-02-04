using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float horizontalInput;
	public float verticalInput;
	public float speed = 4f;

	//private float m_Movement;
	Rigidbody2D bod;

	void Start()
	{
		bod = GetComponent<Rigidbody2D> ();
	}

	void Update()
	{
		horizontalInput = Input.GetAxis("Horizontal");
		verticalInput = Input.GetAxis("Vertical");
		//m_Movement.Set(horizontalInput, verticalInput);
		//Debug.Log(m_Movement);
		transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);
		transform.Translate(Vector2.up * Time.deltaTime * speed * verticalInput);
		var position = new Vector3(transform.position.x, transform.position.y, 0);
		bod.MovePosition(position);
	}
}
