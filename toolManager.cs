using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toolManager : MonoBehaviour
{
    public GameObject Panel;
    public LineRenderer brushLineRenderer; // Référence vers le composant LineRenderer dans l'inspecteur

    void Start()
    {
        Panel.gameObject.SetActive(false);
        brushLineRenderer = GameObject.Find("BrushSample").GetComponent<LineRenderer>();
    }

    public void OnClick()
    {
        Panel.gameObject.SetActive(true);
    }

    public void OnClick72()
    {
        Debug.Log("Taille du pinceau réglée à 72 pixels");
        ModifyLineWidth(0.72f);
        Panel.gameObject.SetActive(false);
    }

    public void OnClick56()
    {
        Debug.Log("Taille du pinceau réglée à 56 pixels");
        ModifyLineWidth(0.56f);
        Panel.gameObject.SetActive(false);
    }

    public void OnClick36()
    {
        Debug.Log("Taille du pinceau réglée à 36 pixels");
        ModifyLineWidth(0.36f);
        Panel.gameObject.SetActive(false);
    }

    public void OnClick24()
    {
        Debug.Log("Taille du pinceau réglée à 24 pixels");
        ModifyLineWidth(0.24f);
        Panel.gameObject.SetActive(false);
    }

    public void OnClick12()
    {
        Debug.Log("Taille du pinceau réglée à 12 pixels");
        ModifyLineWidth(0.12f);
        Panel.gameObject.SetActive(false);
    }

    public void OnClick6()
    {
        Debug.Log("Taille du pinceau réglée à 6 pixels");
        ModifyLineWidth(0.06f);
        Panel.gameObject.SetActive(false);
    }

    private void ModifyLineWidth(float newWidth)
    {
        brushLineRenderer.startWidth = newWidth;
        brushLineRenderer.endWidth = newWidth;
    }

    void Update()
    {

    }
}
