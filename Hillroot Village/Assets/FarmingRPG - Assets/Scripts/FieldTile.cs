using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldTile : MonoBehaviour
{
    //private Crop curCrop;
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
        Debug.Log("Interacted!");
    }
}
