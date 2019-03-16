using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] appleReference;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnFruit", 0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }



    void SpawnFruit()
    {
        Quaternion RandomRotation = Quaternion.Euler(Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f));
        System.Random random = new System.Random();
        int randomNumber = random.Next(0, appleReference.Length);

        GameObject RandomGameObject = Instantiate(appleReference[randomNumber], transform.position, RandomRotation) as GameObject;

        Vector3 throwForce = new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(0.7f, 0.7f), Random.Range(-0.1f, 0.1f));
        RandomGameObject.GetComponent<Rigidbody>().AddForce(throwForce, ForceMode.Impulse);
    }

}