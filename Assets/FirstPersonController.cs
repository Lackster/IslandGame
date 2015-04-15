using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FirstPersonController : MonoBehaviour {

	IDictionary[] inventoryPlayer;
	Ray cameraRay;
	GameObject mainCharacter;
	int objectID;
	int inventorySlot;
	bool inventoryChange;


	void Start () {
		inventoryPlayer = new IDictionary[10];
		cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		mainCharacter = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame




	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "AcceptedObject") 
		{
			bool check;
			switch(collision.gameObject.tag)
			{
			case ("Arrow"):
			while (check)
				{
					if (inventoryPlayer[inventorySlot].Keys == "Arrow")
					{
						inventoryPlayer[inventorySlot].Add("Arrow",value:+1);

					}
					else if(inventoryPlayer.Length == inventorySlot)
					{
						//Cannot pick up item text

					}
					else
					{
						inventorySlot = inventorySlot + 1;
					}
				}
				break;

			case("Sword"):
			
				while (check)
				{
					if(inventoryPlayer[inventorySlot].Keys == "Sword")
					{
						inventoryPlayer[inventorySlot].Add("Sword", value:+1);
						break;
					}else if(inventoryPlayer.Length == inventorySlot)
					{
					//ExitScriptCannotPickUp!!!!
					}
					else
					{
						inventorySlot = inventorySlot + 1;
					}

				}
				break;
			case("Wood"):

			while(check)
				{
					if (inventoryPlayer[inventorySlot].Keys == "Wood")
					{
						inventoryPlayer[inventorySlot].Add ("Wood",value:+1);
						break;
					}else if(inventoryPlayer.Length == inventorySlot)
					{
						//ExitScriptCannotPickUp!!!!
					}
					else
					{
						inventorySlot = inventorySlot + 1;
					}
				}
				break;

			case("Boat"):
				while(check)
				{
					if(inventoryPlayer[inventorySlot].Keys == "Wood")
					{
						inventoryPlayer[inventorySlot].Add("Boat",value:+1);
						break;
					}else if (inventoryPlayer.Length == inventorySlot)
					{
						//ExitScriptCannotPickUp!!!!
					}
					else
					{
						inventorySlot = inventorySlot + 1;
					}
				}
				break;

			case("tree"):
				while(check)
				{
					if(inventoryPlayer[inventorySlot].Keys == "tree")
					{
						inventoryPlayer[inventorySlot].Add("tree",value:+1;
						break;
					}else if (inventoryPlayer.Length == inventorySlot)
					{
						//ExitScriptCannotPickUp!!!!
					}
					else
					{
						inventorySlot = inventorySlot + 1;
					}	

				}
				break;
		}
	}
}



	void Update () 
	{
		Collision hit;
		if (Physics.Raycast(cameraRay,out hit))
		{
			GameObject currView = hit.gameObject;

			if (currView.tag == "AcceptedObject")
			{
				GUI.enabled = true;
				Rect rect = new Rect(0,0,5,5);

				//Made to use different behieviors for different objects.
				switch(currView.name)
				{

				case("something"):
					GUI.TextArea(rect,currView.name);
					objectID = 1;
					break;

				case("something2"):

					GUI.TextArea(rect,currView.name);
					objectID = 2;
					break;
				case("something3"):
					GUI.TextArea(rect,currView.name);
					objectID = 3;
				}

			}else
			{
				GUI.enabled = false;
			}

		}

		if (Input.GetMouseButton(1))
		{
			if (objectID != null)
			{
				bool inProgress = true;
			switch(objectID)
			{
			case(0)://ObjectDesc
				Scrollbar bar = new Scrollbar();
					int objectIDClone = objectID;
					int timeRequired = 1;
					int timeRecorded = 0;
					int state;
				while (inProgress)
					{
						if (objectID != objectIDClone)
						{
							break;
						}
						//Progress Bar.
						timeRecorded += Time.deltaTime;
						if (timeRecorded == timeRequired)
						{
							timeRecorded = 0;
							// For state movement: state = state++;
							//bar.size for scrollbar.
							//increase the size of bar, or other functions.

						}
						//if State == 5 inprogress{break;}




					}

				break;

			case(1)://ObjectDesc

				break;

			case(2)://ObjectDesc
				break;

			case(3)://ObjectDesc
				break;

			case(4)://ObjectDesc
				break;

			case(5)://ObjectDesc
				break;

			case(6)://ObjectDesc
				break;

			case(7)://ObjectDesc
				break;

			case(8)://ObjectDesc
				break;





			}


			}
		}
		  


	}
}
