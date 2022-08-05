
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSoldierDest : MonoBehaviour
{
    public int pivotPoint;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            //if (pivotPoint == 1)
            //{
            //    this.gameObject.transform.position = new Vector3(1, 2, -16);
            //    pivotPoint = 2;
            //}

            if (pivotPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(1, 2, -17);
                pivotPoint = 1;
            }
        }
    }
}
