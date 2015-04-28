using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FirstPersonController : MonoBehaviour {

	Rigidbody playerRigidbody;

	IDictionary[] inventoryPlayer;
	Ray cameraRay;
	GameObject mainCharacter;
	int objectID;
	int inventorySlot;
	bool inventoryChange;
	bool invOn;
	GameObject selectedObject;

	Vector3 objectHitLocation;

	// Actual Objects Under Here. To Assign, make sure they are public!:
	public GameObject Wood;
	public GameObject Fish; // I think we are getting Feesh. Lol.


	void Start () {
		inventoryPlayer = new IDictionary[10];
		cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
		mainCharacter = GameObject.FindGameObjectWithTag ("Player");
		playerRigidbody = new Rigidbody(GetComponent <Rigidbody>());

	}
	
	// Update is called once per frame


	void Drop()
	{
		Quaternion filler = new Quaternion (1, 1, 1, 1);
		GameObject.Instantiate (Wood, objectHitLocation,filler);
		objectHitLocation = new Vector3(0,0,0);

	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "AcceptedObject") 
		{
			bool check = true;
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
						inventoryPlayer[inventorySlot].Add("tree",value:+1);
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
		ContactPoint point;

		if (Input.GetKey (KeyCode.W)) 
		{
			playerRigidbody.AddForce(Vector3.forward * 5, ForceMode.Acceleration); // Difficult to limit this.
		}

		if (Input.GetKey(KeyCode.A)) 
		{
			playerRigidbody.AddForce (Vector3.left * 5, ForceMode.Acceleration);
		}

		if (Input.GetKey (KeyCode.D)) 
		{
			playerRigidbody.AddForce (Vector3.right * 5, ForceMode.Acceleration);
		}

		if (Input.GetKey (KeyCode.S)) 
		{
			playerRigidbody.AddForce (Vector3.back * 5, ForceMode.Acceleration);
		}

		if (Input.GetKeyDown (KeyCode.I)) 
		{
			if (invOn)
			{
				for (int i = 0; i< inventoryPlayer.Length; i ++)
				{
					int guiSlot =1;
				while(true)
					{
						guiSlot = guiSlot+1;
						GUIContent generatedContent = new GUIContent(inventoryPlayer[guiSlot]);// LOTS OF WORK NEEDED HERE! How do I get the object attatched to the . . You know?
						

					}
				}
			}
			else
			{

			}


		}


		/*Transform playerRot = GetComponent<Transform>();
		Vector3 mousePosition = Input.mousePosition;
		if (Input.mousePosition = ! mousePosition) 
		{
			playerRot.localRotation = new Quaternion(playerRot.rotation.x + mousePosition.position.x,playerRot.localRotation.y + mousePosition.position.y);
			mousePosition.position = new Vector3(0,0,0);
		}
		*///HEY YO! Me! I need to make sure that this works correctly, so the character can actually look around. k?? k..


		Collision hit;
		if (Physics.Raycast(cameraRay,out hit))//God knows why this is overloading match. It should be fine, but it likes breaking on me. Mess around with it a li'l.
		{
			GameObject currView = hit.gameObject;

			if (currView.tag == "AcceptedObject")
			{
				GUI.enabled = true;
				Rect rect = new Rect(0,0,5,5);
				string fillerz = currView.name;
				//Made to use different behieviors for different objects.
				switch(fillerz)
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
						if (Input.GetMouseButtonUp(1))
						{
							inProgress = false; // Oops. Looks like I didn't need a bool. Might as well use it anyways.
							break;
						}
						if (objectID != objectIDClone)
						{
							break;
						}
						if (selectedObject.name != "Axe")
						{
							break;
						}
						//Progress Bar.
						timeRecorded += Time.deltaTime;
						if (timeRecorded == timeRequired)
						{
							timeRecorded = 0;
							objectHitLocation = new Vector3(hit.transform.position.x, hit.transform.position.y,hit.transform.position.z);
							Destroy(hit.gameObject);
							Drop();
							break;


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
