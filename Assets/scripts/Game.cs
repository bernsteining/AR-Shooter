using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField]
    GameObject Shooting;

    [SerializeField]
    GameObject UI;

    public bool GameStarted = false;
    // Start is called before the first frame update
    void Start()
    {
        Shooting.SetActive(false);
        UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(appleSpawner.isGame){
            Shooting.SetActive(true);
            UI.SetActive(true);
        }
    }
}
