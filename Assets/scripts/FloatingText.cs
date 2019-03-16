using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour
{
    public Animator animator;
    private Text increaseText;

    // Start is called before the first frame update
    void Start()
    {
        AnimatorClipInfo[] clipinfo = animator.GetCurrentAnimatorClipInfo(0);
        Destroy(gameObject, clipinfo[0].clip.length);
        increaseText = animator.GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    { 
        
    }

    public void SetText(string text){
        animator.GetComponent<Text>().text = text;
    }
}
