using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
	public bool hasHoe = false;
	public bool hasSeed = false;
	public bool hasWater = false;
	public bool noItems = true;
	public int CarrotCounter = 0;
	void Start()
	{

	}

	void Update()
	{
		if(hasHoe && hasSeed && hasWater)
			Debug.Log("hasAll");
	}

}
