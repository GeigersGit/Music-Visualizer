using UnityEngine;
using System.Collections;

public class RotateScript : MonoBehaviour {

public float rotationDegreesPerSecond = 2;
public float rotationDegreesAmount = 10000;
private float totalRotation = 0;

void Start () {

}


void Update () {
    

    
        SwingOpen();
}

void SwingOpen()
{   
   float currentAngle = transform.rotation.eulerAngles.y;
   transform.rotation = 
    Quaternion.AngleAxis(currentAngle + (Time.deltaTime * 5), Vector3.up);
   totalRotation += Time.deltaTime * 5;
}
	
}

