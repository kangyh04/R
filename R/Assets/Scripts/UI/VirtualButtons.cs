using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirtualButtons : MonoBehaviour
{
    [SerializeField]
    private List<Button> buttons;

    private Action<int> buttonAction;

    private void Awake()
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            var button = buttons[i];
            button.onClick.AddListener(() =>
            {
                buttonAction(i);
            });
        }
    }

    public void AddListener(Action<int> action)
    {
        buttonAction = action;
    }
}
