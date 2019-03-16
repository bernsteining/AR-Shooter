using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plusScript : MonoBehaviour
{
    private float speed;
    private Vector3 direction;
    private float fadeTime;
    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(0,-20,0);
        transform.Translate(direction);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Initialize(float speed, Vector3 direction){
        this.speed = speed;
        this.direction = direction;
    }
}
