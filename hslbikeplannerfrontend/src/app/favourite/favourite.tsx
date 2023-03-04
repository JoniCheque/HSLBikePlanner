import { func } from 'prop-types';
import styles from './favourite.module.css';

import Form from 'react-bootstrap/Form';
import InputGroup from 'react-bootstrap/InputGroup';
import Button from 'react-bootstrap/Button';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import React from 'react';
import Stack from 'react-bootstrap/Stack';

/* eslint-disable-next-line */
export interface FavouriteProps {}

export function Favourite(props: FavouriteProps) {
  function handleSubmit()
  {

  }

  return (
    <div>
      <form method='' onSubmit={handleSubmit}>
        <InputGroup size='lg'>
          <h5>Lisää uusi kohde</h5>
          <Row>
            <Form.Control
              className='mb-2'
              placeholder='Nimi'
              aria-label='Small'
              aria-describedby="inputGroup-sizing-default"
              name='startingPoint'/>
            <Form.Control
              className='mb-2'
              placeholder='Kuvaus'
              aria-label='Small'
              aria-describedby="inputGroup-sizing-default"
              name='startingPoint'/>
            <Form.Control
              className='mb-2'
              placeholder='Longitude'
              aria-label='Small'
              aria-describedby="inputGroup-sizing-default"
              name='startingPoint'/>
            <Form.Control
              className='mb-2'
              placeholder='Latidute'
              aria-label='Small'
              aria-describedby="inputGroup-sizing-default"
              name='startingPoint'/>
            <Button variant="outline-success">Lisää</Button>{' '}
          </Row>
        </InputGroup>
      </form>
    </div>
  );
}

export default Favourite;
