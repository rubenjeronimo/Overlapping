using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class zonaSeguraSlider : MonoBehaviour {
    public Slider sliderZonaSegura;
    public Text zonaSeguraLabel;
    public Text focoCercanoLabel;
    public Text focoLejanoLabel;
    private float AfocoLejano;
    private float AfocoCercano;
    private float distanciaObjeto;
    private float focoLejano;
    private float focoCercano;

    void OnEnable()
    {
        sliderZonaSegura.onValueChanged.AddListener(CambiaValorZonaSegura);
        CambiaValorZonaSegura(sliderZonaSegura.value);

    }

    void OnDisable()
    {
        sliderZonaSegura.onValueChanged.RemoveAllListeners();
    }

    void CambiaValorZonaSegura(float valorZonaSegura)
    {
        zonaSeguraLabel.text = System.Math.Round(valorZonaSegura, 2).ToString() + "%"; ;
        AfocoCercano = (distanciaObjeto - focoCercano) * (sliderZonaSegura.value / 100);
        //    focoCercano = distanciaObjeto - AfocoCercano;
        focoCercanoLabel.text = (distanciaObjeto - AfocoCercano).ToString() + "m"; ;
        if (focoLejano<0)
        {
            focoLejanoLabel.text = "Infinito";
        }
        else if (focoLejano >= 0)
        {
            AfocoLejano = (focoLejano - distanciaObjeto) * (sliderZonaSegura.value / 100);
            focoLejanoLabel.text = (distanciaObjeto + AfocoLejano).ToString() + "m"; ;
        }
    }
    // Use this for initialization
    void Start () {
        distanciaObjeto = PlayerPrefs.GetFloat("distanciaObjetoPref");
        focoLejano = PlayerPrefs.GetFloat("focoLejanoPref");
        focoCercano = PlayerPrefs.GetFloat("focoCercanoPref");

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}





