using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MenuLogic : MonoBehaviour
{
    // Singleton Pattern: Ensuring there's only one instance of MenuLogic
    public static MenuLogic instance;

    public TextMeshProUGUI descriptionText;

    // Array: Holding descriptions of the food items
    private string[] foodDescriptions = { "Sizzling bacon, cooked to perfection.", "Golden pancakes drizzled with honey.", "A soft-boiled egg, fresh and delicious." };

    // List: Storing the names of the food items
    private List<string> foods = new List<string> { "Bacon", "Pancake", "Egg" };

    private void Awake()
    {
        // Singleton Pattern: Ensures only one instance of MenuLogic exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void OnButtonClick(string food)
    {
        // Decision Statement: Checks if the selected food is in the list and within bounds of the array
        int index = foods.IndexOf(food);

        if (index >= 0 && index < foodDescriptions.Length)
        {
            descriptionText.text = foodDescriptions[index]; // Setting the description text
        }
        else
        {
            descriptionText.text = "Food not found.";
        }
    }
}
