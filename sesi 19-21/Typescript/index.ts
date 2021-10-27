//const hello: string = "Hello World";
//console.log("Hello")

let students: (string|boolean)[][]=[
    ['Gusti', true],
    ['Ricky', true]
]

console.log(students)

//declare object secara langsung
let person: {
    name: string,
    age: number | string
}={
    name: 'Budi',
    age:25
}

class Persons{
    name: string
    age: number | string

    constructor(name: string, age: string|number){
        this.name = name
        this.age = age
    }
}

console.log(person)

//declar object lewat interface
interface StudentObject {
    name: string,
    age: number|string
}

let student:StudentObject = {
    name:'Ricky',
    age: 21
}

let employee: StudentObject[]=[
    {name:'Jimmy',
    age:20},
    student

]

console.log(student)

//object literal
//let student={}

//object instance
//class Student{
//    constructor(name, age){

//    }
//}

//optional function
function classStudent(name:string, age?:number){
    console.log("Hello my name is "+name)
}

classStudent('Jimmy')

//Declare Class
class murid implements StudentObject{
    private id :number|undefined;
    private mentors: string [] = [];

    public name: string="Budi";
    public age: number=20;
}

