using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Crop : MonoBehaviour
{
    private CropData curCrop;
    private int plantDay;
    private int daysSinceLastWatered;

    public SpriteRenderer sr;

    public static event UnityAction<CropData> onPlantCrop;
    public static event UnityAction<CropData> onHarvestCrop;

    public void Plant(CropData crop)
    {

    }

    public void NewDayCheck()
    {

    }

    void UpdateCropSprite()
    {

    }

    public void Water()
    {

    }

    public void Harvest()
    {

    }

    int CropProgress()
    {

    }
}
