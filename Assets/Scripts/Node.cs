using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    private Renderer rend;
    private Color startColor;
    public GameObject turret;
    public Vector3 positionOffset;


    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

    }

    void OnMouseDown()
    {
        if (turret != null)
        {
            Debug.Log("Cant Build here");
            return;
        }

        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
        
    }

    private void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }
    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
