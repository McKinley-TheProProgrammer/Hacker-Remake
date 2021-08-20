using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deactivateObject : MonoBehaviour
{
    [SerializeField] private float countdown = 3f;
    [SerializeField] private bool useAnimationFrames;
    
    private float countAux;

    private Animator anim;
    void Start()
    {
        countAux = countdown;
        CheckAnimationUse();
    }

    void CheckAnimationUse()
    {
        if (useAnimationFrames)
        {
            anim = GetComponent<Animator>();
            countdown = anim.GetCurrentAnimatorStateInfo(0).length;
            countAux = countdown;
        }
    }
    void Countdown()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            countdown = countAux;
            gameObject.SetActive(false);
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        Countdown();
    }
}
