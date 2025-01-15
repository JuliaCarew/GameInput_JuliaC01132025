using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeAction : MonoBehaviour
{
    private void OnEnable()
    {
        ActionManager.OnInteractStarted += CubeAction;
    }
    private void OnDisable()
    {
        ActionManager.OnInteractStarted -= CubeAction;
    }
    // cube turns green with T input
    private void CubeAction()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
        Debug.Log("Cube Action method called");
    }
}
