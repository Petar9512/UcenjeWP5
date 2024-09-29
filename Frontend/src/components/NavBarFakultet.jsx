import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';

export default function NavBarFakultet() {
    return(
    <>
    <Navbar expand="lg" className="bg-body-tertiary">
        <Navbar.Brand href="#home">Fakultet APP</Navbar.Brand>
        <Navbar.Toggle aria-controls="basic-navbar-nav" />
        <Navbar.Collapse id="basic-navbar-nav">
          <Nav className="me-auto">
            <Nav.Link href="https://sandworm-001-site1.ftempurl.com/swagger/index.html" target="_blank">Swagger</Nav.Link>
            <NavDropdown title="Programi" id="basic-nav-dropdown">
              <NavDropdown.Item href="#action/3.1">Smjerovi</NavDropdown.Item>
              <NavDropdown.Item href="#action/3.2">
                Kolegiji
              </NavDropdown.Item>
              <NavDropdown.Item href="#action/3.3">Studenti</NavDropdown.Item>
              <NavDropdown.Item href="#action/3.4">
                Ispitni rokovi
              </NavDropdown.Item>
            </NavDropdown>
          </Nav>
        </Navbar.Collapse>
    </Navbar>
    </>
    )
}