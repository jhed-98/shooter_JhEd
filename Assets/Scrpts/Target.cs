using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameManager gameManager;
    private AudioSource _audio;

    // Start is called before the first frame update
    void Start()
    {
        gameManager= 
            GameObject.Find("EventSystem").GetComponent<GameManager>();
        Destroy(gameObject, 2f);
    }

    void OnMouseDown()
    {
        gameManager.IncrementScore();
        Destroy(gameObject);
    }
    void Awake(){
        _audio=GetComponent<AudioSource>();
    }

    void Destroy(){
        _audio.Play();
    }

}
