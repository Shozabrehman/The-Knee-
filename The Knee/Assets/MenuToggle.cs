using UnityEngine;
using VRTK;
public class MenuToggle : MonoBehaviour {
    public VRTK_ControllerEvents ControllerEvents;
    public GameObject menu;

    bool menuState = false;

    void OnEnable()
    {     
        ControllerEvents.ButtonTwoReleased += ControllerEvents_ButtonTwoReleased;
    }

    void OnDisable()
    {
        ControllerEvents.ButtonTwoReleased -= ControllerEvents_ButtonTwoReleased;
    }
    public void ControllerEvents_ButtonTwoReleased(object sender, ControllerInteractionEventArgs e)
    {
        menuState = !menuState;
        menu.SetActive(menuState);
    }
}
