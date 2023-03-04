import React from 'react';
import styles from './routeplanning.module.css';

import Form from 'react-bootstrap/Form';
import InputGroup from 'react-bootstrap/InputGroup';
import Button from 'react-bootstrap/Button';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';

/* eslint-disable-next-line */
export interface RouteplanningProps {}

export function Routeplanning(props: RouteplanningProps) {
  function handleSubmit() {
    console.log("Submit was clicked!");
  }

  return (
    <div>
      <h5>Reittisuunnittelu</h5>
      <form method='' onSubmit={handleSubmit}>
        <Row>
          <Col lg>
            <InputGroup size='lg' className='mb-3'>
              <InputGroup.Text id='inputGroup-sizing-sm'>Lähtöpiste</InputGroup.Text>
              <Form.Control
                placeholder='Lähtöpiste'
                aria-label='Small'
                aria-describedby="inputGroup-sizing-default"
                name='startingPoint'/>
            </InputGroup>
          </Col>
          <Col lg>
            <InputGroup size='lg' className='mb-3'>
            <InputGroup.Text id='inputGroup-sizing-sm'>Määränpää</InputGroup.Text>
            <Form.Control
              placeholder='Määränpää'
              aria-label='Small'
              aria-describedby="inputGroup-sizing-default"
              name='startingPoint'/>
              <Button variant="outline-secondary" id="button-addon2" type='submit'>
                Hae reitti!
              </Button>
            </InputGroup>
          </Col>
        </Row>
      </form>
    </div>
  );
}

export default Routeplanning;
