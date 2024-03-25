using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class DoorInteraction : MonoBehaviour
{
    public bool isInRange;
    public GameObject AnimeObject;
    public GameObject Instruction;
    public GameObject Trigger;
    public AudioSource DoorOpenSound;


    private void Start()
    {
        Instruction.SetActive(false);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (isInRange == true)
            {
                Instruction.SetActive(false);
                Trigger.SetActive(false);
                AnimeObject.GetComponent<Animator>().Play("DoorOpen");
                isInRange = false;
                DoorOpenSound.Play();
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instruction.SetActive(true);
            isInRange = true;
            Debug.Log("in range");
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instruction.SetActive(false);
            isInRange = false;
            Debug.Log("not in range");
        }
    }
}
