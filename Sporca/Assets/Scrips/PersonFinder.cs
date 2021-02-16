using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PersonFinder : MonoBehaviour
{
    // Used to get the positin on the screen where you touch
    private Vector2 touchPos;
    [SerializeField]
    private Camera arCamera;

    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Touch touch = Input.GetTouch(0);
        touchPos = touch.position;
        if (touch.phase == TouchPhase.Began)
        {
            Ray ray = arCamera.ScreenPointToRay(touch.position);
            RaycastHit hitObject;
            if (Physics.Raycast(ray, out hitObject))
            {
                Debug.Log("Hello there");
            }
        }

    }
}
