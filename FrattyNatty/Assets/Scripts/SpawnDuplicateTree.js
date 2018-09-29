#pragma strict

var X_COORD = 0.0;
var Y_COORD = 0.0;
var Z_COORD = 2.7;

var prefab : GameObject;

var NUM_OBJECTS = 100;

// function left(idx) {
//   Instantiate(prefab, new Vector3(X_COORD + (idx+1.0)*Random.Range(50.0, 70.0), Y_COORD, Z_COORD), Quaternion.AngleAxis(30, Vector3.left));
// }
// function right(idx){
//   Instantiate(prefab, new Vector3(X_COORD + (idx+1)*Random.Range(50.0, 70.0), Y_COORD, 0.0), Quaternion.AngleAxis(30, Vector3.right));
// }
 
function Awake()
{
  for (var idx = NUM_OBJECTS - 1; idx >= 0; idx--) {
    if (Random.Range(0.0, 2.0) > 1.0) {
      Instantiate(prefab, new Vector3(X_COORD + (idx+1.0)*Random.Range(70.0, 120.0), Y_COORD+Random.Range(2.0,4.0), Z_COORD), Quaternion.AngleAxis(90, Vector3.left));
    } else {
      Instantiate(prefab, new Vector3(X_COORD + (idx+1)*Random.Range(50.0, 90.0), Y_COORD+Random.Range(3.0,4.0), -1.0), Quaternion.AngleAxis(90, Vector3.right));
    }
  }
   // var go1 = Instantiate(prefab, new Vector3(Z_COORD + 10, X_COORD, Y_COORD), Quaternion.identity);
   // var go2 = Instantiate(prefab, new Vector3(Z_COORD + 40, X_COORD, Y_COORD), Quaternion.identity);
   // var go3 = Instantiate(prefab, new Vector3(Z_COORD + 140, X_COORD, Y_COORD + 3), Quaternion.identity);
   // var go4 = Instantiate(prefab, new Vector3(Z_COORD + 180, X_COORD, Y_COORD), Quaternion.identity);
   // var go5 = Instantiate(prefab, new Vector3(Z_COORD + 180, X_COORD, Y_COORD+1), Quaternion.identity);  
   // var go6 = Instantiate(prefab, new Vector3(Z_COORD + 200, X_COORD, Y_COORD + 3), Quaternion.identity);
   // var go7 = Instantiate(prefab, new Vector3(Z_COORD + 500, X_COORD + 10, Y_COORD), Quaternion.identity);

}