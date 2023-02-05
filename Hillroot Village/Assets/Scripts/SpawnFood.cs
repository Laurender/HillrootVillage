using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
	public GameObject food;
	private Inventory s2;

	public bool newday = true;

	void Start()
	{
		s2 = GameObject.Find("Inventory").GetComponent<Inventory> ();
	}

	void Update()
	{
		if(s2.newday)
		{
			var pos = new Vector3(7.63f, 0.8f, 0f);
			Instantiate(food, pos, food.transform.rotation).SetActive(true);
			s2.newday = false;
		}
	}
}
