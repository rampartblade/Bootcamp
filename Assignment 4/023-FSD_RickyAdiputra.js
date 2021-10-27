let prompt = require('prompt-sync')();

let a = Number(prompt('Angka a :'));
let b = Number(prompt('Angka b :'));

console.log("Sum :",a+b)
console.log("Difference : " ,a-b)
console.log("Product :",a*b)
console.log("Quotient :",a/b)
console.log("Remainder :",a%b)
console.log("Value of num1 after increment :", ++a)
console.log("Value of num2 after decrement :", --b)

