using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
	public Transform player;
	public GameObject watercan;
	private Inventory s2;
	private bool m_IsPlayerInRange;
	void Start()
	{
		s2 = GameObject.Find("Inventory").GetComponent<Inventory> ();
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space) && m_IsPlayerInRange && s2.energy != 0)
		{
			if(!s2.hasWater && s2.noItems)
			{
				s2.hasWater = true;
				s2.noItems = false;
				s2.energy -= 1;
				watercan.SetActive(false);
			}
			else if(s2.hasWater && !s2.noItems)
			{
				s2.hasWater = false;
				s2.noItems = true;
				watercan.SetActive(true);
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
