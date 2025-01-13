using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereAction : MonoBehaviour
{
    private void OnEnable()
    {
        ActionManager.OnJumpPerformed += SphereAction;
    }
    private void OnDisable()
    {
        ActionManager.OnJumpPerformed -= SphereAction;
    }
    // sphere gets bigger with Space input
    private void SphereAction()
    {
        gameObject.transform.localScale += new Vector3(1, 1, 0);
        Debug.Log("Sphere Action method called");
    }
}
