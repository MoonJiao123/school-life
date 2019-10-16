using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public void TriggerDialogue() {
        //find dialogue system object
        FindObjectOfType<DialogueSystem>().StartDialogue(dialogue);
    }
}
