using UnityEngine;

public class PlayerGUI : MonoBehaviour
{
    private bool isOpened;
    public void Inventory()
    {
        print($"Inventory is {isOpened = !isOpened}");
    }
}