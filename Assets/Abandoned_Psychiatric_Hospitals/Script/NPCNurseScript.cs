using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCNurseScript : MonoBehaviour
{
    public AudioSource audioSource;
    NavMeshAgent nurse;
    public GameObject dest;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        nurse = GetComponent<NavMeshAgent>();
        audioSource = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        anim.SetBool("stop", true);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(run(80f));
    }

    IEnumerator run(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (nurse.transform.position.x == 7.3f && nurse.transform.position.z == 2)
        {
            // Rotate soldier to face player
            nurse.transform.rotation = Quaternion.Euler(0, 270, 0);
            anim.SetBool("stop", true);
        }
        else
        {
            anim.SetBool("stop", false);
            yield return new WaitForSeconds(1f);
        }
        nurse.SetDestination(dest.transform.position);
    }

    public void playAudio(int audio)
    {
        audioSource.PlayOneShot(Resources.Load<AudioClip>("Sounds/nurse_" + audio));
    }
}
