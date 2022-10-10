using UnityEngine;

public class DoorOpenScript : MonoBehaviour
{
    bool trig, open;
    public float smooth = 2.0f;
    public float DoorOpenAngle = 90.0f;
    private Vector3 defaulRot;
    private Vector3 openRot;
     public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        defaulRot = transform.eulerAngles;
        openRot = new Vector3(defaulRot.x, defaulRot.y + DoorOpenAngle, defaulRot.z);
    }

    public void playAudio()
    {
        audioSource.PlayOneShot(Resources.Load<AudioClip>("Sounds/Door"));
    }
    // Update is called once per frame
    void Update()
    {
        if (trig)// open
        {
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, Time.deltaTime * smooth);
        }
        else// close
        {
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaulRot, Time.deltaTime * smooth);
        }
    }
    private void OnTriggerEnter(Collider coll)//вход и выход в\из  триггера 
    {
		if(coll.tag != "SOLDIER") {
			return;
		}
        trig = true;
        playAudio();

    }
    //private void OnTriggerExit(Collider coll)//вход и выход в\из  триггера 
    //{
    //    trig = false;
    //}
}