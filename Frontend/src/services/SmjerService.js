import { HttpService } from "./HttpService";

async function get() {
    return await HttpService.get('/Smjer')
    .then((odgovor)=>{
        //console.table(odgovor.data)
        return {greska: false, poruka: odgovor.data}
    })
    .catch((e)=>{
        console.log(e)
        return {greska: true, poruka: 'Problem kod dohvaćanja smjerova'}
    })
}

async function brisanje(sifra) {
    return await HttpService.delete('/Smjer/' + sifra)
    .then(()=>{
        return {greska: false, poruka: 'Obrisano'}
    })
    .catch(()=>{
        return {greska: true, poruka: 'Problem kod brisanja smjera'}
    })
}

async function dodaj(smjer) {
    return await HttpService.post('/Smjer', smjer)
    .then(()=>{
        return {greska: false, poruka: "Smjer dodan"}
    })
    .catch(()=>{
        return {greska: true, poruka: "Problem kod dodavanja smjera"}
    })
}


export default {
    get,
    brisanje,
    dodaj
}