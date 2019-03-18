using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField]
    GameObject Shooting;

    [SerializeField]
    GameObject UI;

    [SerializeField]
    GameObject PauseScreen;

    [SerializeField]
    GameObject Portal;


    public bool GameStarted = false;
    // Start is called before the first frame update
    void Start()
    {
        Shooting.SetActive(false);
        UI.SetActive(false);
        PauseScreen.SetActive(false);
        Portal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (appleSpawner.isGame)
        {
            GameObject Plane = GameObject.Find("Plane");
            if (Plane){
                Destroy(Plane);
            }
            Portal.SetActive(true);
            Shooting.SetActive(true);
            UI.SetActive(true);
        }
    }

    public void Pause()
    {
        PauseScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {

        PauseScreen.SetActive(false);
        Time.timeScale = 1;
    }
}
