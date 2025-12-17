using System;
using UnityEngine;

public class VirtualPad : MonoBehaviour
{
    [SerializeField]
    private VirtualButtons virtualButtons;

    private void Awake()
    {
    }

    public void AddButtonListener(Action<int> action)
    {
        virtualButtons.AddListener(action);
    }
}
