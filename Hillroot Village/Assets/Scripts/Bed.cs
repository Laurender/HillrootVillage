using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour
{
	public Transform player;
	private Inventory s2;

	private bool m_IsPlayerInRange;
	public int energyIncrease = 3;

	void Start()
	{
		s2 = GameObject.Find("Inventory").GetComponent<Inventory> ();
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space) && m_IsPlayerInRange)
		{
			s2.day += 1;
			Debug.Log("You go to sleep");
			s2.newnoon = true;
			s2.newday = true;
			s2.energy = 21 + energyIncrease * (s2.day - 1);
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
