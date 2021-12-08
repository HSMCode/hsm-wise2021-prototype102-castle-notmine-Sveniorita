using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGhost : MonoBehaviour
{
    public float speed;
    public float minSpeed= 2f;
    public float maxSpeed= 6f;

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Death")
        {
            Destroy(gameObject);
        }
    }
}
