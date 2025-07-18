using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InfoPopup : MonoBehaviour
{
    public TextMeshProUGUI Name;
    public TextMeshProUGUI Data;
    public RectTransform ContentTransform;
    public ContentEntry EntryPrefab;

    public void ClearContent()
    {
        foreach (Transform child in ContentTransform)
        {
            Destroy(child.gameObject);
        }
    }
    
    public void AddToContent(int count, Sprite Icone)
    {
        var newEntry = Instantiate(EntryPrefab, ContentTransform);

        newEntry.Count.text = count.ToString();
        newEntry.Icone.sprite = Icone;
    }
}
