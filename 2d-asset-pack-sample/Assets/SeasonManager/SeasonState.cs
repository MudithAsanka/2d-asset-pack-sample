using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SeasonState : MonoBehaviour
{
    public enum Season
    {
        Normal,
        Winter,
        Autumn
    }

    public Season currentSeason;
    public TMP_Dropdown seasonSelection;


    private void Start()
    {
        List<TMP_Dropdown.OptionData> options = new();
        string[] names = System.Enum.GetNames(typeof(Season));

        foreach(string name in names)
        {
            options.Add(new TMP_Dropdown.OptionData(name));
        }
        seasonSelection.AddOptions(options);
        seasonSelection.onValueChanged.AddListener(SetSeason);
    }

    private void Update()
    {
        switch (currentSeason)
        {
            case Season.Normal:
                Debug.Log("Normal");
                break;
            case Season.Winter:
                Debug.Log("Winter");
                break;
            case Season.Autumn:
                Debug.Log("Autumn");
                break;
        }
    }

    private void SetSeason(System.Int32 index)
    {
        currentSeason = (Season)index;
    }
    
}
