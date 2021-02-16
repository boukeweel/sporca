using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonFinder : MonoBehaviour
{
    // Used to get the positin on the screen where you touch
    private Vector2 touchPos;

    // Gets the camera you're using
    [SerializeField]
    private Camera arCamera;

    [SerializeField]
    private AudioSource source;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {


            Touch touch = Input.GetTouch(0);
            // Makes the touch position the posiion you touched the screen
            touchPos = touch.position;
            if (touch.phase == TouchPhase.Began)
            {
                // Sends out a ray for the touch position
                Ray ray = arCamera.ScreenPointToRay(touchPos);
                RaycastHit hitObject;
                // Checks if the ray hit something
                if (Physics.Raycast(ray, out hitObject))
                {
                    source.Play();
                    Debug.Log("Touch");
                }
            }
        }
    }
}
