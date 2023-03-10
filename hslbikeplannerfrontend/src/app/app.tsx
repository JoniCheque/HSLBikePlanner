// eslint-disable-next-line @typescript-eslint/no-unused-vars
import React from 'react';
// import styles from './app.module.css';
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap/dist/js/bootstrap.bundle.min";
import 'maplibre-gl/dist/maplibre-gl.css';

import Container from 'react-bootstrap/Container';
import Col from 'react-bootstrap/Col';

import NxWelcome from './nx-welcome';
import Mapcomponent from './mapcomponent/mapcomponent';

export function App() {
  return (
    <>
      <Container fluid>
          <NxWelcome title="to HSL Bike Route Planner" />
          <Col>
            <Mapcomponent></Mapcomponent>
          </Col>
      </Container>
      <div />
    </>
  );
}

export default App;
