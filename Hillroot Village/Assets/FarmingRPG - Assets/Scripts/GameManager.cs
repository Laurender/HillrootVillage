using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int curDay;
    public int money;
    public int cropInventory;

    public CropData selectedCropToPlant;
    public TextMeshProUGUI statsText;

    public event UnityAction onNewDay;

    //Singleton
    public static GameManager instance;

    void OnEnable()
    {
        Crop.onPlantCrop += OnPlantCrop;
        Crop.onHarvestCrop += OnHarvestCrop;
    }

    void OnDisable()
    {
        Crop.onPlantCrop -= OnPlantCrop;
        Crop.onHarvestCrop -= OnHarvestCrop;
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        } else
        {
            instance = this;
        }
    }

    public void SetNextDay()
    {
        curDay++;
        onNewDay?.Invoke();
        UpdateStatsText();
    }

    public void OnPlantCrop(CropData crop)
    {
        cropInventory--;

        UpdateStatsText();
    }

    public void OnHarvestCrop(CropData crop)
    {
        money += crop.sellPrice;
        UpdateStatsText();
    }

    public void PurhaceCrop(CropData crop)
    {
        money -= crop.purhacePrice;
        cropInventory++;
        UpdateStatsText();
    }

    public bool CanPlantCrop()
    {
        return cropInventory > 0;
    }

    public void OnBuyCropButton(CropData crop)
    {
        if(money >= crop.purhacePrice)
        {
            PurhaceCrop(crop);
        }
    }

    void UpdateStatsText()
    {
        statsText.text = $"Day: {curDay}\nMoney: ${money}\nCrop Inventory: {cropInventory}";
    }
}
