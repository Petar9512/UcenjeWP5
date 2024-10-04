import SmjerService from "../../services/SmjerService"
import { Button, Col, Form, Row } from "react-bootstrap";
import moment from "moment/moment";
import { Link, useNavigate } from "react-router-dom";
import { RouteNames } from "../../constants";

export default function SmjeroviDodaj() {

    const navigate = useNavigate()

    async function dodaj(smjer) {
        console.log(JSON.stringify(smjer))
        const odgovor = await SmjerService.dodaj(smjer)
        if (odgovor.greska) {
            alert (odgovor.poruka)
            return;
        }
        navigate(RouteNames.SMJER_PREGLED)
    }

    function obradiSubmit(e) {
        e.preventDefault();
        let podatci = new FormData(e.target)

        dodaj ({
            naziv: podatci.get('naziv'),
            brojStudenata: parseInt(podatci.get('brojStudenata'))
        })
    }

    return(
        <>
        <Form onSubmit={obradiSubmit}>

            <Form.Group controlId="naziv">
                <Form.Label>Naziv</Form.Label>
                <Form.Control type="text" name="naziv" required />
            </Form.Group>

            <Form.Group controlId="brojStudenata">
                <Form.Label>Broj mjesta</Form.Label>
                <Form.Control type="number" min={20} max={80} name="brojStudenata" required />
            </Form.Group>

        <Row className="random">
            <Col xs={6} sm={12} md={3} lg={6} xl={6} xxl={6}>
            <Link to={RouteNames.SMJER_PREGLED} className="btn btn-danger siroko">Odustani</Link>
            </Col>
            <Col xs={6} sm={12} md={9} lg={6} xl={6} xxl={6}>
            <Button type="submit" variant="success" className="siroko">Dodaj smjer</Button>
            </Col>
        </Row>
        </Form>
        </>
    )
}