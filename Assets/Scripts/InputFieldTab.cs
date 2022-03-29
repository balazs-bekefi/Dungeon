using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldTab : MonoBehaviour
{
    public List<InputField> fields;
    public Button Start;
    int fieldIndexer=-1;

    private void Update()
    {
        try
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                fieldIndexer++;
                fields[fieldIndexer].Select();
            }
        }
        catch(ArgumentOutOfRangeException)
        {
            fieldIndexer = 0;
            fields[fieldIndexer].Select();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Start.onClick.Invoke();
        }
    }
}
