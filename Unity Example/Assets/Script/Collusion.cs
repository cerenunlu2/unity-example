using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collusion : MonoBehaviour
{
    [SerializeField] float loaddelay = 1f;
    [SerializeField] ParticleSystem crashVfx;
    private void OnTriggerEnter(Collider other)
    {
        CrashProcess();
    }

    private void CrashProcess()
    {
        crashVfx.Play();
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Movement>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        Invoke("Reloadlevel", loaddelay);
    }

    void Reloadlevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
