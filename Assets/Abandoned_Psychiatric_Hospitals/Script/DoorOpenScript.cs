using UnityEngine;

public class DoorOpenScript : MonoBehaviour
{
    bool trig, open;//trig-проверка входа выхода в триггер(игрок должен быть с тегом Player) open-закрыть и открыть дверь
    public float smooth = 2.0f;//скорость вращения
    public float DoorOpenAngle = 90.0f;//угол вращения 
    private Vector3 defaulRot;
    private Vector3 openRot;
    // Start is called before the first frame update
    void Start()
    {
        defaulRot = transform.eulerAngles;
        openRot = new Vector3(defaulRot.x, defaulRot.y + DoorOpenAngle, defaulRot.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (trig)//открыть
        {
            transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, Time.deltaTime * smooth);
        }
        else//закрыть
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
    }
    //private void OnTriggerExit(Collider coll)//вход и выход в\из  триггера 
    //{
    //    trig = false;
    //}
}