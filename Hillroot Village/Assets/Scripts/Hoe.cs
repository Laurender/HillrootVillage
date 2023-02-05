using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoe : MonoBehaviour
{
	public Transform player;
	public GameObject hoe;
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
			if(!s2.hasHoe && s2.noItems)
			{
				s2.hasHoe = true;
				s2.noItems = false;
				s2.energy -= 1;
				hoe.SetActive(false);
			}
			else if(s2.hasHoe && !s2.noItems)
			{
				s2.hasHoe = false;
				s2.noItems = true;
				hoe.SetActive(true);
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
