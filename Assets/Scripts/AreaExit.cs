using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour {

    public string areaToLoad;
    public string areaTransitionName;
    public AreaEntrance theEntrance;
    // Start is called before the first frame update
    void Start()
    {
        theEntrance.nameTransition = areaTransitionName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
// Função para trocar de cena ao entrar no trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(areaToLoad);
            PlayerController.instance.areaTransitionName = areaTransitionName;
        }
    }
}
