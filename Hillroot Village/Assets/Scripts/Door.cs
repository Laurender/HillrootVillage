using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
	public Transform player;
	private Inventory s2;
	private bool m_IsPlayerInRange;

	void Start()
	{
		if(SceneManager.GetActiveScene () == SceneManager.GetSceneByName("YardScene"))
			s2 = GameObject.Find("Inventory").GetComponent<Inventory> ();
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space) && m_IsPlayerInRange)
		{
			if(SceneManager.GetActiveScene () == SceneManager.GetSceneByName("HouseScene"))
				SceneManager.LoadScene("YardScene");
			else
			{
				s2.hasHoe = false;
				s2.hasSeed = false;
				s2.hasWater = false;
				s2.noItems = true;
				SceneManager.LoadScene("HouseScene");
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
