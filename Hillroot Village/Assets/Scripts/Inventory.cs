using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
	public bool hasHoe = false;
	public bool hasSeed = false;
	public bool hasWater = false;
	public bool noItems = true;
	public bool newday = true;
	public bool newnoon = true;

	public int day = 1;
	public int energy = 21;
	public int CarrotCounter = 0;
	public int Money = 0;
	
	void Awake()
	{
		DontDestroyOnLoad(gameObject);
	}

	void Update()
	{
	}

}
