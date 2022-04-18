Cypress.Commands.add('randomName',(textZone, array)=>{ 


    var text = "RandomUsername"; //alapnév
    var possible = "0123456789"; //random generálható számok 
    for (var i = 0; i < 5; i++){
        text += possible.charAt(Math.floor(Math.random() * possible.length))  //névgenerálás (pl. RandomUsername1234)
    };
    cy.get(textZone).clear().type(text);  // Új név beírása
    array.push(text);
})

Cypress.Commands.add('randomPassword',(textZone, textZone2, array)=>{ 


    var text = "RandomPassword"; //alapjelszó
    var possible = "0123456789"; //random generálható számok 
    for (var i = 0; i < 5; i++){
        text += possible.charAt(Math.floor(Math.random() * possible.length))  //jelszógenerálás (pl. RandomPassword1234)
    };
    text+="A!"; //nagybetű és szimbólum hozzáadása a jelszóhoz
    cy.get(textZone).clear().type(text);  // Új jelszó beírása
    cy.get(textZone2).clear().type(text);  // Új jelszó beírása
    array.push(text);
})
