using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public AudioClip CoinClip;
    public AudioSource AudioSource; 
    public float speed = 10f;
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "FPSController")
        {
            other.GetComponent<PlayerScript>().points++; 
            Destroy(gameObject);
            AudioSource.Play();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        AudioSource.clip = CoinClip;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
