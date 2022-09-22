using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class EventSequence : MonoBehaviour
{

    public GameObject nurse;
    public GameObject soldier;
    public GameObject senior;
    public GameObject airRaidSiren;
    public GameObject explosion;
    public GameObject shootingSound;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MySequence());
    }

    IEnumerator MySequence()
    {
        NPCNurseScript nurseScript = nurse.GetComponent<NPCNurseScript>();
        NPCSeniorScript seniorScript = senior.GetComponent<NPCSeniorScript>();
        NPCSoldierScript soldierScript = soldier.GetComponent<NPCSoldierScript>();
        

        // First conversation
        yield return new WaitForSeconds(10f);
        seniorScript.playAudio(1);
        yield return new WaitForSeconds(3f);
        nurseScript.playAudio(1);
        yield return new WaitForSeconds(2f);
        seniorScript.playAudio(2);
        yield return new WaitForSeconds(4f);
        nurseScript.playAudio(2);
        yield return new WaitForSeconds(3f);
        seniorScript.playAudio(3);

        // Air raid siren goes off
        yield return new WaitForSeconds(4f);
        airRaidSiren.GetComponent<AudioSource>().Play();
        // Bombings occur
        yield return new WaitForSeconds(2f);
        explosion.GetComponent<AudioSource>().Play();
        shootingSound.GetComponent<AudioSource>().Play();

        // Second Conversation
        yield return new WaitForSeconds(4f);
        soldierScript.playAudio(1);
        yield return new WaitForSeconds(7f);
        nurseScript.playAudio(3);
        yield return new WaitForSeconds(11f);
        soldierScript.playAudio(2);
        yield return new WaitForSeconds(6f);
        nurseScript.playAudio(4);
        yield return new WaitForSeconds(7f);
        soldierScript.playAudio(3);
        yield return new WaitForSeconds(3f);
        seniorScript.playAudio(4);


        // Third Conversation 
        yield return new WaitForSeconds(2f);
        soldierScript.playAudio(4);
      
        // Resume convo
        yield return new WaitForSeconds(8.5f);
        explosion.GetComponent<AudioSource>().Stop();
        soldierScript.playAudio(5);
        yield return new WaitForSeconds(5f);
        nurseScript.playAudio(5);
        yield return new WaitForSeconds(8f);
        // Third convo

        yield return new WaitForSeconds(25f);
        nurseScript.playAudio(6);
        yield return new WaitForSeconds(4f);
        seniorScript.playAudio(5);
        yield return new WaitForSeconds(6f);
        nurseScript.playAudio(7);

    }

}
