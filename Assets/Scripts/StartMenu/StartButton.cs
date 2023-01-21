using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    [SerializeField] private GameObject _inputNameMenu;
    public void PressStartButton()
    {
        _inputNameMenu.SetActive(true);
        gameObject.SetActive(false);
    }
}
