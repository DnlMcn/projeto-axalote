using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollectTrash : MonoBehaviour
{
    [SerializeField] private string trashTag = "Trash";

    private void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag(trashTag))
        {
            Destroy(other.gameObject);
            Debug.Log("Object destroyed");
        }
    }
}
