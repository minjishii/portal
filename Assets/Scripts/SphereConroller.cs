using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SphereConroller : MonoBehaviour
{

    public Text messageText;

    private void Start()
    {
        messageText.enabled = false;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Enemy"))
        {
            messageText.text = "You Win";
            messageText.enabled = true;
            Destroy(hit.gameObject);
        }
    }
}
