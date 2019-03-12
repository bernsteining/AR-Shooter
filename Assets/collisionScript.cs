using UnityEngine;
using System.Collections;

public class collisionScript : MonoBehaviour
{
    
    

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //for this to work both need colliders, one must have rigid body (spaceship) the other must have is trigger checked.
    void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
    
        ScoreManager.score += 1;// add 1 point to the score when a collision happens

        Destroy(gameObject);//destruction of the object

    }

}
