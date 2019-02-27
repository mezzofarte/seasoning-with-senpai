using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public ParticleSystem part;
    public float radius;
    private Transform startPosition;
    public float distance;
    public float angle = 0;
    
    // Start is called before the first frame update
    
    public List<ParticleCollisionEvent> collisionEvents;
    void Start()
    {
        //part = GetComponent<ParticleSystem>();
        collisionEvents = new List<ParticleCollisionEvent>();

        startPosition = GameObject.FindGameObjectWithTag("Shaker").transform;
        radius = GameObject.FindGameObjectWithTag("Shaker").GetComponent<CapsuleCollider>().radius;
    }
    

    // Update is called once per frame
    void Update()
    {
        float randomAngle = Random.Range(-5f, 5f);
        angle += randomAngle;
        if (angle > 30f)
        {
            angle = 30f;
        }
        else if (angle < -30f)
        {
            angle = -30f;
        }
        transform.RotateAround(startPosition.position, Vector3.up, 60 * Time.deltaTime);
        float distanceThisFrame = distance * Time.deltaTime;
        transform.Translate(Vector3.right * distanceThisFrame, Space.World);
        //transform.Translate(Vector3.forward * distanceThisFrame, Space.World);
        distance += Random.Range(-3f, 3f);
        if (distance > 25)
        {
            distance = 0;
        }
        else if (distance < -25)
        {
            distance = 0;
        }
    }

/*
    public void initialize( float r, Transform sP)
    {
        radius = r;
        startPosition = sP;
    }
    */

    void OnParticleCollision(GameObject other)
    {
        
        int numCollisionEvents = part.GetCollisionEvents(other, collisionEvents);
        if (other.CompareTag("Player"))
        {
            
            other.GetComponent<Player>().takeDamage();

            //Destroy(other);

//            int i = 0;
//
//            while (i < numCollisionEvents)
//            {
//                Destroy(collisionEvents[i].);
//                i++;
//            }
        }

    }
    
}
