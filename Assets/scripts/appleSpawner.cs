using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] appleReference;
    public static bool isGame = false;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void startSpawn(float rate){
        CancelInvoke();
        InvokeRepeating("SpawnFruit", 0.5f, rate);
    }

    void SpawnFruit()
    {
        if (isGame)
        {
            Quaternion RandomRotation = Quaternion.Euler(Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f));
            System.Random random = new System.Random();
            int randomNumber = random.Next(0, appleReference.Length);

            GameObject RandomGameObject = Instantiate(appleReference[randomNumber], transform.position, RandomRotation) as GameObject;

            Vector3 throwForce = new Vector3(Random.Range(-0.01f, 0.01f), Random.Range(0.7f, 0.7f), Random.Range(-0.2f, 0.2f));
            RandomGameObject.GetComponent<Rigidbody>().AddForce(throwForce, ForceMode.Impulse);
        }
    }

}