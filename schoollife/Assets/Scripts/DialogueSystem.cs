using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueSystem : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    private Queue<string> sentences;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //create queue to hold all sentences
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue) {
        //animator set open state
        animator.SetBool("IsOpen", true);

        //initialize name and sentences store in queue
        nameText.text = dialogue.name;
        sentences.Clear();
        foreach (string sentence in dialogue.sentences) {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence() {
        //end of sentences finsih conversion
        if (sentences.Count == 0) {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    public void EndDialogue() {
        //set open state to false dialogue box move out of screen
        animator.SetBool("IsOpen", false);
    }
}
