using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [SerializeField] int ScorePerHit = 15;
    [SerializeField] int hitPoints = 4;
    Score score;
    [SerializeField] GameObject deathVfx;
    [SerializeField] GameObject hitVfx;
    [SerializeField] Transform parent;
    [SerializeField] GameObject parentV2;
    [SerializeField] AudioClip olme;
    AudioSource audio;
     public GameObject yoket1; 
     


    void Start()
    {
        audio = GetComponent<AudioSource>();
        score = FindObjectOfType<Score>();
    }

    void OnParticleCollision()
    {
        
        HitProcess();
        if (hitPoints < 1)
        {
            KillProcess();
        }
    }

    void HitProcess()
    {
        hitPoints--;
        if (hitPoints % 8 == 0)
        {
            GameObject vfx = Instantiate(hitVfx, transform.position, Quaternion.identity);
         
        }

        score.IncreaseScore(ScorePerHit);
    }

    void KillProcess()
    {
        audio.PlayOneShot(olme);
        GameObject vfx = Instantiate(deathVfx, transform.position, Quaternion.identity);
        vfx.transform.parent = parent;
        yoket1.GetComponent<SkinnedMeshRenderer>().enabled = false;
       
        GetComponent<BoxCollider>().enabled = false;
       // Destroy(gameObject);
       // Destroy(parentV2);
    }
}