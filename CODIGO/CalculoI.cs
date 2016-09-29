using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class CalculoI : MonoBehaviour {
    public Text anchoImagenLabel;
    public Text altoImagenLabel;
    public Text focalLabel;
    public Text distanciaHiperFocalLabel;
    public Text focoLejanoLabel;
    public Text focoCercanoLabel;
    public Text resolucionLabel;
    public float anchoImagen;
    public float altoImagen;
    public float focal;
    public float distanciaHiperFocal;
    public float focoLejano;
    public float focoCercano;
    public float resolucion;

    // Use this for initialization
    void Start () {
        anchoImagen = PlayerPrefs.GetFloat("anchoImagenPref");
        anchoImagen = Mathf.Round(anchoImagen * 1000) / 1000;
        anchoImagenLabel.text = anchoImagen.ToString() + "m"; 
        altoImagen= PlayerPrefs.GetFloat("altoImagenPref");
        altoImagen=Mathf.Round(altoImagen * 1000) / 1000;
        altoImagenLabel.text = altoImagen.ToString() + "m";
        resolucion = PlayerPrefs.GetFloat("resolucionPref");
        resolucion=Mathf.Round(resolucion * 1000) / 1000;
        resolucionLabel.text =  resolucion.ToString() + "cm/px";
        //     Debug.Log("resolucion " + resolucion);
        focal = PlayerPrefs.GetFloat("focalPref");
        focal = Mathf.Round(focal * 1000) / 1000;
        focalLabel.text = focal.ToString() + "mm"; ;
        distanciaHiperFocal= PlayerPrefs.GetFloat("distanciaHiperFocalPref");
        distanciaHiperFocal=Mathf.Round(distanciaHiperFocal * 1000) / 1000;
        distanciaHiperFocalLabel.text = distanciaHiperFocal.ToString() + "m"; ;
        focoCercano= PlayerPrefs.GetFloat("focoCercanoPref");
        focoCercano=Mathf.Round(focoCercano * 1000) / 1000;
        focoCercanoLabel.text = focoCercano.ToString() + "m"; ;
        focoLejano= PlayerPrefs.GetFloat("focoLejanoPref");
        focoLejano = Mathf.Round(focoLejano * 1000) / 1000;
        if (focoLejano < 0)
        {
            focoLejanoLabel.text = "Infinito";
        }
        else if (focoLejano >= 0)
        {
            focoLejanoLabel.text = focoLejano.ToString() + "m"; ;

        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
