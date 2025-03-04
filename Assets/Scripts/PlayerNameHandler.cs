using UnityEngine;
using TMPro;  // Import TextMeshPro for InputField

public class PlayerNameHandler : MonoBehaviour
{
    public TMP_InputField nameInputField;  // Drag & Drop the Input Field in Inspector

    public void OnNameEntered()
    {
        if (DataStore.Instance != null)
        {
            DataStore.Instance.playerName = nameInputField.text;
            DataStore.Instance.SaveHighScore();
            Debug.Log("Player Name Set: " + DataStore.Instance.playerName);
        }
        else
        {
            Debug.LogError("DataStore is not initialized");
        }
    }
}
