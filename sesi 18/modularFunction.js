function removeSpaces (text){
    return text.replace(/ /g, '')
}

function reverseText (text){
   let temp = text.split('');
   return temp.reverse().join('');
}

function updateVowels (text){
    //a jadi b, i jadi j, u jadi v, e jadi f, o jadi p
    let temp = text.split('');
    for(count = 0; count < text.length; count++)
    {
        if(temp[count] == 'a')
        {
            temp[count] = 'b'
        }
        else if(text[count] == 'i'){
            temp[count] = 'j'
        }        
        else if(text[count] == 'u'){
            temp[count] = 'v'
        }
        else if(text[count] == 'e'){
            temp[count] = 'f'
        }
        else if(text[count] == 'o'){
            temp[count] = 'p'
        }        
    }
    return temp.join('');
}

let prompt = require('prompt-sync')();


let password = prompt('Masukkan password : ')
let noSpaces = removeSpaces(password)
let reversed = reverseText(noSpaces)
let encryptedPassword = updateVowels(reversed)

console.log(noSpaces)
console.log(reversed)
console.log(encryptedPassword)