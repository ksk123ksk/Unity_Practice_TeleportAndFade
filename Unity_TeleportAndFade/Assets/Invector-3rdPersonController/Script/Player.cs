using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private toNextScene toNextScene;
    void Start()
    {
        toNextScene = FindObjectOfType<toNextScene>();
    }

    private void OnTriggerEnter(Collider other)
    {
        print(other.name);
        if (other.name == "傳送門")
        {
            StartCoroutine(toNextScene.NextLevel());
        }
    }
}
