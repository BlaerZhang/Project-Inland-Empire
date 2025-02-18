using System;
using System.Collections;
using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class Task : MonoBehaviour
{
    [SerializeField] private IntReference currentFinishedTaskNumber;
    [SerializeField] private string taskObjectName;

    private int currentTaskObjectNum = 0;
    [SerializeField] private int maxTaskObjectNum = 0;

    private void TrackTaskObjectNumber()
    {
        currentTaskObjectNum++;
        // if the tracked task object number reaches the max number
        if (currentTaskObjectNum >= maxTaskObjectNum) currentFinishedTaskNumber.Value++;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (taskObjectName.Equals(other.name))
        {
            // lock the position of the object has already placed
            // Rigidbody taskObjectRb = other.gameObject.GetComponent<Rigidbody>();
            // taskObjectRb.isKinematic = true;
            // taskObjectRb.constraints = RigidbodyConstraints.FreezeAll;
            other.isTrigger = false;
            print(taskObjectName);
            TrackTaskObjectNumber();
        }
    }
}
