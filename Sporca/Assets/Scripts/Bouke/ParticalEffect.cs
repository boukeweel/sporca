using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalEffect : MonoBehaviour
{
    [SerializeField] private ParticleSystem Partical;
    private void OnDestroy()
    {
        Partical.Play();
    }
}
