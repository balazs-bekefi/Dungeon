/// <reference types="Cypress"/>

describe("webpage test", ()=>{
    it("weboldal meglátogatása és regisztráció", ()=>{
        cy.visit("https://adungeongame.000webhostapp.com/register.php");
        var username=[];
        var password=[];

        cy.randomName(':nth-child(1) > .form-control', username);
        cy.log('véletlenszerű felhasználónév létrehozása')
        cy.randomPassword(':nth-child(2) > .form-control', ':nth-child(3) > .form-control', password);
        cy.log('véletlenszerű jelszó létrehozása')
        cy.get('.btn-primary').click();

        cy.writeFile('jsons/username.json', username);
        cy.writeFile('jsons/password.json', password);
        cy.log('teszt felhasználónév és jelszó elmentése json file-ba')


    })
    
    it("bejelentkezés és elfelejtett jelszó", ()=>{
        cy.visit("https://adungeongame.000webhostapp.com/index.php");
        cy.readFile("jsons/username.json").then(r=>{
            r.forEach(element => {
                cy.get(':nth-child(1) > .row > .col-lg-5 > .form-control').clear().type(element);
            });
        })
        cy.log('felhasználónév kitöltése fájlból');
        cy.readFile('jsons/password.json').then(f=>{
            f.forEach(element=> {
                cy.get(':nth-child(2) > .row > .col-lg-5 > .form-control').clear().type(element);
            })
        })
        cy.log('jelszó kitöltése fájlból');
        cy.get('.btn').click();


        cy.get('.btn-warning').click();
        var password=[];
        cy.randomPassword(':nth-child(1) > .form-control', ':nth-child(2) > .form-control', password);
        cy.writeFile('jsons/password.json', password);
        cy.get('.btn-primary').click();

        cy.log('véletlenszerű jelszó generálása és elmentése');
    })

    it("bejelentkezés és kijelentketés", ()=>{
        cy.visit("https://adungeongame.000webhostapp.com/index.php");
        cy.readFile("jsons/username.json").then(r=>{
            r.forEach(element => {
                cy.get(':nth-child(1) > .row > .col-lg-5 > .form-control').clear().type(element);
            });
        })
        cy.log('felhasználónév kitöltése fájlból');

        cy.readFile('jsons/password.json').then(f=>{
            f.forEach(element=> {
                cy.get(':nth-child(2) > .row > .col-lg-5 > .form-control').clear().type(element);
            })
        })
        cy.log('jelszó kitöltése fájlból');
        cy.get('.btn').click();
        cy.get('.btn-danger').click();
    })
})

