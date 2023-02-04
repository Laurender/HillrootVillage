using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoe : MonoBehaviour
{
	public Transform player;
	public Inventory s2;
	private bool m_IsPlayerInRange;
	void Start()
	{
		s2 = GameObject.Find("Inventory").GetComponent<Inventory> ();
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space) && m_IsPlayerInRange)
		{
			if(!s2.hasHoe && s2.noItems)
			{
				s2.hasHoe = true;
				s2.noItems = false;
			}
			else if(s2.hasHoe && !s2.noItems)
			{
				s2.hasHoe = false;
				s2.noItems = true;
			}
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
