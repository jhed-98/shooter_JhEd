using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparar : MonoBehaviour
{
    float tiempo  = 0.0f;
    public AudioClip sonidoClip;
    public AudioSource _audio;
    // Start is called before the first frame update
    void Start()
    {
     _audio = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0)){
            _audio.PlayOneShot(sonidoClip);
        }
    }
}
