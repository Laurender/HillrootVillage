using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
	public Transform player;
	private Inventory s2;
	private bool m_IsPlayerInRange;

	void Start()
	{
		s2 = GameObject.Find("Inventory").GetComponent<Inventory> ();
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space) && m_IsPlayerInRange)
		{
			Debug.Log("GetEnergyHere(10 + days?): " + 10);
			if(s2.day < 5)
				s2.energy += 5 + s2.day;
			else
				s2.energy += 8 + s2.day;
			Destroy(gameObject);
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
