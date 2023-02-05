using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

	public TextMeshProUGUI infoText;
	public TextMeshProUGUI energyText;
	public GameObject inHand;
	public GameObject canvas;
	private RawImage inHandImage;
	private int currentItemImage;
	public static Inventory inventoryInstance;
	public static GameObject canvasInstance;

	public Texture[] items;
	
	void Awake()
	{
		if(inventoryInstance != null && inventoryInstance != this)
        {
			Destroy(gameObject);
        }
		else
        {
			DontDestroyOnLoad(gameObject);
			inventoryInstance = this;
			UpdateStatsText();
			UpdateEnergyText();
		}
		DontDestroyOnLoad(canvas);
		inHandImage = inHand.GetComponent<RawImage>();
	}

	public void UpdateStatsText()
	{
		infoText.text = $"Day: {day}\nMoney: ${Money}\nCarrots: {CarrotCounter}";
	}

	public void UpdateEnergyText()
    {
		energyText.text = $"Energy: {energy}\n";
	}

	public void ChangeInHand(int i)
    {
		inHandImage.texture = items[i];
		currentItemImage = i;
    }

	void Update()
    {
        if (hasHoe && currentItemImage != 1)
        {
			ChangeInHand(1);
			inHandImage.color = Color.white;
        }
		else if (hasWater && currentItemImage != 2)
        {
			ChangeInHand(2);
			inHandImage.color = Color.white;
		}
		else if(hasSeed && currentItemImage != 3)
        {
			ChangeInHand(3);
			inHandImage.color = Color.white;
		}
		else if(noItems && currentItemImage != 0)
        {
			ChangeInHand(0);
			inHandImage.color = Color.clear;
		}
		UpdateEnergyText();
    }

}
