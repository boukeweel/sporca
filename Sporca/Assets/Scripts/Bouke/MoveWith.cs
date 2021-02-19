using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWith : MonoBehaviour
{
    [SerializeField]public Transform human;

    private void Update()
    {
        transform.position = human.position;
        if(human == null)
        {
            Destroy(gameObject, 2);
        }
    }
}
