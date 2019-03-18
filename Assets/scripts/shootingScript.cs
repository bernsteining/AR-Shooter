using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingScript : MonoBehaviour
{
    public GameObject canvas;
    public GameObject explosion;
    public GameObject Clockexplosion;
    public GameObject gameCamera;
    public float previousTime = 0;
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

            if (hit.transform.name != "HitCube")
            {
                if (hit.transform.name == "TNT(Clone)")
                {
                    floatinTextController.CreateFloatingText("-40", transform, new Color(1f, 0f, 0f));
                    Score.Increase(-40);
                    Destroy(hit.transform.gameObject);
                    GameObject go = Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));
                    if (Time.timeScale == 0.5f)
                    {
                        Time.timeScale = 1f;
                    }
                }

                else if (hit.transform.name == "Clock(Clone)")
                {
                    Time.timeScale = 0.5f;
                    Destroy(hit.transform.gameObject);
                    GameObject go = Instantiate(Clockexplosion, hit.point, Quaternion.LookRotation(hit.normal));
                }

                else
                {
                    hitTime = Time.time;
                    Destroy(hit.transform.gameObject);

                    if (Time.timeScale == 0.5f)
                    {
                        Time.timeScale = 1f;
                    }

                    if (Combo())
                    {
                        floatinTextController.CreateFloatingText("+40", transform, new Color(0.4f, 0.6f, 1f));

                    }
                    else
                    {
                        floatinTextController.CreateFloatingText("+20", transform, new Color(1.0f, 0.6f, 1f));
                    }
                    GameObject go = Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));
                    Score.Increase(10);
                    previousTime = hitTime;
                }
            }
        }

    }
    private bool Combo()
    {
        if (hitTime - previousTime > 2)
        {
            return false;
        }
        else { return true; }

    }
}
