using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class canvasScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(appleSpawner.isGame){
            this.gameObject.SetActive(true);
        }
    }
}
