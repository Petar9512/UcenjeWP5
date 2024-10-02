import { HttpService } from "./HttpService";

async function get() {
    return await HttpService.get('/Smjer')
    .then((odgovor)=>{
        console.table(odgovor.data)
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


export default {
    get,
    brisanje
}