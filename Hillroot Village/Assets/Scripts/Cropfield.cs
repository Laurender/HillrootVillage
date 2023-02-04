using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cropfield : MonoBehaviour
{
	public Transform player;
	public int numb;
	public Inventory s2;

	private bool m_IsPlayerInRange;
	SpriteRenderer rendererr;

	void Start()
	{
		numb = 0;
		s2 = GameObject.Find("Inventory").GetComponent<Inventory> ();
	}

	void Update()
	{
		rendererr = GetComponent<SpriteRenderer> ();
		
		if(Input.GetKeyDown(KeyCode.Space) && m_IsPlayerInRange)
		{
			Debug.Log("space #" + numb);
			rendererr.color = new Color(220f, 24f, 24f, 200f);

			if(numb == 3 /*&& tomorrow*/)
			{
				Debug.Log("get carrot");
				numb = 0;
			}
			if(numb == 2 && s2.hasWater)
				numb += 1;
			if(numb == 1 && s2.hasSeed)
				numb += 1;
			if(numb == 0 && s2.hasHoe)
				numb += 1;


			//if(m_IsPlayerInRange)
				//Debug.Log("inRange");
			//energy -= 1;

		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.transform == player)
			m_IsPlayerInRange = true;
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if(other.transform == player)
			m_IsPlayerInRange = false;
	}
}
