using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{

    [SerializeField] private AudioSource buttonclickopen;
    [SerializeField] private AudioSource buttonclickclose;

    public void OpenItchio()
    {
        buttonclickopen.Play();
        Application.OpenURL("https://dandelikeslion.itch.io/");
    }

    public void OpenPortfolio()
    {
        buttonclickopen.Play();
        Application.OpenURL("https://jpro44.wixsite.com/-jeanne-boudouresque");
    }
}