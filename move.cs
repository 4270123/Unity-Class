using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public int xySpeed = 20;
    public int zSpeed = 10;
    public int rotation = 20;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        print("Player - XYspeed: " + xySpeed + " Zspeed: " + zSpeed + " rotation: " + rotation);
        transform.Translate(xySpeed * Time.deltaTime * Input.GetAxis("Y"),
            xySpeed * Time.deltaTime * Input.GetAxis("Z"),
            zSpeed * Time.deltaTime * Input.GetAxis("X"));

        transform.eulerAngles += new Vector3(- rotation * Time.deltaTime * Input.GetAxis("Mouse Y")
            , rotation * Time.deltaTime * Input.GetAxis("Mouse X")
            , 0);
    }
}
