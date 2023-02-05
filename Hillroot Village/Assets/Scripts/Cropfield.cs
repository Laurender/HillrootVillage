using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cropfield : MonoBehaviour
{
	public Transform player;
	private Inventory s2;
	public int numb;
	public int numberOfCarrotsPerPatch = 1;

	private bool m_IsPlayerInRange;
	SpriteRenderer rendererr;
	void Awake()
	{
		DontDestroyOnLoad(gameObject);
	}

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
				s2.CarrotCounter += numberOfCarrotsPerPatch;
				s2.energy -= 2;
				numb = 0;
			}
			if(numb == 2 && s2.hasWater)
			{
				s2.energy -= 1;
				numb += 1;
			}
			if(numb == 1 && s2.hasSeed)
			{
				if(s2.day > 15)
					s2.energy -= 1;
				else
					s2.energy -= 2;
				numb += 1;
			}
			if(numb == 0 && s2.hasHoe)
			{
				if(s2.day > 20)
					s2.energy -= 1;
				else if(s2.day > 10)
					s2.energy -= 2;
				else
					s2.energy -= 3;
				numb += 1;
			}


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
