// eslint-disable-next-line @typescript-eslint/no-unused-vars
import React from 'react';
// import styles from './app.module.css';
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap/dist/js/bootstrap.bundle.min";
import 'maplibre-gl/dist/maplibre-gl.css';

import Container from 'react-bootstrap/Container';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import Stack from 'react-bootstrap/Stack';

import NxWelcome from './nx-welcome';
import Routeplanning from './routeplanning/routeplanning';
import Mapcomponent from './mapcomponent/mapcomponent';
import Favourite from './favourite/favourite';

export function App() {
  return (
    <>
      <Container fluid={"lg"}>
          <NxWelcome title="HSL Bike Route Planner" />
          <Routeplanning />
          <Row className='mb-5'>
            <Col lg={8} className='mb-5'>
              <Mapcomponent></Mapcomponent>
            </Col>
            <Col lg={4}>
              <Favourite></Favourite>
            </Col>
          </Row>
      </Container>
      <div />
    </>
  );
}

export default App;
