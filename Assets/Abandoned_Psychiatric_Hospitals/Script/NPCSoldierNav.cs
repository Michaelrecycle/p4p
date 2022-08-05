using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCSoldierNav : MonoBehaviour
{
    NavMeshAgent soldier;
    public GameObject dest;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        soldier = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        soldier.SetDestination(dest.transform.position);
        if(soldier.transform.position.x == 1 && soldier.transform.position.z == -17 )
        {
            // Rotate soldier to face player
            soldier.transform.rotation = Quaternion.Euler(0, 0, 0);
            anim.SetBool("stop", true);
        }
        else
        {
            anim.SetBool("stop", false);
        }
    }
}
