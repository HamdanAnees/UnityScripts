using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraZoom : MonoBehaviour
{
    public int minZoom2D, maxZoom2D;
    public int zoomSpeed2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.orthographic){
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                //zoomin
                Camera.main.orthographicSize -= zoomSpeed2D * Time.deltaTime;

            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                //zoomout
                Camera.main.orthographicSize += zoomSpeed2D * Time.deltaTime;

            }
            //Restrict The value
            Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, minZoom2D, maxZoom2D);
        }
    }
}
