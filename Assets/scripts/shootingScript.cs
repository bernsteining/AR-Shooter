using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingScript : MonoBehaviour
{
    public GameObject canvas;
    public GameObject explosion;
    public GameObject gameCamera;
    public float previousTime=0;
    public float hitTime;
    // Start is called before the first frame update
    void Start()
    {
        floatinTextController.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {

        RaycastHit hit;

        if (Physics.Raycast(gameCamera.transform.position, gameCamera.transform.forward, out hit))
        {

            if (hit.transform.name 
                != "HitCube")
            {

                hitTime = Time.time;
                Destroy(hit.transform.gameObject);
                if (Combo())
                {
                    floatinTextController.CreateFloatingText("+40", transform,new Color(0.4f, 0.6f, 1f));

                }
                else
                {
                    floatinTextController.CreateFloatingText("+20", transform,new Color(1.0f, 0.6f, 1f));
                }
                GameObject go = Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));
                Score.Increase(10);
                previousTime = hitTime;
            }
        }

    }
    private bool Combo(){
        if (hitTime - previousTime > 2)
        {
            return false;
        }
        else { return true; }

    }
}
