using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CalculoII : MonoBehaviour {
    public Text desplazamientoHorizontalLabel;
    public Text desplazamientoVerticalLabel;
    public float desplazamientoHorizontal;
    public float desplazamientoVertical;
  //  public Animation animacion;

	// Use this for initialization
	void Start () {
        desplazamientoHorizontal = PlayerPrefs.GetFloat("desplazamientoHorizontalPref");
        desplazamientoVertical = PlayerPrefs.GetFloat("desplazamientoVerticalPref");
        desplazamientoHorizontal = Mathf.Round(desplazamientoHorizontal*1000)/1000;
        desplazamientoVertical = Mathf.Round(desplazamientoVertical*1000)/1000;
        desplazamientoHorizontalLabel.text = desplazamientoHorizontal.ToString() + "m"; 
        desplazamientoVerticalLabel.text = desplazamientoVertical.ToString() + "m";
      //  animacion.Play("animacionRecubrimiento");
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
