// Modules
using UnityEngine;

// unity Class
public class CameraZoom : MonoBehaviour
{
    // Variables
    public bool zoomActive;
    public Vector3[] target;
    public Camera Cam;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Cam = Camera.current;     
    }

    public void LateUpdate()
    {
        if(zoomActive)
        {
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, 3, speed);
        } else 
        {
            Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, 5, speed);
        }
    }
}
