using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int ring = 0;
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ring"))
        {
            ring++;
            Destroy(other.gameObject);
            Debug.Log(ring);
        }
    }
}
