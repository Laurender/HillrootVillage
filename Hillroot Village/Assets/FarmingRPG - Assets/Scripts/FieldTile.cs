using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldTile : MonoBehaviour
{
    private Crop curCrop;
    public GameObject cropPrefab;

    public SpriteRenderer sr;

    private bool tilled;

    [Header("Sprites")]
    public Sprite grassSprite;
    public Sprite tilledSprite;
    public Sprite wateredTilledSprite;

    void Start()
    {
        //Set all tiles to grass at start
        sr.sprite = grassSprite;
    }

    public void Interact()
    {
        if (!tilled)
        {
            Till();
        } 
        else if(!HasCrop() && GameManager.instance.CanPlantCrop())
        {
            PlantNewCrop(GameManager.instance.selectedCropToPlant);
        }
        else if(HasCrop() && curCrop.CanHarvest())
        {
            curCrop.Harvest();
        }
        else
        {
            Water();
        }
    }

    void PlantNewCrop(CropData crop)
    {
        if (!tilled)
        {
            return;
        }

        curCrop = Instantiate(cropPrefab, transform).GetComponent<Crop>();
    }

    void Till()
    {

    }

    void Water()
    {

    }

    void OnNewDay()
    {

    }

    bool HasCrop()
    {
        return curCrop != null;
    }
}
