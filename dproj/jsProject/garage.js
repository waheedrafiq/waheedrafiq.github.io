 "use strict";
    let vehicleList =[{regNo: "XX09WP", model: "Ford KA", repairCost:"23.89" ,typeRepair:
    "exhust" ,checkInStatus: false}];
    let index =0;
    let chkInStatus = false;
     
    function refreshVehicleList(){
        let select = document.getElementById("selectRegnumber"); 
     

        for(let i = 0; i < vehicleList.length; i++) {
        let opt = vehicleList[i];
        let el = document.createElement("option");
        el.textContent = opt.regNo;
        el.value = opt;
        if(select.appendChild !=null)
            {
                select.appendChild(el);
            }
        
       }
     } // end of populateOption

    
     function createNewCar(){
       
        // get values from input box create new vehicles
        let regNopass = document.getElementById("myRegNo").value;
        let modelPass = document.getElementById("myModel").value;
        let repairCost = document.getElementById("myrepairCost").value;
        let typeRepairpass = document.getElementById("mytypRepair").value;
        // print values to textarea 
        //document.getElementById("myCheckInArea").innerHTML =` Reg: ${regNopass} Model: ${modelPass} Price: ${repairCost}`;
        vehicleList["regNo"] = regNopass;
        vehicleList["model"] = modelPass;
        vehicleList["myrepairCost"] = repairCost;
        vehicleList["typeRepair"]= typeRepairpass;
        vehicleList["checkInStatus"]= false;
        // add those value above to array
        vehicleList.push({regNo : regNopass , model : modelPass, repaircost : repairCost,
         typeRepair: typeRepairpass, checkInStatus: false });

         refreshVehicleList();
         console.log(vehicleList.length);


     }
     

function chkOutCar(){

        // developer note revisit , you need to select from dropdown box only !!!
        let regNopass = document.getElementById("myRegNo").value;
        let modelPass = document.getElementById("myModel").value;
        let repairCost = document.getElementById("myrepairCost").value;
        let typeRepairpass = document.getElementById("mytypRepair").value;
        // print out to the text area 
        document.getElementById("myCheckOutArea").innerHTML = `Vehicle checkout: ${regNopass} ${modelPass}  ${repairCost}   ${typeRepairpass}`;
        document.getElementById("myCheckInArea").innerHTML = "";
        vehicleList["regNo"] = regNopass;
        vehicleList["model"] = modelPass;
        vehicleList["repaircost"] = repairCost;
        vehicleList["typeRepair"] = typeRepairpass;
       
       // let index;
        vehicleList.forEach(function(element){
            console.log("Your in for each..");
            if(document.getElementById("myRegNo").value === element["regNo"]){
                index =vehicleList.indexOf(element);
               
                // clear dropbox
                document.getElementById("selectRegnumber").innerHTML ="";
                //populateOption();
            }


         },this);
         // remove the match index from the list
         if (index > -1) {
             
             vehicleList.splice(index,1);
            
              console.log("reg has been removed");
              console.log("Array Index left:" + vehicleList.length);
              refreshVehicleList();
         }
        
           
    }// end of function 

   

function cal(){
        
        vehicleList.forEach(function(element){

             if(document.getElementById("selectRegnumber").value === element["regNo"]){
                index =vehicleList.indexOf(element);
               console.log("in foreach:" +element.repairCost);
             }
            
         },this);
         if (index > -1) {
          console.log(" in if index: " + vehicleList[index].repairCost);
        let num1 = parseInt(vehicleList[index].repairCost);
         // print out to the text area 
        let totalPrice = num1 + 17.5;
        document.getElementById("myCheckInArea").innerHTML = `Invoice For:  Vehicle Reg:${vehicleList.regNopass} ${vehicleList.modelPass}  Total: ${totalPrice}`;
       
        }

}// calulate method 

     // use for check in 
       function selectRegNoFromList(){

             vehicleList.forEach(function(element){
                 console.log("trigger by SelectREG.");
                 console.log(element.regNo);
               
                 document.getElementById("myCheckInArea").innerHTML = `Vehicle checkIn: ${element.regNo} : ${element.model} : ${element.repaircost} :  ${element.typeRepairpass}`;

              },this);
             
       }
    
      function adminConsole(choice){
           
        choice = document.getElementById("AdminCommand").value;
        let sQuery = choice.split(" ");
        console.log("in console func: " + choice);
        switch(sQuery[0].toLowerCase()){

            case "create":
                   
                    document.getElementById("myConsoleOutput").innerHTML = ` ${sQuery}`;
                    console.log(sQuery);
                    let tmpCar = {}
                    tmpCar["regNo"] = sQuery[1];
                    tmpCar["model"] = sQuery[2];
                    tmpCar["repaircost"] = sQuery[3];
                    tmpCar["typeRepair"] = sQuery[4];
                    tmpCar["checkInStatus"] = false;
                    vehicleList.push(tmpCar);
                     
                    console.log("your length is:" + vehicleList.length);
                    console.log(vehicleList);

                break;
            case "checkin":
                console.log("checkin: " + sQuery[1]); 
                //let searchValue = sQuery[1];
                 index=0;
                vehicleList.forEach(function(element){
                        if(vehicleList[index].regNo === sQuery[1]){

                            vehicleList[index].checkInStatus = true;  
                        
                            document.getElementById("myConsoleOutput").innerHTML =`Vehicle has been checked In: ${vehicleList[index].regNo}`;
                        }
                        index++;

                     },this);
                     
                     console.log(vehicleList); 
                 break;
            case "checkout":

            index=0;
            vehicleList.forEach(function(element){
                    if(vehicleList[index].regNo === sQuery[1]){

                        document.getElementById("myConsoleOutput").innerHTML =`Vehicle has been checked out: ${vehicleList[index].regNo}`;
                         vehicleList.splice(index,1); // remove vehicle  
                    
                        
                    }
                    index++;

                 },this);
                 
                 console.log(vehicleList);            
            break;

            default: 
            document.getElementById("myConsoleOutput").innerHTML= "Enter a default command ";

        }// end of the menu switch statement 


        
    } // end of console 
     
   
    