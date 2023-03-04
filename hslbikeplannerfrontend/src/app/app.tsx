// eslint-disable-next-line @typescript-eslint/no-unused-vars
import React from 'react';
// import styles from './app.module.css';
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap/dist/js/bootstrap.bundle.min";

import Container from 'react-bootstrap/Container';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';

import NxWelcome from './nx-welcome';
import Routeplanning from './routeplanning/routeplanning';
import Map from './map/map';
import Favourite from './favourite/favourite';

export function App() {
  return (
    <>
      <Container fluid>
        <NxWelcome title="HSL Bike Route Planner" />
        <Routeplanning />
        <Row>
          <Col>
            <Favourite></Favourite>
          </Col>
          <Col>
            <Map></Map>
          </Col>
        </Row>
      </Container>
      <div />
    </>
  );
}

export default App;
