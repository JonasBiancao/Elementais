using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cutscene_velho_novo : MonoBehaviour
{
    [SerializeField] private Image painelCutscene;
    [SerializeField] private float count, aum;

    void start()
    {
        count = 0;
        aum = 0;
    }
    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
               
            if (count >= 0)
            {
                painelCutscene.color = new Color(painelCutscene.color.r, painelCutscene.color.g, painelCutscene.color.b, aum += 0.005f);
            }                                
    }
}
