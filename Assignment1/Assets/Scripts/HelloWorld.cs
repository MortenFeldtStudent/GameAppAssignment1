using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("f"))
        {
            print("Respect");
        }

    }

    //Button "Hello World" print
    public void OnButtonTextClick()
    {
        print("Hello World Text Button");
    }

    //Button "Hello World" print
    public void OnButtonAudioClick()
    {
        print("Hello World Audio Button");
        audioSource.clip = audioClip;
        audioSource.Play();
    }

    //Button "Hello World" print
    public void OnButtonSpawnClick()
    {
        print("Hello World Spawn Button");
        Instantiate(cube, new Vector3(260, 250, 450), Quaternion.identity);
    }

}
