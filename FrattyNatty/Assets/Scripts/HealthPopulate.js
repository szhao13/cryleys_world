#pragma strict

var X_COORD = 0.0;
var Y_COORD = 0.0;
var Z_COORD = 2.7;

var prefab : GameObject;

var NUM_OBJECTS = 100;
 
function Awake()
{
  for (var i = NUM_OBJECTS - 1; i >= 0; i--) {
    Instantiate(prefab, new Vector3(X_COORD + (i+1)*Random.Range(40.0,200.0), Y_COORD+Random.Range(2.0, 5.0), Z_COORD-1.5), Quaternion.AngleAxis(180, Vector3.up) * Quaternion.AngleAxis(Random.Range(0, 120), Vector3.right));
  }

}