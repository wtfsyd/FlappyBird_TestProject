using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wingScript : MonoBehaviour
{
    public Animator wingAnimator;
    public birdscript bird;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && bird.birdIsAlive)
        {
            wingAnimator.SetBool("isUp", true);
        }

        if (Input.GetKeyUp(KeyCode.Space) && bird.birdIsAlive)
        {
            wingAnimator.SetBool("isUp", false);
        }
    }
}
