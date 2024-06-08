using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    [SerializeField] int ScorePerHit = 15;
    [SerializeField] int hitPoints = 4;
    Score score;
    [SerializeField] GameObject deathVfx;
    [SerializeField] GameObject hitVfx;
    [SerializeField] Transform parent;


    void Start()
    {
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
        GameObject vfx = Instantiate(hitVfx, transform.position, Quaternion.identity);
        hitPoints--;
        score.IncreaseScore(ScorePerHit);
    }
    void KillProcess()
    {
        GameObject vfx = Instantiate(deathVfx, transform.position, Quaternion.identity);
        vfx.transform.parent = parent;

        Destroy(gameObject); 
    }

}
