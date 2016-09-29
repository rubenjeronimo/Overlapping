using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using System.Collections.Generic;

public class datosCamaraSeleccionada : MonoBehaviour {
    private string modelo;
    private string marca;
    private float sensorHmm;
    private float sensorVmm;
    private int sensorHpx;
    private int sensorVpx;
    private float circuloConfusion;
//    private string fullFrame;
    public static datosCamaraSeleccionada Instance;
    public Text modeloLabel;
    public Text marcaLabel;
    public Text sensorHmmLabel;
    public Text sensorVmmLabel;
    public Text sensorHpxLabel;
    public Text sensorVpxLabel;
    public Text circuloConfusionLabel;

    public Text aperturaLabel;
    public Text focalLabel;
    public Text distanciaObjetoLabel;

/*
    // Use this for initialization
    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
    */
    void Update()
    {
        cargaParametrosAnteriores();
    }

    void Start()
    {
        cargaParametrosAnteriores();
        marca = PlayerPrefs.GetString("marcaPref");
        modelo = PlayerPrefs.GetString("modeloPref");
        sensorHmm = PlayerPrefs.GetFloat("sensorHmmPref");
        sensorVmm = PlayerPrefs.GetFloat("sensorVmmPref");
        sensorHpx = PlayerPrefs.GetInt("sensorHpxPref");
        sensorVpx = PlayerPrefs.GetInt("sensorVpxPref");
        circuloConfusion = PlayerPrefs.GetFloat("circuloConfusionPref");
      

        focalLabel.text= PlayerPrefs.GetFloat("focalPref").ToString();
        aperturaLabel.text = PlayerPrefs.GetFloat("aperturaPref").ToString();
        distanciaObjetoLabel.text = PlayerPrefs.GetFloat("distanciaObjetoPref").ToString();
    //    fullFrame = PlayerPrefs.GetString("FullFramePref");

        modeloLabel.text = modelo;
        marcaLabel.text = marca;
        sensorHpxLabel.text = sensorHpx.ToString();
        sensorVpxLabel.text = sensorVpx.ToString();
        sensorHmmLabel.text = sensorHmm.ToString();
        sensorVmmLabel.text = sensorVmm.ToString();
        circuloConfusionLabel.text = circuloConfusion.ToString();

        
    }

    void cargaParametrosAnteriores()
    {
        
        focalLabel.text = PlayerPrefs.GetFloat("focalPref").ToString();
        aperturaLabel.text = PlayerPrefs.GetFloat("aperturaPref").ToString();
        distanciaObjetoLabel.text = PlayerPrefs.GetFloat("distanciaObjetoPref").ToString();
/*
        Debug.Log("cargaParametrosanteriores en datoscamaraseleccionada");
        Debug.Log("distanciaObjeto: "+PlayerPrefs.GetFloat("distanciaObjetoPref"));
        Debug.Log("focal: " + PlayerPrefs.GetFloat("focalPref"));
        Debug.Log("apertura: " + PlayerPrefs.GetFloat("aperturaPref"));
*/
    }
}


