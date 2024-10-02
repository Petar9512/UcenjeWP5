import { useEffect, useState } from "react"
import SmjerService from "../../services/SmjerService"
import { Table } from "react-bootstrap";
import moment from "moment/moment";

export default function SmjeroviPregled() {

    const[smjerovi, setSmjerovi] = useState();

async function dohvatiSmjerove(){
const odgovor = await SmjerService.get();
if (odgovor.greska) {
    alert(odgovor.poruka)
    return
}
setSmjerovi(odgovor.poruka)
}

useEffect(()=>{
dohvatiSmjerove();
},[])


function formatirajDatum(datum) {
    if (datum==null) {
        return "Nije definirano";
    }
    return moment.utc(datum).format('DD.MM.YYYY. hh:mm:ss');
}

function pristupio(p) {
    if (p==null) return 'gray'
    if (p) return 'green'
    return 'red'
}


    return(
        <>
        <Table striped bordered hover responsive>
            <thead>
                <tr>
                    <th>Naziv</th>
                    <th>Broj mjesta</th>
                    <th>Akcija</th>
                </tr>
            </thead>
            <tbody>
                {smjerovi && smjerovi.map((smjer, index)=>(
                    <tr key={index}>
                        <td>
                            {smjer.naziv}
                        </td>
                        <td className={smjer.brojStudenata==null ? 'sredina' : 'desno'}>
                            {smjer.brojStudenata==null ? 'Nije definirano' : smjer.brojStudenata}
                        </td>
                        <td>Akcija</td>
                    </tr>
                ))}
            </tbody>
        </Table>
        </>
    )
}