
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSoldierDest : MonoBehaviour
{
    private int spivotPoint = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SOLDIER")
        {

            if (spivotPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(0.5f, 2f, -17f);
                spivotPoint = 1;
            }
        }
    }
}
