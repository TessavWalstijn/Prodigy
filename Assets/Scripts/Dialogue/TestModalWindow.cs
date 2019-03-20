using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

//  This script will be updated in Part 2 of this 2 part series.
public class TestModalWindow : MonoBehaviour {
    protected ModalPanel modalPanel;
    protected DisplayManager displayManager;

    protected UnityAction myYesAction;
    protected UnityAction myNoAction;
    protected UnityAction myCancelAction;

    public void Awake () {
        modalPanel = ModalPanel.Instance ();
        displayManager = DisplayManager.Instance ();

        myYesAction = new UnityAction (TestYesFunction);
        myNoAction = new UnityAction (TestNoFunction);
        myCancelAction = new UnityAction (TestCancelFunction);
    }
    protected void TestYNC () {
        modalPanel.Choice ("Wanna get stabbed?", TestYesFunction, TestNoFunction, TestCancelFunction);
    }
    protected void TestYesFunction () {
        displayManager.DisplayMessage ("Hell yes Brother!!!!");
    }

    protected void TestNoFunction () {
        displayManager.DisplayMessage ("No can do");
    }

    public void TestCancelFunction () {
        displayManager.DisplayMessage ("I surrender");
    }
}