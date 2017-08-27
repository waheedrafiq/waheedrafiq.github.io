//hangman game 

let emptyword = [];
let correctsword = [];
let  wordList = [];
let lifescore =9; 
let computerword;
let userguess;





function readFilefromList(){
    
   var requestURL ='https://raw.githubusercontent.com/dwyl/english-words/master/words_alpha.txt';
   var request = new XMLHttpRequest();
   request.open("GET",requestURL);
   request.responseType ='text';
   document.write(requestURL);
   request.send();

   request.onload = function() {
      var requestData = request.responseText;
      wordList = requestData.split("\n");

    
      console.log(wordList.length);
      computerword = generateRandomWord();
      console.log("from reading " + computerword);
   }
   

  } // end of read from file 
  
  // step one read from file load into wordList array
 readFilefromList();


// step machine select the word to play with 

    function generateRandomWord() {

        var rnd = Math.floor(Math.random() * wordList.length);

        console.log("random word is: " + wordList[rnd]);

        computerword = wordList[rnd];
        fillInBlankSpace();
        return computerword
       
    }

    function  userInput(){
        
        let usrinput = document.getElementById("userInput").value;
        
        return usrinput;
  
     }
      
     function printCorrectGuess(){

        for(let i=0; i < correctsword.length; i++)
        {
      
            
            document.getElementById("correctguess").innerHTML +=correctsword[i];

        }
     }

     function fillInBlankSpace(){
           // save it in the array
           for(let i=1; i < computerword.length;i++) {
               emptyword.push("__, ");
           }
         // print off the array with underscore 
           for(let i=1; i< emptyword.length; i++)
            {
               
               document.getElementById("mySystemConsole").innerHTML += emptyword[i];
            }

     }
   
     function fillinBlankCharacterSpace(){
             let guessChar = document.getElementById("userInput").value;
             console.log("user character is:" + guessChar);

             
               let index = computerword.indexOf(guessChar);
               console.log("printing index of:" +index);
               emptyword[index,guessChar];
               emptyword.splice(index,1,guessChar);
               console.log("repace :"+ emptyword[index]);
               document.getElementById("mySystemConsole").innerHTML ="";
                console.log(emptyword);
               //document.getElementById("mySystemConsole").innerHTML = emptyword;
                for(let i = 1; i < computerword.length; i++)
                {
                    document.getElementById("mySystemConsole").innerHTML = emptyword;
                   
                        
                }         
            
     }//; end of fill 


    







 function drawingString8(){
    let string8 = "______________";
    document.getElementById("myDrawHangman").innerHTML= string8 ;
 }

function drawingString7(){
    let string7 = "______________" + "\n" +
                   "| |";


    document.getElementById("myDrawHangman").innerHTML= string7 ;

}

function drawingString6(){
    let string6 = "______________" + "\n" +
                   "| |" + "\n" +
                   "| O";
    document.getElementById("myDrawHangman").innerHTML = " "; 
    document.getElementById("myDrawHangman").innerHTML= string6 ;
    console.log(string6);
}

function drawingString5(){
    let string5 = "______________" + "\n" +
                   "| |" +"\n"+
                   "| O" +"\n"+
                   "|/|\ ";

    document.getElementById("myDrawHangman").innerHTML= string5 ;
}

function drawingString4(){
    let string4 = "______________" + "\n" +
                   "| |"+"\n"+
                   "| O"+"\n"+
                   "|/|/ "+"\n"+
                   "|/ / "+"\n" ;


    document.getElementById("myDrawHangman").innerHTML= string4 ;
}


function drawingString3(){
    let string3 = "______________" + "\n" +
                   "| |"+"\n"+
                   "| O"+"\n"+
                   "|/|/ "+"\n"+
                   "|/ / "+"\n"+
                   "|" ;
                   

    document.getElementById("myDrawHangman").innerHTML= string3 ;
}

function drawingString2(){
    let string2 = "______________" + "\n" +
                   "| |"+"\n"+
                   "| O"+"\n"+
                   "|/|/ "+"\n"+
                   "|/ / "+"\n"+
                   "|" +"\n"+
                   "|______" +"\n";
                   

    document.getElementById("myDrawHangman").innerHTML= string2 ;
}

function drawingString1(){
    let string1 = "______________" + "\n" +
                   "| |"+"\n"+
                   "| O"+"\n"+
                   "|/|/ "+"\n"+
                   "|/ / "+"\n"+
                   "|" +"\n"+
                   "|______"+"\n"+
                   "|     |"+"\n";
                   

    document.getElementById("myDrawHangman").innerHTML= string1 ;
}
  

function drawingString0(){
    let string0 = "______________" + "\n" +
                   "| |"+"\n"+
                   "| O"+"\n"+
                   "|/|/ "+"\n"+
                   "|/ / "+"\n"+
                   "|" +"\n"+
                   "|______"+"\n"+
                   "|     |"+"\n"+
                   "Life is indeed curel. You are now offically dead." +"\n"+ " CRUCIFIXION Killed you";
                   

    document.getElementById("myDrawHangman").innerHTML= string0 ;
}

 // check if the user has enter the correct character 
   function checkGuessCharacter(){
         // for debug purpose only 
         console.log("printing from guess:" + computerword);
         console.log("total length: "+ computerword.length );
          userguess = userInput();
          console.log("user guess is" + userguess);
        // algorithm check for match
         

        // action begins 
        do{
            var tmpCP = computerword.match(userguess);
            
           
           if(tmpCP == null)
            {
                // user lost score
                lifescore--;
              
             
                console.log("lifescore is:" + lifescore);
                document.getElementById("feedback").innerHTML=`Only ${lifescore} left wrong answer ${tmpCP}`;
               
              
              
             break;
            }
            else if(tmpCP !=null)
                {
                    // print correct character
                    document.getElementById("correctguess").innerHTML="";
                     //correctsword = tmpCP;
                     correctsword.push(tmpCP);
                   // document.getElementById("correctguess").innerHTML += tmpCP;
                    printCorrectGuess();
                    fillinBlankCharacterSpace();
                    break;
                }


        }while(lifescore !== 0);



 switch(lifescore){

           case 8:
        
           drawingString8();

            break;

            case 7:
            drawingString7();
            break;

            case 6:
            drawingString6();
            break;

            case 5:
            drawingString5();
            break;

            case 4:
            drawingString4();
            break;

            case 3:
            drawingString3();
            break;

            case 2:
            drawingString2();
            break;

            case 1:
            drawingString1();
            break;
            
           case 0:
           drawingString0();
           break;

        }// end of switch statment 


   }// end of the method.

  
   
