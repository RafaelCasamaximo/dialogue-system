using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{

    public static DialogueManager instance;

    public TMP_Text nameText;
    public TMP_Text contentText;

    public Queue<string> sentences;

    /*
            DialogueManager é a classe que organiza os diferentes dialogos
        como os dialogos sempre aparecem em uma caixa na tela, é normal
        que essa parte seja mantida.
    */
    void Start()
    {
        sentences = new Queue<string>();
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
            return;
        }
        Destroy(this);
        return;
    }

    public void StartDialogue(Dialogue dialogue)
    {
        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        contentText.text = sentence;
    }

    private void EndDialogue()
    {
        nameText.text = " ";
        contentText.text = " ";
    }
}
