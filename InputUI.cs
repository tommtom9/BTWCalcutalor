using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputUI : MonoBehaviour
{
    public InputField productField;
    public InputField pricePerItem;
    public InputField landCode;

    public Text productText;
    public Text priceItemText;
    public Text landCodeText;


	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        productText.text = productField.text;
        priceItemText.text = pricePerItem.text ;
        landCodeText.text = landCode.text; 
	}
}
