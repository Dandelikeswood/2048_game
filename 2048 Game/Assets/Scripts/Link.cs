using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{
    public void OpenItchio()
    {
        Application.OpenURL("https://dandelikeslion.itch.io/");
    }

    public void OpenPortfolio()
    {
        Application.OpenURL("https://jpro44.wixsite.com/-jeanne-boudouresque");
    }
}