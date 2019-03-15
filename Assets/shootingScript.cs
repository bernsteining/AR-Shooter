using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingScript : MonoBehaviour
{
    public GameObject explosion;
    public GameObject gameCamera;
    // Start is called before the first frame update
    void Start()
    {
        
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

            if (hit.transform.name == "Sphere(Clone)")
            {

                Destroy(hit.transform.gameObject);

                GameObject go = Instantiate(explosion, hit.point, Quaternion.LookRotation(hit.normal));


            }
        }

    }
}
