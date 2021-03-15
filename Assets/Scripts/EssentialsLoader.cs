using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssentialsLoader : MonoBehaviour
{
    public GameObject UIScreen;
    public GameObject player;
    // Start is called before the first frame update

    void Awake()
    {
        if(UIFade.instace == null)
        {
            Instantiate(UIScreen);
        }
        if(PlayerController.instance == null)
        {
            Instantiate(player);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
