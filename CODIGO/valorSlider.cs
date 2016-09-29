using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class valorSlider : MonoBehaviour {
    public Slider sliderBH;
    public Slider sliderSolapeH;
    public Text BHLabel;
    public Text solapeHLabel;
    void OnEnable()
    {
        sliderBH.onValueChanged.AddListener(CambiaValorBH);
        CambiaValorBH(sliderBH.value);
        sliderSolapeH.onValueChanged.AddListener(CambiaValorSolapeH);
        CambiaValorSolapeH(sliderSolapeH.value);
    }
    void OnDisable()
    {
        sliderBH.onValueChanged.RemoveAllListeners();
        sliderSolapeH.onValueChanged.RemoveAllListeners();
    }
    void CambiaValorBH(float valorBH)
    {
        BHLabel.text = System.Math.Round( valorBH,2).ToString()+"%";
        PlayerPrefs.SetFloat("BH",sliderBH.value);
    }
    void CambiaValorSolapeH(float valorSolapeH)
    {
        solapeHLabel.text = System.Math.Round(valorSolapeH, 2).ToString() + "%";
        PlayerPrefs.SetFloat("solapeH", sliderSolapeH.value);
    }
    void Start()
    {
        PlayerPrefs.SetFloat("BH", sliderBH.value);
        PlayerPrefs.SetFloat("solapeH", sliderSolapeH.value);
    }
}
