using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCSeniorScript : MonoBehaviour
{
    public AudioSource audioSource;
    public Animator anim;
    NavMeshAgent senior;
    public GameObject dest;

    // Start is called before the first frame update
    void Start()
    {
        senior = GetComponent<NavMeshAgent>();
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
        if (senior.transform.position.x == 5 && senior.transform.position.z == 3)
        {
            // Rotate soldier to face player
            senior.transform.rotation = Quaternion.Euler(0, 90, 0);
            anim.SetBool("stop", true);
        }
        else
        {
            anim.SetBool("stop", false);
            yield return new WaitForSeconds(1f);
        }
        senior.SetDestination(dest.transform.position);
    }

    public void playAudio(int audio)
    {
        audioSource.PlayOneShot(Resources.Load<AudioClip>("Sounds/senior_" + audio));
    }
}
