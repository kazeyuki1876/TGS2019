using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Main_HSVConverter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject FilterStory;
    public GameObject FilterMemory;
    public GameObject MainController;
    public int A;
    public int B;
    Material Story;
    Material Memory;

    public float cahngeAlphaUpSpeed;
    public float VUpSpeed;

    public float cahngeAlphaMAX;
    



    public float cahngeAlphaDOWSSpeed;
    public float VDOWNSpeed;

    
    public bool isFilterStory;
    public bool isFilterMemory;
    public bool isDown;


    public float H;
    public float S;
    public float V;

    public float changeRed = 1.0f;
    public float changeGreen = 1.0f;
    public float cahngeBlue = 1.0f;
    public float cahngeAlpha = 0.0f;

    // Use this for initialization
    void Start()
    {
        Story = FilterStory.transform.GetComponent<Renderer>().material;
        Memory = FilterMemory.transform.GetComponent<Renderer>().material;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (cahngeAlpha >= cahngeAlphaMAX) { isFilterMemory = false; isFilterStory = false; }
        if (cahngeAlpha <= 0) {  isDown = false;}
        FilterStoryUP();
       FilterMemoryUP();
        FilterStoryAndFilterMemoryDown();


    }
    void VUP() {
        A = MainController.GetComponent<Main_Controller>().Read;
        B = MainController.GetComponent<Main_Controller>().Unread;
        if (A>= B)
        {
            isFilterStory = true;
        }
        else {
            isFilterMemory = true;
        }

    }
    void FilterStoryUP() {
        if (isFilterStory && cahngeAlpha < cahngeAlphaMAX)
        {

            
           
           // V = V + VUpSpeed * Time.deltaTime; ;//明るさ
            Color target = Color.HSVToRGB(H, S, V);
            Story.SetVector("_Color", target);
           
            cahngeAlpha = cahngeAlpha + cahngeAlphaUpSpeed * Time.deltaTime;//透明数値
            FilterStory.GetComponent<SpriteRenderer>().color = new Color(changeRed, changeGreen, cahngeBlue, cahngeAlpha);
            
        }
      

    }

    void FilterMemoryUP() {
        if (isFilterMemory && cahngeAlpha < cahngeAlphaMAX)
        {
            

             // V = V + VUpSpeed * Time.deltaTime; ;//明るさ
              Color target = Color.HSVToRGB(H, S, V);
          Memory.SetVector("_Color", target);
            cahngeAlpha = cahngeAlpha + cahngeAlphaUpSpeed * Time.deltaTime;//透明数値
            FilterMemory.GetComponent<SpriteRenderer>().color = new Color(changeRed, changeGreen, cahngeBlue, cahngeAlpha);
           
        }

    }






    void VDOWN() {
        /*
        V = 0.0f;//明るさ
        Color target = Color.HSVToRGB(H, S, V);
        Memory.SetVector("_Color", target);
        */
        isDown = true;

    }
    void FilterStoryAndFilterMemoryDown() {
        if (isDown && cahngeAlpha > 0) {
            isFilterMemory = false; isFilterStory = false;
            cahngeAlpha = cahngeAlpha - cahngeAlphaDOWSSpeed * Time.deltaTime; ;
            FilterStory.GetComponent<SpriteRenderer>().color = new Color(changeRed, changeGreen, cahngeBlue, cahngeAlpha);
            FilterMemory.GetComponent<SpriteRenderer>().color = new Color(changeRed, changeGreen, cahngeBlue, cahngeAlpha);
            
        }
        
    }

}
