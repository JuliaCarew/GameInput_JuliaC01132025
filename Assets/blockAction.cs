using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockAction : MonoBehaviour
{
    private void OnEnable()
    {        
        ActionManager.OnCrouchStarted += BlockAction;
    }
    private void OnDisable()
    {
        ActionManager.OnCrouchCancelled -= BlockActionEnd;
    }
    
    // block moves up by one unit with Tab input
    private void BlockAction()
    {
        gameObject.transform.position += new Vector3(0, 1, 0);
        Debug.Log("Block Action method called");
    }
    private void BlockActionEnd()
    {
        gameObject.transform.position += new Vector3(0, -1, 0);
        Debug.Log("Block Action method ended");
    }
}
