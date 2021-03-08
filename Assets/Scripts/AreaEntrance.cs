using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEntrance : MonoBehaviour
{
    public string nameTransition;
    // Start is called before the first frame update
    void Start()
    {
        if(nameTransition == PlayerController.instance.areaTransitionName){
            PlayerController.instance.transform.position = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}