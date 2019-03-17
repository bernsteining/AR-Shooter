using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{   
    private float speed=1f;
    private float timer = 120f;
    // Start is called before the first frame update
    void Start()
    {
        this.Awake();
    }

    private void Update()
    {
        this.GetComponent<Text>().text = this.timer+"";
    }

    public void Awake()
    {
        StartCoroutine(ActiveTimer());
    }

    public void setSpeed(float speed){
        this.speed = speed;
    }

    private IEnumerator ActiveTimer()
    {
        while (true){
            yield return new WaitForSeconds(this.speed);
            this.timer -= 1f;
        }
    }
}
