//const hello: string = "Hello World";
//console.log("Hello")
var students = [
    ['Gusti', true],
    ['Ricky', true]
];
console.log(students);
//declare object secara langsung
var person = {
    name: 'Budi',
    age: 25
};
console.log(person);
var student = {
    name: 'Ricky',
    age: 21
};
console.log(student);
//object literal
//let student={}
//object instance
//class Student{
//    constructor(name, age){
//    }
//}
//optional function
function classStudent(name, age) {
    console.log("Hello my name is " + name);
}
classStudent('Jimmy');
var murid = /** @class */ (function () {
    function murid() {
        this.mentors = [];
        this.name = "Budi";
        this.age = 20;
    }
    return murid;
}());
console.log(murid);
