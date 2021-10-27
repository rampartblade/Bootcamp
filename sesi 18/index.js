const kursi = {
    warna :"merah",
    bahan: "kain",
    jumlahKaki: "4",
    merk: "asdawd",
    harga: 100000
}

console.log(kursi)

//cara 1: object.property
console.log(kursi.warna)

//cara 2 :object[property]
console.log(kursi['bahan'])

kursi['bahan'] = 'titanium' // untuk mengganti isi object
console.log(kursi)

delete kursi.harga //delete object
console.log(kursi)

kursi.bahan = [           //untuk mengganti object dari string menjadi string array
    'besi',
    'titanium'
]
console.log(kursi)

function getValue(obj, key){ // cara biasa
    return obj[key]
}

var getValue = function(obj, key){ //menggunakan ekspresi
    return obj[key]
}

var getValue = (obj, key) =>{ //arrow function
    obj[key]
}

console.log(getValue(kursi,'bahan'))