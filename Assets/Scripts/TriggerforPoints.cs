using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerforPoints : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Friend"))
        {
            Debug.Log("Friendo! +1");
            
        }
        
        
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("noooo -1");
            
        }
        
    }
}
