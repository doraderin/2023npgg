using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;
/// <summary>
/// NOT FINISHED. NEEDS ENUMERATION.
/// </summary>
public class AnimText : MonoBehaviour
{
    public TextMeshProUGUI UIText;
    public List<string> DLT = new List<string>();
    public int curline;
    
    // Start is called before the first frame update
    void Start()
    {
        UIText = GameObject.FindGameObjectWithTag("UIText").GetComponent<TextMeshProUGUI>();
        curline  = DLT.Count;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextLine(){
        UIText.text = "";
        if (curline < DLT.Count){
            curline++;
            for (int i = 0; i<DLT[curline].Length; i++){
                UIText.text += i;
                Thread.Sleep(100);
            }
        }
        else{
            //put here function to close text box
        }

        
    }



}
