using UnityEngine;
using System.Collections;
using System;
using System.Reflection;
using System.IO;


[System.Serializable]
public class ClipboardHelper
{
	private static PropertyInfo m_systemCopyBufferProperty = null;
	private static PropertyInfo GetSystemCopyBufferProperty()
	{
		if (m_systemCopyBufferProperty == null)
		{
			Type T = typeof(GUIUtility);
			m_systemCopyBufferProperty = T.GetProperty("systemCopyBuffer", BindingFlags.Static | BindingFlags.NonPublic);
			if (m_systemCopyBufferProperty == null)
				throw new Exception("Can't access internal member 'GUIUtility.systemCopyBuffer' it may have been removed / renamed");
		}
		return m_systemCopyBufferProperty;
	}
	public static string clipBoard
	{
		get
		{
			PropertyInfo P = GetSystemCopyBufferProperty();
			return (string)P.GetValue(null,null);
		}
		set
		{
			PropertyInfo P = GetSystemCopyBufferProperty();
			P.SetValue(null,value,null);
		}
	}
}



public class CharacterAnimationController : MonoBehaviour {
	public Animator a;
	public int AnimateOrder;
	public int LastOrder;
	public bool IsSpeaking;
	bool Onetime = false;
	bool Onetime2 = false;
	bool Onetime3 = false;
	bool Onetime4 = false;
	// Use this for initialization
	void Start () {
		a = this.GetComponent<Animator> ();
		//EmptyClipboard ();
		//Debug.Log ("Cleaned");

	}
	
	// Update is called once per frame
	void Update () {
		switch (AnimateOrder) {
		case 1:
			a.SetBool("IsSpeaking",true);
			LastOrder = 1;
			a.SetInteger ("AnimationIndex",1);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 2:
			a.SetBool("IsSpeaking",true);
			LastOrder = 2;
			a.SetInteger ("AnimationIndex",2);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
//		case 3:
//			IsSpeaking = true;
//			LastOrder = 3;
//			a.SetInteger ("AnimationIndex",3);  //EYeBLink
//			a.SetTrigger("tt");
//			AnimateOrder = 0;
//			break;
		case 4:
			a.SetBool("IsSpeaking",true);
			LastOrder = 4;
			a.SetInteger ("AnimationIndex",4);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 5:
			a.SetBool("IsSpeaking",true);
			LastOrder = 5;
			a.SetInteger ("AnimationIndex",5);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 6:
			a.SetBool("IsSpeaking",true);
			LastOrder = 6;
			a.SetInteger ("AnimationIndex",6);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 7:
			a.SetBool("IsSpeaking",true);
			LastOrder = 7;
			a.SetInteger ("AnimationIndex",7);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 8:
			a.SetBool("IsSpeaking",true);
			LastOrder = 8;
			a.SetInteger ("AnimationIndex",8);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 9:
			a.SetBool("IsSpeaking",true);
			LastOrder = 9;
			a.SetInteger ("AnimationIndex",9);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 10:
			a.SetBool("IsSpeaking",true);
			LastOrder = 10;
			a.SetInteger ("AnimationIndex",10);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 11:
			a.SetBool("IsSpeaking",true);
			LastOrder = 11;
			a.SetInteger ("AnimationIndex",11);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 12:
			a.SetBool("IsSpeaking",true);
			LastOrder = 12;
			a.SetInteger ("AnimationIndex",12);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 13:
			//a.SetBool("IsSpeaking",true);
			LastOrder = 13;
			a.SetInteger ("AnimationIndex",13);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 14:
			a.SetBool("IsSpeaking",true);
			LastOrder = 14;
			a.SetInteger ("AnimationIndex",14); //Lipsing
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 15:
			a.SetBool("IsSpeaking",true);
			LastOrder = 15;
			a.SetInteger ("AnimationIndex",15);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 16:
			a.SetBool("IsSpeaking",true);
			LastOrder = 16;
			a.SetInteger ("AnimationIndex",16);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 17:
			a.SetBool("IsSpeaking",true);
			LastOrder = 17;
			a.SetInteger ("AnimationIndex",17);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 18:
			a.SetBool("IsSpeaking",true);
			LastOrder = 18;
			a.SetInteger ("AnimationIndex",18);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 19:
			a.SetBool("IsSpeaking",true);
			LastOrder = 19;
			a.SetInteger ("AnimationIndex",19);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 20:
			a.SetBool("IsSpeaking",true);
			LastOrder = 20;
			a.SetInteger ("AnimationIndex",20);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 21:
			a.SetBool("IsSpeaking",true);
			LastOrder = 21;
			a.SetInteger ("AnimationIndex",21);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 22:
			a.SetBool("IsSpeaking",true);
			LastOrder = 22;
			a.SetInteger ("AnimationIndex",22);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 23:
			a.SetBool("IsSpeaking",true);
			LastOrder = 23;
			a.SetInteger ("AnimationIndex",23);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 24:
			a.SetBool("IsSpeaking",true);
			LastOrder = 24;
			a.SetInteger ("AnimationIndex",24);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 25:
			a.SetBool("IsSpeaking",true);
			LastOrder = 25;
			a.SetInteger ("AnimationIndex",25);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 26:
			a.SetBool("IsSpeaking",true);
			LastOrder = 26;
			a.SetInteger ("AnimationIndex",26);   //TalkPerformance
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
		case 27:
			a.SetBool("IsSpeaking",true);
			LastOrder = 27;
			a.SetInteger ("AnimationIndex",27);
			a.SetTrigger("tt");
			AnimateOrder = 0;
			break;
            case 28:
                a.SetBool("IsSpeaking", true);
                LastOrder = 28;
                a.SetInteger("AnimationIndex", 28);
                a.SetTrigger("tt");
                AnimateOrder = 0;
                break;
            case 29:
                a.SetBool("IsSpeaking", true);
                LastOrder = 29;
                a.SetInteger("AnimationIndex", 29);
                a.SetTrigger("tt");
                AnimateOrder = 0;
                break;
            case 30:
                a.SetBool("IsSpeaking", true);
                LastOrder = 30;
                a.SetInteger("AnimationIndex", 30);
                a.SetTrigger("tt");
                AnimateOrder = 0;
                break;
            case 31:
                a.SetBool("IsSpeaking", true);
                LastOrder = 31;
                a.SetInteger("AnimationIndex", 31);
                a.SetTrigger("tt");
                AnimateOrder = 0;
                break;
            case 32:
                a.SetBool("IsSpeaking", true);
                LastOrder = 32;
                a.SetInteger("AnimationIndex", 32);
                a.SetTrigger("tt");
                AnimateOrder = 0;
                break;
            case 33:
                a.SetBool("IsSpeaking", true);
                LastOrder = 33;
                a.SetInteger("AnimationIndex", 33);
                a.SetTrigger("tt");
                AnimateOrder = 0;
                break;
            default:
			break;
		}


		if (a.GetCurrentAnimatorStateInfo(0).IsTag("Default")&&a.GetBool("IsSpeaking")== true&&!Onetime) {
			Paste2Clipboard("Free");
			Onetime3 = false;
			Onetime4 = false;
			Onetime2 = false;
			Onetime = true;
			LastOrder = 0;
		}
		else if (!a.GetCurrentAnimatorStateInfo(0).IsTag("Default")&&a.GetBool("IsSpeaking")== true&&!Onetime2) {

			Paste2Clipboard("Busy");
			Onetime2 = true;
			Onetime = false;
			Onetime4 = false;
			Onetime3 = false;
		}
		else if (a.GetCurrentAnimatorStateInfo(0).IsTag("Default")&&a.GetBool("IsSpeaking")== false&&!Onetime3) {
			Paste2Clipboard("Idle");
			Onetime2 = false;
			Onetime = false;
			Onetime4 = false;
			Onetime3 = true;
		}
		else if (!a.GetCurrentAnimatorStateInfo(0).IsTag("Default")&&a.GetBool("IsSpeaking")== false&&!Onetime4) {
			Paste2Clipboard("AlmostBusy");
			Onetime2 = false;
			Onetime = false;
			Onetime4 = true;
			Onetime3 = false;
		}


			
	}







	

		
		void OnGUI()
		{
		string ClipText = ClipboardHelper.clipBoard;
		int n;
		if (int.TryParse(ClipText,out n)) {

		switch (Int32.Parse(ClipText)) {
		case 100:
			if (Onetime2) {
			Paste2Clipboard("Busy");
		}
		else if (Onetime) {
			Paste2Clipboard("Free");
		}
		else {
		EmptyClipboard();
		}
			Debug.Log ("1000000");
			a.SetBool("IsSpeaking",false);
			break;
		case 0:
			AnimateOrder = 0;
			EmptyClipboard();
			break;
		case 1:
			if(LastOrder!=1)
			AnimateOrder = 1;
			EmptyClipboard();
			break;
		case 2:
			if(LastOrder!=2)
			AnimateOrder = 2;
			EmptyClipboard();
			break;
		case 4:
			if(LastOrder!=4)
			AnimateOrder = 4;
			EmptyClipboard();
			break;
		case 5:
			if(LastOrder!=5)
			AnimateOrder = 5;
			EmptyClipboard();
			break;
		case 6:
			if(LastOrder!=6)
			AnimateOrder = 6;
			EmptyClipboard();
			break;
		case 7:
			if(LastOrder!=7)
			AnimateOrder = 7;
			EmptyClipboard();
			break;
		case 8:
			if(LastOrder!=8)
			AnimateOrder = 8;
			EmptyClipboard();
			break;
		case 9:
			if(LastOrder!=9)
			AnimateOrder = 9;
			EmptyClipboard();
			break;
		case 10:
			if(LastOrder!=10)
			AnimateOrder = 10;
			EmptyClipboard();
			break;
		case 11:
			if(LastOrder!=11)
			AnimateOrder = 11;
			EmptyClipboard();
			break;
		case 12:
			if(LastOrder!=12)
			AnimateOrder = 12;
			EmptyClipboard();
			break;
		case 13:
			if(LastOrder!=13)
			AnimateOrder = 13;
			EmptyClipboard();
			break;
		case 14:
			if(LastOrder!=14)
			AnimateOrder = 14;
			EmptyClipboard();
			break;
		case 15:
			if(LastOrder!=15)
			AnimateOrder = 15;
			EmptyClipboard();
			break;
		case 16:
			if(LastOrder!=16)
			AnimateOrder = 16;
			EmptyClipboard();
			break;
		case 17:
			if(LastOrder!=17)
			AnimateOrder = 17;
			EmptyClipboard();
			break;
		case 18:
			if(LastOrder!=18)
			AnimateOrder = 18;
			EmptyClipboard();
			break;
		case 19:
			if(LastOrder!=19)
			AnimateOrder = 19;
			EmptyClipboard();
			break;
		case 20:
			if(LastOrder!=20)
			AnimateOrder = 20;
			EmptyClipboard();
			break;
		case 21:
			if(LastOrder!=21)
			AnimateOrder = 21;
			EmptyClipboard();
			break;
		case 22:
			if(LastOrder!=22)
			AnimateOrder = 22;
			EmptyClipboard();
			break;
		case 23:
			if(LastOrder!=23)
			AnimateOrder = 23;
			EmptyClipboard();
			break;
		case 24:
			if(LastOrder!=24)
			AnimateOrder = 24;
			EmptyClipboard();
			break;
		case 25:
			if(LastOrder!=25)
			AnimateOrder = 25;
			EmptyClipboard();
			break;
		case 26:
			if(LastOrder!=26)
			AnimateOrder = 26;
			EmptyClipboard();
			break;
		case 27:
			if(LastOrder!=27)
			AnimateOrder = 27;
			EmptyClipboard();
			break;
        case 28:
        if (LastOrder != 28)
         AnimateOrder = 28;
        EmptyClipboard();
            break;
                case 29:
                    if (LastOrder != 29)
                        AnimateOrder = 29;
                    EmptyClipboard();
                    break;
                case 30:
                    if (LastOrder != 30)
                        AnimateOrder = 30;
                    EmptyClipboard();
                    break;
                case 31:
                    if (LastOrder != 31)
                        AnimateOrder = 31;
                    EmptyClipboard();
                    break;
                case 32:
                    if (LastOrder != 32)
                        AnimateOrder = 32;
                    EmptyClipboard();
                    break;
                case 33:
                    if (LastOrder != 33)
                        AnimateOrder = 33;
                    EmptyClipboard();
                    break;
                //		case 100:
                //			Debug.Log ("1000000");
                //			a.SetBool("IsSpeaking",false);
                //			EmptyClipboard();
                //			break;
                default:
			break;
		}
		}
			

		    
			
			
			
		}

	 void EmptyClipboard ()
	{
		TextEditor te2 = new TextEditor {
			content = new GUIContent ("3")
		};
		te2.SelectAll ();
		te2.Copy ();
	}
	void Paste2Clipboard (string text)
	{
		TextEditor te2 = new TextEditor {
			content = new GUIContent (text)
		};
		te2.SelectAll ();
		te2.Copy ();
	}
}
