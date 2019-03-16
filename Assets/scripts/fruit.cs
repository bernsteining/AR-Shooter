using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruit : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -10)
        {
            Destroy(gameObject);
        }

        gameObject.transform.Rotate(Random.Range(0.0f, 2.0f), Random.Range(0.0f, 2.0f), Random.Range(0.0f, 2.0f));

    }
}
