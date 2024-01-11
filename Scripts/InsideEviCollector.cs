using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideEviCollector : MonoBehaviour
{
    private AudioSource CollectionAudio;

    // This script is used to disable any obj that enters the collector

    private void Start()
    {
        GetComponent<TriggerCollection>().OnEnterEvent.AddListener(InsideCollector);
        //call this function when on trigger function is called

        CollectionAudio = GetComponent<AudioSource>();//to get the audio source on this component
    }
    public void InsideCollector(GameObject Obj)
    {
        Obj.SetActive(false);
        CollectionAudio.Play(); //to play the audio on collision
    }
}
