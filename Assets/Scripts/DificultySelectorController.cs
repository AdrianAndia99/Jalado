using UnityEngine;
using UnityEngine.Events;
public class DificultySelectorController : MonoBehaviour
{
    public UnityEvent assingButtons;
    DoubleLinkedCircularList<GameObject> buttons = new DoubleLinkedCircularList<GameObject>();
    private void Awake()
    {
        assingButtons?.Invoke();

    }
    public void AddButton(GameObject button)
    {
        buttons.InsertNodeAtEnd(button);
    }
    public void Print()
    {
        //for(int i = 0; i < buttons.)
    }
}
