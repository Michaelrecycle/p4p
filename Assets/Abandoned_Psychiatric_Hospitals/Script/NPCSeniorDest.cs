using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSeniorDest : MonoBehaviour
{
    private int pivotPoint = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SENIOR")
        {
            if (pivotPoint == 4)
            {
                this.gameObject.transform.position = new Vector3(5f, 1.5f, 3f);
                pivotPoint = 5;
            }

            if (pivotPoint == 3)
            {
                this.gameObject.transform.position = new Vector3(4.91f, 1.5f, 0.46f);
                pivotPoint = 4;
            }

            if (pivotPoint == 2)
            {
                this.gameObject.transform.position = new Vector3(-4.47f, 2f, 0.46f);
                pivotPoint = 3;
            }

            if (pivotPoint == 1)
            {
                this.gameObject.transform.position = new Vector3(-4.569f, 2f, -16.68f);
                pivotPoint = 2;
            }

            if (pivotPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(-0.76f, 2f, -16.178f);
                pivotPoint = 1;
            }
        }
    }
}
