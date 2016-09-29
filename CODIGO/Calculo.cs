using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class Calculo : MonoBehaviour {
//    private string modelo;
    private string marca;
    private float sensorHmm;
    private float sensorVmm;
    private int sensorHpx;
    private float sensorHpxFloat;
 //   private int sensorVpx;
    private float circuloConfusion;

    private float solapeH;
    private float BH;
    private float distanciaObjeto;
    private float focal;
    private float focalReal;
    private float apertura;
    private string fullFrame;

    private float resolucion;
    private float desplazamientoVertical;
    private float desplazamientoHorizontal;
    private float distanciaHiperFocal;
    private float focoLejano;
    private float focoCercano;
    private float anchoImagen;
    private float altoImagen;

    public static datosCamaraSeleccionada Instance;

    public Text modeloLabel;
    public Text marcaLabel;
    public Text sensorHmmLabel;
    public Text sensorVmmLabel;
    public Text sensorHpxLabel;
    public Text sensorVpxLabel;
    public Text circuloConfusionLabel;
    public Slider sliderBH;
    public Slider sliderSolapeH;
    public Text FocalLabel;
    public Text distanciaObjetoLabel;
    public Text aperturaLabel;

    // Use this for initialization
    void Start () {
     //   marca = PlayerPrefs.GetString("marcaPref");
     //   modelo = PlayerPrefs.GetString("modeloPref");
        sensorHmm = PlayerPrefs.GetFloat("sensorHmmPref");
        sensorVmm = PlayerPrefs.GetFloat("sensorVmmPref");
        sensorHpx = PlayerPrefs.GetInt("sensorHpxPref");
        sensorHpxFloat = (float)sensorHpx;
     //   sensorVpx = PlayerPrefs.GetInt("sensorVpxPref");
        circuloConfusion = PlayerPrefs.GetFloat("circuloConfusionPref");
        fullFrame = PlayerPrefs.GetString("FullFramePref");
    }
	void OnMouseDown()
    {
        solapeH = sliderSolapeH.value;
        BH = sliderBH.value;
        focal = float.Parse(FocalLabel.text.ToString());
        if ((String.Compare(fullFrame,"SI")==0))
        {
        }
        else if ((String.Compare(fullFrame, "NO") == 0))
        {
            focal=(focal*sensorHmm)/34.6f;
        }
        //    Debug.Log(fullFrame);
        apertura = float.Parse(aperturaLabel.text);
        distanciaObjeto = float.Parse(distanciaObjetoLabel.text);
        PlayerPrefs.SetFloat("focalPref", focal);
        PlayerPrefs.SetFloat("aperturaPref", apertura);
        PlayerPrefs.SetFloat("distanciaObjetoPref", distanciaObjeto);

        anchoImagen = ((sensorHmm / 1000) * distanciaObjeto) / (focal / 1000);
        PlayerPrefs.SetFloat("anchoImagenPref", anchoImagen);
        altoImagen = ((sensorVmm / 1000) * distanciaObjeto) / (focal / 1000);
        PlayerPrefs.SetFloat("altoImagenPref", altoImagen);
                
        resolucion = (anchoImagen *100)/ sensorHpxFloat;
        PlayerPrefs.SetFloat("resolucionPref", resolucion);
        

        desplazamientoHorizontal = anchoImagen * (1 - (solapeH / 100));
        PlayerPrefs.SetFloat("desplazamientoHorizontalPref", desplazamientoHorizontal);
        desplazamientoVertical = altoImagen * BH;
        PlayerPrefs.SetFloat("desplazamientoVerticalPref", desplazamientoVertical);
        distanciaHiperFocal = ((focal * focal) / (apertura * circuloConfusion)) / 1000;
        Debug.Log("calculo...DHF: " + distanciaHiperFocal);
        PlayerPrefs.SetFloat("distanciaHiperFocalPref", distanciaHiperFocal);
        focoLejano = (distanciaHiperFocal * distanciaObjeto) / ((distanciaHiperFocal - distanciaObjeto) - (focal / 1000));
        PlayerPrefs.SetFloat("focoLejanoPref", focoLejano);
        focoCercano = (distanciaHiperFocal * distanciaObjeto) / ((distanciaHiperFocal + distanciaObjeto) - (focal / 1000));
        PlayerPrefs.SetFloat("focoCercanoPref", focoCercano);

        Application.LoadLevel("CalculoI");
     //   Debug.Log("calculo....apertura: " + apertura);
    }
	// Update is called once per frame
	void Update () {
	
	}
}
