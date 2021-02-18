using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersonFinder : MonoBehaviour
{
    // Used to get the positin on the screen where you touch
    private Vector2 touchPos;

    // Gets the camera you're using
    [SerializeField]
    private Camera arCamera;

    [SerializeField]
    private AudioSource source;

    [SerializeField]
    private PointSystem pointSys;

    private GameObject[] persons;

    [SerializeField]
    private bool foundBouke = false;
    [SerializeField]
    private bool foundDaninjo = false;
    [SerializeField]
    private bool foundIan = false;
    [SerializeField]
    private bool foundWiebe = false;

    // Update is called once per frame
    void Update()
    {
        if (foundBouke && foundDaninjo && foundIan && foundWiebe)
        {
            pointSys.FinalPoints = pointSys.Points;
            Debug.Log("You've done it!");
            SceneManager.LoadScene("EndManu");
            pointSys.Pause = true;
            Debug.Log(pointSys.FinalPoints);
            PlayerPrefs.SetInt("currentScore", pointSys.FinalPoints);
            PlayerPrefs.Save();
        }

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
                    if (hitObject.transform.tag == "Bouke")
                    {
                        Destroy(hitObject.transform.gameObject);
                        source.Play();
                        Debug.Log("Found me");
                        pointSys.Points -= 1;
                        foundBouke = true;
                    }
                    else if (hitObject.transform.tag == "Daninjo")
                    {
                        Destroy(hitObject.transform.gameObject);
                        source.Play();
                        Debug.Log("Found me");
                        pointSys.Points -= 1;
                        foundDaninjo = true;
                    }
                    else if (hitObject.transform.tag == "Ian")
                    {
                        Destroy(hitObject.transform.gameObject);
                        source.Play();
                        Debug.Log("Found me");
                        pointSys.Points -= 1;
                        foundIan = true;
                    }
                    else if (hitObject.transform.tag == "Wiebe")
                    {
                        Destroy(hitObject.transform.gameObject);
                        source.Play();
                        Debug.Log("Found me");
                        pointSys.Points -= 1;
                        foundWiebe = true;
                    }
                    else
                    {
                        Debug.Log("Better luck next time");
                        pointSys.Points += 1;
                    }
                }
            }
        }
    }
}
