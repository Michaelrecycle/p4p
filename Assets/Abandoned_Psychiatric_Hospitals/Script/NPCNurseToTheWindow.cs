using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCNurseToTheWindow : MonoBehaviour
{
    public Animator anim;
    NavMeshAgent senior;
    public GameObject dest;

    // Start is called before the first frame update
    void Start()
    {
        senior = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        anim.SetBool("stop", true);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(run(30f));
    }

    IEnumerator run(float delay)
    {
        yield return new WaitForSeconds(delay);
        
        senior.SetDestination(dest.transform.position);
    }
}
