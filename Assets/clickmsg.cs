using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Unity.VisualScripting;

public class ButtonClickHandler : MonoBehaviour
{
    public TMP_Text textMeshProText; // 引用用于显示文本的 TextMeshPro Text 组件
    public TMP_Text textMeshProTextpre; // 引用用于显示文本的 TextMeshPro Text 组件
    public Button buttonnum1; // 引用增加按钮1
    public Button buttonnum2; // 引用增加按钮2
    public Button buttonnum3; // 引用增加按钮3
    public Button buttonnum4; // 引用增加按钮4
    public Button buttonnum5; // 引用增加按钮5
    public Button buttonnum6; // 引用增加按钮6
    public Button buttonnum7; // 引用增加按钮7
    public Button buttonnum8; // 引用增加按钮8
    public Button buttonnum9; // 引用增加按钮9
    public Button buttonnum0; // 引用增加按钮0
    public Button buttonreset;// 引用增加按钮reset
    
    public Button buttonAdd; // 引用加按钮
    public Button buttonMinus; // 引用减按钮
    public Button buttonMultiply; // 引用乘以按钮
    public Button buttonDivide; // 引用除按钮
    public Button buttonEqual;
    private float result = 0;
    private int number = 0;
    private float numberold = 0;
    private int operat = 0;
    private int num = 0;
    private string symble = "";
    private bool overflow = false;

    void Start()
    {
        buttonnum1.onClick.AddListener(Button1Click);
        buttonnum2.onClick.AddListener(Button2Click);
        buttonnum3.onClick.AddListener(Button3Click);
        buttonnum4.onClick.AddListener(Button4Click);
        buttonnum5.onClick.AddListener(Button5Click);
        buttonnum6.onClick.AddListener(Button6Click);
        buttonnum7.onClick.AddListener(Button7Click);
        buttonnum8.onClick.AddListener(Button8Click);
        buttonnum9.onClick.AddListener(Button9Click);
        buttonnum0.onClick.AddListener(Button0Click);

        buttonAdd.onClick.AddListener(ButtonAddClick);
        buttonMinus.onClick.AddListener(ButtonMinusClick);
        buttonMultiply.onClick.AddListener(ButtonMultiplyClick);
        buttonDivide.onClick.AddListener(ButtonDivideClick);
        buttonEqual.onClick.AddListener(ButtonEqualClick);
       
        buttonreset.onClick.AddListener(ButtonresetClick);

        ButtonresetClick();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
        {
            Button1Click();
        }
        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            Button2Click();
        }
        if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
        {
            Button3Click();
        }
        if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            Button4Click();
        }
        if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5))
        {
            Button5Click();
        }
        if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6))
        {
            Button6Click();
        }
        if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7))
        {
            Button7Click();
        }
        if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8))
        {
            Button8Click();
        }
        if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9))
        {
            Button9Click();
        }
        if (Input.GetKeyDown(KeyCode.Keypad0) || Input.GetKeyDown(KeyCode.Alpha0))
        {
            Button0Click();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            ButtonresetClick();
        }
        if (Input.GetKeyDown(KeyCode.Plus) || Input.GetKeyDown(KeyCode.Equals))
        {
            ButtonAddClick();
        }
        if (Input.GetKeyDown(KeyCode.Minus))
        {
            ButtonMinusClick();
        }
        if (Input.GetKeyDown(KeyCode.Asterisk))
        {
            ButtonMultiplyClick();
        }
        if (Input.GetKeyDown(KeyCode.Slash))
        {
            ButtonDivideClick();
        }
        if (Input.GetKeyDown(KeyCode.Equals))
        {
            ButtonEqualClick();
        }
       
    }

    void Button1Click()
    {

        //if (Mathf.Abs(number) >= 10000000)
        //    return;
        //num = 1;
        //number = number * 10 + num;
        //UpdateText();
        if (textMeshProText.text.Length >= 8)
            return;
        if (textMeshProText.text == "0")
            textMeshProText.text = "1";
        else
            textMeshProText.text += "1";
    }
    void Button2Click()
    {
        //if (Mathf.Abs(number) >= 10000000)
        //    return;
        //num = 2;
        //number = number * 10 + num;
        //UpdateText();
        if (textMeshProText.text.Length >= 8)
            return;
        if (textMeshProText.text == "0")
            textMeshProText.text = "2";
        else
            textMeshProText.text += "2";
    }
    void Button3Click()
    {
        //if (Mathf.Abs(number) >= 10000000)
        //    return;
        //num = 3;
        //number = number * 10 + num;
        //UpdateText();
        if (textMeshProText.text.Length >= 8)
            return;
        if (textMeshProText.text == "0")
            textMeshProText.text = "3";
        else
            textMeshProText.text += "3";
    }
    void Button4Click()
    {
        //if (Mathf.Abs(number) >= 10000000)
        //    return;
        //num = 4;
        //number = number * 10 + num;
        //UpdateText();
        if (textMeshProText.text.Length >= 8)
            return;
        if (textMeshProText.text == "0")
            textMeshProText.text = "4";
        else
            textMeshProText.text += "4";
    }
    void Button5Click()
    {
        //if (Mathf.Abs(number) >= 10000000)
        //    return;
        //num = 5;
        //number = number * 10 + num;
        //UpdateText();
        if (textMeshProText.text.Length >= 8)
            return;
        if (textMeshProText.text == "0")
            textMeshProText.text = "5";
        else
            textMeshProText.text += "5";
    }
    void Button6Click()
    {
        //if (Mathf.Abs(number) >= 10000000)
        //    return;
        //num = 6;
        //number = number * 10 + num;
        //UpdateText();
        if (textMeshProText.text.Length >= 8)
            return;
        if (textMeshProText.text == "0")
            textMeshProText.text = "6";
        else
            textMeshProText.text += "6";
    }
    void Button7Click()
    {
        //if (Mathf.Abs(number) >= 10000000)
        //    return;
        //num = 7;
        //number = number * 10 + num;
        //UpdateText();
        if (textMeshProText.text.Length >= 8)
            return;
        if (textMeshProText.text == "0")
            textMeshProText.text = "7";
        else
            textMeshProText.text += "7";
    }
    void Button8Click()
    {
        //if (Mathf.Abs(number) >= 10000000)
        //    return;
        //num = 8;
        //number = number * 10 + num;
        //UpdateText();
        if (textMeshProText.text.Length >= 8)
            return;
        if (textMeshProText.text == "0")
            textMeshProText.text = "8";
        else
            textMeshProText.text += "8";
    }
    void Button9Click()
    {
        //if (Mathf.Abs(number) >= 10000000)
        //    return;
        //num = 9;
        //number = number * 10 + num;
        //UpdateText();
        if (textMeshProText.text.Length >= 8)
            return;
        if (textMeshProText.text == "0")
            textMeshProText.text = "9";
        else
            textMeshProText.text += "9";
    }
    void Button0Click()
    {
        //if (Mathf.Abs(number) >= 10000000)
        //    return;
        //num = 0;
        //number = number * 10 + num;
        //UpdateText();
        if (textMeshProText.text.Length >= 8)
            return;
        if (textMeshProText.text == "0")
            textMeshProText.text = "0";
        else
            textMeshProText.text += "0";
    }



    void ButtonresetClick()
    {
        //number = 0;
        //numberold = 0;
        //result = 0;
        overflow = false;
        textMeshProTextpre.text = "0 +";
        textMeshProText.text = "";
        //UpdateText();
    }

    void ProcOP()
    {
        if (textMeshProText.text == "")
            return;
        Char lastChar = textMeshProTextpre.text.Substring(textMeshProTextpre.text.Length - 1)[0];
        int preNum = int.Parse(textMeshProTextpre.text.Substring(0, textMeshProTextpre.text.Length - 2));
        int curNum = int.Parse(textMeshProText.text);
        if (lastChar == '+')
        {
            textMeshProTextpre.text = (preNum + curNum).ToString();
        }
        else if (lastChar == '-')
        {
            textMeshProTextpre.text = (preNum - curNum).ToString();
        }
        else if (lastChar == '*')
        {
            textMeshProTextpre.text = (preNum * curNum).ToString();
        }
        else if (lastChar == '/')
        {
            textMeshProTextpre.text = (preNum / curNum).ToString();
        }
        textMeshProText.text = "";
    }
    void ButtonAddClick()
    {
        ProcOP();
        try
        {
            if (!Char.IsDigit(textMeshProTextpre.text[textMeshProTextpre.text.Length - 1]))
            {
                textMeshProTextpre.text = textMeshProTextpre.text.Substring(0, textMeshProTextpre.text.Length - 2);
            }
        }
        catch (ArgumentOutOfRangeException ex) { }
        textMeshProTextpre.text += " +";
        //symble = " + ";
        //operat = 1;
        //if (number == 0)
        //{
        //    return;
        //}
        //else
        //{
        //    ButtonEqualClick();
        //    if (result > 0)
        //    {
        //        numberold = result;
        //    }
        //    else
        //    {
        //        numberold = number;
        //    }
            
            

        //    textMeshProTextpre.text = numberold.ToString() + symble;

        //    number = 0;
        //    UpdateText();
        //    operat = 0;
        //}
    }
    void ButtonMinusClick()
    {
        ProcOP();
        if (!Char.IsDigit(textMeshProTextpre.text[textMeshProTextpre.text.Length - 1]))
        {
            textMeshProTextpre.text = textMeshProTextpre.text.Substring(0, textMeshProTextpre.text.Length - 2);
        }
        textMeshProTextpre.text += " -";
        //symble = " - ";
        //operat = 2;
        //if (number == 0)
        //{
        //    return;
        //}
        //else
        //{
        //    ButtonEqualClick();
        //    if (result > 0)
        //    {
        //        numberold = result;
        //    }
        //    else
        //    {
        //        numberold = number;
        //    }



        //    textMeshProTextpre.text = numberold.ToString() + symble;
        //    number = 0;
        //    UpdateText();
        //    operat = 0;
    //}
    }
    void ButtonMultiplyClick()
    {
        ProcOP();
        if (!Char.IsDigit(textMeshProTextpre.text[textMeshProTextpre.text.Length - 1]))
        {
            textMeshProTextpre.text = textMeshProTextpre.text.Substring(0, textMeshProTextpre.text.Length - 2);
        }
        textMeshProTextpre.text += " *";
        //symble = " x ";
        //operat = 3;
        //if (number == 0)
        //{

        //    return;
        //}
        //else
        //{
        //    ButtonEqualClick();
        //    if (result > 0)
        //    {
        //        numberold = result;
        //    }
        //    else
        //    {
        //        numberold = number;
        //    }
            
            

        //    textMeshProTextpre.text = numberold.ToString() + symble;
        //    number = 0;
        //    UpdateText();
        //    operat = 0;
        //}
    }
    void ButtonDivideClick()
    {
        ProcOP();
        if (!Char.IsDigit(textMeshProTextpre.text[textMeshProTextpre.text.Length - 1]))
        {
            textMeshProTextpre.text = textMeshProTextpre.text.Substring(0, textMeshProTextpre.text.Length - 2);
        }
        textMeshProTextpre.text += " /";
        //symble = " / ";
        //operat = 4;
        //if (number == 0) {
        //    return;
        //}
        //else
        //{
        //    ButtonEqualClick();
        //    if (result > 0)
        //    {
        //        numberold = result;
        //    }
        //    else
        //    {
        //        numberold = number;
        //    }
            
            

        //    textMeshProTextpre.text = numberold.ToString() + symble;
        //    number = 0;
        //    UpdateText();
        //    operat = 0;
        //}

    }
    void ButtonEqualClick()
    {
        ProcOP();
        if (!Char.IsDigit(textMeshProTextpre.text[textMeshProTextpre.text.Length - 1]))
        {
            textMeshProTextpre.text = textMeshProTextpre.text.Substring(0, textMeshProTextpre.text.Length - 2);
        }
        //if ( operat == 1 )
        //  {

        //      ProcOP();
        //      if (!Char.IsDigit(textMeshProTextpre.text[textMeshProTextpre.text.Length - 1]))
        //      {
        //          textMeshProTextpre.text = textMeshProTextpre.text.Substring(0, textMeshProTextpre.text.Length - 2);
        //      }

        //  }
        //if ( operat == 2 )
        //  {

        //          symble = " - ";
        //          textMeshProTextpre.text = numberold.ToString() + symble + number.ToString();
        //          result = numberold - number;
        //          if (Mathf.Abs(result) >= 10000000)
        //          {
        //              overflow = true;
        //              UpdateText();
        //          }
        //          else
        //          {
        //              numberold = result;
        //              textMeshProText.text = result.ToString();
        //              operat = 0;
        //          }


        //  }
        //if ( operat == 3 )
        //  {

        //          symble = " x ";
        //          textMeshProTextpre.text = numberold.ToString() + symble + number.ToString();
        //          result = numberold * number;
        //          if (Mathf.Abs(result) >= 10000000)
        //          {
        //              overflow = true;
        //              UpdateText();
        //          }
        //          else
        //          {
        //              result = numberold + number;
        //              numberold = result;
        //              textMeshProText.text = result.ToString();
        //              operat = 0;

        //      }

        //  }
        //if ( operat == 4 )
        //  {

        //          symble = " / ";
        //          textMeshProTextpre.text = numberold.ToString() + symble + number.ToString();
        //          result = numberold / number;
        //          if (Mathf.Abs(result) >= 10000000)
        //          {
        //              overflow = true;
        //              UpdateText();
        //          }
        //          else
        //          {
        //              numberold = result;
        //              textMeshProText.text = result.ToString();
        //              operat = 0;
        //          }


        //  }
    }


    //void UpdateText()
    //{
 
     
    //    if (overflow)
    //    {
    //        textMeshProText.text = "OVERFLOW";
    //    }
    //    else
    //    {
    //        textMeshProText.text = number.ToString();
           
    //    }
    //}


}


