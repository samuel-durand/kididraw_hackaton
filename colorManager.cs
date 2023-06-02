using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorManager : MonoBehaviour
{
    public GameObject colorPanel;
    public GameObject brushSamplePrefab; // Préfabriqué du "BrushSample"
    private List<GameObject> brushSamples = new List<GameObject>(); // Liste des "BrushSamples" créés
    private LineRenderer currentBrushLineRenderer; // LineRenderer du "BrushSample" actuellement sélectionné

    public Material[] materials; // Tableau des matériaux disponibles

    void Start()
    {
        colorPanel.SetActive(false);
    }

    public void OnClick()
    {
        colorPanel.SetActive(true);
    }

    public void CreateBrushSamples()
    {
        // Supprime les anciens "BrushSamples"
        foreach (GameObject brushSample in brushSamples)
        {
            Destroy(brushSample);
        }
        brushSamples.Clear();

        // Crée un "BrushSample" pour chaque matériau
        foreach (Material material in materials)
        {
            GameObject brushSample = Instantiate(brushSamplePrefab, Vector3.zero, Quaternion.identity);
            LineRenderer brushLineRenderer = brushSample.GetComponent<LineRenderer>();
            brushLineRenderer.material = material;
            brushSample.SetActive(false); // Désactive le "BrushSample" par défaut
            brushSamples.Add(brushSample);
        }
    }

    public void ModifyLineColor(Color newColor)
    {
        if (currentBrushLineRenderer != null)
        {
            currentBrushLineRenderer.startColor = newColor;
            currentBrushLineRenderer.endColor = newColor;
        }
    }

    public void SelectBrush(int index)
    {
        // Désactive tous les "BrushSamples"
        foreach (GameObject brushSample in brushSamples)
        {
            brushSample.SetActive(false);
        }

        // Active le "BrushSample" sélectionné et assigne son LineRenderer à currentBrushLineRenderer
        GameObject selectedBrushSample = brushSamples[index];
        selectedBrushSample.SetActive(true);
        currentBrushLineRenderer = selectedBrushSample.GetComponent<LineRenderer>();
    }

    public void ChangeToBlack()
    {
        Debug.Log("changement de la couleur en noir");
        ModifyLineColor(Color.black);
        colorPanel.SetActive(false);
    }

    public void ChangeToWhite()
    {
        Debug.Log("changement de la couleur en blanc");
        ModifyLineColor(Color.white);
        colorPanel.SetActive(false);
    }

    public void ChangeToBlue()
    {
        Debug.Log("changement de la couleur en bleu");
        ModifyLineColor(Color.blue);
        colorPanel.SetActive(false);
    }

    public void ChangeToRed()
    {
        Debug.Log("changement de la couleur en rouge");
        ModifyLineColor(Color.red);
        colorPanel.SetActive(false);
    }

    public void ChangeToYellow()
    {
        Debug.Log("changement de la couleur en jaune");
        ModifyLineColor(Color.yellow);
        colorPanel.SetActive(false);
    }

    public void ChangeToGreen()
    {
        Debug.Log("changement de la couleur en vert");
        ModifyLineColor(Color.green);
        colorPanel.SetActive(false);
    }

    void Update()
    {

    }
}
