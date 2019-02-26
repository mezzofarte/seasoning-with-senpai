using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public ParticleSystem part;
    // Start is called before the first frame update
    
    public List<ParticleCollisionEvent> collisionEvents;
    void Start()
    {
        //part = GetComponent<ParticleSystem>();
        collisionEvents = new List<ParticleCollisionEvent>();
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnParticleCollision(GameObject other)
    {
        
        //Debug.Log("test");
        int numCollisionEvents = part.GetCollisionEvents(other, collisionEvents);
        if (other.CompareTag("Player"))
        {
            Debug.Log("test");
        }

    }
    
}
