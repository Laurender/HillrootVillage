using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public int curDay;
    public int money;
    public int cropInventory;

    public CropData selectedCropToPlant;

    //public event UnityAction onNewDay;

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

    }

    public void OnPlantCrop(CropData crop)
    {
        cropInventory--;
    }

    public void OnHarvestCrop(CropData crop)
    {
        money += crop.sellPrice;
    }

    public void PurhaceCrop(CropData crop)
    {

    }

    public bool CanPlantCrop()
    {
        return true;
    }

    public void OnBuyCropButton(CropData crop)
    {

    }

    void UpdateStatsText()
    {

    }
}
