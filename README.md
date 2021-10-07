# Dialogue System
This repository is a simple project based on a video from Brackeys in conjunction with the Singleton Design Pattern.

## How it works?
The system consists of 3 different scripts:
### A script to manage all dialogues

    DialogueManager.cs

### A script to trigger the dialogues

    DialogueTrigger.cs

### A script to represent the dialogues    

    Dialogue.cs

## How do I use it in my game?
First, it's important that you have these three scripts. They are the foundation of the system and changes will be made to them. Follow the steps to be able to reproduce basic usage.

 1. Create a `Empty GameObject` called `DialogueManager` and attach the script `DialogueManager.cs` to it;
 2. Create a `Empty GameObject` called `[NAME]Trigger` or a similar name. Then, attach the `DialogueTrigger.cs` to it;
 3. Create the dialogue using the inspector on the `DialogueTrigger/ [NAME]Trigger` `GameObject`;
 4. Assign the `DialogueTrigger.TriggerDialogue()` to a button or action in your game (it was done with a button in the example code in this repository);
 5. Assign the `DialogueManager.DisplayNextSentence()` to another button or keyPress;
 
 ## How to customize it?
You can change the `Dialogue.cs` to define other data. You can access all the data in the DialogueManager.cs and display it. It is not recommended that any dialog data be changed or accessed in the `DialogueTrigger.cs`.

