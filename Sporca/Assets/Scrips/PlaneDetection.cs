using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Experimental.XR;
using UnityEngine.XR.ARSubsystems;
using System;

public class PlaneDetection : MonoBehaviour
{
    private ARRaycastManager arRaycast;
    private Pose placementPose;
    private bool validPlacementPose = false;
    [SerializeField]
    private GameObject surounding;

    // Start is called before the first frame update
    void Start()
    {
        arRaycast = FindObjectOfType<ARRaycastManager>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePlacementPose();
        UpdatePlacementIndicator();
    }

    private void UpdatePlacementIndicator()
    {
        if (validPlacementPose)
        {
            surounding.SetActive(true);
            surounding.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
        }
    }

    private void UpdatePlacementPose()
    {
        var screenCenter = Camera.current.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();
        arRaycast.Raycast(screenCenter, hits, TrackableType.Planes);

        validPlacementPose = hits.Count > 0;
        if (validPlacementPose)
        {
            placementPose = hits[0].pose;
        }
    }
}
