using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullRotation : MonoBehaviour
{
    public Animator animatorController;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animatorController.SetTrigger("UpParam");
        }
    }
}
