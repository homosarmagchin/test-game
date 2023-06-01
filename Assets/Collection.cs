using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collection : MonoBehaviour
{
    int counter = 0;
    [SerializeField] Text coinText;
    [SerializeField] AudioSource collectionSound;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Coin")){
            Destroy(other.gameObject);
            collectionSound.Play();
            counter++;
            coinText.text = "Coin: " +counter;
        }
    }
}
