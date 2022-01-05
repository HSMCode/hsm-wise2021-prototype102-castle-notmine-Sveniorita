using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGhost : MonoBehaviour
{
    private float speed;
    private float minSpeed= 2f;
    private float maxSpeed= 6f;
    public ParticleSystem particleBad;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);  //set random speed to spawned Ghosts
        particleBad.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed); // move Ghosts to the left
    }
    private void OnTriggerEnter(Collider other) // check for Collisions
    {
        if(other.gameObject.CompareTag("Death")) // Destroy Ghosts when reaching DeathPlane
        {
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Player")) // Destroy Ghosts when Player is interacting
        {
           particleBad.Play();
           Destroy(gameObject, 0.1f);
        }
    }
}
