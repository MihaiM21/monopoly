using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TileScript : MonoBehaviour
{
    [SerializeField] public int priceLevel1;
    public int resellBasePrice;
    public int upgradePrice;
    [SerializeField] public int level1Tax;
    private int level2Tax;
    private int level3Tax;
    private int level = 0;
    private int priceLevel2;
    private int priceLevel3;
    public GameObject buildingLevel1;
    public GameObject buildingLevel2;
    public GameObject buildingLevel3;
    public TextMesh priceText;

    /*
        Levels:
        0 -> No building
        1 -> level 1 building
        2 -> level 2 building
        3 -> level 3 building
    */

    // Start is called before the first frame update
    void Start()
    {
        
        level2Tax = level1Tax * 25 / 100 + level1Tax;
        level3Tax = level2Tax * 25 / 100 + level1Tax;

        priceLevel2 = priceLevel1 + priceLevel1 / 2;
        priceLevel3 = priceLevel2 + priceLevel2 / 2;

        upgradePrice = priceLevel1 / 2;

        buildingLevel1.SetActive(false);
        buildingLevel2.SetActive(false);
        buildingLevel3.SetActive(false);

        priceText.text = priceLevel1.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (level == 1)
        {
            priceText.GetComponent<Text>().text = level1Tax.ToString();
        }
        if (level == 2)
        {
            priceText.GetComponent<Text>().text = level2Tax.ToString();
        }
        if (level == 3)
        {
            priceText.GetComponent<Text>().text = level3Tax.ToString();
        }
     
        
    }

    public void buyLevel1()
    {
        level = 1;
        buildingLevel1.SetActive(true);
    }
    public void buyLevel2()
    {
        level = 2;
        if(level == 0)
        {
            buyLevel1();  
        }
        buildingLevel2.SetActive(true);
    }
    public void buyLevel3()
    {
        level = 3;
        if(level == 0)
        {
            buyLevel1();
            buyLevel2();
        }
        if(level == 1)
        {
            buyLevel2();
        }
        buildingLevel3.SetActive(true);
    }
}
