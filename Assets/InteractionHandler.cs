using UnityEngine;
using TMPro;

public class InteractionHandler : MonoBehaviour
{
    public TextMeshProUGUI promptText;
    public TextMeshProUGUI infoText;

    private AnimalHandler animalHandler;
    private GameObject currentHabitat;

    void Start()
    {
       
        animalHandler = GameObject.FindObjectOfType<AnimalHandler>();
        promptText.text = "";
        infoText.text = "";
    }

    void Update()
    {
        // presses E
        if (currentHabitat != null && Input.GetKeyDown(KeyCode.E))
        {
            var animal = animalHandler.GetAnimalByHabitat(currentHabitat);
            infoText.text = animalHandler.GetAnimalInfo(animal);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("InteractPoint"))
        {
           
            currentHabitat = other.transform.parent.gameObject;
            promptText.text = "Press E to Interact";
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("InteractPoint"))
        {
           
            currentHabitat = null;
            promptText.text = "";
            infoText.text = "";
        }
    }
}
