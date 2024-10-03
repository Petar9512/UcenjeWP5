import 'bootstrap/dist/css/bootstrap.min.css'
import Container from 'react-bootstrap/Container';
import './App.css'
import NavBarFakultet from './components/NavBarFakultet';
import { Route, Routes } from 'react-router-dom';
import { RouteNames } from './constants';
import Pocetna from './pages/Pocetna';
import SmjeroviPregled from './pages/smjerovi/SmjeroviPregled';
import SmjeroviDodaj from './pages/smjerovi/SmjeroviDodaj';

function App() {
  

  return (
    <>
    <Container>
      <NavBarFakultet/>
      <Routes>
        <Route path={RouteNames.HOME} element={<Pocetna />} />
        <Route path={RouteNames.SMJER_PREGLED} element={<SmjeroviPregled />} />
        <Route path={RouteNames.SMJER_NOVI} element={<SmjeroviDodaj />} />


      </Routes>
      <hr />
      &copy; Fakultet
    </Container>
    </>
  )
}

export default App
