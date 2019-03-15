using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject appleReference;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFruit", 0.3f, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnFruit()
    {

        GameObject Sphere = Instantiate(appleReference, transform.position, Quaternion.identity) as GameObject;
        Vector3 throwForce = new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(0.3f, 0.35f), Random.Range(-0.1f, 0.1f));
        Sphere.GetComponent<Rigidbody>().AddForce(throwForce, ForceMode.Impulse);

    }
}