using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
	public bool hasHoe = false;
	public bool hasSeed = false;
	public bool hasWater = false;
	void Start()
	{
		//hasHoe = true;
		hasSeed = true;
		if(hasHoe && hasSeed && hasWater)
			Debug.Log("hasHoe");
	}

	void Update()
	{
		
	}
}
