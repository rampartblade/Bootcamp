//getbyid
let pageTitleElement = document.getElementById('page-title')
console.log(pageTitleElement)

//getbyclassname
let pageBoxElement = document.getElementsByClassName('page-box')
console.log(pageBoxElement)

for(let i = 0; i<pageBoxElement.length; i++){
    const pageBox = pageBoxElement[i]

    console.log(pageBox.innerHTML)
}

$(document).ready(function(){
    console.log($('#page-title'))
    console.log($('.page-box'))
    $('#page-title').click(function() {
        alert("page title")
    })
})

$('#submitButton').click(function (e) {
    e.preventDefault() // untuk mencegah page reload
    let username = $('#username').val()
    alert("hallo " + username)
})

$('.page-box:first').addClass('btn-danger')