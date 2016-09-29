using UnityEngine;
using System.Collections;



public class irSeleccionCamara : MonoBehaviour {

    public AudioClip audioClip;
    void OnMouseDown()
    {
        AudioSource.PlayClipAtPoint(audioClip, new Vector3(5, 1, 2));
        Application.LoadLevel("seleccionCamara");
    }
}
