using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinusRotatorScript : MonoBehaviour {

    public float rotation_Amplityde_X = 0;
    public float rotation_Amplityde_Y = 0;
    public float rotation_Amplityde_Z = 0;

    public float rotation_Speed_X = 0;
    public float rotation_Speed_Y = 0;
    public float rotation_Speed_Z = 0;

    float cTime = 0;
    Vector3 rotationVector = new Vector3();
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cTime += Time.deltaTime;
        rotationVector.x = Mathf.Sin(cTime* rotation_Speed_X) * rotation_Amplityde_X;
       
        rotationVector.y = Mathf.Sin(cTime  * rotation_Speed_Y) * rotation_Amplityde_Y; 
        rotationVector.z = Mathf.Sin(cTime  * rotation_Speed_Z) * rotation_Amplityde_Z; 
        transform.Rotate(rotationVector); 
        
    }
}
