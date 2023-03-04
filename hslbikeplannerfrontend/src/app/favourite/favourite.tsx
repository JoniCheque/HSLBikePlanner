import { func } from 'prop-types';
import styles from './favourite.module.css';

import Form from 'react-bootstrap/Form';
import InputGroup from 'react-bootstrap/InputGroup';
import Button from 'react-bootstrap/Button';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import React from 'react';

/* eslint-disable-next-line */
export interface FavouriteProps {}

export function Favourite(props: FavouriteProps) {
  function handleSubmit()
  {

  }

  return (
    <div>
      <h5>Lisää uusi kohde</h5>

      <form method='' onSubmit={handleSubmit}>
        <Row>
          <Col md>
            <InputGroup size='lg' className='mb-3'>
              <InputGroup.Text id='inputGroup-sizing-sm'>Lähtöpiste</InputGroup.Text>
              <Form.Control
                placeholder='Lähtöpiste'
                aria-label='Small'
                aria-describedby="inputGroup-sizing-default"
                name='startingPoint'/>
            </InputGroup>
          </Col>
          <Col md>
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

export default Favourite;
