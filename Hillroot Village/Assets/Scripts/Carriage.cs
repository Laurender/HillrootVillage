using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carriage : MonoBehaviour
{
	public Transform player;
	private Inventory s2;

	public int carrotPrice = 10;
	private bool m_IsPlayerInRange;
	void Start()
	{
		s2 = GameObject.Find("Inventory").GetComponent<Inventory> ();
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space) && m_IsPlayerInRange && s2.CarrotCounter > 0)
		{
			Debug.Log("Carrot checkout");
			s2.Money += carrotPrice * s2.CarrotCounter;
			s2.CarrotCounter = 0;
			s2.UpdateStatsText();
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
