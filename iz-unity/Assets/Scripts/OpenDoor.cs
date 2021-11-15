using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject player;
    public GameObject door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            iTween.RotateTo(door, iTween.Hash("rotation", new Vector3(0f, -30f, 0f),
                "easetype", iTween.EaseType.easeOutBack, "time", 2.0f));
            transform.gameObject.SetActive(false);
        }
    }
}
