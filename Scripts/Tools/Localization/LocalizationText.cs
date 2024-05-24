using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LocalizationText
{
    [SerializeField] private List<LocalizationPair> textList = new List<LocalizationPair>();

    public string GetByCode(string code)
    {
        foreach (var pair in textList)
        {
            if (code == pair.langCode)
            {
                return pair.text;
            }
        }

        return string.Empty;
    }
}