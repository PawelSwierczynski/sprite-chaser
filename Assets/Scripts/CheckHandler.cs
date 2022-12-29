using UnityEngine;
using UnityEngine.UI;

public class CheckHandler : MonoBehaviour
{
    private bool isChecked;

    public void Start()
    {
        isChecked = false;
    }

    public void ToggleChecked()
    {
        isChecked = !isChecked;

        GetComponent<Image>().color = isChecked ? Color.green : Color.white;
    }
}