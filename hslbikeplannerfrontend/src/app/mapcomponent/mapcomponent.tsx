import React from 'react';
import styles from './mapcomponent.module.css';
import maplibregl from 'maplibre-gl';
import Map, {NavigationControl} from 'react-map-gl';
import 'maplibre-gl/dist/maplibre-gl.css';

/* eslint-disable-next-line */
export interface MapcomponentProps {}

export function Mapcomponent(props: MapcomponentProps) {
  return (
    <div className={styles['container']}>
      <h1>Welcome to Map!</h1>
      <div className="App">
        <Map mapLib={maplibregl} 
          initialViewState={{
            longitude: 24.93178,
            latitude: 60.16556,
            zoom: 13
          }}
          //style={{width: "100%", height: " calc(100vh - 90px)"}}
          style={{width: "100%", height: " calc(75vh - 90px)"}}
          mapStyle="https://api.maptiler.com/maps/streets/style.json?key=IrM0m1zv3WHy3SyZUfCR"
        >
          <NavigationControl position="top-left" />
        </Map>
      </div>
    </div>
  );
}

export default Mapcomponent;
