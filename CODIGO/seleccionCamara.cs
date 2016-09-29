using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]

public class CamaraLista
{
    public string marca;
    public string modelo;
    public float sensorHmm;
    public float sensorVmm;
    public int sensorHpx;
    public int sensorVpx;
    public float circuloConfusion;
    public Sprite icono;
    public Button.ButtonClickedEvent enviaDatosCamaraSeleccionada;
}
public class seleccionCamara : MonoBehaviour {

    public GameObject sampleButton;
    public List<CamaraLista> itemList;
    public List<Camara> camaraSeleccionada = new List<Camara>();
    public Transform contentPanel;
    public sampleButton button;
    public string marca;
    public string modelo;
    public float sensorHmm;
    public float sensorVmm;
    public int sensorHpx;
    public int sensorVpx;
    public float circuloConfusion;
    // Use this for initialization
    void Start () {
        PopulateList();
        marca = PlayerPrefs.GetString("marcaPref");
        modelo = PlayerPrefs.GetString("modeloPref");
        sensorHmm = PlayerPrefs.GetFloat("sensorHmmPref");
        sensorVmm = PlayerPrefs.GetFloat("sensorVmmPref");
        sensorHpx = PlayerPrefs.GetInt("sensorHpxPref");
        sensorVpx = PlayerPrefs.GetInt("sensorVpxPref");
    }
	
    void PopulateList()
    {
        foreach(var item in itemList)
        {
            GameObject newButton = Instantiate(sampleButton) as GameObject;
            sampleButton button = newButton.GetComponent<sampleButton>();
            button.marca.text = item.marca;
            button.modelo.text = item.modelo;
            button.icono.sprite = item.icono;
            button.button.onClick = item.enviaDatosCamaraSeleccionada;
            newButton.transform.SetParent(contentPanel);
         }
    }

    public void enviaDatosCamaraSeleccionada()
    {
        
        /*
        if (string.Equals(button.marca.text,"EOS600D"))
        {
            //   camaraSeleccionada.Add(new Camara(button.modelo, button.modelo, 22.3, 17.4, 4853, 3853, 0.019));
            Debug.Log("600D");
        }
        else if (button.marca.text == "EOS1100D")
        {
            //    camaraSeleccionada.Add(new Camara(button.modelo, button.modelo, 22.3, 17.4, 4853, 3853, 0.019));
            Debug.Log("1100D");
        }
        else if (button.marca.text == "5D")
        {
            //    camaraSeleccionada.Add(new Camara(button.modelo, button.modelo, 22.3, 17.4, 4853, 3853, 0.019));
            Debug.Log("5D");
        }
        */
    }
    public void datosEOS600D()
    {
        camaraSeleccionada.Add(new Camara());
        //    Debug.Log("600D");
        PlayerPrefs.SetString("marcaPref", "EOS600D");
        PlayerPrefs.SetString("modeloPref", "Canon");
        PlayerPrefs.SetFloat("sensorHmmPref", 22.3f);
        PlayerPrefs.SetFloat("sensorVmmPref", 14.9f);
        PlayerPrefs.SetInt("sensorHpxPref", 5184);
        PlayerPrefs.SetInt("sensorVpxPref", 3456);
        PlayerPrefs.SetFloat("circuloConfusionPref", 0.019f);
        PlayerPrefs.SetString("FullFramePref","NO");
        Application.LoadLevel("Inicio");
    }
    public void datosEOS100D()
    {
        camaraSeleccionada.Add(new Camara());
        //      Debug.Log("100D");
        PlayerPrefs.SetString("marcaPref", "EOS100D");
        PlayerPrefs.SetString("modeloPref", "Canon");
        PlayerPrefs.SetFloat("sensorHmmPref", 22.3f);
        PlayerPrefs.SetFloat("sensorVmmPref", 14.9f);
        PlayerPrefs.SetInt("sensorHpxPref", 5184);
        PlayerPrefs.SetInt("sensorVpxPref", 3456);
        PlayerPrefs.SetFloat("circuloConfusionPref", 0.019f);
        PlayerPrefs.SetString("FullFramePref", "NO");
        Application.LoadLevel("Inicio");

    }
    public void datosEOS1100D()
    {
        camaraSeleccionada.Add(new Camara());
        //    Debug.Log("1100D");
        PlayerPrefs.SetString("marcaPref", "EOS1100D");
        PlayerPrefs.SetString("modeloPref", "Canon");
        PlayerPrefs.SetFloat("sensorHmmPref", 22.2f);
        PlayerPrefs.SetFloat("sensorVmmPref", 14.7f);
        PlayerPrefs.SetInt("sensorHpxPref", 4272);
        PlayerPrefs.SetInt("sensorVpxPref", 2848);
        PlayerPrefs.SetFloat("circuloConfusionPref", 0.019f);
        PlayerPrefs.SetString("FullFramePref", "NO");
        Application.LoadLevel("Inicio");

    }
    public void datos5D()
    {
        camaraSeleccionada.Add(new Camara());
        //     Debug.Log("5D");
        PlayerPrefs.SetString("marcaPref", "5D");
        PlayerPrefs.SetString("modeloPref", "Canon");
        PlayerPrefs.SetFloat("sensorHmmPref", 35.8f);
        PlayerPrefs.SetFloat("sensorVmmPref", 23.9f);
        PlayerPrefs.SetInt("sensorHpxPref", 5760);
        PlayerPrefs.SetInt("sensorVpxPref", 3840);
        PlayerPrefs.SetFloat("circuloConfusionPref", 0.03f);
        PlayerPrefs.SetString("FullFramePref", "SI");
        Application.LoadLevel("Inicio");
    }
    public void datosNEX6()
    {
        camaraSeleccionada.Add(new Camara());
        //    Debug.Log("NEX6");
        PlayerPrefs.SetString("marcaPref", "NEX6");
        PlayerPrefs.SetString("modeloPref", "Sony");
        PlayerPrefs.SetFloat("sensorHmmPref", 23.5f);
        PlayerPrefs.SetFloat("sensorVmmPref", 15.6f);
        PlayerPrefs.SetInt("sensorHpxPref", 4912);
        PlayerPrefs.SetInt("sensorVpxPref", 3264);
        PlayerPrefs.SetFloat("circuloConfusionPref", 0.02f);
        PlayerPrefs.SetString("FullFramePref", "NO");
        Application.LoadLevel("Inicio");
    }
    public void datosNikon()
    {
        camaraSeleccionada.Add(new Camara());
        //    Debug.Log("Nikon");
        PlayerPrefs.SetString("marcaPref", "D800");
        PlayerPrefs.SetString("modeloPref", "Nikon");
        PlayerPrefs.SetFloat("sensorHmmPref", 35.9f);
        PlayerPrefs.SetFloat("sensorVmmPref", 24.0f);
        PlayerPrefs.SetInt("sensorHpxPref", 7360);
        PlayerPrefs.SetInt("sensorVpxPref", 4912);
        PlayerPrefs.SetFloat("circuloConfusionPref", 0.03f);
        PlayerPrefs.SetString("FullFramePref", "SI");
        Application.LoadLevel("Inicio");
    }
    public void datosPanasonic()
    {
        camaraSeleccionada.Add(new Camara());
     //   Debug.Log("Panasonic");
        PlayerPrefs.SetString("marcaPref", "DMC-G6H");
        PlayerPrefs.SetString("modeloPref", "Panasonic");
        PlayerPrefs.SetFloat("sensorHmmPref", 17.3f);
        PlayerPrefs.SetFloat("sensorVmmPref", 13.0f);
        PlayerPrefs.SetInt("sensorHpxPref", 4608);
        PlayerPrefs.SetInt("sensorVpxPref", 3456);
        PlayerPrefs.SetFloat("circuloConfusionPref", 0.015f);
        PlayerPrefs.SetString("FullFramePref", "NO");
        Application.LoadLevel("Inicio");
    }
    public void datosHERO3()
    {
        camaraSeleccionada.Add(new Camara());
     //   Debug.Log("6HERO3");
        PlayerPrefs.SetString("marcaPref", "HERO3");
        PlayerPrefs.SetString("modeloPref", "GoPro");
        PlayerPrefs.SetFloat("sensorHmmPref", 4.69f);
        PlayerPrefs.SetFloat("sensorVmmPref", 4.25f);
        PlayerPrefs.SetInt("sensorHpxPref", 4000);
        PlayerPrefs.SetInt("sensorVpxPref", 3000);
        PlayerPrefs.SetFloat("circuloConfusionPref", 0.0048f);
        PlayerPrefs.SetString("FullFramePref", "NO");
        Application.LoadLevel("Inicio");
    }
    // Update is called once per frame
    void Update () {
       
	}

}
