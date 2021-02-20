using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndLevel : MonoBehaviour
{
    [SerializeField] private TMP_Text _endLevelMassage;
    [SerializeField] private Tower _tower;

    private void OnEnable()
    {
        _tower.SizeUpdated += OnSizeUpdated;
    }

    private void OnDisable()
    {
        _tower.SizeUpdated -= OnSizeUpdated;
    }

    private void OnSizeUpdated(int size)
    {
        if (size == 0)
        {
            _endLevelMassage.text = "Tower is Broken!";
        }
    }
}
