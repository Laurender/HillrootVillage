using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cropfield : MonoBehaviour
{
    public Transform player;
    private int numb = 0;

    bool isPlayerInRange = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            numb += 1;
            Debug.Log("space" + numb);
            
            if(isPlayerInRange)
                Debug.Log("inRange");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.transform == player)
        {
            isPlayerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.transform == player)
        {
            isPlayerInRange = false;
        }
    }
}
