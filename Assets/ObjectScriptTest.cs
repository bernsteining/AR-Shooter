using UnityEngine;
using UnityEngine;
using System.Collections;

public class Apple : MonoBehaviour
{
    [SerializeField]
    private GameObject splashReference;
    private Vector3 randomPos = new Vector3(Random.Range(-1, 1), Random.Range(0.3f, 0.7f), Random.Range(-6.5f, -7.5f));
    private GUIText scoreReference;

    void Start()
    {
       
    }

    void Update()
    {
        /* Remove fruit if out of view */
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Line")
        {
            Camera.main.GetComponent<AudioSource>().Play();
            Destroy(gameObject);

            Instantiate(splashReference, randomPos, transform.rotation);

            /* Update Score */

            
        }
    }
}
