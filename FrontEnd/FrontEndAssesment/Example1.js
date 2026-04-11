"use strict";
// function myFunction(){
//     if(true){
//         var mynum = 25;
//     }
//     console.log(mynum);
// }
// console.log("---function call---");
// myFunction();
// function myFunction(){
//     if(true){
//         let mynum = 25;
//         console.log(mynum);
//     }
//     let mynum = 50;
//     console.log(mynum);
// }
// console.log("---function call---");
// myFunction();
// function sum(num1:number,num2:number){
//     return num1+num2;
// }
// let result : number = sum(45,15);
// console.log(result);
// function concat(val1:string,val2:string){
//     return val1+val2;
// }
// let result : string = concat('Amruth',' Varsha');
// console.log(result);
// function printIdCard(id:number|string){
//     console.log('Student ID: ',id);
// }
// printIdCard(13);
// printIdCard('LPU-121');
// class Employee {
//     id;
//     name;
//     salary;
//     constructor(id, name, salary) {
//         this.id = id;
//         this.name = name;
//         this.salary = salary;
//     }
//     display() {
//         console.log('Employee ID: ', this.id);
//         console.log('Employee Name: ', this.name);
//         console.log('Employee Salary: ', this.salary);
//     }
// }
// const obj1 = new Employee(13, 'sam', 95000);
// obj1.display();
// const obj2 = new Employee(14, 'Nithin', 89000);
// obj2.display();
// class Developer extends Employee {
//     domain;
//     constructor(id, name, salary, domain) {
//         super(id, name, salary);
//         this.domain = domain;
//     }
//     display() {
//         super.display();
//         console.log('Employee Domain: ', this.domain);
//     }
// }
// const obj3 = new Developer(13, 'sam', 95000, 'DotNet');
// obj3.display();


function Add(){
    var num1 = parseFloat(document.getElementById('num1').value);
    var num2 = parseFloat(document.getElementById('num2').value);

    var result = parseFloat(num1+num2);
    document.getElementById('result').innerHTML = num1+' + '+num2+' = '+result;
}

function Subtract(){
    var num1 = parseFloat(document.getElementById('num1').value);
    var num2 = parseFloat(document.getElementById('num2').value);

    var result = parseFloat(num1-num2);
    document.getElementById('result').innerHTML = num1+' - '+num2+' = '+result;

}

function Multiply(){
    var num1 = parseFloat(document.getElementById('num1').value);
    var num2 = parseFloat(document.getElementById('num2').value);

    var result = parseFloat(num1*num2);
    document.getElementById('result').innerHTML = num1+' * '+num2+' = '+result;

}

function Divide(){
    var num1 = parseFloat(document.getElementById('num1').value);
    var num2 = parseFloat(document.getElementById('num2').value);
    var result;
    if(num2==0){
        result = "denominator cannot be 0";
    }
    else{
        result = parseFloat(num1/num2);
    }
    document.getElementById('result').innerHTML = num1+' ÷ '+num2+' = '+result.toFixed(2);

}