using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScreen : MonoBehaviour
{
    public RectTransform[] Btn;
    // ----------Functions---------------------------\\
    public void Play(){SceneManager.LoadScene(1);}              //PLAY
    public void About()                                         //ABOUT
    {
        for(int i=0;i<4;i++)
            Btn[i].gameObject.SetActive(false);
        Btn[4].gameObject.SetActive(true);
    }
    public void AboutBack()                                     //ABOUT_BACK
    {
        for(int i=0;i<4;i++)
            Btn[i].gameObject.SetActive(true);
        Btn[4].gameObject.SetActive(false);
    }
    public void Exit(){Application.Quit(0);}                    //EXIT
    public void SoundBTN(){}                                    //SOUND_BUTTON
    public void MenuBTN(){}                                     //MENU_BUTTON
}