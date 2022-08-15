using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingController : MonoBehaviour
{
    
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform cameraTransform;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Fishing action
            Debug.Log("Pescando...");
        }

        Vector3 cameraForward = cameraTransform.forward * 10;
        playerTransform.LookAt(cameraForward);
    }
}
