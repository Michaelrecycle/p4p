using UnityEngine;

public class DoorOpenScript : MonoBehaviour
{
    bool doorState = false;
    int doorCount = 0;

    public void OnTriggerEnter(Collider other){
        if(other.gameObject.tag != "Player" && other.gameObject.tag != "NPC") {
            return;
        }
        doorState = true;
        doorCount++;
        if(doorCount == 1) {
            transform.GetChild(0).transform.RotateAround(transform.position, Vector3.up, 90);
        }      
    }

    public void OnTriggerExit(Collider other){
        if(other.gameObject.tag != "Player" && other.gameObject.tag != "NPC") {
            return;
        }
        doorState = false;
        doorCount--;
        if(doorCount == 0) {
            transform.GetChild(0).transform.RotateAround(transform.position, Vector3.down, 90);
        } 
        
    }
}