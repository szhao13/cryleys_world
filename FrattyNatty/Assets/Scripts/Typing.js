// var letterPause : float = 0.2;
// var word : String;
 
// function Start () {
//   word= guiText.text;
//   guiText.text = "";
//   TypeText(word);
// }
 
 
// function TypeText () {
 
//   var bold : boolean = false; //toggles the style for bold;
//   var red : boolean = false; // toggle red
//   var italics : boolean = false;
 
//   var ignore : boolean = false; //for ignoring special characters that toggle styles
 
//   for (var nextletter in word.ToCharArray()) {
 
//     switch (nextletter) {
 
//       case "@":
//         ignore = true; //make sure this character isn't printed by ignoring it
//         red = !red; //toggle red styling
//       break;
//       case "¬":
//         ignore = true; //make sure this character isn't printed by ignoring it
//         bold = !bold; //toggle bold styling
//       break;
//       case "/":
//         ignore = true; //make sure this character isn't printed by ignoring it
//         italics = !italics; //toggle italic styling
//       break;
//     }
 
 
//     var letter : String = nextletter.ToString();
 
//     if (!ignore) {
 
//       if (bold){
 
//         letter = "<b>"+letter+"</b>";
 
//       }
//       if (italics){
 
//         letter = "<i>"+letter+"</i>";
 
//       }
//       if (red){
 
//         letter = "<color=#ff0000>"+letter+"</color>";
 
//       }
 
//       guiText.text += letter; 
 
//     }
//                 //make sure the next character isn't ignored
//                 ignore = false;
//     yield WaitForSeconds (letterPause);
//   }
// }